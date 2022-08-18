using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountriesDemo.Models
{
    public class Country
    {
        
        public Guid Id { get; set; }
        [Display(Name = "Name")]
        public string? Name { get; set; }
        [Display(Name = "Alpha2")]
        public string? Alpha2 { get; set; }
        [Display(Name = "Alpha3")]
        public string? Alpha3 { get; set; }
        [Display(Name = "Numeric")]
        public string? Numeric { get; set; }
        [Display(Name = "Active")]
        public bool Active { get; set; }
        public ICollection<Currency>? Currencies { get; set; }
    }
}
