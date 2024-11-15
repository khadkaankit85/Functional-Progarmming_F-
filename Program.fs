// printfn " Hello world"

// let a = 5
// // to make something mutable
// let mutable b = "ankit"
// //to store a new value
// b <- "khadka"

// printfn "%s" (a.ToString())
// printfn "%s" b

// let add a b = a + b
// let result = add 4 5t
// printfn "%s" (result.ToString())

// let multiply = fun a b -> a * b
// let result1 = multiply 4 5
// printfn "%s" (result1.ToString())
t
// let multiply2 a b = a * b
// let result2 = multiply 5 6
// printfn "%s" (result2.ToString())

// [ 1..100 ] |> List.sum |> printf "sum-%d"
type human = { name: string; kind: bool }
let ankit = { name = "ankit"; kind = true }

let h2 = { name = "h2"; kind = false }

printfn "equal? %A" (ankit = h2)

let cube a = a * a * a
let cubeOf3 = cube 3
printfn "%d" cubeOf3

let myNum = 25 |> cube |> printfn "%d"

// recursion to calculate factorial of a number
let rec factorial a =
    if a <1 then 1
    else a * factorial (a - 1)

let resultofF5=factorial 5
printfn "%d" (resultofF5)

// array in F#
let arr1=[|1;2;3;4;5|]
let arr2=[|7;8;9;10;11|]

let combined = Array.append arr1 arr2

printfn "%A" (combined)

// mapping over an array in F#
let arrToMap=[| 1;2;3;4;5;6;7|]
let increasedArr=Array.map (fun x->x+1) arrToMap
printfn "%A" (increasedArr)

// for i in arrToMap do
//     printfn "%d" i

//     let ankit = [| 1L .. 10000000000000000L |]
//     printfn "%A" (ankit)

// let x = fun n -> n * n
// // let nums = [2; 3; 4; 5; 6; 7]
// // let squared = nums |> List.map x
// // printfn "Squared numbers: %A" squared
// // let x = fun n -> n*n
// // let square = [2;3;4;5] |> List.map x

 

// // printfn "%A" square

 

// // // let f = fun (s : string) -> s.Length
// // let newList = ["five"; "six"; "pick up"; "sticks"]
// // // let lengths = newList |> List.map f
// // // printfn "%A" lengths

// // let iter = List.iter (fun elem -> printfn "%s" elem)
// // iter newList
// for i=1 to 2 do
//     printfn "%s" "hello"
//     for j=1 to 2 do  
//         printfn "%d" j
//         printfn "%s" "end"
