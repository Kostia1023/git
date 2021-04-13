function sum(params) {    
    return  params.reduce((res,x,i,arr)=>res+x)
}
function multi(params) {
    return params.reduce((res,x,i,arr)=>res*x)
}
function arif(params) {
    return params.reduce((res,x,i,arr)=>res+x) / params.length
}
function Min(params) {
    return params.reduce((res,x,i,arr)=>x < res?x:res)
}
let a = []
for (let i = 0; i < 4; i++) {
    a.push(parseInt(prompt('Введіть число')));   
}
alert(`Числа: ${a}\nСума = ${sum(a)}\nДобуток = ${multi(a)}\nСереднє арифметичне = ${arif(a)}\nМінімальне = ${Min(a)}`)