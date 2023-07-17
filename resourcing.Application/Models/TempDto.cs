using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Application.Models
{
    public class TempDto
    {
        public Guid Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(255)]
        public string LastName { get; set; } = string.Empty;
    }
}
