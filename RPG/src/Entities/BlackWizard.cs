namespace RPG.src.Entities
{
    public class BlackWizard : Hero
    {
     public BlackWizard(string Name, int Level, string Classe) {
            this.Name = Name;
            this.Level = Level;
            this.Classe = Classe;
            
         
     }
        public override string attack(){
            return this.Name + "Lançou magia";

        }
        public string attack(int bonus){  
            if(bonus> 6){

                return this.Name + "lançou magia sombria Super efetivacom bonus de" + bonus;
            }
            else{
                 return this.Name + "lançou magia sombria com força fraca com o bonus de" + bonus;

            }
            }
        }



    }
}