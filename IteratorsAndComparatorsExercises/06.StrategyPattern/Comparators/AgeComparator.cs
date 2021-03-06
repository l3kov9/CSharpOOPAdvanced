﻿using System;
using System.Collections.Generic;

namespace _06.StrategyPattern.Comparators
{
    public class AgeComparator : IComparer<Person>
    {
        public int Compare(Person x, Person y)
        {
            return x.Age.CompareTo(y.Age);
        }
    }
}
