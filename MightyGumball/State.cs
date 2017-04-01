﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MightyGumball
{
    interface State
    {
        
        void InsertQuarter();
        void EjectQuarter();
        void TurnCrank();
        void Dispense();

    }
}
