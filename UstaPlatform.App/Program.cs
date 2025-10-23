using UstaPlatform.Domain;
using UstaPlatform.Pricing;
using UstaPlatform.Infrastructure;
using System.Globalization;

class Program
{
    static void Main()
    {
        // Tüm uygulamaya TR kültürü (opsiyonel ama önerilir)
        CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("tr-TR");
        CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("tr-TR");

        var vatandas = new Vatandas { Ad = "Ali Yılmaz", Adres = "Merkez Mah." };
        var usta = new Usta { Ad = "Mehmet Usta", Uzmanlik = "Tesisat", Puan = 4.8 };

        var talep = vatandas.TalepOlustur("Musluk sızdırıyor.");

        var isEmri = new IsEmri
        {
            Usta = usta,
            Vatandas = vatandas,
            Fiyat = 200,
            Tarih = DateTime.Now
        };

        var engine = new PricingEngine("plugins");
        engine.KuralEkle(new WeekendExtraFeeRule());
        engine.KuralEkle(new EmergencyCallRule());

        var nihaiFiyat = engine.Hesapla(isEmri.Fiyat);

        Console.WriteLine("=== UstaPlatform Demo ===");
        Console.WriteLine($"İş: {talep.Aciklama}");
        Console.WriteLine($"Usta: {usta}");
        Console.WriteLine($"Müşteri: {vatandas.Ad}");
        Console.WriteLine($"Fiyat: {MoneyFormatter.Format(nihaiFiyat)}");
    }
}
