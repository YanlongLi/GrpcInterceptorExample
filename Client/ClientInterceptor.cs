namespace Client
{
    using Grpc.Core;
    using Grpc.Core.Interceptors;
    using System;
    using System.Diagnostics;

    class ClientInterceptor : Interceptor
    {
        public ClientInterceptor()
        {
        }

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(TRequest request, ClientInterceptorContext<TRequest, TResponse> context, AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            try
            {
                var stopWatch = Stopwatch.StartNew();
                var response = base.AsyncUnaryCall(request, context, continuation);
                stopWatch.Stop();
                Console.WriteLine($"Got response in {stopWatch.ElapsedMilliseconds} ms for method '{context.Method.Name}'.");
                return response;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Request '{context.Method.Name}' got exception, '{ex.Message}'.");
                throw ex;
            }
        }
    }
}
