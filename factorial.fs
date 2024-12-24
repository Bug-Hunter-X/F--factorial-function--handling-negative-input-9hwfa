let rec factorial n = 
    match n with
    | 0 -> 1
    | n when n < 0 -> failwith "Input must be non-negative"
    | _ -> n * factorial (n - 1)

let result = factorial (-1)