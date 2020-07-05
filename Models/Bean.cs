using System;
using System.ComponentModel.DataAnnotations;

namespace all_the_beans.Models
{
    public class Bean
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set;}
        public double Cost { get; set; }
        public string Aroma { get; set; }
        public string Colour { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }

        public Bean() { }
    }
}
