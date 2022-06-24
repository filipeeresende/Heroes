using HEROES.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES.Heroes
{
    public class Jenica
    {
        public static void Show()
        {
            var name = "Jenica";

            GenericClass.GetShowMessage(name);
            GenericClass.GetOptionsMessage(name);
            var hero = short.Parse(Console.ReadLine());
            Start(hero);

        }

        public static void Start(short hero)
        {

            var wizard = new Wizard();


            switch (hero)
            {
                case 1:
                    Console.Clear();
                    wizard.Name = "JENICA";
                    wizard.Level = 22;
                    wizard.Hp = 200;

                    GenericClass.GetMessageInformation(wizard.Name, wizard.Level, wizard.Hp);
                    break;



                case 2:

                    GenericClass.GetMessagePower();
                    var bonus = int.Parse(Console.ReadLine());
                    GenericClass.GetAttackMessage(wizard.Attack(bonus), bonus);
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
