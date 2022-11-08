using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class DeSerial
    {
        public Class1[] Load(string path)
        {
            path = "goods.json";
            if (!File.Exists(path))
            {
                return null;
            }
            else
            {
                var json = File.ReadAllText(path);
                Class1[] goods = JsonSerializer.Deserialize<Class1[]>(json);
                return goods;
            }
        }
    }
}
