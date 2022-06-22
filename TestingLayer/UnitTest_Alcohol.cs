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
    public class UnitTest_Alcohol
    {
        private DrinkingPartiesDbContext _dbContext;
        private AlcoholContext _AlcoholContext;
        DbContextOptionsBuilder builder;

        [SetUp]
        public void Setup()
        {
            builder = new DbContextOptionsBuilder();
            builder.UseInMemoryDatabase(Guid.NewGuid().ToString());
            _dbContext = new DrinkingPartiesDbContext(builder.Options);
            _AlcoholContext = new AlcoholContext(_dbContext);
        }

        [Test]
        public void CreateAlcohol()
        {
            int AlcoholsBefore = _AlcoholContext.ReadAll().Count();
            _AlcoholContext.Create(new Alcohol("Bira Kamenitsa", "Hmel", "Bulgaria", 22, 35, 45));
            int AlcoholsAfter = _AlcoholContext.ReadAll().Count();
            Assert.IsTrue(AlcoholsBefore != AlcoholsAfter);
        }

        [Test]
        public void ReadAlcohol()
        {
            _AlcoholContext.Create(new Alcohol("Bira Kamenitsa", "Hmel", "Bulgaria", 22, 35, 45));
            Alcohol alcohol = _AlcoholContext.Read(1);
            Assert.That(alcohol != null, "There is no record with id 1!");
        }

        [Test]
        public void UpdateAlcohol()
        {
            _AlcoholContext.Create(new Alcohol("Bira Kamenitsa", "Hmel", "Bulgaria", 22, 35, 45));
            Alcohol alcohol = _AlcoholContext.Read(1);
            alcohol.Title = "Bira Shumensko";
            alcohol.MainIngrediant = "krushi";
            alcohol.Countries = "hungary";
            alcohol.PriceInBushido = 35;
            alcohol.PriceInOnyx = 80;
            alcohol.PriceInSecrets = 50;
            _AlcoholContext.Update(alcohol);
            Assert.IsTrue(alcohol.Title == "Bira Shumensko" || alcohol.MainIngrediant == "krushi" || alcohol.Countries == "hungary" || alcohol.PriceInBushido == 35 || alcohol.PriceInOnyx == 80 || alcohol.PriceInSecrets == 50, "Updade didn`t change anything");
        }

        [Test]
        public void DeleteAlcohol()
        {
            _AlcoholContext.Create(new Alcohol("Bira Kamenitsa", "Hmel", "Bulgaria", 22, 35, 45));
            int AlcoholsBeforeTest = _AlcoholContext.ReadAll().Count();
            _AlcoholContext.Delete(1);
            int AlcoholsAfterTest = _AlcoholContext.ReadAll().Count();
            Assert.AreNotEqual(AlcoholsBeforeTest, AlcoholsAfterTest);
        }
    }
}