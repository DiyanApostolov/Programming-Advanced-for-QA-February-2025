function solve(data){
    let towns = [];

    for (const element of data) {
        let [town, latitude, longitude] = element.split(' | ')
        latitude = Number(latitude).toFixed(2);
        longitude = Number(longitude).toFixed(2);

        let currentTown = {
            town,
            latitude,
            longitude
        }

        towns.push(currentTown);
    }

    for (const element of towns) {
        console.log(element)
    }
}

solve(['Sofia | 42.696552 | 23.32601',
    'Beijing | 39.913818 | 116.363625'])