using Microsoft.Practices.Unity;
using Unity.Wcf;
using LootServices;

namespace Loot.Services.Factories
{
    public class LootServiceFactory : UnityServiceHostFactory
    {
        protected override void ConfigureContainer(IUnityContainer container)
        {
            container
                .RegisterType<ILootService, LootService>()
                .RegisterType<Dal.ILootUnitOfWork, Dal.LootUnitOfWork>()
                .RegisterType<Dal.LootDbContext>(new HierarchicalLifetimeManager());
        }
    }
}