using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Loot.Dal;

namespace LootServices
{
    public class LootService : ILootService
    {
        private readonly ILootUnitOfWork unitOfWork;

        public LootService(ILootUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void DoWork()
        {
        }
    }
}
