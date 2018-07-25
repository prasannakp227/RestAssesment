using System;
using RestAssesment;
using Xunit;
using System.Collections.Generic;

namespace RestAssesmentTest
{
    public class RestServiceTest
    {
        [Fact]
        public async void HappyPath()
        {
            var result = await new RestService().Getdetails("AK");
            Assert.NotNull(result);
        }

        [Fact]
        public async void SadPath()
        {
            List<string> response = null;
            Exception exception;
            try{
                response = await new RestService().Getdetails("ABC");
            }
            catch(Exception){}
            Assert.Null(response)
        }
    }
}
