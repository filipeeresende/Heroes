using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HEROES.src.Entities
{
    public class Kinight : Hero
    {

        public string Attack(int bonus)
        {

            if (bonus > 25)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                return this.Name + "" + "" + "" + "LANÇOU UM ATAQUE SUPER EFETIVO COM BONUS DE " + bonus;

            }
            else
            {
                return this.Name + "" + "LANÇOU ATAQUE FRACO COM BONUS DE " + bonus;
            }
        }

    }
}
