
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
        public async global::System.Threading.Tasks.Task SendUnifiedConversationItemDeleteAsync(
            global::Inworld.Realtime.UnifiedConversationItemDelete message,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            message = message ?? throw new global::System.ArgumentNullException(nameof(message));

            var json = global::System.Text.Json.JsonSerializer.Serialize(message, typeof(global::Inworld.Realtime.UnifiedConversationItemDelete), JsonSerializerContext);

            await SendAsync(json, cancellationToken).ConfigureAwait(false);
        }
    }
}