// <auto-generated/>

#nullable disable

using System.ComponentModel;

namespace AzureDataFactory.TestingFramework.Models
{
    /// <summary> The transport protocol to use in the Thrift layer. </summary>
    public readonly partial struct SparkThriftTransportProtocol : IEquatable<SparkThriftTransportProtocol>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SparkThriftTransportProtocol"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SparkThriftTransportProtocol(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string BinaryValue = "Binary";
        private const string SaslValue = "SASL";
        private const string HttpValue = "HTTP ";

        /// <summary> Binary. </summary>
        public static SparkThriftTransportProtocol Binary { get; } = new SparkThriftTransportProtocol(BinaryValue);
        /// <summary> SASL. </summary>
        public static SparkThriftTransportProtocol Sasl { get; } = new SparkThriftTransportProtocol(SaslValue);
        /// <summary> HTTP. </summary>
        public static SparkThriftTransportProtocol Http { get; } = new SparkThriftTransportProtocol(HttpValue);
        /// <summary> Determines if two <see cref="SparkThriftTransportProtocol"/> values are the same. </summary>
        public static bool operator ==(SparkThriftTransportProtocol left, SparkThriftTransportProtocol right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SparkThriftTransportProtocol"/> values are not the same. </summary>
        public static bool operator !=(SparkThriftTransportProtocol left, SparkThriftTransportProtocol right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SparkThriftTransportProtocol"/>. </summary>
        public static implicit operator SparkThriftTransportProtocol(string value) => new SparkThriftTransportProtocol(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SparkThriftTransportProtocol other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SparkThriftTransportProtocol other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}