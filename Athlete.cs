using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp36
{
    internal class Athlete
    {

        private string name;
        private int birth_date;
        private int proffesion;
        private int competion_number;
    
        public Athlete(string name, int birth_date, int proffesion, int competion_number)
        {
            this.name = name;
            this.birth_date = birth_date;
            this.proffesion = proffesion;
            this.competion_number = competion_number;
        }

        public int GetProfession()
        {
            return this.proffesion;
        }

        public int GetCompetionNumber() 
        {

            return this.competion_number;
        
        }
        public void IncreaseCompetions()
        {
            this.competion_number++;
        }

        public string Name(Athlete other) 
        {

            if (this.birth_date < other.birth_date) 
            { 
            
             return other.name;
            
            }
            else
            {
                return this.name;
            }
        
        
        
        }
        
       
    
    
    }
}
