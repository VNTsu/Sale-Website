
namespace ShopV2.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Login")]
    public partial class Login
    {
        [StringLength(200)]
        public String cusFullname { get; set; }
        [Key]
        [StringLength(20)]
        public string cusPhone { get; set; }

        [StringLength(50)]
        public string pass { get; set; }
    }
}