// Copyright (c) Xenko contributors (https://xenko.com) and Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using System;

namespace Xenko.Core.Assets
{
    /// <summary>
    /// Associates meta-information to a particular <see cref="Asset"/>.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class)]
    public class AssetDescriptionAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssetDescriptionAttribute"/> class.
        /// </summary>
        /// <param name="fileExtensions">The file extensions supported by a type of asset.</param>
        public AssetDescriptionAttribute(string fileExtensions)
        {
            FileExtensions = fileExtensions;
        }

        /// <summary>
        /// Gets the file extensions supported by a type of asset.
        /// </summary>
        /// <value>The extension.</value>
        public string FileExtensions { get; }

        /// <summary>
        /// Gets whether this asset can be an archetype.
        /// </summary>
        public bool AllowArchetype { get; set; } = true;

        /// <summary>
        /// Always mark this asset type as root.
        /// </summary>
        public bool AlwaysMarkAsRoot { get; set; }
    }
}
