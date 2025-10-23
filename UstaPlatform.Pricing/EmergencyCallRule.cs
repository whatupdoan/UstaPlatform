using UstaPlatform.Domain;

namespace UstaPlatform.Pricing
{
    public class EmergencyCallRule : IPricingRule
    {
        public decimal Uygula(decimal temelFiyat)
        {
            return temelFiyat + 50; // Acil çağrı ek ücreti
        }
    }
}
