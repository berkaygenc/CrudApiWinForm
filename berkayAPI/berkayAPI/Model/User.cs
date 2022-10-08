using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace berkayAPI.Model
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [StringLengthAttribute(50)]
        public string Ad { get; set; }
        [StringLengthAttribute(50)]
        public string Soyad { get; set; }
    }
}
