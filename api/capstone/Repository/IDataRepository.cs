using capstone.Model;

namespace capstone.Repository
{
    public interface IDataRepository<TEntity>
    {
        Task<IEnumerable<TEntity>> GetAll();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity dbEntity, TEntity entity);
        void Delete(TEntity entity);
        Task<string> Validate(TEntity entity);
        Task<IEnumerable<offers>> GetAlloffers(long servicenumber,long simnumber);
    }
    
}
