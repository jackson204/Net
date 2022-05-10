using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace NSubstituteDemo
{
    public class PaginationTest
    {
        [Fact]
        public void GetPage_1()
        {
            var api = new ThirdPartyAPI();
            var actual = api.callBetRecord(10, 1);
            actual.Should().BeEquivalentTo(new List<string>()
            {
                "data1",
                "data2",
            });
        }

        [Fact]
        public void GetPage_2()
        {
            var api = new ThirdPartyAPI();
            var actual = api.callBetRecord(10, 2);
            actual.Should().BeEquivalentTo(new List<string>()
            {
                "data3",
                "data4",
            });
        }
    }

    public class ThirdPartyAPI 
    {
        public List<string> GetData(int count)
        {
            var ListData = new List<string>();
            for(var j = 1; j < count; j++)
            {
                ListData.Add("data" + j);
            }
            return ListData;
        }

        // 每次只顯示兩筆資料
        public List<string> callBetRecord(int Total, int page)
        {
            return GetData(Total).Skip((page - 1) * 2)
                .Take(2).ToList();
        }
    }
}