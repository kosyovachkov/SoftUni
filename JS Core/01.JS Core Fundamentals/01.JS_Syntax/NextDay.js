function solve(year, month, day) {
    let newDate = new Date(year, (month - 1), day);
    let oneDayMilliseconds = 24 * 60 * 60 * 1000;
    let nexDayDate = new Date(newDate.getTime() + oneDayMilliseconds);

    console.log(nexDayDate.getFullYear() + '-' + (nexDayDate.getMonth() + 1) + '-' + nexDayDate.getDate());

}

solve(2016, 9, 30);