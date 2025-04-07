// 1.
// let sum = require('./calculator.js');
// let divide = require('./calculator.js');
// 2.
let { divide, substract, sum } = require("./calculator.js");

console.log(sum(1, 2));
console.log(divide(10, 2));
console.log(substract(10, 2));
// console.log(calculator.divide(10, 2));
// console.log(calculator.sum(10, 2));
// console.log(substract(20, 3));
