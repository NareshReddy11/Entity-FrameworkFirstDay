using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework2.Models
{
    [Table("tblProducts")]
    public class Product
    {
        [Key]
        public int ProductId { set; get; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public Catagiry Catagiry { get; set; }
    }
}