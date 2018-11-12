using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace EntityFramework2.Models
{
    [Table("tblCatagiries")]
    public class Catagiry
    {
        [Key]
        public int CatagiryId { get; set; }
        public string CatagiryName { get; set; }
        
    }
}