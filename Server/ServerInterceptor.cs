namespace ExampleServer
{
    using Grpc.Core;
    using Grpc.Core.Interceptors;
    using System;
    using System.Diagnostics;
    using System.Threading.Tasks;

    class ServerInterceptor : Interceptor
    {
        public override Task<TResponse> UnaryServerHandler<TRequest, TResponse>(TRequest request, ServerCallContext context, UnaryServerMethod<TRequest, TResponse> continuation)
        {
            var stopWatch = Stopwatch.StartNew();
            var response = base.UnaryServerHandler(request, context, continuation);
            stopWatch.Stop();
            Console.WriteLine($"Request '{context.Method}' finished in {stopWatch.ElapsedMilliseconds} ms on server.");
            return response;
        }
    }
}
