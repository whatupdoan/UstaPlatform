namespace UstaPlatform.Domain
{
    public class Usta
    {
        public int Id { get; init; }
        public string Ad { get; set; }
        public string Uzmanlik { get; set; }
        public double Puan { get; set; }
        public int GunlukIsSayisi { get; set; }

        public override string ToString() => $"{Ad} ({Uzmanlik}) - Puan: {Puan}";
    }
}
