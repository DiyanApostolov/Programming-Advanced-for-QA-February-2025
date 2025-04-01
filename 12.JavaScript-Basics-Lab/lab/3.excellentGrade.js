function solve(number) {
  // Using the ternary operator to determine the output based on the value of `number`
  // number >= 5.5 --> checks if the number is greater than or equal to 5.5
  // "Excellent" --> the string to return if the condition is true
  // "Not excellent" --> the string to return if the condition is false
  console.log(number >= 5.5 ? "Excellent" : "Not excellent");
}

solve(6); 
