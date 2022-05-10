using System;

namespace NSubstituteDemo
{
    public class MyClass
    {
        private readonly IMediator _mediator;

        public MyClass(IMediator mediator)
        {
            _mediator = mediator;
        }
        public void ImageNotUploaded()
        {
            throw new InvalidOperationException("未上傳圖片");
        }

        public void MyClassMethod()
        {
          
            _mediator.MediatorMethod("ABC", 123, true);
            
            _mediator.MediatorMethod2(new Demo()
            {
                Name = "DemoName",
                Age = 12
            });
            
            
        }
    }
}