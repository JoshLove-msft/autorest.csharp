// <auto-generated/>

#nullable disable

using System;
using System.ClientModel;
using System.ClientModel.Primitives;
using System.ClientModel.Primitives.Pipeline;
using System.Threading;
using System.Threading.Tasks;

namespace NoTestTypeSpec
{
    internal static class ClientPipelineExtensions
    {
        public static async ValueTask<PipelineResponse> ProcessMessageAsync(this Pipeline<PipelineMessage> pipeline, PipelineMessage message, RequestOptions requestContext, CancellationToken cancellationToken = default)
        {
            await pipeline.SendAsync(message).ConfigureAwait(false);

            if (message.Response == null)
            {
                throw new InvalidOperationException("Failed to receive Result.");
            }

            if (!message.Response.IsError || requestContext?.ErrorBehavior == ErrorBehavior.NoThrow)
            {
                return message.Response;
            }

            throw new MessageFailedException(message.Response);
        }

        public static PipelineResponse ProcessMessage(this Pipeline<PipelineMessage> pipeline, PipelineMessage message, RequestOptions requestContext, CancellationToken cancellationToken = default)
        {
            pipeline.Send(message);

            if (message.Response == null)
            {
                throw new InvalidOperationException("Failed to receive Result.");
            }

            if (!message.Response.IsError || requestContext?.ErrorBehavior == ErrorBehavior.NoThrow)
            {
                return message.Response;
            }

            throw new MessageFailedException(message.Response);
        }

        public static async ValueTask<NullableResult<bool>> ProcessHeadAsBoolMessageAsync(this Pipeline<PipelineMessage> pipeline, PipelineMessage message, RequestOptions requestContext)
        {
            PipelineResponse response = await pipeline.ProcessMessageAsync(message, requestContext).ConfigureAwait(false);
            switch (response.Status)
            {
                case >= 200 and < 300:
                    return Result.FromValue(true, response);
                case >= 400 and < 500:
                    return Result.FromValue(false, response);
                default:
                    return new ErrorResult<bool>(response, new MessageFailedException(response));
            }
        }

        public static NullableResult<bool> ProcessHeadAsBoolMessage(this Pipeline<PipelineMessage> pipeline, PipelineMessage message, RequestOptions requestContext)
        {
            PipelineResponse response = pipeline.ProcessMessage(message, requestContext);
            switch (response.Status)
            {
                case >= 200 and < 300:
                    return Result.FromValue(true, response);
                case >= 400 and < 500:
                    return Result.FromValue(false, response);
                default:
                    return new ErrorResult<bool>(response, new MessageFailedException(response));
            }
        }
    }
}
