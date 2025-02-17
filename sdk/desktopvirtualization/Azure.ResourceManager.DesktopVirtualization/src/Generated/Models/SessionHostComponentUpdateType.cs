// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.ComponentModel;

namespace Azure.ResourceManager.DesktopVirtualization.Models
{
    /// <summary> The type of maintenance for session host components. </summary>
    public readonly partial struct SessionHostComponentUpdateType : IEquatable<SessionHostComponentUpdateType>
    {
        private readonly string _value;

        /// <summary> Initializes a new instance of <see cref="SessionHostComponentUpdateType"/>. </summary>
        /// <exception cref="ArgumentNullException"> <paramref name="value"/> is null. </exception>
        public SessionHostComponentUpdateType(string value)
        {
            _value = value ?? throw new ArgumentNullException(nameof(value));
        }

        private const string DefaultValue = "Default";
        private const string ScheduledValue = "Scheduled";

        /// <summary> Agent and other agent side components are delivery schedule is controlled by WVD Infra. </summary>
        public static SessionHostComponentUpdateType Default { get; } = new SessionHostComponentUpdateType(DefaultValue);
        /// <summary> TenantAdmin have opted in for Scheduled Component Update feature. </summary>
        public static SessionHostComponentUpdateType Scheduled { get; } = new SessionHostComponentUpdateType(ScheduledValue);
        /// <summary> Determines if two <see cref="SessionHostComponentUpdateType"/> values are the same. </summary>
        public static bool operator ==(SessionHostComponentUpdateType left, SessionHostComponentUpdateType right) => left.Equals(right);
        /// <summary> Determines if two <see cref="SessionHostComponentUpdateType"/> values are not the same. </summary>
        public static bool operator !=(SessionHostComponentUpdateType left, SessionHostComponentUpdateType right) => !left.Equals(right);
        /// <summary> Converts a string to a <see cref="SessionHostComponentUpdateType"/>. </summary>
        public static implicit operator SessionHostComponentUpdateType(string value) => new SessionHostComponentUpdateType(value);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override bool Equals(object obj) => obj is SessionHostComponentUpdateType other && Equals(other);
        /// <inheritdoc />
        public bool Equals(SessionHostComponentUpdateType other) => string.Equals(_value, other._value, StringComparison.InvariantCultureIgnoreCase);

        /// <inheritdoc />
        [EditorBrowsable(EditorBrowsableState.Never)]
        public override int GetHashCode() => _value?.GetHashCode() ?? 0;
        /// <inheritdoc />
        public override string ToString() => _value;
    }
}
