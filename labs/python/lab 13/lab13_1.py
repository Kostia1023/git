import math


class TCircle:
    def __init__(self, r):
        self.r = r

    @property
    def r(self):
        return self.__r

    @r.setter
    def r(self, _r):
        if _r > 0:
            self.__r = _r
        else:
            raise Exception('r is not correct')

    @property
    def s(self):
        return math.pi * self.r ** 2

    def input(self, _r):
        self.r = _r

    def print(self):
        return self.r

    def s_sector(self, a):
        return self.s * (360/a)

    def length_circle(self):
        return 2 * math.pi * self.r

    def __gt__(self, other):
        return self.r > other.r

    def __ge__(self, other):
        return self.r >= other.r

    def __eq__(self, other):
        return self.r == other.r

    def __ne__(self, other):
        return self.r != other.r

    def __lt__(self, other):
        return self.r < other.r

    def __le__(self, other):
        return self.r <= other.r

    def __add__(self, other):
        return self.r + other.r

    def __sub__(self, other):
        return self.r - other.r

    def __mul__(self, other):
        return self.r * other


#------------------------------------------------------
class TSphere(TCircle):
    def __init__(self, _r):
        super().__init__(_r)

    def s_sphere(self):
        return 4 * super().s

    def __gt__(self, other):
        return super().r > other.r

    def __ge__(self, other):
        return super().r >= other.r

    def __eq__(self, other):
        return super().r == other.r

    def __ne__(self, other):
        return super().r != other.r

    def __lt__(self, other):
        return super().r < other.r

    def __le__(self, other):
        return super().r <= other.r

    def __add__(self, other):
        return super().r + other.r

    def __sub__(self, other):
        return super().r - other.r

    def __mul__(self, other):
        return super().r * other


f = TCircle(2)
f1 = TCircle(4)
print(f.s_sector(180))
print(f1.s)
print(f < f1)
print('-------------------')
F = TSphere(2)
F1 = TSphere(4)
print(F.s_sphere())
print(F1 - F)
print(F != F1)
