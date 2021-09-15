using Xunit;
using System.Collections.Generic;

namespace Assignment1.Tests
{
    public class RegExprTests
    {
        [Fact]
        public void SplitLine_givenLines_returnWords()
        {
            List<string> expected = new List<string>(){"Seje", "reje", "Simon", "er", "god"};
            List<string> lines = new List<string>(){"Seje reje", "Simon er god"};
            var output = RegExpr.SplitLine(lines);

            Assert.Equal(expected, output);
        }

        [Fact]
        public void Resolution_givenResolutionString_ReturnStreamAsTuples()
        {
            
            List<(int,int)> expected = new List<(int,int)>(){(1024,768),(800,600),(640,480)};
            string resolutions = "1024x768, 800x600, 640x480";
            IEnumerable<(int width,int height)> output = RegExpr.Resolution(resolutions);

            Assert.Equal(expected,output);
        }
    }
}
