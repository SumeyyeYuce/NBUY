using BlogApp.Shared.Utilities.Result.ComplexTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Shared.Utilities.Result.Abstract
{
    public interface IResult
    {
        public ResultStatus ResultStatus { get; }//ResultStatus.Info gibi kullamıcaz
        public string Message { get;}//hata mesajlarını bunula taşıyaz
        public Exception Exception { get; }//hataları exception ları bunula taşıcaz

    }
}
