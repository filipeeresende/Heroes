using HEROES.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES.Heroes
{
    public class Arus
    {
        public static void Show()
        {
            var name = "Arus";

            GenericClass.GetShowMessage(name);
            GenericClass.GetOptionsMessage(name);
            var hero = short.Parse(Console.ReadLine());
            Start(hero);
        }

        public static void Start(short hero)
        {
            var kinight = new Kinight();

            switch (hero)
            {
                case 1:
                    kinight.Name = "Arus";
                    kinight.Level = 12;
                    kinight.Hp = 140;

                    GenericClass.GetStartMessage(kinight.Name, kinight.Level, kinight.Hp);
                    break;

                case 2:

                    GenericClass.GetMessagePower();
                    var bonus = int.Parse(Console.ReadLine());
                    GenericClass.GetAttackMessage(kinight.Attack(bonus), bonus);
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
