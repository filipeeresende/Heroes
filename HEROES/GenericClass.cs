using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES
{
    public class GenericClass
    {
        public static void GetShowMessage(string name)
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine($"VOCÊ ESCOLHEU O HEROI {name}");
            Console.WriteLine("===================================");
            Console.WriteLine("");
            Console.WriteLine("");
        }

        public static void GetOptionsMessage(string name)
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine($"PARA INFORMAÇÕES DE {name} DIGITE -1");
            Console.WriteLine($"PARA ATACAR COM {name} DIGITE-2");
            Console.WriteLine("===================================");
            Console.WriteLine();
            Console.WriteLine("PARA VOLTAR AO MENU DIGITE-3");
        }

        public static void GetStartMessage(string name, int level, int hp)
        {
            Console.Clear();
            Console.WriteLine($"Name {name} , Level {level} , Hp {hp}");
            Console.WriteLine("====================================================");
        }

        public static void GetAttackMessage(string attack, int bonus)
        {

            Console.WriteLine(attack);
            Console.WriteLine($"PARABÉNS VOÇê RANCOU {bonus} DE HP DO INIMIGO");
            Console.WriteLine("====================================================");
        }
        public static void GetMessagePower()
        {
            Console.Clear();
            Console.WriteLine("DIGITE UM VALOR DE PODER ");
        }
        public static void GetMessageInformation(string name, int level, int hp)
        {
            Console.WriteLine($"Name {name} , Level {level} , Hp {hp}");
            Console.WriteLine("====================================================");
        }
    }
}
