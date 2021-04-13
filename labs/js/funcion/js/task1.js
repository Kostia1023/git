function month(params) {
    switch (params) {
        case 1:
            alert('Це січень')
            break;
        case 2:
            alert('Це лютий')
            break;
        case 3:
            alert('Це березень')
            break;
        case 4:
            alert('Це квітень')
            break;
        case 5:
            alert('Це травень')
            break;
        case 6:
            alert('Це червень')
            break;
        case 7:
            alert('Це липень')
            break;
        case 8:
            alert('Це серпень')
            break;
        case 9:
            alert('Це вересень')
            break;
        case 10:
            alert('Це жовтень')
            break;
        case 11:
            alert('Це листопад')
            break;
        case 12:
            alert('Це грудень')
            break;
        default:
            break;
    }
}
month(parseInt(prompt('Номер місяця: ')))