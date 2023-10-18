using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
     class Car
    {
        public enum State
        {
            P,
            R,
            N,
            D
        }

        public enum Gear
        {
            First,
            Second,
            Third,
            Fourth
        }
    }
}
