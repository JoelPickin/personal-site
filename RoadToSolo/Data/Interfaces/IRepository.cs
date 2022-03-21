using System.Collections.Generic;
using System.Threading.Tasks;

namespace RoadToSolo.Data.Interfaces
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetSingleById(int id);

        T GetSingleByName(string name);
    }
}