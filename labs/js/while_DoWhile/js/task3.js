let sum = parseInt(prompt('Початкова сума:'))
let a = 0
do{
    sum += a
    a = parseInt(prompt('Введіть число:'))
}while(sum + a < 100)
alert(`Сума = ${sum}`)