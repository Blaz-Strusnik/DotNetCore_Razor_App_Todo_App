using Core.DataAccess.EntityFramework;
using TodoApp.DataAccess.Interfaces;
using TodoApp.Entities;

namespace TodoApp.DataAccess.Concretes.EntityFramework
{
    public class NalogaDal : EFRepositoryBase<Naloga, int, UpraljvalecNaDbContext>, INalogaDal { }
}
