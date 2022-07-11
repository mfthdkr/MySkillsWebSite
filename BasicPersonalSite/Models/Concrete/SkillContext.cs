using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BasicPersonalSite.Models.Concrete
{
    public class SkillContext : DbContext
    {
        public DbSet<Yetenek> Yeteneks { get; set; }
    }
}