function solve(arr){
    let age = arr[0];
    let result = '';

    if (age < 0){
        result = 'out of bounds';
    } else if (age >= 0 && age <= 2){
        result = 'baby';
    } else if (age >= 3 && age <= 13){
        result = 'child';
    } else if (age >= 14 && age <= 19){
        result = 'teenager';
    } else if (age >= 20 && age <= 65){
        result = 'adult';
    } else if (age > 65) {
        result = 'elder';
    }

    console.log([result])
}

solve(20)
solve(1)
solve(5)
solve(15)
solve(35)
solve(70)