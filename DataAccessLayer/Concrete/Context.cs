using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext //:bir başka sınıftan kalıtsal yolla birşeyierli almak için kullanılır
    {
        //bdset entitydeki sınıflar tek tek yazılır
        //burada tanımlanan propertiler sqlde tablo adına denk gelecek
        public DbSet<About> Abouts { get; set; } //about projede yer alann sınıfın ismi abouts ise sqlde veritabanınan yansıyan isim 
        public DbSet<Category> Categories { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Content> Contents { get; set; }
        public DbSet<Heading> Headings { get; set; }
        public DbSet<Writer> Writers { get; set; }
        //burayayazılmş olan dbseti sqle yansıtacak

    }

}
