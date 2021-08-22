using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using UpravaljalecNalog.Business.IServices;
using UpravaljalecNalog.DataAccess.Interfaces;
using UpravaljalecNalog.DTO;
using UpravaljalecNalog.Entities;

namespace UpravaljalecNalog.Business.Services
{
    public class NalogaService : ITaskService
    {
        //DTO kullanımında AutoMapper gibi paketler kullanılabilir.

        private readonly INalogaDal _nalogaDal;

        public NalogaService(INalogaDal nalogaDal)
        {
            _nalogaDal = nalogaDal;
        }

        public int AddTask(NalogaDto nalogaDto)
        {
            var naloga = new Naloga
            {
                Ime = nalogaDto.Ime,
                Opis = nalogaDto.Opis,
                ZacetniDatum = nalogaDto.ZacetniDatum,
                KoncniDatum = nalogaDto.KoncniDatum
            };
            return _nalogaDal.Add(naloga);
        }

        public int UpdateTask(NalogaDto nalogaDto)
        {
            var naloga = new Naloga
            {
                Id = nalogaDto.Id,
                Ime = nalogaDto.Ime,
                Opis = nalogaDto.Opis,
                ZacetniDatum = nalogaDto.ZacetniDatum,
                KoncniDatum = nalogaDto.KoncniDatum
            };
            return _nalogaDal.Update(naloga);
        }

        public int DeleteTaskById(int id)
        {
            return _nalogaDal.DeleteById(id);
        }

        public IEnumerable<NalogaDto> GetAllTask(Expression<Func<Naloga, bool>> exp = null)
        {
            var naloge = _nalogaDal.GetAllByExp(exp).ToList();
            var nalogaDtoList = new List<NalogaDto>();

            naloge.ForEach(n =>
            {
                nalogaDtoList.Add(new NalogaDto
                {
                    Id = n.Id,
                    Ime = n.Ime,
                    Opis = n.Opis,
                    ZacetniDatum = n.ZacetniDatum,
                    KoncniDatum = n.KoncniDatum
                });
            });

            return nalogaDtoList;
        }
    }
}
