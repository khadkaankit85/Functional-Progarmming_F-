# Functional Programming Tasks

## 1. Partial Application

- Write a function that takes two parameters: `exponent` and `value`. This function should apply the exponent to the value and return the result. For example, if `3` and `4` are the chosen parameters, the result should be `64` (4 raised to the power of 3).
- Use partial application by applying `2` and `3` as parameters and store them as `square` and `cube`.
- Invoke the `square` and `cube` by passing a few values and print the results.

## 2. Tail Recursion 1

- Write a program using tail recursion to calculate the product of all elements in a list.

## 3. Tail Recursion 2

- Write a program using tail recursion to calculate the product of all odd numbers from a given number down to 1. Assume that only an odd number will be passed to this function. No validation is needed.
- Example: If the parameter is `11`, then the result of the function should be `11 * 9 * 7 * 5 * 3 * 1 = 10395`.

## 4. Using Map Function with a Collection

- Use the following list of strings:
  `[" Charles"; "Babbage  "; "  Von Neumann  "; "  Dennis Ritchie  "]`
- Using the `map` function, trim all the empty spaces before and after each element. You can use the `String.Trim()` function to achieve this.

## 5. Using Filter and Reduce with a Collection

- Create a sequence of the first 700 positive integers.
- Convert the sequence into a list using the `Seq.ToList` function.
- Filter out those elements that are multiples of both 7 and 5.
- Finally, sum all the filtered numbers using a `reduce` or `fold` function.

## 6. Using Filter and Reduce with a Collection of Strings

- Use the following list of strings:
  `["James"; "Robert"; "John"; "William"; "Michael"; "David"; "Richard"]`
- Filter all the elements that have the letter "I."
- Use the `reduce`/`fold` function to concatenate all the resulting names.
