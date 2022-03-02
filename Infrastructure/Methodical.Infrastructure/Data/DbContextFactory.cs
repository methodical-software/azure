using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Methodical.Infrastructure.Data
{
    public class ApplicationContextDesignFactory : DesignTimeDbContextFactoryBase<MethodicalDBContext>
    {
        public ApplicationContextDesignFactory() : base("MethodicalDBConnection", typeof(MethodicalDBContext).GetTypeInfo().Assembly.GetName().Name)
        { }
        protected override MethodicalDBContext CreateNewInstance(DbContextOptions<MethodicalDBContext> options)
        {
            return new MethodicalDBContext(options);
        }
    }
}
