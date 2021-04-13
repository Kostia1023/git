const a = ['Вася','Ваня','Петя','Саша','Ваня'];
alert(a.reduce((res,x,i,arr)=>(x==='Ваня'?++res : res), 0))