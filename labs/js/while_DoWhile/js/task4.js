let N = parseInt(prompt('N = '))
let even = 0
let sum = 0; 
do{
    let a = parseInt(prompt('Введіть число'))
    if(a%2 == 0)
    {
        sum += a
        even++
    }
}while(even < N)
alert(`sum = ${sum}`)