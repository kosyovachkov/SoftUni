function solve(w, h, W, H) {
    let [areOne, areTwo] = [(w * h), (W * H)]
    return areOne + areTwo - (Math.min(w, W) * Math.min(h, H))
}