using HEROES.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES.Heroes
{
    public class Wedge
    {
        public static void Show()
        {
            var name = "Wedge";

            GenericClass.GetShowMessage(name);
            GenericClass.GetOptionsMessage(name);
            var hero = short.Parse(Console.ReadLine());
            Start(hero);

        }

        public static void Start(short hero)
        {

            var ninja = new Ninja();


            switch (hero)
            {
                case 1:
                    Console.Clear();
                    ninja.Name = "WEDGE";
                    ninja.Level = 20;
                    ninja.Hp = 180;

                    GenericClass.GetMessageInformation(ninja.Name, ninja.Level, ninja.Hp);
                    break;



                case 2:

                    GenericClass.GetMessagePower();
                    var bonus = int.Parse(Console.ReadLine());
                    GenericClass.GetAttackMessage(ninja.Attack(bonus), bonus);
                    break;




                case 0:
                    {
                        Console.Clear();
                        Environment.Exit(0);
                        break;
                    }
                default: Menu.Show(); break;
            }


        }

    }
}
