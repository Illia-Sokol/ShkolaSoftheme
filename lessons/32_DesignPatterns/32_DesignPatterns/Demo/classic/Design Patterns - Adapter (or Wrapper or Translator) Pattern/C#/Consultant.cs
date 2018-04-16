using System;
using System.Collections.Generic;

namespace AdapterPatternDemo
{
    //existing class does not need to be changed
    public class Consultant
    {
        private string name;

        public Consultant(string name)
        {
            this.name = name;
        }

        protected void ShowSmile()
        {
            Console.WriteLine("Consultant " + this.name + " smiles");
        }
    }
}
