using System;
using Xunit;
using NSubstitute;
using FluentAssertions;
namespace NSubstituteDemo
{
    public class Tests
    {
        private readonly IMediator _mediator;
        private readonly MyClass _target;
        public Tests()
        {
            _mediator = Substitute.For<IMediator>();
            _target = new MyClass(_mediator);
        }
        [Fact]
        public void Invoking_Throw()
        {
            _target.Invoking(r => r.ImageNotUploaded())
                .Should()
                .Throw<InvalidOperationException>()
                .WithMessage("未上傳圖片");
        }
        
        [Fact]
        public void TestDo()
        {
            var demo = new Demo();
            // 參數只有一個
            _mediator.MediatorMethod2(Arg.Do<Demo>(r => demo = r));
            _target.MyClassMethod();
            demo.Age.Should().Be(12);
            demo.Name.Should().Be("DemoName");
        }
        
        [Fact]
        public void TestWhenDo()
        {
            var first = string.Empty;
            var count = 0;
            var boolean = false;

            _mediator.When(r => r.MediatorMethod(Arg.Any<string>(), Arg.Any<int>(), Arg.Any<bool>()))
                .Do(w =>
                {
                    first = w[0].As<string>();
                    count = w[1].As<int>();
                    boolean = w[2].As<bool>();
                });

            var demo = new Demo();

            _mediator.When(r => r.MediatorMethod2(Arg.Any<Demo>()))
                .Do(r => demo = r[0].As<Demo>());

            _target.MyClassMethod();

            first.Should().Be("ABC");
            count.Should().Be(123);
            boolean.Should().BeTrue();

            demo.Age.Should().Be(12);
            demo.Name.Should().Be("DemoName");
        }
    }
}