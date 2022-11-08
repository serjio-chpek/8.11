using ConsoleApp7;
using System.IO;
using System.Text.Json;
Console.WriteLine("Напишите, сколько товаров/услуг Вы хотите занести в список");
int x = Convert.ToInt32(Console.ReadLine());

Class1[] goods = new Class1[x];

for (int i = 0; i<x; i++)
{
    Class1 predmet = new Class1();
    Console.WriteLine("Напишите год выпуска/появления товара/услуги");
    predmet.godvipuska = Console.ReadLine();
    Console.WriteLine("Напишите название товара/услуги");
    predmet.name = Console.ReadLine();
    Console.WriteLine("Напишите цену");
    predmet.price = Console.ReadLine();
    Console.WriteLine("Напишите гарантийный срок");
    predmet.garantiya = Console.ReadLine();
    goods[i] = predmet; 
}


var json = JsonSerializer.Serialize (goods);
File.WriteAllText("goods.json", json);

DeSerial deserial = new DeSerial();
string path = "goods.json";


var t = deserial.Load(path);


if (t == null)
    return;

foreach (var item in t)
{
    Console.WriteLine("{0} {1} {2} {3}", item.name, item.godvipuska, item.price, item.garantiya);
}