﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.DolgihEN.Sprint1.Task6.V16.Lib
{
    public class DataService : ISprint1Task6V16
    {
        public bool CheckSpecSymbols(string value)
        {
            bool containsExclamation = value.Contains("!");
            bool containsQuestion = value.Contains("?");
            return containsExclamation && containsQuestion;
        }
    }
}
