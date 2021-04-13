let prod = 1
let a = 1;
do {
    prod *= a
    a = parseInt(prompt("Введіть число:"))
} while(a != 0)
alert(`Сума чисел = ${prod}`)