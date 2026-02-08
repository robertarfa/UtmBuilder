using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;
using Xunit;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    public class UrlTests
    {

        private const string InvalidUrl = "Teste";
        private const string ValidUrl = "http://www.google.com";

        [Fact]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            try
            {
                var url = new Url(InvalidUrl);
                Assert.True(false);
            }
            catch (InvalidUrlException e)
            {
                Assert.Equal("Invalid URL", e.Message);
            }
        }

        [Fact]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao_2()
        {
            var ex = Assert.Throws<InvalidUrlException>(() => new Url(InvalidUrl));
            Assert.Equal("Invalid URL", ex.Message);
        }

        [Fact]
        public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
        {
            new Url(ValidUrl);
            Assert.True(true);
        }
    }
}