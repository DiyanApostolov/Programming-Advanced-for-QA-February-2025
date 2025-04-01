function sumFirstAndLast(numbers) {
    // shift() --> removes the first element from an array and returns that removed element,
    // modifying the original collection 
    // pop() --> removes the last element from an array and returns that element
    // parseFloat() --> parsing elements from shift and pop
    console.log(parseFloat(numbers.shift()) + parseFloat(numbers.pop()));
}

sumFirstAndLast([20, 30, 40]);