
'use strict'
//--------------- String literals ---------------

let text1 = "I Love C#"
let text2 = 'I Love C#'

let cSharp = 'C#'
let text3 = `I Love ${cSharp}`  //string interpolation

//--------------- Concatinating-----------------
let text = 'I Love'
let c = 'C# and JavaScript'

console.log(text + ' ' + c)
console.log(text.concat(c))

//--------------- IndefOf ----------------

console.log(c.indexOf('a'))      // return first occurance
console.log(c.lastIndexOf('a'))  // return last occurance

//--------------- Substring ----------------
let str = 'I am JavaScript developer'
let substr = str.substring(5, 9)
console.log(substr)

//--------------- Replace ----------------

let hw = "Hello World! Hello World!"
let hwReplaced = hw.replace('World', 'C#') // replace only first occurance
console.log(hwReplaced)

let hwAllReplaced = hw.replaceAll('World', 'C#')  // replace all occurance
console.log(hwAllReplaced)

//--------------- Split ----------------

let strArr = str.split(' ');
console.log(strArr);

//--------------- Includes ----------------
console.log(str.includes('Java'))    // same as .Contains() in C# -> return bolean
console.log(str.includes('C#'))

//--------------- Repeat ----------------
console.log('*'.repeat(5))
console.log('abc'.repeat(3))

//--------------- StartsWith ----------------
console.log(str.startsWith('I am'))  // return true
console.log(str.startsWith('I am Dido'))  // return false

//--------------- EndsWith ----------------
console.log(str.endsWith('per'))  // return true
console.log(str.endsWith('per.'))  // return false

//--------------- PadStart ----------------
let padText = 'word'
console.log(padText.padStart(8, '*'))

//--------------- PadEnd ----------------
console.log(padText.padEnd(8, '*'))

//--------------- Objects ----------------

let person = {
    name: 'Vasko',
    city: 'Sofia',
    age: 25,
    sayHello: function() {
        console.log("Hello from Vasko!")
    },
    eat(){
        console.log('I am eating.')
    }
}

person.address = 'Vitosha #1'
console.log(person)

delete person.age

console.log(person)
console.log(person.address)


let person2 = {};

person2.name = "Dido";
person2['city'] = 'Varna'

console.log(person2.name)
console.log(person2.city)

person.sayHello()
person.eat()

person.driveCar = () => console.log('Driving...')

person.driveCar()

console.log(Object.keys(person))
console.log(Object.values(person))
console.log(Object.entries(person))

for (let i = 0; i < Object.entries(person).length; i++){
    console.log(Object.entries(person)[i])
}

//--------------- Associate arrays ----------------
let assocArr = {
    'one': 1,
    'two': 2,
    'three': 3
}

// add keys with values runtime
assocArr['four'] = 4
assocArr.five = 5

// foreach in JavaScript
for (let key in assocArr){  
    console.log(`${key} => ${assocArr[key]}`)
}

//hasOwnProperty -> retuar bolean (true if key/property exist, otherwise false)

console.log(assocArr.hasOwnProperty('one'))
console.log(assocArr.hasOwnProperty('six'))


//--------------- Sorting arrays ----------------

let numbers = [3, 7, 1, 14, 5]
console.log(numbers)

numbers.sort((a, b) => a - b) // sort in ascending order

console.log(numbers)

numbers.sort((a, b) => b - a) // sort in descending order

console.log(numbers)

//--------------- Destructing ----------------

let nums = [5, 20, 10, 8]
let [num1, num2] = nums

let num3 = nums[2]

console.log(num1) // 5
console.log(num2) // 20
console.log(num3) // 10

//--------------- Functions ----------------

function sumTwoNums(x, y) {
    return x + y
} 
console.log(sumTwoNums(5, 10) + 100)

let sum = sumTwoNums(2, 7)

console.log(sum)

//--------------- Arrow Functions ----------------

let multiply = (x, y) => x * y
console.log(multiply(3, 5))