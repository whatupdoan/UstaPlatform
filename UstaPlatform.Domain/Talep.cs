namespace UstaPlatform.Domain
{
    public class Talep
    {
        public int Id { get; init; }
        public required Vatandas Vatandas { get; init; }
        public required string Aciklama { get; init; }
        public DateTime OlusturmaZamani { get; init; } = DateTime.Now;
    }
}
