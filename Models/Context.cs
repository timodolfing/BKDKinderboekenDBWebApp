using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BKDKinderboekenDBWebApp.Models
{
    public class Context : DbContext
    {
        public Context() : base("Server=DESKTOP-R82UNLU\MSSQLSERVER_1;Database=KDBKinderboeken;Trusted_Connection=True;")
        {

        }
        DbSet<Boek> Boeken { get; set; }
    }
}