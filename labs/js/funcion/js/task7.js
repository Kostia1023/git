function getRandomInt(max) {
    return Math.floor(Math.random() * Math.floor(max));
  }

function random_img(...arg) {
    document.write(`<img src="${arg[getRandomInt(arg.length)]}" alt="Випадкове з списку зображення">`)
}

img1 = '../img/purple.jpg' //prompt('Зображення номер 1')
img2 = '../img/darkGreen.jpg' //prompt('Зображення номер 2')
img3 = '../img/aqua.jpg' //prompt('Зображення номер 3')
img4 = '../img/yellow.png' //prompt('Зображення номер 4')
random_img(img1,img2,img3,img4)