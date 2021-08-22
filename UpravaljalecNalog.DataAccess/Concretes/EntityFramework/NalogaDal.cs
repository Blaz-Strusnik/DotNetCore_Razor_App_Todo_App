using Core.DataAccess.EntityFramework;
using UpravaljalecNalog.DataAccess.Interfaces;
using UpravaljalecNalog.Entities;

namespace UpravaljalecNalog.DataAccess.Concretes.EntityFramework
{
    public class NalogaDal : EFRepositoryBase<Naloga, int, UpraljvalecNaDbContext>, INalogaDal { }
}
