using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Abstract
{
    //out ile istediğimiz şekilde birşey döndürebilirz
    public interface IDataResult<out T> : IResult
    {
        public T Data { get;}
        //new DataResult<Category>(ResultStatus.Success,Category)
        //new DataResult<IListCategory>(ResultStatus.Success,categories)
        //new DataResult<Ilist<Category>>(ResultStatus)
    }
}
