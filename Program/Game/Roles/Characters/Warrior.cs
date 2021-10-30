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
    public class Warrior : Character
    {
        public Warrior(string name) : base(name, "Warrior")
        {

        }

        public override void DealDamage(IEnemy enemy)
        {


        }
        public override void TakeDamage(double damage)
        {

        }
        public override void Defend()
        {

        }

        public override void Heal()
        {

        }
    }
}