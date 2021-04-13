function arif(params) {
    return params.reduce((res,x,i,arr)=>res+x) / params.length
}
function rating(params) {
    if(params.some(el=>el==2)) return "двійочник"
    if(params.some(el=>el==3)) return "трійочник"
    if(params.some(el=>el==4)) return "хорошист"
    return "відмінник"
}
let a = (prompt('Введіть оцінки').split(',')).map(x=>parseInt(x))
alert(`Середній бал = ${arif(a)}`)
alert(rating(a))