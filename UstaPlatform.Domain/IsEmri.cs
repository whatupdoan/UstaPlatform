namespace UstaPlatform.Domain
{
    public class IsEmri
    {
        public int Id { get; init; }
        public required Usta Usta { get; init; }
        public required Vatandas Vatandas { get; init; }
        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public Route Rota { get; init; } = new Route();

        public override string ToString() => $"{Usta.Ad} → {Vatandas.Ad} ({Fiyat}₺)";
    }
}
