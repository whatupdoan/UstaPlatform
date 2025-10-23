namespace UstaPlatform.Domain
{
    public interface IPricingRule
    {
        decimal Uygula(decimal temelFiyat);
    }
}
