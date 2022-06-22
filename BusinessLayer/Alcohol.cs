using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Alcohol
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        [MaxLength(40)]
        public string Title { get; set; }

        [Required]
        [MaxLength(20)]
        public string MainIngrediant { get; set; }

        [Required]
        [MaxLength(25)]
        public string Countries { get; set; }

        [Range(0, double.MaxValue)]
        public double PriceInBushido { get; set; }

        [Range(0, double.MaxValue)]
        public double PriceInOnyx { get; set; }

        [Range(0, double.MaxValue)]
        public double PriceInSecrets { get; set; }

        private Alcohol()
        {

        }

        public Alcohol(string title, string mainIngrediant, string countries, double priceInBushido, double priceInOnyx, double priceInSecrets)
        {
            Title = title;
            MainIngrediant = mainIngrediant;
            Countries = countries;
            PriceInBushido = priceInBushido;
            PriceInOnyx = priceInOnyx;
            PriceInSecrets = priceInSecrets;
        }
        public Alcohol(int iD, string title, string mainIngrediant, string countries, double priceInBushido, double priceInOnyx, double priceInSecrets) : this(title, mainIngrediant, countries, priceInBushido, priceInOnyx, priceInSecrets)
        {
            ID = iD;
        }


    }
}