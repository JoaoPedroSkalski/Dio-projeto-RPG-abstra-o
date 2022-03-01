namespace RPG.src.Entities
{
    public class Knight : Hero
    {
     public Knight(string Name, int Level, string Classe) {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            
         
     }
        public override string attack(){
            return this.Name + "Lançou magia";

        }
        public string attack(int bonus){  
            if(bonus> 6){

                return this.Name + "Realizou um ataque  forte com a espada com bonus de " + bonus;
            }
            else{
                 return this.Name + "Realizou um ataque fraco com a espada com bonus de " + bonus;

            }
            }
        }



    }
}