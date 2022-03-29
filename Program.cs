// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int deger;
deger = 5;

//Değişken tanımlarken işlem operatörü, boşluk, tire, "class" gibi isimlendirmeleri kullanamazsın. Sayı ile başlayamazsın.

string Degisken = null;
string degisken = null;

byte b = 5; // 1 byte. 0 - 255
sbyte c = -5; // 1 byte. -128 - 127

short d = 10; // 2 byte. -32768 - 32768
ushort e = 15; // 2 byte. 0 - 65365

Int16 i6 = 2; // 2 byte
int i = 2; // 4 byte
Int32 i32 = 2; // 4 byte
Int64 i64 = 2; // 8 byte

uint ui = 2; // 4 byte
long ş = 4; // 8 byte

//Reel sayılar
float f = 5; // 4 byte
double g = 5; // 8 byte
decimal j = 5; // 16 byte

char k = 'a'; // 2 byte
string str = "Furkan"; // sınırsız

bool b1 = false;
bool b2 = true;

DateTime dt = DateTime.Now; //O anın yerel saatini alıyor değer olarak.
Console.WriteLine(dt);

object o1 = "Furkan";
object o2 = 'f';
object o3 = 3;
object o4 = 4.4;

// Her veri tipi bir objedir ve bu şekilde de kullanılabilirler.

//  --------- //

// String ifadeler

string str2 = string.Empty; // boş değer atamak istediğimizde kullanabiliriz.
str2 = "Furkan Yılmaz";
string ad = "Furkan";
string soyad = "Yılmaz";
string tamisim = ad + soyad;

// Intiger tanımlama şekilleri

int integer1 = 3;
int integer2 = 4;
int integer3 = integer1 * integer2;

// boolean

bool b3 = 10 < 2; // true ve false'u mantık çerçevesinde de yaptırabiliriz.

// değişken dönüşümleri

string str20 = "20";
int int20 = 20;

string yenideger = str20 + int20.ToString(); // Çıktısı 2020
Console.WriteLine(yenideger); 

int int21 = int20 + Convert.ToInt32(str20); // Çıktısı 40
Console.WriteLine(int21); 

int int22 = int20 + int.Parse(str20); // Çıktısı 40

// datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime);

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime);

string hour = DateTime.Now.ToString("HH:mm");
Console.WriteLine(hour);


Console.ReadLine();