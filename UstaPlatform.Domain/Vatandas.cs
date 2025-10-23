namespace UstaPlatform.Domain
{
    public class Vatandas
    {
        public int Id { get; init; }
        public string Ad { get; set; }
        public string Adres { get; set; }

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
