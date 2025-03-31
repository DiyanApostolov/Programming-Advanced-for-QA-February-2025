function solve(arr){
    let phoneBook = {};

    for (const element of arr) {
        let [name, phoneNumber] = element.split(' ');
        phoneBook[name] = phoneNumber;
    }

    for (const key in phoneBook) {
        console.log(`${key} -> ${phoneBook[key]}`)
    }
}

solve(
    ['Tim 0834212554',
    'Peter 0877547887',
    'Bill 0896543112',
    'Tim 0876566344']
   )