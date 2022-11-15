using System;
using System.Collections.Generic;

namespace Proje02_DatabaseFirst.efcore
{
    public partial class CurrentProductList
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; } = null!;
    }
}
