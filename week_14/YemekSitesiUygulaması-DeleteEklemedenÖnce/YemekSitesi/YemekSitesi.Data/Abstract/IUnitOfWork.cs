using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekSitesi.Data.Abstract
{
    public interface IUnitOfWork :IDisposable
    {
        IFoodRepository Foods { get; }
        ICategoryRepository Categories { get; }

        Task SaveAsync();
        void Save();
    }
}
