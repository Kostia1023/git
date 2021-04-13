let txt = '';
let letter = '';
do{
    txt = `${letter}${txt}`;
     letter = prompt('Введіть букву');
} while(letter != 'a')
alert(txt)