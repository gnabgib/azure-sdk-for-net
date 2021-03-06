// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.ResourceManager.Sql.Models
{
    /// <summary> Represents a database transparent data encryption configuration. </summary>
    public partial class TransparentDataEncryption : Resource
    {
        /// <summary> Initializes a new instance of TransparentDataEncryption. </summary>
        public TransparentDataEncryption()
        {
        }

        /// <summary> Initializes a new instance of TransparentDataEncryption. </summary>
        /// <param name="id"> Resource ID. </param>
        /// <param name="name"> Resource name. </param>
        /// <param name="type"> Resource type. </param>
        /// <param name="location"> Resource location. </param>
        /// <param name="status"> The status of the database transparent data encryption. </param>
        internal TransparentDataEncryption(string id, string name, string type, string location, TransparentDataEncryptionStatus? status) : base(id, name, type)
        {
            Location = location;
            Status = status;
        }

        /// <summary> Resource location. </summary>
        public string Location { get; }
        /// <summary> The status of the database transparent data encryption. </summary>
        public TransparentDataEncryptionStatus? Status { get; set; }
    }
}
