using Project.BLL.DesignPattern.SingletonPatrern.GenericRepository.BaseRep;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.SingletonPatrern.GenericRepository.ConcRep
{
    public class ProfileRepository : BaseRepository<AppUserProfile>
    {
        // App User Profile'a özel veritabanına özel sorular yapmak istersek buraya yazabiliriz.
    }
}
