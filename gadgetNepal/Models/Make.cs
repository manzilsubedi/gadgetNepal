using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace gadgetNepal.Models
{
    public class Make
    {
        public int id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
