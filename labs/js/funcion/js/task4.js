function bin(params) {
    let k = 0;
    params.forEach((x,i,arr) => {
    if(x%2 == 0) k++;         
    });
    return k
}
let a = []
for (let i = 0; i < 3; i++) {
    a.push(parseInt(prompt('Введіть число')));   
}
alert(bin(a))