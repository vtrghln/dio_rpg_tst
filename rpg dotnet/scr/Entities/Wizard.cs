namespace rpg_dotnet.scr.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType) {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }

        public override string Attack(){
            return this.Name + " Magic attack ";
        }

        public string Attack(int Bonus){
            return this.Name + " Magic attack with bonus by " + Bonus;
        }
    }
}