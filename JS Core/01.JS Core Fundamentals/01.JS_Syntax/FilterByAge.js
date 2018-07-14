function solve(num, nameOne, ageOne, nameTwo, ageTwo) {
    let firstPerson = {
        name: nameOne,
        age: ageOne
    };
    let secondPerson = {
        name: nameTwo,
        age: ageTwo
    };

    if (firstPerson.age >= num) console.log(firstPerson);
    if (secondPerson.age >= num) console.log(secondPerson);

}

solve(12, 'Ivan', 15, 'Asen', 9)