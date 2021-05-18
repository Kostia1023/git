class FormDelivery{
    constructor (loginArr, passwordArr) {
         this.main = document.getElementById('main');
         this.LoginArr = loginArr;
         this.PasswordArr = passwordArr;
    }
    render(){
        this.InputLogin = document.createElement('input');
        this.InputLogin.placeholder = 'Login';
        this.InputPassword = document.createElement('input');
        this.InputPassword.placeholder = 'Password';
        this.Button = document.createElement('button');
        this.Button.innerText = 'Ввійти';
        this.main.appendChild(this.InputLogin);
        this.main.appendChild(this.InputPassword);
        this.main.appendChild(this.Button);
        this.InputLogin.addEventListener('input', this.ChangeLogin.bind(this));
    }
    ChangeLogin(){
        const index = this.LoginArr.indexOf(this.InputLogin.value);
        if(~index){
            this.InputPassword.value = this.PasswordArr[index];
        }
    }
}
const login = ['1122', 'LoL', 'Hello'];
const password = ['123', 'qweasd', 'zxc?'];

let a = new FormDelivery(login, password);
a.render();