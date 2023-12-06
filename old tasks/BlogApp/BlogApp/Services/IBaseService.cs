using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Services
{
    internal class IBaseService<T>
    {
        ICollection<T> GetAll();
        T GetById(int id);
        int Create(T data);
    }
}
