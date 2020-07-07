using Microsoft.AspNetCore.Http;
using System;

namespace all_the_beans.ViewModels
{
    public class BeanVM
    {  
        public Guid? id { get; set; }
        public string name { get; set; }
        public double cost { get; set; }
        public string aroma { get; set; }
        public string colour { get; set; }
        public DateTime date { get; set; }
        public string image { get; set; }
    }
}
