// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

// Copyright (c) 2004 Mainsoft Co.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
//
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//


using Xunit;


namespace System.Data.Tests
{
    public class VersionNotFoundExceptionTest
    {
        [Fact]
        public void Generate1()
        {
            DataTable tbl = DataProvider.CreateChildDataTable();
            DataRow drParent = tbl.Rows[0];
            drParent.Delete();
            tbl.AcceptChanges();

            Assert.Throws<VersionNotFoundException>(() =>
            {
                object obj = drParent[0, DataRowVersion.Proposed];
            });
        }

        [Fact]
        public void Generate2()
        {
            DataTable tbl = DataProvider.CreateChildDataTable();
            DataRow drParent = tbl.Rows[0];
            drParent.Delete();
            tbl.AcceptChanges();

            Assert.Throws<VersionNotFoundException>(() =>
            {
                object obj = drParent[0, DataRowVersion.Current];
            });
        }

        [Fact]
        public void Generate3()
        {
            DataTable tbl = DataProvider.CreateChildDataTable();
            DataRow drParent = tbl.Rows[0];
            drParent.Delete();
            tbl.AcceptChanges();

            Assert.Throws<VersionNotFoundException>(() =>
            {
                object obj = drParent[0, DataRowVersion.Original];
            });
        }
    }
}
