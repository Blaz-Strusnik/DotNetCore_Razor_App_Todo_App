using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Upravljalec_Nalog.Models;

namespace Upravljalec_Nalog.Data
{
    public class Seed
    {
        public static void Initialize(UpravljalecNaDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Naloge.Any())
            {
                return;   // DB has been seeded
            }

            var naloge = new NalogaDto[]
            {
           new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                },
                new NalogaDto
                {
                    Ime = "Past Activity 1",
                    Opis = "Activity 2 months ago",
                    ZacetniDatum  = DateTime.Now.AddMonths(-2),
                    KoncniDatum  = DateTime.Now.AddMonths(-4)
                }
            };
            foreach (NalogaDto n in naloge)
            {
                context.Naloge.Add(n);
            }
            context.SaveChanges();
        }
    }
}
