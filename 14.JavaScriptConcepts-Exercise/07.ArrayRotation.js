function solve(arr, rotations){
    for(i = 0; i < rotations; i++){
        let element = arr.shift();   // shift -> take the first element in the array
        arr.push(element);           // push -> push the emlement in the last position in the array
    }

    console.log(arr.join(' '));
}

// alternative solution
function solve2(arr, rotations){
    let n = rotations % arr.length  // reduce the rotations

    for(i = 0; i < n; i++){  
        arr.push(arr.shift());      // take the first element and push it to the end    
    }

    console.log(arr.join(' '));
}

solve2([51, 47, 32, 61, 21], 2)
solve2([2, 4, 15, 31], 6)