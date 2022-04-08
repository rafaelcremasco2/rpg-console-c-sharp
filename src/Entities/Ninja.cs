namespace rpg_console_c_sharp.src.Entities
{
    public class Ninja : Hero
    {
        
        public Ninja(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack()
        {
            return this.Name + " lançou sua estrelinha.";            
        }
        public string Attack(int Power)
        {
            if(Power > 6)
            {
                return this.Name + $" lançou sua estrelinha com bônus adicional de {Power}."; 
            } 
            else
            {
                return this.Name + " lançou sua estrelinha."; 
            }
            
        }
    }
}