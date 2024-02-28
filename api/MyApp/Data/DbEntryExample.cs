using System.ComponentModel.DataAnnotations;

namespace MyApp
{
    public class DbEntryExample
    {
        [Key]
        public int Id {get; set;}
        public string message {get; set;}
    }
}