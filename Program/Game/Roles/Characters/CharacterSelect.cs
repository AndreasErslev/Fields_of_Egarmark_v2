using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Roles.Characters
{
    public class CharacterSelect
    {
        private string _choice;
        private string _name;
        public Character ChooseCharacter()
        {

            Console.WriteLine("Choose your character name:");
            _name = Console.ReadLine();

            Console.WriteLine("Choose your character: \n1: Mage | 2: Warrior |3: Rouge");
            _choice = Console.ReadLine();

            do
            {
                switch (_choice)
                {
                    case "1":
                        return new Mage(_name);
                    case "2":
                        return new Warrior(_name);
                    case "3":
                        return new Rouge(_name);
                }

                Console.WriteLine("You have chosen an invalid value. Try again!");
                _choice = Console.ReadLine();

            } while (true);
        }

    }
}
