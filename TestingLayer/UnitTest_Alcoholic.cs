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
    public class UnitTest_Alcoholic
    {
        private DrinkingPartiesDbContext _dbContext;
        private AlcoholicContext _AlcoholicContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            _dbContext = new DrinkingPartiesDbContext(builder.Options);
            _AlcoholicContext = new AlcoholicContext(_dbContext);
        }

        [Test]
        public void CreateAlcoholic()
        {
            int AlcoholicsBefore = _AlcoholicContext.ReadAll().Count();
            _AlcoholicContext.Create(new Alcoholic("Mihail", "Soliev", 18, "Han Solo"));
            int AlcoholicsAfter = _AlcoholicContext.ReadAll().Count();
            Assert.IsTrue(AlcoholicsBefore != AlcoholicsAfter);
        }

        [Test]
        public void ReadAlcoholic()
        {
            _AlcoholicContext.Create(new Alcoholic("Mihail", "Soliev", 18, "Han Solo"));
            Alcoholic alcoholic = _AlcoholicContext.Read(1);
            Assert.That(alcoholic != null, "There is no record with id 1!");
        }

        [Test]
        public void UpdateAlcoholic()
        {
            _AlcoholicContext.Create(new Alcoholic("Mihail", "Soliev", 18, "Han Solo"));
            Alcoholic alcoholic = _AlcoholicContext.Read(1);
            alcoholic.Name = "Gavrail";
            _AlcoholicContext.Update(alcoholic);
            Assert.IsTrue(alcoholic.Name == "Gavrail", "Updade didn`t change anything");
        }

        [Test]
        public void DeleteAlcoholic()
        {
            _AlcoholicContext.Create(new Alcoholic("Mihail", "Soliev", 18, "Han Solo"));
            int AlcoholicsBeforeTest = _AlcoholicContext.ReadAll().Count();
            _AlcoholicContext.Delete(1);
            int AlcoholicsAfterTest = _AlcoholicContext.ReadAll().Count();
            Assert.AreNotEqual(AlcoholicsBeforeTest, AlcoholicsAfterTest);
        }
    }
}