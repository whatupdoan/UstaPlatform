using System.Reflection;
using UstaPlatform.Domain;

namespace UstaPlatform.Pricing
{
    public class PricingEngine
    {
        private readonly List<IPricingRule> _kurallar = new();

        public PricingEngine(string eklentiKlasoru)
        {
            if (!Directory.Exists(eklentiKlasoru))
                Directory.CreateDirectory(eklentiKlasoru);

            foreach (var dll in Directory.GetFiles(eklentiKlasoru, "*.dll"))
            {
                var asm = Assembly.LoadFrom(dll);
                var ruleTypes = asm.GetTypes()
                    .Where(t => typeof(IPricingRule).IsAssignableFrom(t) && !t.IsInterface);

                foreach (var type in ruleTypes)
                {
                    var instance = (IPricingRule?)Activator.CreateInstance(type);
                    if (instance != null)
                        _kurallar.Add(instance);
                }
            }
        }

        public void KuralEkle(IPricingRule kural) => _kurallar.Add(kural);

        public decimal Hesapla(decimal temelFiyat)
        {
            decimal fiyat = temelFiyat;
            foreach (var rule in _kurallar)
                fiyat = rule.Uygula(fiyat);

            return fiyat;
        }
    }
}
