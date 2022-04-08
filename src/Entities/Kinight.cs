namespace rpg_console_c_sharp.src.Entities
{
    public class Kinight : Hero
    {
        public Kinight(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public string Attack()
        {
            return this.Name + " atacou com sua espada."; 
        }

        public  string Attack(int Power)
        {
            if(Power > 6)
            {
                return this.Name + $" atacou com sua espada com bônus adicional de {Power}."; 
            } 
            else
            {
                return this.Name + " atacou com sua espada."; 
            }
            
        }
    }
}