﻿using System;
using System.Collections.Generic;

public partial class Tester
{
    public void TestNullCoalescingAssignemt()
    {
        List<int> numbers = null;
        int? i = null;

        numbers ??= new List<int>();
        numbers.Add(i ??= 17);
        numbers.Add(i ??= 20);

        Console.WriteLine(string.Join(' ', numbers));  // output: 17 17
        Console.WriteLine(i);  // output: 17
    }
}