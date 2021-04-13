function getRandomInt(min, max) {
    min = Math.ceil(min);
    max = Math.floor(max);
    return Math.floor(Math.random() * (max - min)) + min; 
  }
let a = []
let b = []
for (let i = 0; i < 10; i++) {
    a.push(getRandomInt(-500,501));
    b.push(i+1);
}
let sum = 0;
let number;
do{
    number = parseInt(prompt(`Виберіть номер елемента.\nЕлементи: ${b}\nАбо 0 для завершення`));
    if(number != 0 && b.includes(number)){
        sum += a[number-1]
        b.splice(b.indexOf(number),1)
    }
}while(number !== 0);
alert(`Сумарний виграш ${sum}`)