#nullable enable

using System.Text.Json.Nodes;
using System.Text.Json.Serialization;

namespace Inworld.Realtime;

[JsonSerializable(typeof(JsonObject))]
internal sealed partial class RealtimeJsonContext : JsonSerializerContext;
