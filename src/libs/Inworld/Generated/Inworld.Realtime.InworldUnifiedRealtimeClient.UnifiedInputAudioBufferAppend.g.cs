
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
        public async global::System.Threading.Tasks.Task SendUnifiedInputAudioBufferAppendAsync(
            global::Inworld.Realtime.UnifiedInputAudioBufferAppend message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Inworld.Realtime.UnifiedInputAudioBufferAppend), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }


        /// <summary>
        ///
        /// </summary>
        /// <param name="audio">The binary payload to send.</param>
        /// <param name="type"></param>
        /// <param name="eventId"></param>
        /// <param name="cancellationToken">A cancellation token.</param>
        public global::System.Threading.Tasks.Task SendUnifiedInputAudioBufferAppendAsync(
            global::System.ReadOnlyMemory<byte> audio,
            global::Inworld.Realtime.UnifiedInputAudioBufferAppendType type = default,
            string? eventId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            return SendUnifiedInputAudioBufferAppendAsync(
                new global::Inworld.Realtime.UnifiedInputAudioBufferAppend
                {
                Audio = audio.ToArray(),
                Type = type,
                EventId = eventId,
                },
                cancellationToken);
        }
    }
}