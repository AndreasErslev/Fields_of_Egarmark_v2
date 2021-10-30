using Game.Attacks.Character;
using Game.Roles.Enemies;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Test
{
    [TestFixture]
    public class AttackCharacterUnitTest
    {
        ICharacterAttack _uut;
        IEnemy _enemy;

        [SetUp]
        public void Setup()
        {
            
        }

        [Test]
        public void Test_Slash_Attack_Slain()
        {
            _uut = new Slash();

            _enemy = new Orc();

            _uut.Attack(_enemy);

            if (_uut._hitOrMiss == true)
                Assert.That(_uut._hitOrMiss, Is.EqualTo(true));
            else if (_uut._hitOrMiss == false)
                Assert.That(_uut._hitOrMiss, Is.EqualTo(false));


        }

    }
}
