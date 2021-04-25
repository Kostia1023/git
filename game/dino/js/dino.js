class Obj{
    constructor (left, parent, href, speed, classItem) {
        this.parent = parent;
        this.pers = document.createElement('img');
        this.pers.style.left = left;
        this.pers.src = href;
      
        this.speed = speed;
        this.pers.classList.add(classItem);
        this.parent.appendChild(this.pers);
    }

}

class earth extends Obj {
    constructor (left, parent, href, speed, classItem){
        super(left, parent, href, speed, classItem)
    }
    Move () {
        if(this.pers.offsetLeft > -2000){
            this.pers.style.left = `${this.pers.offsetLeft - this.speed}px`
        }
        else{
            this.pers.style.left = '1990px'
        }
    }
}

class Barrier extends Obj{
    constructor (left, parent, href, speed, classItem, height, width, top){
        super(left, parent, href, speed, classItem)
        this.pers.style.height = height;
        this.pers.style.width = width;
        this.pers.style.top = top;
    }
    Move(){
        this.pers.style.left = `${this.pers.offsetLeft - this.speed}px`
    }
}

class Dino{
    constructor (parent) {
        this.pers = document.createElement('img');
        this.parent = parent;
        this.space = false;
        this.timeJump = 0;
        this.pers.src = `img/running.gif`
        this.pers.classList.add('dino');
        this.parent.appendChild(this.pers);
        this.Arrow = false;
    }
    MoveDown() {
        this.Arrow = true;
        this.pers.style.top = '420px'
        this.pers.style.height = '30px'
        this.pers.style.width = '80px'
    }
    Stay() {
        this.Arrow = false;
        this.pers.style.top = '390px'
        this.pers.style.height = '60px'
        this.pers.style.width = '50px'
    }
    CheckDie(enemy){
        if(enemy != null){
        if (this.pers.offsetLeft + this.pers.offsetWidth < enemy.pers.offsetLeft || this.pers.offsetLeft > enemy.pers.offsetLeft + enemy.pers.offsetWidth) return false;
            if (this.pers.offsetTop + this.pers.offsetHeight < enemy.pers.offsetTop || this.pers.offsetTop > enemy.pers.offsetTop + enemy.pers.offsetHeight) return false;
            return true;
        }
        return false;
    }
    MoveUp(){
        if(this.space && this.timeJump > 20){
            this.timeJump--;
            this.pers.style.top = `${this.pers.offsetTop - 10}px`;
        }else if(this.space && this.timeJump > 5){
            this.timeJump--;
            this.pers.style.top = `${this.pers.offsetTop + 10}px`;
        }else if(this.timeJump != 0){
            this.timeJump--;
            this.pers.style.top = '390px' ;
            this.space = false;
        }
    }
    Jump(){
        this.timeJump = 35;
        this.space = true;
    }

    
    Die (enemy){
        if (this.CheckDie(enemy)){
            this.pers.src = 'img/dead.png'
            console.log('you die :)');

            return true
        }
        return false;
    }
}

function getRandomInt(max) {
    return Math.floor(Math.random() * max);
  }


class Game{
    constructor(){
        this.gamePole = document.querySelector('.game');
        this.ListLines = [new earth('0px',this.gamePole,'img/1.png' , 10, 'lines'), 
                        new earth('2000px',this.gamePole,'img/1.png', 10, 'lines')];
        this.ListBar = [new Barrier('-100px',this.gamePole,'img/bird.png' ,10, 'bar', '31px', '50px', '390px'),
                        new Barrier('-100px',this.gamePole,'img/obstacle-2.png', 10, 'bar', '50px', '51px', '400px'),
                        new Barrier('-100px',this.gamePole,'img/bird.png', 10, 'bar', '31px', '50px', '420px'),
                        new Barrier('-100px',this.gamePole,'img/bird.png', 10, 'bar', '31px', '50px', '410px')];
                    
        this.hero = new Dino(this.gamePole);
        this.scoreLabel = document.querySelector('.score');
        this.score = 0;
        this.BarNow;
        this.Dead = false;
        this.interval = setInterval(() => {
            this.ListLines.forEach((x,i,arr) => x.Move());
            this.ListBar[this.BarNow]?.Move();
            this.hero?.MoveUp();
            if (this.hero?.Die(this.ListBar[this.BarNow])){
                
                alert(`You lose \nYou score ${this.score}`)
                clearInterval(this.interval);
                this.Dead = true;
               
            }
            this.score++;
            this.scoreLabel.innerHTML= String(this.score).padStart(7,'0');
        
        }, 15);

        this.timerId = setTimeout(this.tick.bind(this), 4100)
    }
    tick() {
        this.BarNow = getRandomInt(4);   
        console.log(this.BarNow) 
        console.log(this.ListBar)
        this.ListBar[this.BarNow].pers.style.left = '2000px';
        this.timerId = setTimeout(this.tick.bind(this), 4100);
    }

    restart(){
        this.score = 0;
        this.Dead = false;
        this.ListBar.forEach((x,i,arr) => {
            arr[i].pers.style.left = '-100px';
        })
        this.hero.pers.src = 'img/running.gif'
        this.interval = setInterval(() => {
            this.ListLines.forEach((x,i,arr) => x.Move());
            this.ListBar[this.BarNow]?.Move();
            this.hero?.MoveUp();
            if (this.hero?.Die(this.ListBar[this.BarNow])){
                alert(`You lose \nYou score ${this.score}`)
                clearInterval(this.interval);
                this.Dead = true;
               
            }
            this.score++;
            this.scoreLabel.innerHTML= String(this.score).padStart(7,'0');
        
        }, 15);;

    }
}

const GameFunc = new Game();


document.addEventListener('keydown', (e)=>{
    if(e.code === 'Space' && GameFunc.hero.timeJump == 0 && !GameFunc.hero.Arrow){
        
        GameFunc.hero.Jump()
        return;
    }
    if(e.code === 'ArrowDown' && GameFunc.hero.timeJump == 0){
       
        GameFunc.hero.MoveDown()
        return;
    }
    if(GameFunc.Dead){
        GameFunc.restart();
        return;
    }
})
document.addEventListener('keyup', (e)=>{
    if(e.code === 'ArrowDown'){
        GameFunc.hero.Stay()
    }
})


