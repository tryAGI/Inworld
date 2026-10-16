
#nullable enable

namespace Inworld.Realtime
{
    public sealed partial class InworldUnifiedRealtimeClient
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="message">The message to send.</param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public async global::System.Threading.Tasks.Task SendUnifiedInputAudioBufferClearAsync(
            global::Inworld.Realtime.UnifiedInputAudioBufferClear message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Inworld.Realtime.UnifiedInputAudioBufferClear), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}