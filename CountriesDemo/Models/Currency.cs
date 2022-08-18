using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CountriesDemo.Models
{
    public class Currency
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [Display(Name = "Active")]
        public bool Active { get; set; }
        public ICollection<Country>? Countries { get; set; }

    }
}
