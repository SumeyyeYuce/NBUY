using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.ComplexTypes
{
    //enum (bununla kendi tiplerimizi oluşturuyouruz)
    public enum ResultStatus
    {
        Success=0,
        Error=1,
        Warning=2,
        Info=3
    }
}
