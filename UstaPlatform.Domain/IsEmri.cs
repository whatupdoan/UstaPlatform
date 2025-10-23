namespace UstaPlatform.Domain
{
    public class IsEmri
    {
        public int Id { get; init; }
        public Usta Usta { get; set; }
        public Vatandas Vatandas { get; set; }
        public decimal Fiyat { get; set; }
        public DateTime Tarih { get; set; }
        public Route Rota { get; set; } = new Route();

        public override string ToString()
        {
            return $"{Usta.Ad} → {Vatandas.Ad} ({Fiyat}₺)";
        }
    }
}
