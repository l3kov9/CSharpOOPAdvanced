﻿using System;

namespace _01.Cards.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.All)]
    public class TypeAttribute : Attribute
    {
        public TypeAttribute(string type, string category, string description)
        {
            this.Type = type;
            this.Category = category;
            this.Description = description;
        }

        public string Type { get; set; }

        public string Category { get; set; }

        public string Description { get; set; }

        public override string ToString()
        {
            return $"Type = {this.Type}, Description = {this.Description}.";
        }
    }
}
