def recursion(i):
    if i == 0:
        return 0
    elif i == 1:
        return 7
    else:
        return recursion(i-1) * (1 + recursion(i-2))
    pass


n = int(input('n = '))
print('х{0} = {1}'.format(n, recursion(n)))
