function sortNums(arr) {
  arr.sort((a, b) => b - a);
}

function sortNumsTest() {
  // Arrange
  let input = [2, 15, -2, 4];
  let expected = [-2, 2, 4, 15];

  // Act
  sortNums(input);

  // Assert
  if (JSON.stringify(input) !== JSON.stringify(expected)) {
    console.error(`Expected : ${expected} but was ${input}`);
    return;
  }

  console.log("Test passed");
}
sortNumsTest();
