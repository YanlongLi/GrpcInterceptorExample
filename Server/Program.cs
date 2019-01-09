namespace ExampleServer
{
    using Grpc.Core.Interceptors;
    using Grpc.Core;
    using GrpcInterceptorExample.Contracts;
    using System;

    class Program
    {
        const int Port = 8888;

        static void Main(string[] args)
        {
            var interceptor = new ServerInterceptor();
            Server server = new Server
            {
                Services = { ExampleService.BindService(new ExampleServiceImpl()).Intercept(interceptor) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("Example server listening on port " + Port);
            Console.WriteLine("Press any key to stop the server...");
            Console.ReadKey();
        }

    }
}
