function solve(m, n) {
  // for --> looping through the numbers from m (starting point) to n (ending point)
  // let i = m --> initializes the loop counter i to the value of m
  // i >= n --> the loop will continue to execute as long as i is greater than or equal to n
  // i-- --> decrements i by 1 after each iteration
  for (let i = m; i >= n; i--) {
    // console.log(i) --> prints the current value of i to the console
    console.log(i);
  }
}

solve(5, 4);
