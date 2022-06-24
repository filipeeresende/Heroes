using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES.src.Entities
{
    public class Ninja : Hero
    {

        public string Attack(int bonus)
        {

            if (bonus == 45)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                return this.Name + "" + "" + "" + "LANÇOU UM ATAQUE SUPER EFETIVO COM BONUS DE " + bonus;

            }
            if (bonus < 45)

                return this.Name + "" + "LANÇOU ATAQUE FRACO COM BONUS DE " + bonus;

            if (bonus > 45)

                Console.ForegroundColor = ConsoleColor.Red;
            return this.Name + "" + "LANÇOU ATAQUE COM CRITICO DE " + bonus;
        }
    }
}
