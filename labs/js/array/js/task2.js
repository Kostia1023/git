function more(params) {
    let a = []
    params.forEach((x,i,arr) => {
        if(x>20) a.push(i+1)
    });
    return a
}
function min_day(params) {
    let m = Math.min(...params)
    let a = []
    params.forEach((x,i,arr) => {
        if(x==m) a.push(i+1)
    });
    return a
}
function max_day(params) {
    let m = Math.max(...params)
    let a = []
    params.forEach((x,i,arr) => {
        if(x==m) a.push(i+1)
    });
    return a
}
function people(params) {
    let s = 0
    for (let i = 0; i < 5; i++) {
        s += params[i]
    }
    return s;
}
function people_weekend(params) {
    let s = 0
    for (let i = 5; i < 7; i++) {
        s += params[i]
    }
    return s;
}
let b = (prompt('Введіть кількість людей за тиждень через кому').split(',')).map(x=>parseInt(x))
alert(b)
alert(more(b))
alert(min_day(b))
alert(max_day(b))
alert(people(b))
alert(people_weekend(b))
