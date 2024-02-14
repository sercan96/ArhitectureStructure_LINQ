using Project.BLL.DesignPattern.SingletonPatrern.GenericRepository.IntRep;
using Project.DAL.ContextClasses;
using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.SingletonPatrern.GenericRepository.BaseRep
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseEntity
    {
        MyContext _db;
        public BaseRepository()
        {
            _db = DBTool.DBInstance;
        }
        public void Add(T item)
        {
            _db.Set<T>().Add(item);
        }

        public void AddRange(List<T> List)
        {
            throw new NotImplementedException();
        }

        public bool Any(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Any(exp);
        }

        public void Delete(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Deleted;
            item.DeletedDate = DateTime.Now;
            Save();
        }

        private void Save()
        {
            _db.SaveChanges();
        }

        public void DeleteRange(List<T> list)
        {
            foreach (var item in list) Delete(item);
         
        }

        public void Destroy(T item)
        {
            _db.Set<T>().Remove(item);
            Save();
        }
        public void DestroyRange(List<T> list)
        {
            _db.Set<T>().RemoveRange(list);
            Save();
        }

        public T Find(int id)
        {
            return _db.Set<T>().Find(id);
        }

        public T FirstOrDefault(Expression<Func<T, bool>> exp)
        {
            throw new NotImplementedException();
        }

        public List<T> GetActives()
        {
            return Where(x => x.Status != ENTITIES.Enums.DataStatus.Deleted);
        }
        public List<T> GetAll()
        {
            return _db.Set<T>().ToList();
        }
        public List<T> GetDatas(int count)
        {
            return _db.Set<T>().Take(count).ToList();
        }

        public List<T> GetFirstDatas(int count)
        {
            return _db.Set<T>().OrderBy(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetLastDatas(int count)
        {
            return _db.Set<T>().OrderByDescending(x => x.CreatedDate).Take(count).ToList();
        }

        public List<T> GetModifieds()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Updated);
        }
        public List<T> GetPassives()
        {
            return Where(x => x.Status == ENTITIES.Enums.DataStatus.Deleted);
        }

        public List<MyModel> Select<MyModel>(Expression<Func<T, MyModel>> exp)
        {
            return _db.Set<T>().Select(exp).ToList();
        }


        public void Update(T item)
        {
            item.Status = ENTITIES.Enums.DataStatus.Updated;
            item.ModifiedDate = DateTime.Now;
            T originalData = Find(item.ID);

            // _db.Entry() ifdesindeki Entry() metodu Databse'inize bir değişiklik yapmak için giriş yapıldığını bildirir...Direkt veriyle ilgilenir...

            _db.Entry(originalData).CurrentValues.SetValues(item);
            Save();
                
        }

        public void UpdateRange(List<T> list)
        {
            foreach (T item in list) Update(item);
        }
        public List<T> Where(Expression<Func<T, bool>> exp)
        {
            return _db.Set<T>().Where(exp).ToList();
        }
    }
}
