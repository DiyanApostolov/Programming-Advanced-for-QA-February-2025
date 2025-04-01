function reverse(n, inputData) {
    // slice(0, n) --> returns new array containing elements from index from 0 to n (not inclusive)
    // reverse() --> reverses the new array from slice()
    // join(' ') --> concatenates elements by adding ' ' and returns string
    console.log(inputData.slice(0, n).reverse().join(' '));
}

reverse(3, [10, 20, 30, 40, 50]);