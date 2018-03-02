using System;
using System.Collections.Generic;
using System.Text;

namespace some
{
    interface IShow<in T> 
        where T : Book
    {
        void ShowContent(T book);
    }
}
