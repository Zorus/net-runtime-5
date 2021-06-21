// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;
using System.Runtime.CompilerServices;

// Based on
// Original generated by Fuzzlyn on 2018-06-20 00:58:58
// Seed: 11049252875418439527
// Reduced from 97.5 KiB to 0.5 KiB
// Debug: Outputs -1
// Release: Outputs -65536

struct S0
{
    public sbyte F0;
    public char F1;
    public ushort F2;
}

struct S1
{
    public short F0;
    public S0 F1;
    public S0 F2;
    public S0 F3;
    public int F4;
    public S1(int f4): this()
    {
        F4 = f4;
    }
}

public class GitHub_18522_4
{
    static S1 s_6;
    static S1[] s_13 = new S1[]{new S1(-1)};
    public static int Main()
    {
        // When generating code for the x64 SysV ABI, the jit was
        // incorrectly typing the return type from M16, and so
        // inadvertently overwriting the F4 field of s_13[0] on return
        // from the call.
        //
        // Here we make sure we properly handle an inline call that
        // resolves to a noinline call.
        s_13[0].F3 = W();
        return s_13[0].F4 == -1 ? 100 : 0;
    }

    static S0 W()
    {
        return M16();
    }

    [MethodImpl(MethodImplOptions.NoInlining)]
    static S0 M16()
    {
        return s_6.F3;
    }
}
