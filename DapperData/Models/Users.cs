using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DapperData.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string mail { get; set; }
        [Required]
        public string phoneNumber { get; set; }
        [Required]
        public string skillSet { get; set; }
        [Required]
        public string hobby { get; set; }     

    }
}
