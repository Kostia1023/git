def a1_and_a2(a, b):
    return a / b


def a_coef_equal_b_coef(*args):
    for i in range(0, len(args)-3, 2):
        if a1_and_a2(args[i], args[i+1]) != a1_and_a2(args[i+2], args[i+3]):
            return False
    return True


class Plane:
    def __init__(self, _a, _b, _c, _d=0):
        self.a = _a
        self.b = _b
        self.c = _c
        self.d = _d

    def return_of_coefficients(self):
        return self.a, self.b, self.c, self.d

    def point_in_plane(self, _x, _y, _z):
        return self.a * _x + self.b * _y + self.c * _z + self.d == 0

    def parallel_planes(self, a1, b1, c1, d1):
        return a_coef_equal_b_coef(self.a, a1, self.b, b1, self.c, c1, self.d, d1)

    def intersection_of_line_and_plane(self, _x, _y, _z, l, m, p):
        ch = self.a * _x + self.b * _y + self.c * _z + self.d
        zn = self.a * l + self.b * m + self.c * p
        t = - (ch / zn)
        x1 = l * t + _x
        y1 = m * t + _y
        z1 = p * t + _z
        m = [x1, y1, z1]
        return m

    def point_projection(self, _x, _y, _z):
        ch = self.a * _x + self.b * _y + self.c * _z + self.d
        zn = self.a ** 2 + self.b ** 2 + self.c ** 2
        t = - (ch / zn)
        x1 = self.a * t + _x
        y1 = self.b * t + _y
        z1 = self.c * t + _z
        m = [x1, y1, z1]
        return m













