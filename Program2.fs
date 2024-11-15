// Write a program that uses tail recursion to process a list.
let rec sumListTailRec list acc =
    match list with
    | [] -> acc
    | head :: tail -> sumListTailRec tail (acc + head)

let sumList list =
    sumListTailRec list 0

let numbers = [1; 2; 3; 4; 5]
let result = sumList numbers
printfn "The sum of the list is: %d" result



// Partial Application
let power exponent value = pown value exponent

let square = power 2
let cube = power 3

printfn "Square of 4: %d" (square 4)
printfn "Cube of 2: %d" (cube 2)



// Tail Recursion 1
let rec productListTailRec list acc =
    match list with
    | [] -> acc
    | head :: tail -> productListTailRec tail (acc * head)

let productList list =
    productListTailRec list 1

let productResult = productList numbers
printfn "The product of the list is: %d" productResult



// Tail Recursion 2
let rec productOfOddsTailRec n acc =
    if n <= 0 then acc
    else productOfOddsTailRec (n - 2) (acc * n)

let productOfOdds n =
    productOfOddsTailRec n 1

let oddProductResult = productOfOdds 11
printfn "The product of odd numbers from 11 to 1 is: %d" oddProductResult



// Using Map Function with a Collection
let names = [" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]
let trimmedNames = names |> List.map (fun name -> name.Trim())
printfn "Trimmed names: %A" trimmedNames


// Using Filter and Reduce with a Collection
let sequence = [1..700]
let filteredNumbers = sequence |> List.filter (fun x -> x % 35 = 0)
let sumOfFilteredNumbers = filteredNumbers |> List.fold (+) 0
printfn "Sum of numbers that are multiples of both 7 and 5: %d" sumOfFilteredNumbers


// Using Filter and Reduce with Collection of Strings
let stringList = ["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]
let filteredStrings = stringList |> List.filter (fun name -> name.Contains("i") || name.Contains("I"))
let concatenatedNames = filteredStrings |> List.fold (fun acc name -> acc + name) ""
printfn "Concatenated names with 'I' or 'i': %s" concatenatedNames