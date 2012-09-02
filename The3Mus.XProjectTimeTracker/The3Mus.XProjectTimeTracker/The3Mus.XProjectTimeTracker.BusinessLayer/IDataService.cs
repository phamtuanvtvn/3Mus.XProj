using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace The3Mus.XProjectTimeTracker.BusinessLayer
{
    public interface IDataService<T>
    {
        IList<T> FindAll();

        System.Collections.Generic.IList<T> Find(T category);

        bool Insert(T value);

        bool Update(T value);

        T FindById(long id);
    }
}
