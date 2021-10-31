using Game.UI;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Test
{
    [TestFixture]
    public class DisplayUnitTest
    {

        private IDisplay _uut;
        private StringWriter _output;
        private StringReader _input;

        [SetUp]
        public void Setup()
        {
            _uut = new Display();
        }

        [Test]
        public void Test_ChooseAttack_Mage()
        {
            _uut = new Display();

            _input = new StringReader("Mage");
            Console.SetIn(_input);

            _output = new StringWriter();
            Console.SetOut(_output);

            _uut.ChooseAttack();

            Assert.That(_output.ToString(), Is.EqualTo("Chose your attack:\r\n1: Slash\r\n2: Fireball\r\n3: Arrow\r\n"));
        }

        [Test]
        public void Test_ChooseAttack_Warrior()
        {
            _uut = new Display();

            _input = new StringReader("Warrior");
            Console.SetIn(_input);

            _output = new StringWriter();
            Console.SetOut(_output);

            _uut.ChooseAttack();

            Assert.That(_output.ToString(), Is.EqualTo("Chose your attack:\r\n1: Slash\r\n2: Fireball\r\n3: Arrow\r\n"));
        }

        [Test]
        public void Test_ChooseAttack_Rouge()
        {
            _uut = new Display();

            _input = new StringReader("Rouge");
            Console.SetIn(_input);

            _output = new StringWriter();
            Console.SetOut(_output);

            _uut.ChooseAttack();

            Assert.That(_output.ToString(), Is.EqualTo("Chose your attack:\r\n1: Slash\r\n2: Fireball\r\n3: Arrow\r\n"));
        }
    }
}
