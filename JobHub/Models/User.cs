using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobHub.Models
{
    public class User
    {
        [Key]
        [Column(TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        [Column(TypeName ="varchar(50)")]
        public string name { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string surname { get; set; }
        [Column(TypeName = "varchar(25)")]
        public string role { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string email { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string password { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime created_at { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime updated_at { get; set;}
        [Column(TypeName = "bit")]
        public bool is_del { get; set; }
        [Column(TypeName = "datetime2")]
        public DateTime? deleted_at { get; set; }
    }
}
