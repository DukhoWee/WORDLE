namespace Wordle

type Feedback =
    | Correct
    | Present
    | Absent

type GuessResult =
    { Guess: string
      Feedback: Feedback list }

type GameConfig =
    { WordLength: int
      MaxAttempts: int
      WordListPath: string }

module Defaults =
    let config =
        { WordLength = 5
          MaxAttempts = 6
          WordListPath = "valid-wordle-words.txt" }
