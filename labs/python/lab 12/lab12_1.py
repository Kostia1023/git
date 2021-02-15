class TMatrix:
    def __init__(self, _n, *args):
        self.n = _n
        self.matrix = list(map(list, args))

    @property
    def n(self):
        return self.__n

    @n.setter
    def n(self, _n):
        if _n > 0:
            self.__n = _n
        else:
            raise Exception('Значення некоректне')

    @property
    def matrix(self):
        return self.__matrix

    @matrix.setter
    def matrix(self, args):
        if len(args) == self.n and self.check_strings(args):
            self.__matrix = list(map(list, args))
        else:
            raise Exception('Некоректно задана матриця')

    @property
    def el(self):
        d = []
        for i in range(self.n):
            d.extend(self.matrix[i])
        return d

    def check_strings(self, args):
        for el in args:
            if len(el) != self.n:
                return False
        return True

    def input_matrix(self, *args):
        self.matrix = list(map(list, args))

    def input_n(self, n):
        self.n = n

    def print_matrix(self):
        return self.matrix

    def print_n(self):
        return self.n

    def print_all(self):
        return '{0}\n{1}'.format(self.n, self.matrix)

    def max_in_matrix(self):
        return max(self.el)

    def min_in_matrix(self):
        return min(self.el)

    def sum_el(self):
        return sum(self.el)


f = TMatrix(2, (10, 2), (3, 4))
print(f.print_all())
print(f.max_in_matrix())
print(f.min_in_matrix())
print(f.sum_el())
