using System;
using System.Collections.Generic;
using System.Text;

namespace FinalExam
{
    class Program
    {
        public static void Main()
        {
            Adult adult = new Adult();
            Child child = new Child();

            adult.FirstName = "Rachel";
            adult.LastName = "Green";

            child.FirstName = "Ross";
            child.LastName = "Geller";

            Object[] objects = new object[2];
            objects[0]= new Adult() { FirstName = "Dami" , LastName ="Lovato" };
            objects[1] = new Child() { FirstName = "Taylor", LastName = "Swift" };

            

        }
    }
}
