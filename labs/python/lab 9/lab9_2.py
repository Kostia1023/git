import datetime
car = {
    "number": 1,
    "owner": 2,
    "year": 3,
    'brand': 4,
    'creation date': datetime.date.today(),
    'last change': datetime.datetime.today()
}

while True:
    n = input('Яка потрібна дія ?\n1 - дізнатись значення за ключем\n2 - ввести всі значення'
              '\n3 - змінити значення за ключем\n4 - вивести весь список\nend - закінчити роботу\n')
    if n == "1":
        key1 = input('ключ -  ')
        print(car[key1])
    elif n == "2":
        for i in car:
            car[i] = input('{0} = '.format(i))
        car['creation date'] = datetime.date.today()
        car['last change'] = datetime.datetime.today()
    elif n == "3":
        key1 = input('ключ - ')
        z = input('нове значення - ')
        car[key1] = z
        car['last change'] = datetime.datetime.today()
    elif n == '4':
        print(car)
    elif n == 'end':
        break
    else:
        raise Exception('Некоректне значення дії')

















