using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace all_the_beans.Models
{
    public class Bean
    {
        [Key]
        public Guid Id { get; set; }
        public double Cost { get; set; }
        public string Aroma { get; set; }
        public string Colour { get; set; }
        public DateTime Date { get; set; }
        public string Image { get; set; }
    }
}
