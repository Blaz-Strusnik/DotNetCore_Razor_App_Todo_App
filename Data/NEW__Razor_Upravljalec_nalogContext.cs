using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace NEW__Razor_Upravljalec_nalog.Data
{
    public class NEW__Razor_Upravljalec_nalogContext : IdentityDbContext<IdentityUser>
    {
        public NEW__Razor_Upravljalec_nalogContext(DbContextOptions<NEW__Razor_Upravljalec_nalogContext> options)
            : base(options)
        {
        }

        public DbSet<NEW__Razor_Upravljalec_nalog.Model.NalogaDto> NalogaDto { get; set; } = default!;
    }
}
