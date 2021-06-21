// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace System.ComponentModel.Composition.Primitives
{
    internal interface IPartCreatorImportDefinition
    {
        ContractBasedImportDefinition ProductImportDefinition { get; }
    }
}
