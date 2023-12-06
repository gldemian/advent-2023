const ex = [[7,9], [15,40], [30,200]]
const mine = [[41,244], [66,1047], [72,1228], [66,1040]]

function calcDistance(t_total, t_press) {
    return t_press * (t_total - t_press);
}

function calcWins(t_total, d_record) {
    let w_count = 0
    for (let i = 1; i < t_total; i++) {
        if (calcDistance(t_total, i) > d_record) {
            w_count += 1
        }
    }
    return w_count
}

let results = [];
let possibilities = 1;

mine.forEach( race => {
    possibilities = calcWins(race[0], race[1]) * possibilities
})

console.log(possibilities)
