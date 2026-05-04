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
<!--
## How to Run

Clone this repository:

```bash
git clone https://github.com/YOUR_USERNAME/YOUR_REPOSITORY_NAME.git
cd YOUR_REPOSITORY_NAME
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
-->
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

## Project Status

This project is currently in the proposal stage.

The final implementation will be completed in this repository using F# and .NET 10.

## LLM Usage

An LLM was used to help draft the project proposal and README structure. The final requirements and implementation will be manually reviewed and modified as needed.

During implementation, if an LLM is used to generate or revise code, this section will be updated to describe what the LLM was used for, what had to be manually changed or reprompted, and what the LLM did not do correctly.
