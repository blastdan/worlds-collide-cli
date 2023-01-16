namespace WorldsCollideDomain
{
    public class Battle
    {
        public Battle()
        {
            this.ExperienceMagicPointsGold = new ExperienceMagicPointsGold();
            this.Bosses = new Bosses();
            this.Scaling = new Scaling();
            this.Encounters = new Encounters();
        }

        public ExperienceMagicPointsGold ExperienceMagicPointsGold { get; set; }
        public Bosses Bosses { get; set; }
        public Scaling Scaling { get; set; }
        public Encounters Encounters { get; set; }
    }
}
