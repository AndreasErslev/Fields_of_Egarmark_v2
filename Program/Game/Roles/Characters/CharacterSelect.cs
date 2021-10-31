using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.UI;

namespace Game.Roles.Characters
{
    public class CharacterSelect
    {
        private string _choice;
        private string _name;

        private readonly Display _display;

        public CharacterSelect()
        {
            _name = "Unknown";
            _choice = "1";
            _display = new Display();
        }

        public Character ChooseCharacter()
        {

            _name = _display.CharacterSelect_Name();

            _choice = _display.CharacterSelect_Choice();

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

                _choice = _display.CharacterSelect_Invalid();

            } while (true);
        }
    }
}
