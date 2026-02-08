using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using Xunit;

namespace UtmBuilder.Core.Tests
{
    public class UtmTests
    {
        private readonly Url _url = new("https://github.com/robertarfa");
        private readonly Campaign _campaign = new("src", "med", "name", "id", "term", "content");

        private const string Link = "https://github.com/robertarfa?" +
                                    "utm_source=src" +
                                    "&utm_medium=med" +
                                    "&utm_campaign=name" +
                                    "&utm_id=id" +
                                    "&utm_term=term" +
                                    "&utm_content=content";

        [Fact]
        public void ShouldReturnUrlFromUtm()
        {
            var utm = new Utm(_url, _campaign);
            Assert.Equal(Link, utm.ToString());
            Assert.Equal(Link, (string)utm);
        }

        [Fact]
        public void ShouldReturnUtmFromUrl()
        {
            Utm utm = Link;

            Assert.Equal("https://github.com/robertarfa", utm.Url.Address);
            Assert.Equal("src", utm.Campaign.Source);
            Assert.Equal("med", utm.Campaign.Medium);
            Assert.Equal("name", utm.Campaign.Name);
            Assert.Equal("id", utm.Campaign.Id);
            Assert.Equal("term", utm.Campaign.Term);
            Assert.Equal("content", utm.Campaign.Content);
        }

    }
}