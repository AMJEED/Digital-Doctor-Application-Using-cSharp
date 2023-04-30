using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_project
{
   public  class doctor
    {

       public  int id;
       public  string name, speciality,clinic,gender,pic;


        public override string ToString()
        {

           return  this.name + speciality;



        }


    }
}
