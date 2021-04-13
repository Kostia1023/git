let a ;
do{
    a = parseInt( prompt('1. Сказати «Привіт».\n2. Сказати «Зачекай».\n3. Сказати «До побачення».\n4. Вихід.'))       
    switch (a) {
        case 1:
            alert('Привіт')
            break;
        case 2:
            alert('Зачекай')
            break;
        case 3:
            alert('До побачення')
            break;
        default:
            break;
        }
}while(a != 4)