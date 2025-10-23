namespace UstaPlatform.Domain
{
    public class Usta
    {
        public int Id { get; init; }
        public required string Ad { get; init; }
        public required string Uzmanlik { get; init; }
        public double Puan { get; set; }
        public int GunlukIsSayisi { get; set; }

        public override string ToString() => $"{Ad} ({Uzmanlik}) - Puan: {Puan}";
    }
}
