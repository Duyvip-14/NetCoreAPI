
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace MvcMovie.Models
{
    [ Table("Persons")]
    public class Person
    {
        [Key]
        public int PersonId { get; set; }
        public  required string FullName { get; set; }
        public required string Address { get; set;}
    }
}