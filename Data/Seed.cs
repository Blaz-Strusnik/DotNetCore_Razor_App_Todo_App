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
                    
                    Ime = "C# Todo app",
                    Opis = "Dokončaj C# Todo app za seminarsko nalogo pri predmetu Programiranje Spremenjena",
                    ZacetniDatum  = DateTime.ParseExact("2021-11-3 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2021-12-27 09:00","yyyy-M-d HH:mm",null)
                },
                new NalogaDto
                {
                    Ime = "POM opravil , nisi opravil",
                    Opis = "Seznanitev kandidatov z uspehom pri poklicni maturi",
                    ZacetniDatum  = DateTime.ParseExact("2022-9-9 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2022-9-9 09:00","yyyy-M-d HH:mm",null)
                },
                new NalogaDto
                {
                    Ime = "Ustni izpiti ",
                    Opis = "Ustni izpiti in 4.predmet. zagovor projektne naloge",
                    ZacetniDatum  = DateTime.ParseExact("2022-8-24 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2022-9-3 09:00","yyyy-M-d HH:mm",null)
                },
                new NalogaDto
                {
                    Ime = "PM pisni del Računalništvo",
                    Opis = "PM pisni del Računalništvo",
                    ZacetniDatum  = DateTime.ParseExact("2022-8-31 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2022-8-31 09:00","yyyy-M-d HH:mm",null)
                },
                new NalogaDto
                {
                    Ime = "PM pisni del angleščina",
                    Opis = "PM pisni del angleščina",
                    ZacetniDatum  = DateTime.ParseExact("2022-8-27 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2022-8-27 09:00","yyyy-M-d HH:mm",null)
                },
                new NalogaDto
                {
                    Ime = "PM pisni del slovenščina",
                    Opis = "PM pisni del slovenščina",
                    ZacetniDatum  = DateTime.ParseExact("2022-8-24 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2022-8-24 09:00","yyyy-M-d HH:mm",null)
                },
                new NalogaDto
                {
                    Ime = "Zadnji rok za oddajo POM projektne naloge",
                    Opis = "Zadnji rok za oddajo POM projektne naloge",
                    ZacetniDatum  = DateTime.ParseExact("2022-8-10 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2022-8-10 09:00","yyyy-M-d HH:mm",null)
                },
                new NalogaDto
                {
                    Ime = "Zadnji rok za prijavo k poklicni maturi",
                    Opis = "Zadnji rok za prijavo k poklicni maturi",
                    ZacetniDatum  = DateTime.ParseExact("2022-7-7 09:00","yyyy-M-d HH:mm",null),
                    KoncniDatum  = DateTime.ParseExact("2022-7-7 09:00","yyyy-M-d HH:mm",null)
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
