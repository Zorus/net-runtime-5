// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Xunit;

namespace System.ComponentModel.Composition
{
    public class ImportingConstructorAttributeTests
    {
        [Fact]
        public void Constructor_ShouldNotThrow()
        {
            var attribute = new ImportingConstructorAttribute();

            Assert.NotNull(attribute);
        }
    }
}
