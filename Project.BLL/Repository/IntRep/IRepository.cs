using Project.ENTITIES.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Project.BLL.Repository.IntRep
{
    public interface IRepository<T> where T : BaseEntity
    {
        // modify commands   *CRUD işlemlerini yapmış olduğumuz yer!!!
        void Add(T item);
        void AddRange(List<T> list);
        void Update(T item);
        void UpdateRange(List<T> list);
        void Delete(T item);
        void DeleteRange(List<T> list);
        void Destroy(T item);
        void DestroyRange(List<T> list);

        //List Commands *Listelemek istediğimiz bilgileri çektiğimiz metodlar burada
        List<T> GetAll();
        List<T> GetActives();
        List<T> GetPassives();
        List<T> GetModifieds(int count);

        //Linq commands Linquery işlemlerini yaptığımız metodlar
        List<T> Where(Expression<Func<T,bool>>exp);
        bool Any(Expression<Func<T,bool>>exp);
        T FirstOrDefault(Expression<Func<T,bool>>exp);
        object Select(Expression<Func<T,object>>exp);
        IQueryable<X> Select<X>(Expression<Func<T,X>>exp);

        //Find Commands
        T Find(int id);

        //Last Data
        List<T> GetLastDatas(int number);

        //First Data
        List<T> GetFirstDatas(int number);

        
    }
}
