using Game.Attacks.Character;
using Game.Roles.Enemies;
using Game.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Roles.Characters
{
    public abstract class Character
    {
        private readonly CharacterCreate _newCharacter;
        private ChangeLevel _changeLevel;

        protected readonly string _name;
        protected readonly string _type;

        protected int _xp;
        protected int _nextLevel;
        protected double _health { get; set; }
        protected double _damage { get; set; }
        protected double _mana { get; set; }

        public Character(string name, string type)
        {
            _name = name;
            _xp = 0;
            _nextLevel = 10;
            _type = type;

            _newCharacter = new CharacterCreate();
            _newCharacter.CreateNewCharacter(_type);

            _health = _newCharacter._health;
            _damage = _newCharacter._damage;
            _mana = _newCharacter._mana;

            _changeLevel = new ChangeLevel(_health, _damage, _mana);

            Console.WriteLine("{0}, {1}, {2}, {3}", _health, _damage, _mana, _name);

        }
        public Character(string name, string type, int xp)
        {
            _name = name;
            _xp = xp;
            _nextLevel = 10;
            _type = type;

            _newCharacter = new CharacterCreate();
            _newCharacter.CreateNewCharacter(type);

            _health = _newCharacter._health;
            _damage = _newCharacter._damage;
            _mana = _newCharacter._mana;

            _changeLevel = new ChangeLevel(_health, _damage, _mana);


        }
        public void CheckLevel()
        {
            if (_xp >= _nextLevel)
            {
                _changeLevel.LevelUp(_type, _health, _damage, _mana);
                _health = _changeLevel._health;
                _damage = _changeLevel._damage;
                _mana = _changeLevel._mana;
            }

            _nextLevel += 10;

        }
        public abstract void Heal();
        public abstract void DealDamage(IEnemy enemy);
        public abstract void TakeDamage(double damage);
        public abstract void Defend();

    }
}
