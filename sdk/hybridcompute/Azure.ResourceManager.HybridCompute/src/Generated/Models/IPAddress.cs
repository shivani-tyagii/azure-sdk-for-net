// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.HybridCompute.Models
{
    /// <summary> Describes properties of the IP address. </summary>
    public partial class IPAddress
    {
        /// <summary> Initializes a new instance of IPAddress. </summary>
        internal IPAddress()
        {
        }

        /// <summary> Initializes a new instance of IPAddress. </summary>
        /// <param name="address"> Represents the IP Address. </param>
        /// <param name="ipAddressVersion"> Represents the Ip Address Version. </param>
        /// <param name="subnet"> The subnet to which this IP address belongs. </param>
        internal IPAddress(string address, string ipAddressVersion, Subnet subnet)
        {
            Address = address;
            IPAddressVersion = ipAddressVersion;
            Subnet = subnet;
        }

        /// <summary> Represents the IP Address. </summary>
        public string Address { get; }
        /// <summary> Represents the Ip Address Version. </summary>
        public string IPAddressVersion { get; }
        /// <summary> The subnet to which this IP address belongs. </summary>
        internal Subnet Subnet { get; }
        /// <summary> Represents address prefix. </summary>
        public string SubnetAddressPrefix
        {
            get => Subnet?.AddressPrefix;
        }
    }
}
