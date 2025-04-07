function sum(a, b) {
  return a + b;
}

function divide(a, b) {
  return a / b;
}

function substract(a, b) {
  return a - b;
}

// 1. default
// module.exports = sum;
// module.exports = divide;

// 2. aggregated export 
module.exports = {
  sum,
  divide,
  substract
}

// 3. named export 
exports.divide = divide;
exports.sum = sum;
exports.substract = substract;