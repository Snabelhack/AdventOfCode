using System.Runtime.InteropServices.JavaScript;

namespace AdventOfCode;

public class SolveOne
{
    /// <summary>
    /// Returns the max value that each elf is carrying. 
    /// </summary>
    /// <param name="input"></param>
    /// <returns>Summary of the maximum weight the elfs are carrying.</returns>
    public static int Solve(string input) =>
        // Check if null or empty input. If so (?) return 0. Else (:) perform and return the lambda function. 
        string.IsNullOrEmpty(input)
            ? 0
            : input
                .Trim() // Remove all whitespace 
                .Split("\n\n") // Split into stringarray segments by separator condition. 
                .Select(segment => segment.Split('\n').Sum(int.Parse)) // Select the segment by separator condition and summarize each number 
                .Max(); // Find the max sum of all the summarized segments.


    /// <summary>
    /// 
    /// </summary>
    /// <param name="input"></param>
    /// <returns></returns>
    public static int MySolve(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            return 0;
        }

        // Use .Split to separate the lines by \n. .Select and lambdaexpression to separate the textblocks
        return input.Split("\n\n").Select(block => block.Split('\n').Sum(int.Parse)).Sum();
    }
}
