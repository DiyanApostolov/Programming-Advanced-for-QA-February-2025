function getCircleArea(radius) {
  // // typeof radius !== "number" --> checks if the type of radius is not a number
  // ? --> starts the conditional (ternary) operator, which executes one of two expressions based on the condition
  // `We can not calculate the circle area, because we received a ${typeof radius}.` -->
  // returns this string if the radius is not a number, using template literals to insert the type of radius into the string.
  // : --> separates the two expressions to be executed based on the condition
  // Math.PI * radius ** 2 --> calculates the area of the circle using the formula πr², if the radius is a number
  // .toFixed(2) --> formats the result to 2 decimal places
  console.log(typeof radius  !== "number" 
    ? `We can not calculate the circle area, because we received a ${typeof radius}.` 
    : (Math.PI * radius ** 2).toFixed(2))
}

getCircleArea(5);
getCircleArea('FIlip');
