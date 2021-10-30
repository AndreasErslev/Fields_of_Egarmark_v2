using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.UI
{
    public class Display : IDisplay
    {
        private string _choice { get; set; }

        public string ChooseAttack()
        {
            Console.WriteLine("Chose your attack:");
            Console.WriteLine("1: Slash");
            Console.WriteLine("2: Fireball");
            Console.WriteLine("3: Arrow");

            _choice = Console.ReadLine();

            return _choice;

        }
    }
}
