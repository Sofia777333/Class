using System;
using System.Collections.Generic;
using System.Linq;



namespace Class
{
    class Fishes
    {
     public string Name;
     private string _kind;
     private string _color;
     private int _size;

     public Fishes() { }
    public Fishes(string name, string Kind, string color, int size)
        {
            Name = name;
            _kind = Kind;
            _color = color;
            _size = size;
        }
        public void DisplayInfo()
        {
            Console.WriteLine($"Имя: {Name}");
            Console.WriteLine($"Вид: {_kind}");
            Console.WriteLine($"Окрас: {_color}");
            Console.WriteLine($"Размер: {_size}");
        }
    }
}
