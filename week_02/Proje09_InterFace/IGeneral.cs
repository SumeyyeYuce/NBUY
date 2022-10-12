using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proje09_InterFace
{
    public interface IGeneral
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }

   
       
    }

        public interface IGeneral2:IGeneral
        {
        public string NameToUpper();
        }

    public class Product : IGeneral2
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string NameToUpper()
        {
            throw new NotImplementedException();
        }
    }

    public class Category : IGeneral2
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string NameToUpper()
        {
            throw new NotImplementedException();
        }
    }

    public class Departman : IGeneral2
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string NameToUpper()
        {
            throw new NotImplementedException();
        }
    }

    public class Employee : IGeneral2
    {
        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public DateTime CreatedDate { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string NameToUpper()
        {
            throw new NotImplementedException();
        }
    }

}
