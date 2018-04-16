using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace DesignPatterns.Modules.Models
{
    class MonthCollection : IEnumerable
    {
        string[] months = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

        public IEnumerator GetEnumerator()
        {
            // Generates values from the collection
            foreach (string element in months)
                yield return element;
        }
    }

   
}
