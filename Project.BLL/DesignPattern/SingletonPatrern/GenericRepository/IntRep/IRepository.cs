using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPattern.SingletonPatrern.GenericRepository.IntRep
{
    public interface IRepository<T> where T : class
    {
        // List Commands

        List<T> GetActives();

        List<T> GetPassives();

        void Add(T item);
        void AddRange(List<T> List);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        T Find(int id);
        List<T> GetAll();
        List<T> GetFirstDatas(int count);
        List<T> GetLastDatas(int count);
        List<T> GetDatas(int count);
        List<T> GetModifieds();

        void Update(T item);
        void UpdateRange(List<T> list);
    
        List<T> Where(Expression<Func<T, bool>> exp);
        T FirstOrDefault(Expression<Func<T, bool>> exp);
        bool Any(Expression<Func<T, bool>> exp);

        //db.Categories.Where(x=> x.Name == "Baverages");
        //                    T          Bool

        // db.Categories.Select(x=> new{});
        List<MyModel> Select<MyModel>(Expression<Func<T,MyModel>> exp);
    }
}
