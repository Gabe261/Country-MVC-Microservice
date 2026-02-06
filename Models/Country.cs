using System.ComponentModel.DataAnnotations;

namespace Assignment1
{
    public class Country
    {
        public int Id { get; set; }

        [Required]
        public string CountryName { get; set; }

        [Required]
        public string Continent  { get; set; }

        [Range(1, int.MaxValue)]
        public int Population { get; set; }

        [StringLength(60)]
        public string CapitalCity { get; set; }
    }
}