using System.Collections.Generic;
using Vavatech.PSI.WPF.Models;

namespace Vavatech.PSI.WPF.IServices
{
    public interface IEntitiesService<TEntity>
        where TEntity : Base
    {
        IList<TEntity> Get();
        TEntity Get(int id);
        void Add(TEntity entity);
        void Update(TEntity entity);
        void Remove(TEntity entity);
    }

   
}
