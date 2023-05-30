// For more information see https://aka.ms/fsharp-console-apps
printfn "Hello from F#"
open System.IO
open System
open System.Collections.Generic

let docPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)+"\Folder"
let docs = Directory.EnumerateFiles(docPath)

let mi a b =
    if (a < b) then 
        a
    else 
        b


let comp (a:string) (b:string) =
    let i = 0
    if (i < mi (a.Length) (b.Length)) then
        if a[i] < b[i] then
            a
        else
            b
    else
        a
let rec fu a b c =
    if (a <> Seq.length c) then
        let elem = Seq.item 0 c
        fu (a + 1) (comp elem b) c
    else
        printfn $"{b}"

fu 0 "Z" docs