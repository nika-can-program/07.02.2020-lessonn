using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07._02._2020_lessonn
{
    class Program
    {
        public  class Animal
        {
            public string type = "Млекопитающие";
            public string breed = "Бритаская";
            public string color = "Серый";
            public int agression = 30;

            public Animal(string type, string breed, string color)
            {
                this.type = type;
                this.breed = breed;
                this.color = color;
            }

            public Animal(string type, string breed, string color, int agression)
            {
                this.type = type;
                this.breed = breed;
                this.color = color;
                this.agression = agression;
            }

            public Animal()
            {

            }

            public Animal(string type, string breed)
            {
                this.type = type;
                this.breed = breed;
            }

            public  void MyInfo() 
            {
                Console.WriteLine($"Тип: {type} , Порода: {breed} , Цвет: {color} , Агрессия: {agression} ");
            }
        }

        public class Tiles
        {
            public string brand = "Кафельный Полл";
            public double size_h = 20;
            public double size_w = 20;
            public int price = 5000;

            public Tiles()
            {

            }
            public Tiles(double size_h, double size_w)
            {
                this.size_h = size_h;
                this.size_w = size_w;
            }
            public Tiles(string brand)
            {
                this.brand = brand;
            }
            public Tiles(int price)
            {
                this.price = price;
            }

            public void getData()
            {
                Console.WriteLine($"Бренд: {brand}, Длина: {size_h}, Ширина: {size_w}, Цена: {price}");
            }


        }

        static void Main(string[] args)
        {
           Animal cat = new Animal();
           cat.agression = 0;
           cat.breed = "Мейн Кун";
           cat.color = "абсолютно разнообразный";
           cat.MyInfo();

           Animal dog = new Animal();
           dog.breed = "Немецкая Овчарка";
           dog.color = "Коричневая с серым";
           dog.agression = 5557;
           dog.MyInfo();

           Animal rat = new Animal("Крыса", "Палзучая");
           rat.MyInfo();

           Animal badger = new Animal("Барсук", "Лесной", "Черно-белый");
           badger.MyInfo();

           Animal parrot = new Animal("птица", "Крикунья", "Радужный", 666);
           parrot.MyInfo();



            Tiles type1 = new Tiles();
            type1.getData();

            Tiles type2 = new Tiles("Поллл");
            type2.getData();

            Tiles type3 = new Tiles(14, 16);
            type3.getData();

            Tiles type4 = new Tiles(11000);
            type4.getData();


            Console.ReadLine();
        }
    }
}
