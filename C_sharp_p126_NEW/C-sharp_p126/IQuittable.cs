﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_p126
{
    interface IQuittable
    // 1. Create an interface called IQuittable and have it define a void method called Quit().
    // 2. Have your Employee class from the previous drill inherit that interface 
    // and implement the Quit() method in any way you choose.
    // 3. Use polymorphism to create an object of type IQuittable and call the Quit() method on it. 
    // Hint: an object can be of an interface type if it implements that specific interface.
    {
        void Quit(Employee employee);
    }
}
