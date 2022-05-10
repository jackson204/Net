using System;
using Xunit;
using NSubstitute;
using FluentAssertions;
namespace NSubstituteDemo
{
    public class Tests
    {
        private readonly MyClass _target;
        public Tests()
        {
        
            _target = new MyClass();
        }
        [Fact]
        public void Invoking_Throw()
        {
            _target.Invoking(r => r.MyClassMethod2())
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("未上傳圖片");
        }
    }
}