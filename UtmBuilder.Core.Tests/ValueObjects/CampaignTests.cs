using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;
using Xunit;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    public class CampaignTests
    {
        [Theory]
        [InlineData("", "", "", true)]
        [InlineData("src", "", "", true)]
        [InlineData("src", "med", "", true)]
        [InlineData("src", "med", "name", false)]
        public void TestCampaign(
            string source,
            string medium, string name,
            bool expectedException)
        {
            if (expectedException)
            {
                var ex = Assert.Throws<InvalidCampaignException>(() => new Campaign(source, medium, name));
                Assert.NotNull(ex);
            }
            else
            {
                var campaign = new Campaign(source, medium, name);
                Assert.NotNull(campaign);
            }
        }

        [Theory]
        [InlineData("", "med", "name", true)]
        [InlineData("src", "med", "name", false)]
        public void TestCampaign_2(
           string source,
           string medium, string name,
           bool expectedException)
        {
            if (expectedException)
            {
                try
                {
                    new Campaign(source, medium, name);
                }
                catch (InvalidCampaignException e)
                when (e.Message == "Invalid Source")
                {
                    Assert.True(true);
                }
            }
            else
            {
                var campaign = new Campaign(source, medium, name);
                Assert.NotNull(campaign);
            }
        }
    }
}