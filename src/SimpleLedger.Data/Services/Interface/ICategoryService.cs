using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLedger.Data.Services.Interface
{
    public interface ICategoryService
    {
        List<string> GetCategories();
    }
}
