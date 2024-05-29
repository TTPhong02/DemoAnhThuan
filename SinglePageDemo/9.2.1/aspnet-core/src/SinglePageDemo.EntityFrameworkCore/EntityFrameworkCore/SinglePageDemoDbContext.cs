using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SinglePageDemo.Authorization.Roles;
using SinglePageDemo.Authorization.Users;
using SinglePageDemo.MultiTenancy;
using SinglePageDemo.Entities;

namespace SinglePageDemo.EntityFrameworkCore
{
    public class SinglePageDemoDbContext : AbpZeroDbContext<Tenant, Role, User, SinglePageDemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<AppTasks> AppTasks { get; set; }
        public DbSet<Product> Products { get; set; }    
        public SinglePageDemoDbContext(DbContextOptions<SinglePageDemoDbContext> options)
            : base(options)
        {
        }
    }
}
