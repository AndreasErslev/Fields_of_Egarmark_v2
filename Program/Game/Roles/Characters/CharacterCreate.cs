using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Roles.Characters
{
    public class CharacterCreate
    {
        private readonly Random _random = new Random();
        public double _health { get; set; }
        public double _damage { get; set; }
        public double _mana { get; set; }
        public void CreateNewCharacter(string type)
        {
            switch (type)
            {
                case "Mage":
                    _health = _random.Next(10, 30);
                    _damage = _random.Next(10, 30);
                    _mana = _random.Next(10, 30);
                    break;
                case "Warrior":
                    _health = _random.Next(10, 30);
                    _damage = _random.Next(10, 30);
                    _mana = _random.Next(10, 30);
                    break;
                case "Rouge":
                    _health = _random.Next(10, 30);
                    _damage = _random.Next(10, 30);
                    _mana = _random.Next(10, 30);
                    break;
            }
        }
    }
}
