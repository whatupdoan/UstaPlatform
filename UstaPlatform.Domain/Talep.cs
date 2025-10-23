namespace UstaPlatform.Domain
{
    public class Talep
    {
        public int Id { get; init; }
        public Vatandas Vatandas { get; set; }
        public string Aciklama { get; set; }
        public DateTime OlusturmaZamani { get; init; } = DateTime.Now;
    }
}
