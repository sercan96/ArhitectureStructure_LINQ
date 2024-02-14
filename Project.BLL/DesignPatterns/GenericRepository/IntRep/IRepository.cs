using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.DesignPatterns.GenericRepository.IntRep
{
    public interface IRepository<T> where T:BaseEntity
    {

        //List Commands

        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds();
        List<T> GetAll();

        //Modify Commands
        void Add(T item);
        void AddRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        /// <summary>
        /// Bu metot veriyi gercekten silmez sadece pasife ceker...
        /// </summary>
        /// <param name="item">Pasife cekmek istediginiz veriyi giriniz</param>
        void Delete(T item);
        void DeleteRange(List<T> list);

        /// <summary>
        /// Bu metot veriyi gerçekten siler
        /// </summary>
        /// <param name="item">Silmek istediginiz veriyi giriniz</param>
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //Linq Commands

        #region LinqSamples
        // (x => x.)

        //Deneme(12)
        //Deneme("Hello World")
        //Deneme(a)
        //db.Categories.Where(x => x.CategoryName.Contains("bev")) 

        //db.Employees.Any(x => x.FirstName == "Nancy" )

        //Linq ifadeleri aslında iki kısımdan olusur
        //1. Kısım : Argüman kısmıdır... (x=>)
        //2. Kısım : İfadenin calısmasını istedigimiz(yapmasını istedigimiz görevi) uygulayan işlem kısmıdır...
        #endregion

        List<T> Where(Expression<Func<T,bool>> exp);
        T FirstOrDefault(Expression<Func<T,bool>> exp);
        bool Any(Expression<Func<T,bool>> exp);

        //db.Categories.Select(x => new{})

        List<MyModel> Select<MyModel>(Expression<Func<T, MyModel>> exp) where MyModel:class;

        //Üst taraftaki yarattıgımız Select metodu dikkat ederseniz generic bir metot olarak yaratılmıstır...Yani görevini cagrıldıgı yerde belirledigimiz tipe göre yapacaktır...Normalde bu Select'in görevi veritabanındaki ilgili tabloya gitmek ve oradan bizim istedigimiz tipte veri döndürmektir...Biz hangi tipte veri dönmesini istedigimizi ise Select'i cagırırken onun generic tipini belirleyerek söyleriz...

        //Find
        T Find(int id);

        //Get Last Datas
        List<T> GetLastDatas(int count);

        //Get First Datas
        List<T> GetFirstDatas(int count);

        //Get Datas
        List<T> GetDatas(int count);

        

    }
}
