using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenC_.dao
{
    public interface DAO<T> where T : class
    {
        public List<T> GetAll();
        public T SelectObject(int id);
        public bool InsertObject(T obj);
        public bool UpdateObject(T obj);
    }
}
