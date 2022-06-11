//bool: хранит значение true или false (логические литералы). Представлен системным типом System.Boolean
bool alive = true;
bool isDead = false;
Console.WriteLine($"bool_alive = {alive}");
Console.WriteLine($"bool_isDead = {isDead}");

//byte: хранит целое число от 0 до 255 и занимает 1 байт. Представлен системным типом System.Byte
byte bit1 = 1;
Console.WriteLine($"byte_bit1 = {bit1}");

//sbyte: хранит целое число от -128 до 127 и занимает 1 байт. Представлен системным типом System.SByte
sbyte bit2 = -101;
Console.WriteLine($"sbyte_bit2 = {bit2}");

//short: хранит целое число от -32768 до 32767 и занимает 2 байта. Представлен системным типом System.Int16
short n1 = 1;
Console.WriteLine($"short_n1 = {n1}");

//ushort: хранит целое число от 0 до 65535 и занимает 2 байта. Представлен системным типом System.UInt16
ushort n2 = 1;
Console.WriteLine($"ushort_n2 = {n2}");

/*
 int: хранит целое число от -2147483648 до 2147483647 и занимает 4 байта. Представлен системным типом System.Int32. 
 Все целочисленные литералы по умолчанию представляют значения типа int:
*/
int a = -2147483648;
Console.WriteLine($"int_a = {a}");

//uint: хранит целое число от 0 до 4294967295 и занимает 4 байта. Представлен системным типом System.UInt32
uint b = 4294967295;
Console.WriteLine($"uint_b = {b}");

/*long: хранит целое число от –9 223 372 036 854 775 808 до 9 223 372 036 854 775 807 и занимает 8 байт.
Представлен системным типом System.Int64*/
long c = -9223372036854775808;
Console.WriteLine($"long_c = {c}");

/*ulong: хранит целое число от 0 до 18 446 744 073 709 551 615 и занимает 8 байт.
Представлен системным типом System.UInt64*/
ulong d = 18446744073709551615;
Console.WriteLine($"ulong_d = {d}");

/*float: хранит число с плавающей точкой от -3.4*1038 до 3.4*1038 и занимает 4 байта.
Представлен системным типом System.Single*/
float e = 3.14F;
Console.WriteLine($"float_e = {e}");

/*double: хранит число с плавающей точкой от ±5.0*10-324 до ±1.7*10308 и занимает 8 байта.
Представлен системным типом System.Double*/
double f = 3.14;
Console.WriteLine($"double_f = {f}");

/*decimal: хранит десятичное дробное число. Если употребляется без десятичной запятой, 
 имеет значение от ±1.0*10-28 до ±7.9228*1028, может хранить 28 знаков после запятой и занимает 16 байт. 
 Представлен системным типом System.Decimal*/
decimal g = 1005.8M;
Console.WriteLine($"decimal_g = {g}");

/*char: хранит одиночный символ в кодировке Unicode и занимает 2 байта. Представлен системным типом System.Char. 
 Этому типу соответствуют символьные литералы:*/
char h = 'H';
Console.WriteLine($"char_h = {h}");

//string: хранит набор символов Unicode. Представлен системным типом System.String. Этому типу соответствуют строковые литералы.
string name = "Altynbek";
Console.WriteLine($"string_name = {name}");

/*object: может хранить значение любого типа данных и занимает 4 байта на 32-разрядной платформе и 8 байт на 64-разрядной платформе. 
 Представлен системным типом System.Object, который является базовым для всех других типов и классов .NET.*/
object i1 = 22;
object i2 = 3.14;
object i3 = "hello code";
Console.WriteLine("object_i1 = {0} object_i2 = {1} object_i3 = {2}", i1, i2, i3);

//Неявная типизация var, которую надо инициализировать сразу, иначе его нельзя будет установить в дальнейшем.
var j = "hello";
Console.WriteLine($"var_j = {j}");










