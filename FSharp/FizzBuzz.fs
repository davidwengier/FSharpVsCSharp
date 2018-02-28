namespace FSharp

module FizzBuzz =
    let is divisor outputString n result =
        if n % divisor = 0 then
            Some ( (result |> Option.defaultValue("")) + outputString)
        else
            result

    let fizz n result = is 3 "fizz" n result
    let buzz n result = is 5 "buzz" n result
    let bang n result = is 7 "bang" n result

    let fizzBuzzChecks n =
        None 
        |> fizz n 
        |> buzz n 
        |> bang n
        |> Option.defaultValue (string n)
      
    let fizzBuzz max =
        [1..max] |> List.map fizzBuzzChecks

    let run max =
        System.String.Concat(fizzBuzz max)
