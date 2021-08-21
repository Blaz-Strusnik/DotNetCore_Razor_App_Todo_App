using Core.IBaseRepositories;
using TodoApp.Entities;

namespace TodoApp.DataAccess.Interfaces
{
    public interface INalogaDal : IRepository<Naloga, int> { }
}
