function solve(string, letter) {
    let count = 0;

    for (const char of string) {
        if (char === letter) {
            count++;
        }
    }

    return count;
}

console.log(solve('hello', 'l'));