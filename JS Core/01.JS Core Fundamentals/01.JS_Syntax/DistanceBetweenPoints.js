function solve(x1, y1, x2, y2) {
    return Math.sqrt((Math.abs(x1 - x2) ** 2) + (Math.abs(y1 - y2) ** 2))
}

console.log(solve(2.34, 15.66, -13.55, -2.9985));