using _01._TestAxe;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestAxe.Tests
{
    [TestFixture]
    public class DummyTests
    {
        [Test]
        public void DummyLosesHealthIfAttacked()
        {
            Dummy dummy = new Dummy(30, 10);

            dummy.TakeAttack(5);

            Assert.AreEqual(dummy.Health, 25);
        }

        [Test]

        public void DeadDummyThrowsAnExceptionWhenAttacked()
        {
            Dummy dummy = new Dummy(0, 5);

            Assert.Throws<InvalidOperationException>(() => dummy.TakeAttack(Random.Shared.Next()));
        }

        [Test]

        public void DeadDummyCanGiveXP()
        {
            Dummy dummy = new Dummy(0, 10);

            Assert.AreEqual(10, dummy.GiveExperience());
        }

        [Test]

        public void AliveDummyCannotGiveXP()
        {
            Dummy dummy = new Dummy(10, 10);

            Assert.Throws<InvalidOperationException>(() => dummy.GiveExperience());
        }
    }
}