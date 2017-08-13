using System;
using Loot.Dal.Repositories;

namespace Loot.Dal
{
    public interface ILootUnitOfWork : IDisposable
    {
        IBossRepository BossRepository { get; }
        IExpansionRepository ExpansionRepository { get; }
        ILootRepository LootRepository { get; }
        IPlayerRepository PlayerRepository { get; }
        IRaidRepository RaidRepository { get; }
        IStatRepository StatRepository { get; }

        void Save();
    }
}