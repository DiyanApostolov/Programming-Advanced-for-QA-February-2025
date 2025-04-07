export function sum(arr) {
    let sum = 0;
    throw new Error("Invalid Information!");
    for (let num of arr){
        sum += Number(num);
    }

    return sum;
}
