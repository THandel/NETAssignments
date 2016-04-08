using System;
using System.Collections.Generic;
using Assignment8;
using Assignment8.Models;
using NUnit.Framework;

namespace Assignment8_Tests
{
    [TestFixture]
    public class Tests
    {
        PlayerDataProvider playerData = new PlayerDataProvider();
        List<Player> newPlayerList = new List<Player>();

        [Test]
        public void testMaxDist()
        {
            playerData.DataRead(newPlayerList);
            var expectMaxDist = 2300;

            Assert.AreEqual(expectMaxDist, playerData.maxDist());
        }

        [Test]
        public void testMinDist()
        {
            playerData.DataRead(newPlayerList);
            var expectMinDist = 1250;

            Assert.AreEqual(expectMinDist, playerData.minDist());
        }

        [Test]
        public void testMinSpeed()
        {
            playerData.DataRead(newPlayerList);
            double expectMinSpd = 3.2;

            Assert.AreEqual(expectMinSpd, playerData.minSpeed());
        }

        [Test]
        public void testMaxSpeed()
        {
            playerData.DataRead(newPlayerList);
            double expectMaxSpd = 4.2;

            Assert.AreEqual(expectMaxSpd, playerData.maxSpeed());
        }

        [Test]
        public void testAvgSpeed()
        {
            playerData.DataRead(newPlayerList);
            decimal expectAvgSpd = Math.Round((decimal)((3.4 + 3.2 + 4.2)/3), 2);
            Assert.AreEqual(expectAvgSpd, playerData.averageSpeed());
        }

        [Test]
        public void testAvgDistance() //test that average distance returns the correct value
        {
            playerData.DataRead(newPlayerList);
            decimal expectAvgDist = Math.Round((decimal)((1500 + 1250 + 2300) / 3.0), 2);
            Assert.AreEqual(expectAvgDist, playerData.avgDistance());
        }

        [Test]
        [ExpectedException(typeof(ListEmptyException))] //test that the correct exception is thrown 
        public void ExpectListEmptyException()       //when a method is called on an empty list
        {
            playerData.avgDistance(); //call avgDistance() without populateLists() being called first
        }

        [Test]
        [ExpectedException(typeof(PlayerExistsException))] //test that the correct exception is thrown
        public void ExpectPlayerExistsException()       //when a player is added whose ID already exists
        {
            playerData.InsertData(2, "Mark", 185, 26, 1500, 3);

        }       
    }
}
