using System.Linq.Expressions;
using WebClient.Models.Entities.Common;

namespace WebClient.Repositories.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : CommonEntity
    {
        IQueryable<TEntity> GetAll(bool tracking = true); // Hepsini Getir.
        IQueryable<TEntity> GetWhere(Expression<Func<TEntity, bool>> method, bool tracking = true); // Şarta uygun olanları getir.
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> method, bool tracking = true); // Şarta uygun olan ilkini getir.
        Task<TEntity> GetByIdAsync(string id, bool tracking = true); // İstenilen Id değerine sahip olanı getir.
        Task<bool> AddAsync(TEntity model); // Data ekle.
        Task<bool> AddRangeAsync(List<TEntity> datas); // Datalar ekle.
        bool Remove(TEntity model); // Data çıkar.
        bool RemoveRange(List<TEntity> datas); // Datalar çıkar.
        Task<bool> RemoveAsync(string id); // İstenilen Id değerine sahip olan datayı çıkar.
        bool UpdateData(TEntity model); // Datayı güncelle.
        Task<int> SaveAsync(); // Değişiklikleri kaydet.
    }
}
