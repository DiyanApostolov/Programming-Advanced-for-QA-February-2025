// other logic
import { divide, sum } from "./calculator.mjs";
import * as calculator from "./calculator.mjs";
import substract from "./calculator.mjs";

function printLine() {
  console.log("here");
}

console.log(sum(1, 2));
console.log(divide(10, 2));
console.log(calculator.divide(10, 2));
console.log(calculator.sum(10, 2));
console.log(substract(20, 3));

printLine();
