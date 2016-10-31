using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace Dal
{
    public interface IRepository<T>
    {
        List<T> GetAll();

        T GetById(int id);

        void Add(T t);

    }
}