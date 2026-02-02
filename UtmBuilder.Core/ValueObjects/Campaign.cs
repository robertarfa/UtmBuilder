using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UtmBuilder.Core.ValueObjects
{
    public class Campaign : ValueObject
    {

        // <summary>
        // Create a new Campaign
        // </summary>
        public Campaign(
            string source,
            string medium,
            string name,
            string? id = null,
            string? term = null,
            string? content = null
        )
        {
            Source = source;
            Medium = medium;
            Name = name;
            Id = id;
            Term = term;
            Content = content;
        }


        // <summary>
        // Source of Campaign
        // </summary>       
        public string Source { get; }
        // <summary>
        // Medium of Campaign
        // </summary>
        public string Medium { get; }
        // <summary>
        // Name of Campaign
        // </summary>
        public string Name { get; }
        // <summary>
        // Id of Campaign
        // </summary>
        public string? Id { get; }
        // <summary>
        // Term of Campaign
        // </summary>
        public string? Term { get; }
        // <summary>
        // Content of Campaign
        // </summary>
        public string? Content { get; }
    }
}