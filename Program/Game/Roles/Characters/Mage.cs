using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Attacks.Character;
using Game.Roles.Enemies;
using Game.UI;

namespace Game.Roles.Characters
{
    public class Mage : Character
    {
        
        private string _choice;

        private ICharacterAttack _attack;
        private IDisplay _display;

        public Mage(string name) : base(name, "Mage")
        {
            _display = new Display();
        }
        public override void DealDamage(IEnemy enemy)
        {
            _choice = _display.ChooseAttack();

            switch (_choice)
            {
                case "1":
                    _attack = new Slash();
                    _attack.Attack(enemy);
                    break;
            }

        }
        public override void TakeDamage(double damage)
        {
            _health -= damage;

            if (_health <= 0)
            {
                //...

            }

        }
        public override void Defend()
        {
            
        }

        public override void Heal()
        {

        }

    }
}
