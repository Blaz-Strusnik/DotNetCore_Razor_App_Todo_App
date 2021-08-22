using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using UpravaljalecNalog.DTO;
using UpravaljalecNalog.Entities;

namespace UpravaljalecNalog.Business.IServices
{
    public interface ITaskService
    {
        int AddTask(NalogaDto naloga);
        int UpdateTask(NalogaDto naloga);
        int DeleteTaskById(int id);
        IEnumerable<NalogaDto> GetAllTask(Expression<Func<Naloga, bool>> exp = null);
    }
}
