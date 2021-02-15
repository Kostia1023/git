class Quadratic_equation:
    def __init__(self, a, b, c):
        self.a = a
        self.b = b
        self.c = c

    @property
    def x1(self):
        return (-self.b + self.discriminant**0.5)/(2*self.a)

    @property
    def x2(self):
        return (-self.b - self.discriminant**0.5)/(2*self.a)

    @property
    def discriminant(self):
        return (self.b ** 2) - 4 * self.a * self.c

    def check(self):
        if self.discriminant >= 0:
            return True
        else:
            return False

    def input(self, a, b, c):
        self.a = a
        self.b = b
        self.c = c

    def print_k(self):
        return self.a, self.b, self.c

    def print_roots(self):
        return self.x1, self.x2


f = Quadratic_equation(1, 4, 4)
print(f.print_k())
print(f.print_roots())
f.input(1, 1, -6)
print(f.print_k())
print(f.print_roots())
