# F# Factorial Function: Handling Negative Input

This example demonstrates a common error in F# recursive functions: not handling negative input in the factorial function.

The `factorial.fs` file contains the initial implementation of the factorial function, which throws an exception when a negative number is provided as input.

The `factorialSolution.fs` file shows how to correctly handle negative input by either returning an error or using the `Option` type to represent the possibility of a missing result for negative inputs.

## Running the code

You can run the code using a F# compiler (e.g., the one included with .NET SDK).

## Additional Notes

This illustrates the importance of input validation in F# and other functional programming languages to ensure the robustness of recursive functions.