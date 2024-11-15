"use strict";

function factorial(n) {
    function factorialHelper(acc, n) {
        if (n <= 1) {
            return acc;
        } else {
            return factorialHelper(acc * n, n - 1);
        }
    }
    return factorialHelper(1, n);
}

console.log(factorial(5));  // Output: 120