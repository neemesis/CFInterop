namespace FSharp

module Say =
    open Domain
    
    let hello name =
        "Hello " + name

    let avgHeight xs = 
        let sum = xs |> List.sumBy (fun (x : Person) -> x.Height) |> double
        let length = List.length xs |> double
        sum / length