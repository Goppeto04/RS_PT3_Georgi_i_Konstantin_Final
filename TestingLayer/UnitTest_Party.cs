using BusinessLayer;
using DataLayer;
using Microsoft.EntityFrameworkCore;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingLayer
{
    public class UnitTest_Party
    {
        private DrinkingPartiesDbContext _dbContext;
        private PartyContext _PartyContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            _dbContext = new DrinkingPartiesDbContext(builder.Options);
            _PartyContext = new PartyContext(_dbContext);
        }

        [Test]
        public void CreateParty()
        {
            int PartysBefore = _PartyContext.ReadAll().Count();
            _PartyContext.Create(new Party("Galena AfterParty", "Bushido", "Uchastie na Galena, ultra bon bok", null, null));
            int PartysAfter = _PartyContext.ReadAll().Count();
            Assert.IsTrue(PartysBefore != PartysAfter);
        }

        [Test]
        public void ReadParty()
        {
            _PartyContext.Create(new Party("Galena AfterParty", "Bushido", "Uchastie na Galena, ultra bon bok", null, null));
            Party party = _PartyContext.Read(1);
            Assert.That(party != null, "There is no record with id 1!");
        }

        [Test]
        public void UpdateParty()
        {
            _PartyContext.Create(new Party("Galena AfterParty", "Bushido", "Uchastie na Galena, ultra bon bok", null, null));
            Party party = _PartyContext.Read(1);
            party.PartyTitle = "Preslava Retro wecher";
            _PartyContext.Update(party);
            Assert.IsTrue(party.PartyTitle == "Preslava Retro wecher", "Updade didn`t change anything");
        }

        [Test]
        public void DeleteParty()
        {
            _PartyContext.Create(new Party("Galena AfterParty", "Bushido", "Uchastie na Galena, ultra bon bok", null, null));
            int PartysBeforeTest = _PartyContext.ReadAll().Count();
            _PartyContext.Delete(1);
            int PartysAfterTest = _PartyContext.ReadAll().Count();
            Assert.AreNotEqual(PartysBeforeTest, PartysAfterTest);
        }
    }
}