﻿using System;
using System.Xml.Serialization;

namespace Lab1.Functions
{
    [XmlInclude(typeof(Constant))]
    [XmlInclude(typeof(PowerFunction))]
    [XmlInclude(typeof(ExponentialFunction))]
    [XmlInclude(typeof(LogarithmicFunction))]
    [Serializable]
    public abstract class Function
    {
        public abstract double Calculation(double x);
        public abstract Function Derivative();
        public abstract override string ToString();
        public abstract override bool Equals(object? obj);
        public abstract override int GetHashCode();
    }
}
