using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AwsWebApp.Models
{
    [Table("customer", Schema = "public")]
    public class Customer
    {
        [Key]
        [Column("id_customer")]
        public int id { get; set; }

        [MaxLength(100)]
        [Column("name")]
        public string Name { get; set; }

        [MaxLength(50)]
        [Column("nit")]
        public string Nit { get; set; }

        [MaxLength(150)]
        [Column("address")]
        public string Address { get; set; }
    }
}