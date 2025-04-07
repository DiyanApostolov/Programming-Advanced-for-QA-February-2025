export function sum(a, b) {
  return a + b;
}

// named export
export function divide(a, b) {
  return a / b;
}

export function substract(a, b) {
  return a - b;
}
// console.log(sum(1,2));
// we can have only one default export
// export default sum;
export default substract;
