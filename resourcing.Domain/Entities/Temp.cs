using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Resourcing.Domain.Entities
{
    [Table("Temp")]
    public class Temp
    {
        [Column("TempID")]
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        [Column("JobID")]
        public Guid JobId { get; set; }
        [ForeignKey("JobId")]
        public Job? Job { get; set; }
    }
}
