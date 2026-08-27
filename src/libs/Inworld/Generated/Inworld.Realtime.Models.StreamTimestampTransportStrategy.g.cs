
#nullable enable

namespace Inworld.Realtime
{
    /// <summary>
    ///
    /// </summary>
    public enum StreamTimestampTransportStrategy
    {
        /// <summary>
        ///
        /// </summary>
        Async,
        /// <summary>
        ///
        /// </summary>
        Sync,
        /// <summary>
        ///
        /// </summary>
        TimestampTransportStrategyUnspecified,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class StreamTimestampTransportStrategyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this StreamTimestampTransportStrategy value)
        {
            return value switch
            {
                StreamTimestampTransportStrategy.Async => "ASYNC",
                StreamTimestampTransportStrategy.Sync => "SYNC",
                StreamTimestampTransportStrategy.TimestampTransportStrategyUnspecified => "TIMESTAMP_TRANSPORT_STRATEGY_UNSPECIFIED",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static StreamTimestampTransportStrategy? ToEnum(string value)
        {
            return value switch
            {
                "ASYNC" => StreamTimestampTransportStrategy.Async,
                "SYNC" => StreamTimestampTransportStrategy.Sync,
                "TIMESTAMP_TRANSPORT_STRATEGY_UNSPECIFIED" => StreamTimestampTransportStrategy.TimestampTransportStrategyUnspecified,
                _ => null,
            };
        }
    }
}