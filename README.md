# fizzbuzz-fsharp
Simple F# implementation of FizzBuzz

You'll need to have [F#](http://fsharp.org/use/mac/) and the [dotnet command line tools](https://docs.microsoft.com/en-us/dotnet/articles/core/tools/) installed - or a suitable Docker container or something.

To run the tests: `dotnet test`

To run it interactively in F# Interactive, use something like: `for i in 1..100 do fizzbuzz i |> printfn "%s"`
