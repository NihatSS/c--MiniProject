﻿using c__Mini_Project;

Generic<int> generic =  new Generic<int>();

//generic.Add(1);
generic.AddRange(1, 2, 3, 5);


//generic.Remove(1);

generic.Insert(1, 3);

//generic.Reverse();

//var res = generic.IndexOf(1);

//var res =generic.Contains(4);

//generic.AddRange(1,7,8,9);

//generic.Contains(1);

Console.WriteLine(generic);