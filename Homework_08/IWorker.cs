﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_08
{
    interface IWorker
    {
        string Name { get; set; }

        void DoWork(House house);
    }
}
