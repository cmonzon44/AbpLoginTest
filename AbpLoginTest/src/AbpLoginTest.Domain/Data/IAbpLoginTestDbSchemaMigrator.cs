using System.Threading.Tasks;

namespace AbpLoginTest.Data;

public interface IAbpLoginTestDbSchemaMigrator
{
    Task MigrateAsync();
}
