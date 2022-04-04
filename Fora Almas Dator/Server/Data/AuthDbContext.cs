using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Fora_Almas_Dator.Server.Data
{
    public class AuthDbContext : IdentityDbContext
    
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options)
        {

        }
    }
}

