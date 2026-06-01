namespace Wordle

open System

module Game =

    let normalize (guess: string) =
        guess.Trim().ToLowerInvariant()

    let isValidGuess wordLength validWords guess =
        let normalized = normalize guess

        normalized.Length = wordLength
        && (normalized |> Seq.forall Char.IsLetter)
        && (validWords |> List.contains normalized)

    let scoreGuess (answer: string) (guess: string) =
        let normalized = normalize guess
        let feedback =
            normalized
            |> Seq.mapi (fun index letter ->
                if answer[index] = letter then Correct
                elif answer.Contains letter then Present
                else Absent)
            |> Seq.toList

        { Guess = normalized
          Feedback = feedback }

    let isWin (result: GuessResult) =
        result.Feedback |> List.forall ((=) Correct)
