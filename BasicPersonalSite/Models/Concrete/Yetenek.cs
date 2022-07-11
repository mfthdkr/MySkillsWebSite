using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BasicPersonalSite.Models.Concrete
{
    public class Yetenek
    {
        [Key]
        public int Id { get; set; }
        public string Aciklama { get; set; }
        public byte Deger { get; set; }
    }
}