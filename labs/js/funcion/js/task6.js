function tabl(a,b) {
    let k = 0;
    document.write('<table border="2px solid black">')
    for (let i = 0; i < a; i++) {
        document.write('<tr>')
        for (let j = 0; j < b; j++) {
            document.write(`<td>${k++}</td>`)
        }
        document.write('</tr>')
    }
    document.write('</table>')
}

const a = parseInt( prompt('Кількість рядків'))
const b = parseInt( prompt('Кількість стовпців'))
tabl(a,b)