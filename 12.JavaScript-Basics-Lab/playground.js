// ======================== VS code ========================
// alt + shift + f --> formatting code.
// ctrl + / --> comment/ uncomment

// ======================== variables ========================
// int a = 5;
// string firstName = "Filip"
// char firstLetter = 'a'

// let a = 5;
// let lastName = "Ivanova"; // ''; ""; ``
// lastName = "Petrova";
// lastName = `Yordanova`;

// const firstName = "Maria";
// firstName = 'Victoria'; --> error you cannot update const !!!!!!!

// ======================== if else ========================
// C#
// if(true)
// {
// }

// js
// if (true) {
//   let test2 = 6;
// }

// ======================== functions ========================
// void PrintName(string name)
// {
//     Console.WriteLine(name); --> Write/WriteLine
// }

// PrintName("Ivan");

// function printName(name) {
//   console.log(name); //         --> WriteLine
// }

// ======================== interpolation ========================
// let firstName = 'Filip';
// let age = 30;
// // Console.WriteLine($"My name is {name} and im {age} years old");
// // always use `` not '' or ""
// console.log(`My name is ${firstName} and im ${age} years old`);

// let a = 3.546;
// console.log(a.toFixed(2)); // as C# rounding
// console.log(a.toFixed(20));
// console.log(Math.round(a)); // --> 4
// console.log(Math.ceil(a)); // C# like --> 4
// console.log(Math.floor(a)); // C# like --> 3

// ======================== operators ========================
// let name = false;
// console.log(typeof name);

// name = 2;
// console.log(typeof name);

// console.log(Math.pow(2, 3));
// console.log(2 ** 3);

// let a = 5;
// let b = 10;
// let result = a + b;
// console.log(result.toFixed(10));

// let a = "1";
// let b = 1;

// console.log(typeof a);
// console.log(typeof b);

// console.log(a == b); // value equal.
// console.log(a === b); // type and value equal.

// let dayOfWeek = 12;
// switch (dayOfWeek) {
//     case 1:
//         console.log('monday')
//         break;
//     default:
//         console.log('not a valid day of week')
//         break;
// }

// JS --> Math.max() --> accept as much numbers as we want
// C# --> Math.Max(a, b) --> accept only two numbers;
// ======================== loops ========================
// int[] items = new int[]{1,2,3} --> C#

// let items = [1, 2, 3];
// // itterate over values
// for (let item of items) {
//   console.log(item);
// }
// // iterate over indexes
// for (let item in items) {
//   console.log(item);
// }

// for (let i = 0; i < items.length; i++) {
//   console.log(items[i]);
// }

// 'use strict'
// let a = 5;
// a = 'FIlip';
// a = []
// console.log(a);
// ======================== arrays ========================
// let numbers = [10, 20, 30, 40, 50];
// let a;
// let b;
// let elems;
// [a, b, ...elems] = numbers;

// console.log(a); // 10
// console.log(b); // 20
// console.log(elems); // [30, 40, 50]

// let firstN = [1, 2, 3];
// let secondN = [6, 5, 4];
// let third = [...firstN, ...secondN];
// console.log(third);

// function test(a, b, items) {
//   let data = [...items];
//   console.log(data);
// }

// test(1, 2, [1, 2, 3, 4, 5]);

// let nums = [1, 3, 4, 5, 6];
// nums.splice(1, 0, 2); // inserts at index 1
// console.log(nums); // [ 1, 2, 3, 4, 5, 6 ]
// nums.splice(4, 0, 19, 20, 21); // replaces 1 element at index 4
// console.log(nums); // [ 1, 2, 3, 4, 19, 6 ]
// let el = nums.splice(2, 1); // removes 1 element at index 2
// let el1 = nums.splice(2, 3); // removes 1 element at index 2
// let el2 = nums.splice(2, 10); // removes 10 element at index 2
// // console.log(nums); // [ 1, 2, 4, 19, 6 ]
// console.log(el);
// console.log(el1);
// console.log(el2);

// let nums = [1, 3, 4, 5, 6];
// let nums2 = nums.slice(1, 4);
// console.log(nums2.reverse().join("-"));

// if (nums.contains(2)) {
//   console.log("here");
// }

// let arr = [1, 2, 3];
// arr.includes(5); // true

// ============== map, filter, reduce =============
// let numbers = [1, 2, 3, 4, 5];
// let roots2 = numbers.map((x) => x ** 2);

// let roots = numbers.map((num, i, arr) => Math.sqrt(num));

// console.log(numbers.filter((x) => x % 2 == 0));

// console.log(numbers.reduce((accumulator, current) => accumulator + current));
