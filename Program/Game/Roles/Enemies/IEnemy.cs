using Game.Roles.Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Roles.Enemies
{
    public interface IEnemy
    {
        public void DealDamage(Character character);
        public void Defend();
        public void Heal();
        public bool TakeDamage(double damage);
    }
}
