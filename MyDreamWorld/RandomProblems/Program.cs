using RandomProblems.Solution;

string s1 = "Listen";
string s2 = "Silent";

bool result = AnagramSolution.IsAnagram(s1, s2);
Console.WriteLine($"'{s1}' and '{s2}' are anagrams: {result}");