# CLI Wordle Game

This repository contains a command-line Wordle game for the CS-20200 Programming Principles term project.

## Overview

CLI Wordle Game is a simple terminal-based game implemented in F# using .NET 10.

The player tries to guess a hidden five-letter English word within six attempts. After each valid guess, the program gives feedback for each letter.

Feedback symbols:

- `[G]`: the letter is correct and in the correct position
- `[Y]`: the letter is in the answer but in the wrong position
- `[B]`: the letter is not in the answer

The game ends when the player guesses the word correctly or uses all six attempts.

## Requirements

- .NET 10 SDK
- F#

## How to Run

Clone this repository:

```bash
git clone https://github.com/DukhoWee/WORDLE.git
cd WORDLE
```

Run the game:

```bash
dotnet run
```

## How to Play

Start the program and enter a five-letter English word as your guess. The input is case-insensitive, so words such as `apple`, `APPLE`, and `Apple` are treated the same.

After each valid guess, the program prints feedback using `[G]`, `[Y]`, and `[B]`. A valid guess uses one attempt. Invalid input, such as a word with fewer or more than five letters or a word containing non-alphabetic characters, does not use an attempt.

The player wins by guessing the hidden word within six attempts. If the player fails to guess the word after six valid guesses, the game reveals the correct answer and ends.

After the game ends, the player can choose whether to play again.

## Example

```text
CLI Wordle Game
Guess the five-letter word within six attempts.

Feedback:
[G] = correct letter and correct position
[Y] = correct letter but wrong position
[B] = letter not in the answer

Attempt 1/6
Enter your guess: apple

Guess: APPLE
Feedback: [B] [Y] [B] [B] [G]
Remaining attempts: 5
```

## Requirement Changes

### Change 1: Word List Source

The original requirements specified that the game should contain a fixed answer list of at least ten five-letter English words, but did not specify where those words should come from. During implementation, the answer list was loaded from a publicly available word list hosted on GitHub instead of being hard-coded directly in the source code.

This change does not alter the observable game behavior or any gameplay requirements. The game still uses a fixed collection of five-letter English words and randomly selects an answer from that collection. Detailed source attribution is provided in the **Data Source** section of this README.

### Change 2: Colored Feedback Output

The original requirements described three feedback symbols: `[G]`, `[Y]`, and `[B]`. During implementation, terminal colors were added to improve readability:

* `[G]` is displayed in green.
* `[Y]` is displayed in yellow.
* `[B]` is displayed in gray.

This change is purely a presentation enhancement and does not modify the meaning or behavior of the feedback system. The same feedback information required by the proposal is still provided, with improved visual clarity for the player.


## LLM Usage
I used an LLM in the following ways during this project:

1. **Finding relevant F# built-in functions and APIs**
   I used an LLM to identify existing F#/.NET functions that could support the features I wanted to implement. For example, feedback was originally represented using characters such as [Y], [G], and [B]. To improve readability, I decided to display feedback using different colors in the CLI. The LLM helped me discover the relevant console functions for changing text colors, which enabled me to implement this feature successfully.

2. **Learning file-handling syntax**
   The project required reading data from a `.txt` file and processing its contents. I used an LLM to learn the necessary F# syntax and file I/O functions for opening text files, reading their contents, and integrating the data into the game logic.

## Data Source

The word list used in this project was obtained from:

* Dracos, *valid-wordle-words.txt*

[GitHub Gist](https://gist.github.com/dracos/dd0668f281e685bad51479e5acaadb93?utm_source=chatgpt.com)

The file is used as the source of valid words for the game.
