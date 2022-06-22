using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class Alcoholic
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        [MaxLength(25)]
        public string Name { get; set; }

        [Required]
        [MaxLength(25)]
        public string FamilyName { get; set; }

        [Required]
        [Range(18, 99)]
        public byte Age { get; set; }

        [Required]
        [MaxLength(35)]
        public string DrunkName { get; set; }

        public IEnumerable<Alcoholic> DrinkingBuddies { get; set; }

        public IEnumerable<Alcohol> FavouriteDrinks { get; set; }

        private Alcoholic()
        {

        }

        public Alcoholic(string name, string familyName, byte age, string drunkName)
        {
            Name = name;
            FamilyName = familyName;
            Age = age;
            DrunkName = drunkName;
            this.DrinkingBuddies = new HashSet<Alcoholic>();
            this.FavouriteDrinks = new HashSet<Alcohol>();
        }

        public Alcoholic(string name, string familyName, byte age, string drunkName, List<Alcoholic> drinkingBuddies, List<Alcohol> favouriteDrinks) : this(name, familyName, age, drunkName)
        {
            this.DrinkingBuddies = drinkingBuddies;
            this.FavouriteDrinks = favouriteDrinks;
        }

        public Alcoholic(int iD, string name, string familyName, byte age, string drunkName) : this(name, familyName, age, drunkName)
        {
            this.ID = iD;
        }
    }
}