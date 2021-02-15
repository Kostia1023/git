schedule = {
    'Monday': {
        '1': 'para 1',
        '2': 'para 2',
        '3': 'para 3',
        '4': 'para 4',
        'section': 'section 1'
    },
    'Tuesday': {
        '1': 'para 2',
        '2': 'para 4',
        '3': 'para 3',
        '4': 'para 1',
        'section': 'section 2'
    },
    'Wednesday': {
        '1': 'para 4',
        '2': 'para 2',
        '3': 'para 3',
        '4': 'para 1',
        'section': 'section 3'
    },
    'Thursday': {
        '1': 'para 4',
        '2': 'para 3',
        '3': 'para 2',
        '4': 'para 1',
        'section': 'section 4'
    },
    'Friday': {
        '1': 'para 4',
        '2': 'para 1',
        '3': 'para 3',
        '4': 'para 2',
        'section': 'section 5'
    }
}

while True:
    n = input('Яка потрібна дія ?\n1 - дізнатись значення за ключем\n2 - ввести всі значення'
              '\n3 - змінити значення за ключем\n4 - вивести весь список\nend - закінчити роботу\n')
    if n == "1":
        key1 = input('день - ')
        key2 = input('пара - ')
        print(schedule[key1][key2])
    elif n == "2":
        for i in schedule:
            for j in schedule[i]:
                schedule[i][j] = input('{0} {1} = '.format(i, j))
    elif n == "3":
        key1 = input('день - ')
        key2 = input('пара - ')
        z = input('нове значення - ')
        schedule[key1][key2] = z
    elif n == '4':
        print(schedule)
    elif n == 'end':
        break
    else:
        raise Exception('Некоректне значення дії')

















