// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.InteropServices;

internal static partial class Interop
{
    internal static partial class WinMM
    {
        [DllImport(Interop.Libraries.WinMM)]
        internal static extern int mmioClose(IntPtr hMIO, int flags);
    }
}
