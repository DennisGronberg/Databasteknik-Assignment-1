using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace DB_Assignment1
{
    public class ContactsContext : DbContext
    {
        public DbSet<Contacts> Contacts { get; set; }
    }
}
