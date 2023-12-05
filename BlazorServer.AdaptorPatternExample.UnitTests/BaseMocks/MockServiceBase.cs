using BlazorServer.AdaptorPatternExample.Domain.Etities;
using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Services;
using BlazorServer.AdaptorPatternExample.Services.FruityViceServices;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServer.AdaptorPatternExample.UnitTests.BaseMocks
{
    public static class MockServiceBase
    {
        public static Mock<TService> MockBaseService<TService, T>()
            where TService : class, IServiceBase<T>
            where T : BaseModel
        {
            var mock = new Mock<TService>();

            mock.Setup(x => x.Add(It.IsAny<T>())).Returns((T x) => x);

            return mock;
        }
    }
}
