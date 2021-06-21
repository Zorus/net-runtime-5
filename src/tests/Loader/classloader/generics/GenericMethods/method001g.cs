// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System;

public abstract class Base
{
	public abstract T Function<T>(T i);
}
public class Foo<U> : Base
{
	public override T Function<T>(T i)
	{
		return i;
	}
		
}

public class Test
{
	public static int counter = 0;
	public static bool result = true;
	public static void Eval(bool exp)
	{
		counter++;
		
		if (!exp)
		{
			result = exp;
			Console.WriteLine("Test Failed at location: " + counter);
		}
	
	}
	
	public static int Main()
	{
		Base f = new Foo<int>();

		Eval(f.Function<int>(1).Equals(1));
		Eval(f.Function<string>("string").Equals("string"));

		Base f2 = new Foo<object>();

		Eval(f2.Function<int>(1).Equals(1));
		Eval(f2.Function<string>("string").Equals("string"));
		
		
		if (result)
		{
			Console.WriteLine("Test Passed");
			return 100;
		}
		else
		{
			Console.WriteLine("Test Failed");
			return 1;
		}
		
	}
}
