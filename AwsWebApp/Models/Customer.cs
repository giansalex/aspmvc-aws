using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AwsWebApp.Models
{
    [Table("customer", Schema = "public")]
    public class Customer
    {
        [Key]
        [Column("id_customer")]
        public int id { get; set; }

        public string customer { get; set; }

        public string nit { get; set; }

        public string address { get; set; }
    }
}