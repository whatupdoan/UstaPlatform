namespace UstaPlatform.Domain
{
    public class Vatandas
    {
        public int Id { get; init; }
        public required string Ad { get; init; }
        public required string Adres { get; init; }

        public Talep TalepOlustur(string aciklama)
        {
            return new Talep
            {
                Vatandas = this,
                Aciklama = aciklama
            };
        }
    }
}
