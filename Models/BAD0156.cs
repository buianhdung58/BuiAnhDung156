using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace BuiAnhDung156.Models
{
    public class BAD0156
    {
        [Key]
        [Column(TypeName="nvarchar(20)")]
        [Required]
        public string NVNId { get; set; }
        [Column(TypeName="nvarchar(50)")]
        [Required]

        public string NVNName { get; set; }

        public Boolean NVNGender { get; set; }
    }
}