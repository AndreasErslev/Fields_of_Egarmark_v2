using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game.Roles.Enemies;

namespace Game.Attacks.Character
{
    public class Slash : ICharacterAttack
    {

        public bool _hitOrMiss { get; set; }

        public Slash()
        {
            _hitOrMiss = false;
        }

        public void Attack(IEnemy targetEnemy)
        {
           
            _hitOrMiss = targetEnemy.TakeDamage(3);

            

        }
    }
}
