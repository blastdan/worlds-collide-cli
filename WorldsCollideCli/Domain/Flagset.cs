namespace WorldsCollideCli.Domain
{
    public class Flagset
    {
        public Flagset()
        {
            this.Battle = new Battle();            
        }
        
        public Battle Battle { get; set; }
    }
}