namespace Wordle

open System
open System.IO

module Words =
    let private resolvePath path =
        let outputPath = Path.Combine(AppContext.BaseDirectory, path)

        if File.Exists outputPath then outputPath
        else path

    let load path =
        path
        |> resolvePath
        |> File.ReadAllLines
        |> Array.map (fun word -> word.Trim().ToLowerInvariant())
        |> Array.filter (fun word -> word.Length > 0)
        |> Array.toList

    let validFiveLetterWords path =
        load path
        |> List.filter (fun word -> word.Length = 5 && word |> Seq.forall Char.IsLetter)
