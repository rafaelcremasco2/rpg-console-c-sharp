namespace rpg_console_c_sharp.src.Entities
{
    public class Wizard : Hero
    {
        
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack( )
        {
            return this.Name + " lançou uma magia.";            
        }
        public string Attack(int Power)
        {
            if(Power > 6)
            {
                return this.Name + $" lançou uma magia com bônus adicional de {Power}."; 
            } 
            else
            {
                return this.Name + " lançou uma magia."; 
            }
            
        }
    }
}