namespace StudentWeb.Data
{
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;
    using StudentWeb.Data.Models;
    public class StudentWebDbContext : IdentityDbContext<ApplicationUser,ApplicationRole,Guid>
    {
        public StudentWebDbContext(DbContextOptions<StudentWebDbContext> options)
            : base(options)
        {
        }
    }
}
