using UstaPlatform.Domain;

namespace UstaPlatform.Pricing
{
    public class WeekendExtraFeeRule : IPricingRule
    {
        public decimal Uygula(decimal temelFiyat)
        {
            if (DateTime.Now.DayOfWeek is DayOfWeek.Saturday or DayOfWeek.Sunday)
                return temelFiyat * 1.2m; // %20 ek ücret
            return temelFiyat;
        }
    }
}
