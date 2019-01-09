namespace ExampleServer
{
    using Bond.Grpc;
    using Grpc.Core;
    using GrpcInterceptorExample.Contracts;
    using System.Threading.Tasks;

    public class ExampleServiceImpl : ExampleService.ExampleServiceBase
    {
        public override async Task<IMessage<SampleResponse>> GetValue(IMessage<SampleRequest> request, ServerCallContext context)
        {
            var key = request.Payload.Deserialize().Key;
            var task = Task.Run(() =>
            {
                Task.Delay(1000);
                return 10;
            });

            var value = await task;
            var response = new SampleResponse()
            {
                Key = key,
                Value = value
            };

            return Message.From(response);
        }
    }
}
