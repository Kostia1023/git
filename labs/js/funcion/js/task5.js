function san_to_d(params) {
    return params / 2.54
}
function k_to_f(params) {
    return params * 2.205
}
function k_to_m(params) {
    return params / 1.609
}
alert(`Дюйми = ${san_to_d(parseInt(prompt('Сантиметри')))}`)
alert(`Фунти = ${k_to_f(parseInt(prompt('Кілограми')))}`)
alert(`Мілі = ${k_to_m(parseInt(prompt('Кілометри')))}`)