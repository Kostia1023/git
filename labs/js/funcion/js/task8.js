function banner(href, src, alt, com) {
    document.write(`<div><a href="${href}" target="blank"><img src="${src}" alt="${alt}"></a></div><p>${com}</p>`)
}
let href = prompt('Посилання:')
let src = prompt('Фотографія: ')
let alt = prompt('Коментар фотографії')
let com = prompt('Заголовок')
banner(href,src,alt,com)