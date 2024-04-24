using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarModels
{
    public interface IBrand
    {
        public string BrandName{get;set;}
        public string ModelName{get;set;}

        public void ShowDetails();
        
    }
}