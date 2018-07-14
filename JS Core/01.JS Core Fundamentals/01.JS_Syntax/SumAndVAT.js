function solve(array) {
    let sum = 0;

    array.forEach(element => {
        sum += element
    });

    console.log(`sum = ${sum}`);
    console.log(`VAT = ${sum*0.2}`);
    console.log(`total = ${sum*1.2}`);
}

solve([1.20, 2.60, 3.50])