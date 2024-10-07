//string tcNo;
//string isim;
//string soyisim;
//string telefonNumarası;
//int yas;
//decimal urunbir;
//decimal uruniki;
decimal toplamharcama;
decimal toplamharcamapuan;

Console.Write("TC Gir: ");
String tcNo = Console.ReadLine();

Console.Write("Adını gir: ");
string isim = Console.ReadLine();

Console.Write("Soyadını gir: ");
string soyisim = Console.ReadLine();

Console.Write("Telefon numarası gir: ");
string telefonNumarası = Console.ReadLine();

// Telefon numarasını string aldım çünkü 0 ile başlayabilir ve üzerinde herhangi bir işlem yapmayacağım.

Console.Write("Yaşını gir: ");
int yas = Convert.ToInt32(Console.ReadLine());

Console.Write("İlk Aldığı Ürünün Fiyatı: ");
decimal urunbir    = decimal.Parse(Console.ReadLine());

Console.Write("İkinci Aldığı Ürünün Fiyatı: ");
decimal uruniki = decimal.Parse(Console.ReadLine());

 toplamharcama = (urunbir + uruniki);

 toplamharcamapuan = 0.1m * (toplamharcama);

Console.WriteLine($"{tcNo} TC numaralı {isim} {soyisim} isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine($"{telefonNumarası} telefon numarasına bildirim mesajı gönderilmiştir.");
Console.Write($"{toplamharcama} TL karşılığında kazandığın % 10 oranındaki patika puanın = {toplamharcamapuan} TL .");

//hata alınca araştırdım ve 0.1 double olarak algılanıyor o yüzden onu decimal'a çevirmek için m harfi ekliyorum.


