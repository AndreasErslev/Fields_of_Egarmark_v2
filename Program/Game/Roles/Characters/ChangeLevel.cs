using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Roles.Characters
{
    public class ChangeLevel
    {
        private readonly Random _random = new Random();
        public double _health { get; set; }
        public double _damage { get; set; }
        public double _mana { get; set; }

        public ChangeLevel(double health, double damage, double mana)
        {
            _health = health;
            _damage = damage;
            _mana = mana;
        }
        public void LevelUp(string type, double health, double damage, double mana)
        {
            switch (type)
            {
                case "Mage":
                    _health = _random.Next(10, 30) + health;
                    _damage = _random.Next(10, 30) + damage;
                    _mana = _random.Next(10, 30) + mana;
                    break;
                case "Warrior":
                    _health = _random.Next(10, 30) + health;
                    _damage = _random.Next(10, 30) + damage;
                    _mana = _random.Next(10, 30) + mana;
                    break;
                case "Rouge":
                    _health = _random.Next(10, 30) + health;
                    _damage = _random.Next(10, 30) + damage;
                    _mana = _random.Next(10, 30) + mana;
                    break;
            }
        }
    }
}
