using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.CONF.Options
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public AppUserConfiguration()
        {

            //Optional Configurations
            //ToTable("Kullanicilar");
            //Property(x=>x.UserName).IsRequired(); //UserName isimli sütun SQL'e not null olarak gider
            //Property(x=>x.Password).IsRequired(); //Password  "         " "        " "      "    "


            //Relational Configurations (Mandatory)
            HasOptional(x => x.Profile).WithRequired(x => x.AppUser);
        }
    }
}
