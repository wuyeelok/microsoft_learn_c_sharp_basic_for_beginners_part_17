﻿// See https://aka.ms/new-console-template for more information
var p = 16;
Console.WriteLine($"Hello, World! Part {p}");

// Specify the data source.
List<int> scores = new List<int> { 180, 2, 97, 92, 81, 60, 300 };


// Define the query expression.
IEnumerable<int> scoreQuery =
    from score in scores
    where score > 80 && score % 2 == 0
    orderby score descending
    select score;

// Convert IEnumerable to List.
List<int> myScores = [.. scoreQuery];

// Execute the query.
foreach (var i in myScores)
{
    Console.Write($"{i} ");
}
// Output: 300, 180, 92
Console.WriteLine();
Console.WriteLine($"Number of scores: {scoreQuery.Count()}");
// Output: 3