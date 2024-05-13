using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
    public class Club
    {
        [Key]
        public int TeamId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int AmountTrophies { get; set; }
        public string TheBestFootballer { get; set; }
    }
}
