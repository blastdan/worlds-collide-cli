using System.ComponentModel.DataAnnotations;

namespace WorldsCollideCli.Domain
{

    public enum ScalingType 
    {
        None = 0,
        PartyAverageLevel = 1,
        PartyHighestLevel = 2,
        CharactersEspers = 3,
        CharactersEspersDragons = 4,
        Checks = 5,
        Time = 6

    }

    public enum AbilityScalingType
    {
        None = 0,
        Element = 1,
        Random = 2
    }

    public class Scaling
    {
        [Required]
        public ScalingType LevelScaling { get; set; }

        [Required]
        [Range(0.5, 5)]
        public int LevelScalingValue { get; set; }

        [Required]
        public ScalingType HpMpScaling { get; set; }
        
        [Required]
        [Range(0.5, 5)]
        public int HpMpScalingValue { get; set; }

        [Required]
        public ScalingType ExpGpScaling { get; set; }
        
        [Required]
        [Range(0.5, 5)]
        public int ExpGpScalingValue { get; set; }

        [Required]
        public AbilityScalingType AbilityScaling { get; set; }
        
        [Required]
        [Range(0.5, 5)]
        public int AbilityScalingValue { get; set; }

        [Required]
        [Range(3, 99)]
        public int MaxScaleLevel { get; set; }

        public bool ScaleEightDragons { get; set; }

        public bool ScaleFinalBattles { get; set; }
    }
}