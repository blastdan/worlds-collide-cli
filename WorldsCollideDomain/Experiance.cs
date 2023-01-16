using System.ComponentModel.DataAnnotations;

namespace WorldsCollideDomain
{
    public class ExperienceMagicPointsGold
    {
        [Required]
        [Range(0, 255)]
        public int ExperienceMultiplier { get; set; }

        [Required]
        [Range(0, 255)]
        public int MagicPointsMultiplier { get; set; }

        [Required]
        [Range(0, 255)]
        public int GoldMultiplier { get; set; }

        [Required]
        public bool SplitPartyExperience { get; set; }
    }
}
