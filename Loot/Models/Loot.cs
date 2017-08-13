using System;
using System.ComponentModel;

namespace Loot.Models
{
    public class Loot
    {
        public enum LootName
        {
            Casque = 1,
            Collier = 2,
            Epaule = 3,
            Cape = 4,
            Torse = 5,
            Poignet = 6,
            Botte = 7,
            Ceinture = 8,
            Jambe = 9,
            Bague = 10,
            Bijou = 11,
            [Description("Relique Corruption")] ReliqueCorruption = 12,
            [Description("Relique Fer")] ReliqueFer = 13,
            [Description("Relique Tempete")] ReliqueTempete = 14,
            [Description("Relique Arcane")] ReliqueArcane = 15,
            [Description("Relique Vie")] ReliqueVie = 16,
            [Description("Relique Sacre")] ReliqueSacre = 17,
            [Description("Relique Ombre")] ReliqueOmbre = 18,
            [Description("Relique Sang")] ReliqueSang = 19,
            [Description("Relique Givre")] ReliqueGivre = 20,
            [Description("Relique Feu")] ReliqueFeu = 21
        }

        public Guid Id { get; set; }
        public LootName Name { get; set; }
    }
}