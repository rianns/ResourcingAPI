using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Application.Models
{
    public class JobDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Name { get; set; }

        [Required]
        [MaxLength(1000)]
        public string? Description { get; set; }
    }
}
