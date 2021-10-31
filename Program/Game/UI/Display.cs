using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.UI
{
    public class Display : IDisplay
    {

        public string ChooseAttack()
        {

            Console.WriteLine("Chose your attack:");
            Console.WriteLine("1: Slash");
            Console.WriteLine("2: Fireball");
            Console.WriteLine("3: Arrow");

            return Console.ReadLine();

        }

        public string CharacterSelect_Name()
        {
            Console.WriteLine("Choose your character name:");
            return Console.ReadLine();
        }

        public string CharacterSelect_Choice()
        {
            Console.WriteLine("Choose your character: \n1: Mage | 2: Warrior |3: Rouge");
            return Console.ReadLine();
        }

        public string CharacterSelect_Invalid()
        {
            Console.WriteLine("You have chosen an invalid value. Try again!");
            return Console.ReadLine();
        }

    }
}
