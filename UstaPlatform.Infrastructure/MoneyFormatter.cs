using System.Globalization;

namespace UstaPlatform.Infrastructure
{
    public static class MoneyFormatter
    {
        // Varsayılan "tr-TR" — istersen çağrı anında başka kültür de geçebilirsin.
        public static string Format(decimal tutar, string culture = "tr-TR")
        {
            var ci = new CultureInfo(culture);
            return string.Format(ci, "{0:C}", tutar);
        }
    }
}
