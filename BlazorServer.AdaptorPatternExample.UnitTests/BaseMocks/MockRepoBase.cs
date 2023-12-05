using BlazorServer.AdaptorPatternExample.Domain.Models;
using BlazorServer.AdaptorPatternExample.Repositories;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorServer.AdaptorPatternExample.UnitTests.BaseMocks
{
    public static class MockRepoBase
    {
        public static Mock<TRepo> MockRepo<TRepo, T>(IEnumerable<T> list)
            where TRepo : class, IRepositoryBase<T>
            where T : BaseModel
        {
            var mock = new Mock<TRepo>();

            mock.Setup(x => x.Add(It.IsAny<T>())).Returns((T x) =>
            {
                x.Id = list.Count() + 1;
                list.Append(x);
                return x;
            });

            mock.Setup(x => x.GetById(It.IsAny<int>())).Returns((int x) => { return list.FirstOrDefault(y => y.Id == x); });

            return mock;
        }
    }
}
