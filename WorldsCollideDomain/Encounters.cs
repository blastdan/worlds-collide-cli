using System.ComponentModel.DataAnnotations;

namespace WorldsCollideDomain
{

    public enum RandomEncountersType
    {
        None = 0,
        Original = 1,
        Shuffle = 2,
        RandomWithBossChance = 3
    }

    public enum FixedEncountersType
    {
        None = 0,
        Original = 1,
        RandomWithBossChance = 3
    }

    public class Encounters
    {
        [Required]
        public RandomEncountersType RandomEncounters { get; set; }

        [Required]
        public FixedEncountersType FixedEncounters { get; set; }

        [Required]
        [Range(0, 100)]
        public int FixedEncountersPercentage { get; set; }

    }
}
