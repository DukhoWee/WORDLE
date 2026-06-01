namespace Wordle

open System

module ConsoleUI =
    let printIntro config =
        printfn "CLI Wordle Game"
        printfn "Guess the five-letter word within six attempts."
        printfn ""
        printfn "Feedback:"
        Console.ForegroundColor <- ConsoleColor.Green
        printf "[G]"
        Console.ResetColor()
        printfn " = correct letter and correct position"
        Console.ForegroundColor <- ConsoleColor.Yellow
        printf "[Y]"
        Console.ResetColor()
        printfn " = correct letter but wrong position"
        Console.ForegroundColor <- ConsoleColor.DarkGray
        printf "[B]"
        Console.ResetColor()
        printfn " = letter not in the answer"
        printfn ""

    let readGuess attempt maxAttempts =
        printfn "Attempt %d/%d" attempt maxAttempts
        printf "Enter your guess: "
        Console.ReadLine()

    let feedbackSymbol feedback =
        match feedback with
        | Correct -> "[G]"
        | Present -> "[Y]"
        | Absent -> "[B]"

    let printColoredFeedback feedback =
        match feedback with
        | Correct ->
            Console.ForegroundColor <- ConsoleColor.Green
            printf "[G]"
        | Present ->
            Console.ForegroundColor <- ConsoleColor.Yellow
            printf "[Y]"
        | Absent ->
            Console.ForegroundColor <- ConsoleColor.DarkGray
            printf "[B]"
        Console.ResetColor()

    let printResult (result: GuessResult) remainingAttempts =
        printfn ""
        printfn "Guess: %s" (result.Guess.ToUpperInvariant())

        result.Feedback
        |> List.iteri (fun index feedback ->
            if index > 0 then printf " "
            printColoredFeedback feedback)
        printfn ""
        printfn "Remaining attempts: %d" remainingAttempts
        printfn ""
    

    let readLine () = 
        Console.ReadLine()