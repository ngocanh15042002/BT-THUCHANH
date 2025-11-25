using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace DemoMVC061.Models
{
   [Table("Persons")]
    public class Person
    {
        [Key]
        public int PersonID { get; set; }
        public required string FullName { get; set; }
        public required string Address { get; set; }
    }
}