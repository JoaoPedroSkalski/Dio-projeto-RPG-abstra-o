namespace RPG.src.Entities
{
    public abstract class Hero
    {

        public Hero(string Name, int Level, string Classe){
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            
        }
        public string Name;

        public int Level;

        public string Classe;

        public override string ToString(){
            return this.Name +" "+ this.Level + " " + this.Classe + " ";
   
        }

        public virtual string attack(){
            return this.Name + "Atacou com sua espada";

        }

    }
}