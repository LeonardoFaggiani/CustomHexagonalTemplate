﻿using NetDevPack.Domain;

namespace Template.Api.Domian
{
    public class Sample : Entity
    {
        protected Sample() { }

        public Sample(string description)
        {
            this.Description = description;
        }

        public string Description { get; }
    }
}
