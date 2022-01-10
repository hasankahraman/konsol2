// See https://aka.ms/new-console-template for more information


Console.WriteLine();

Console.WriteLine("");
string degisken = " ";

byte b = 5;     //1 byte
sbyte c = 5;    //1 byte

short s = 5;    //2 bytes 
ushort u = 5;   //2 bytes

Int16 i16 = 2;  //2 bytes
int i = 2;      //4 bytes
Int32 i32 = 2;  //4 bytes
Int64 i64 = 2;  //8 bytes

uint ui = 2;    //4 bytes
long l = 4;     //8 bytes
ulong ul = 4;   //8 bytes

//Reel Sayılar
float f = 5;    //4 bytes
double d = 5;   //8 bytes
decimal de = 5; //8 bytes

char ch = '2';   //2 bytes
string st = "Hasan"; //infinite

bool b1 = true;
bool b2 = false;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

Object o1 = "x";
Object o2 = "y";
Object o3 = 4;
Object o4 = 4.3;

// String İfadeler

String str1 = String.Empty;
str1 = "Hasan KAHRAMAN";
string  ad = "Hasan";
string soyad = "KAHRAMAN";
string tamAd = ad + " " + soyad;

//Integer Tanımlama Şekilleri

int integer1 = 5;
int integer2 = 3;
int integer3 = integer1 + integer2;

//boolean

bool bb1 = 10<2;

//Değişken Dönüşümleri

string str12 = "20";
int int12 = 20;

string yeniDeger = str12 + int12.ToString();

Console.WriteLine(yeniDeger); //sonuç 2020


int int13 = int12 + Convert.ToInt32(str12);
Console.WriteLine(int13); //sonuc 40

int int14 = int12 + int.Parse(str12)+ 10;
Console.WriteLine(int14); //sonuc 50

//Datetime

string datetime = DateTime.Now.ToString("dd.MM.yyyy");
Console.WriteLine(datetime); //

string datetime2 = DateTime.Now.ToString("dd/MM/yyyy");
Console.WriteLine(datetime2); //

string hour = DateTime.Now.ToString("HH.mm");
Console.WriteLine(hour); //

