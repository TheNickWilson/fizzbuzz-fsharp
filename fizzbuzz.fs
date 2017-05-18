namespace fizzbuzz

module fb =
    let (|DivisibleBy|_|) divisor i =
        if i % divisor = 0 then Some () else None

    let fizzBuzz i = 
        match i with
        | DivisibleBy 15 -> "FizzBuzz"
        | DivisibleBy 3 -> "Fizz"
        | DivisibleBy 5 -> "Buzz"
        | _ -> string i
