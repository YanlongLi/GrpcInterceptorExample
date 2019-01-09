namespace Client
{
    using Grpc.Core;
    using Grpc.Core.Interceptors;
    using GrpcInterceptorExample.Contracts;
    using System;
    using System.Threading.Tasks;

    class Program
    {
        static void Main(string[] args)
        {
            Test().Wait();
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        static async Task Test()
        {
            Channel channel = new Channel("127.0.0.1:8888", ChannelCredentials.Insecure);

            var interceptor = new ClientInterceptor();
            var callInvoker = channel.Intercept(interceptor);

            var client = new ExampleService.ExampleServiceClient(callInvoker);

            var reply = await client.GetValueAsync(new SampleRequest { Key = "test" });
            Console.WriteLine("Value: " + reply.Payload.Deserialize().Value);

            channel.ShutdownAsync().Wait();
        }
    }
}
