using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Upravljalec_Nalog.Models;

namespace Upravljalec_Nalog.Data
{
    public class UpravljalecNaDbContext : DbContext
    {

            public UpravljalecNaDbContext(DbContextOptions<UpravljalecNaDbContext> options) : base(options)
            {
            }

            public DbSet<NalogaDto> Naloge { get; set; }
    }
    }

