class TMatrix:
    def __init__(self, n, *args):
        self.n = n
        self.matrix = list(map(list, args))

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

    @property
    def el(self):
        d = []
        for i in range(self.n):
            d.extend(self.matrix[i])
        return d

    def max_in_matrix(self):
        return max(self.el)

    def min_in_matrix(self):
        return min(self.el)

    def sum_el(self):
        return sum(self.el)


f = TMatrix(2, (1, 2), (3, 4))
print(f.print_all())
print(f.max_in_matrix())
print(f.min_in_matrix())
print(f.sum_el())
