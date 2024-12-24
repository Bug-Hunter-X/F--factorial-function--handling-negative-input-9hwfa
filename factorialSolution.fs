let rec factorial n = 
    match n with
    | 0 -> 1
    | n when n < 0 -> failwith "Input must be non-negative"
    | _ -> n * factorial (n - 1)

//Option handling
let rec factorialOption n = 
    match n with
    | 0 -> Some 1
    | n when n < 0 -> None
    | _ -> let result = factorialOption (n-1) in
            match result with
            |Some x -> Some (n*x)
            |None -> None

let result1 = factorial 5
let result2 = factorialOption (-1)
let result3 = factorialOption 5