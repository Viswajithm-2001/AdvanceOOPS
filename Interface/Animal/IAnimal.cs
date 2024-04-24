using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Animal
{
    public interface IAnimal
    {
        protected string Name{get;set;}
        protected string Habitat{get;set;}
        protected string EatingHabit{get;set;}

        public void DisplayName();
        
    }
}