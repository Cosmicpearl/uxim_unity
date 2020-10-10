using System;
using System.Collections.Generic;

namespace Eugene_Kim
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3;
            x = int.Parse(Console.ReadLine());
            x +=1;
            Console.WriteLine(x);

            string[] monsters = {"아이린", "슬기"};
            int[] monsterLevel = new int[2];
            monsterLevel[0] = 2;
            monsterLevel[1] = 3;

            List<string> items = new List<string>();
            items.Add("생명물약30");
            items.Add("마법물약30");

            items.RemoveAt(0);

            Console.WriteLine("가지고 있는 아이템");
            Console.WriteLine(items[0]);

            Console.WriteLine("Eu" + "gene");

            int health = 30;
            int mana = 25;
            bool isBadCondition = health <= 50 && mana <=20;
            string condition = isBadCondition ? "나쁨" : "좋음"; //if == True : False

            switch (monsters[0]) 
            {
                case "아이린":
                case "슬기":
                    Console.WriteLine("레드벨벳 출현");
                break;
                default:
                    Console.WriteLine("???? 출현");
                    break;
            }


            Person a = new Person();
            a.age = 26;
            a.name = "슬기";
            a.weapon = "vocal";
            a.print();

            private static int a();


        }
    }
}
