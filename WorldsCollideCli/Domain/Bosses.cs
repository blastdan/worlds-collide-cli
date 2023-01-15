using System.ComponentModel.DataAnnotations;

namespace WorldsCollideCli.Domain
{
    public enum BossBattleType
    {
        None = 0,
        Original = 1,
        Shuffled = 2,
        Mixed = 3
    }

    public class Bosses
    {
        [Required]
        public BossBattleType BossBattles { get; set; }

        [Required]
        public BossBattleType StatueBattles { get; set; }

        [Required]
        public BossBattleType DragonBattles { get; set; }
        
        [Required]
        public bool BoosExperiance { get; set; }
    }
}