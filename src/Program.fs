namespace Wordle

module Program =
    [<EntryPoint>]
    let main _ =
        let config = Defaults.config
        let words = Words.validFiveLetterWords config.WordListPath
        let random = System.Random()
        let pickAnswer _ =
            words.[random.Next(words.Length)]
        
        ConsoleUI.printIntro config

        let rec gameLoop _ = 
            let answer = pickAnswer ()
            let rec playLoop n =
                if n > config.MaxAttempts then
                    printfn "Game over! The answer was: %s" answer
                else
                    printf "Attempt %d/%d: " n config.MaxAttempts
                    let guess = ConsoleUI.readLine()
                    if Game.isValidGuess config.WordLength words guess then
                        let result = Game.scoreGuess answer guess
                        ConsoleUI.printResult result (config.MaxAttempts - n)
                        if Game.isWin result then
                            printfn "Congratulations! You've guessed the word in %d attempts!" n
                        else
                            playLoop (n + 1)
                    else
                        printfn "Invalid guess. Please enter a valid five-letter word."
                        playLoop n
            playLoop 1
            printfn "Do you want to play again? (Y/N)"
            match ConsoleUI.readLine().Trim().ToUpperInvariant() with
            | "Y" -> gameLoop ()
            | _ -> printfn "Goodbye!"
        gameLoop ()
        0 // return an integer exit code    
