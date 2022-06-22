using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BusinessLayer
{
    public class Party
    {
        [Key]
        public int ID { get; private set; }

        [Required]
        [MaxLength(40)]
        public string PartyTitle { get; set; }

        [Required]
        [MaxLength(25)]
        public string Location { get; set; }

        [Required]
        public string Description { get; set; }

        public IEnumerable<Alcoholic> PartyMembers { get; set; }

        public IEnumerable<Alcohol> Drinks { get; set; }

        private Party()
        {

        }

        public Party(string partyTitle, string location, string description)
        {
            this.PartyTitle = partyTitle;
            this.Location = location;
            this.Description = description;
            this.PartyMembers = new HashSet<Alcoholic>();
            this.Drinks = new HashSet<Alcohol>();
        }

        public Party(string partyTitle, string location, string description, List<Alcoholic> partymembers, List<Alcohol> drinks) : this(partyTitle, location, description)
        {
            this.PartyMembers = partymembers;
            this.Drinks = drinks;
        }

        public Party(int iD, string partyTitle, string location, string description) : this(partyTitle, location, description)
        {
            ID = iD;
        }
    }
}