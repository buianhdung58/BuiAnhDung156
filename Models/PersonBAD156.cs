using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace BuiAnhDung156.Models
{
    public class PersonBAD156
    {
        [Key]
        [Column(TypeName="nvarchar(20)")]
        [Required]
        public string PersonId { get; set; }
        [Column(TypeName="nvarchar(50)")]
        [Required]

        public string PersonName { get; set; }
    }
}