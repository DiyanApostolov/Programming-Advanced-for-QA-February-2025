function solve(a, b, operator) {
  // switch (operator) --> Evaluates based on the operator and performs the corresponding arithmetic operation
  switch (operator) {
    // case "+" --> If operator is '+', performs addition of a and b, then prints the result
    case "+":
      console.log(a + b);
      break;

    // case "-" --> If operator is '-', performs subtraction of b from a, then prints the result
    case "-":
      console.log(a - b);
      break;

    // case "*" --> If operator is '*', performs multiplication of a and b, then prints the result
    case "*":
      console.log(a * b);
      break;

    // case "/" --> If operator is '/', performs division of a by b, then prints the result
    case "/":
      console.log(a / b);
      break;

    // case "%" --> If operator is '%', performs modulus operation (remainder of a divided by b), then prints the result
    case "%":
      console.log(a % b);
      break;

    // case "**" --> If operator is '**', performs exponentiation (a raised to the power of b), then prints the result
    case "**":
      console.log(a ** b);
      break;
  }
}

// Testing the function with examples
solve(5, 2, "+"); // Expected output: 7
solve(5, 2, "-"); // Expected output: 3
solve(5, 2, "*"); // Expected output: 10
solve(5, 2, "/"); // Expected output: 2.5
solve(5, 2, "%"); // Expected output: 1
solve(5, 2, "**"); // Expected output: 25
