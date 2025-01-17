﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.ContainerInstance.Fluent
{
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;

    /// <summary>
    /// Defines values for container instance OS type.
    /// </summary>
    public class OSTypeName : ExpandableStringEnum<OSTypeName>
    {
        public static readonly OSTypeName Linux = Parse("Linux");
        public static readonly OSTypeName Windows = Parse("Windows");
    }
}