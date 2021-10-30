using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Roles.Characters;

namespace Game.Roles.Enemies
{
    public class Orc : IEnemy
    {
        private Random _random = new Random();
        private double _health { get; set; }
        private double _damage { get; set; }
        private double _mana { get; set; }

        public void DealDamage(Character character)
        {
            switch (_random.Next(1,4))
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;
            }
        }

        public void Defend()
        {

        }

        public void Heal()
        {

        }

        public bool TakeDamage(double damage)
        {

            switch (_random.Next(0, 5))
            {
                case 0:
                    Console.Write("Missed");
                    return false;

                case 1:
                    Console.Write("Missed");
                    return false;

                default:
                    Console.Write("Hit");
                    _health -= damage;
                    break;
            }

            if (_health <= 0)
                Console.WriteLine("The Orc has been slain");

            return true;

        }
    }
}
