using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp1.Shared.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }
        public string Login { get; set; }
        public string FullName { get; set; }
        public int Course { get; set; }
        public string Group { get; set; }
    }
}
