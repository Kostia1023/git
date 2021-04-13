let N = parseInt(prompt('N = '))
let a;
let s;
do{
    a = parseInt( prompt('1.Ініціалізація (сума=0)\n2.Додати 2\n3.Додати 3\n4.Відняти 2\n5.Відняти 3.\n6.Вивести суму\n7.Вихід. '))
    switch (a) {
        case 1:
            s = 0;      
            break;
        case 2:
            s += 2;      
            break;
        case 3:
            s += 3;      
            break;
        case 4:
            s -= 2;      
            break;
        case 5:
            s -= 3;      
            break;
        case 6:
            alert(s);      
            break;
        default:
            break;
    }
}while(a!=7 && s!= N)
if (s=N) {
    alert(`Вітаю у вас вийшло ${s} = ${N}`)
}