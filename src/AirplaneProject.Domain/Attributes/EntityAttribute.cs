using System;
using System.Collections.Generic;
using System.Text;

namespace AirplaneProject.Domain.Attributes
{
    [AttributeUsageAttribute(AttributeTargets.Class)]
    public class EntityAttribute : Attribute
    {
        public string Include { get; set; }

        public EntityAttribute(string include)
        {
            this.Include = include;
        }
    }
}
