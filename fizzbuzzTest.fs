namespace fizzbuzz
open System
open NUnit.Framework
open fizzbuzz
open FsUnit

module ``Spec`` =

    [<Test>]
    let ``fizzbuzzing 1 should give me 1`` () =
        fb.fizzBuzz 1 |> should equal "1"

    [<Test>]
    let ``fizzbuzzing 2 should give me 2`` () =
        fb.fizzBuzz 2 |> should equal "2"

    [<Test>]
    let ``fizzbuzzing 3 should give me Fizz`` () =
        fb.fizzBuzz 3 |> should equal "Fizz"
        
    [<Test>]
    let ``fizzbuzzing 4 should give me 4`` () =
        fb.fizzBuzz 4 |> should equal "4"
                
    [<Test>]
    let ``fizzbuzzing 5 should give me Buzz`` () =
        fb.fizzBuzz 5 |> should equal "Buzz"
        