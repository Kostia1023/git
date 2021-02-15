class TGoods:
    def __init__(self, name, units_of_measurement, quantity, the_price_of_one_unit):
        self.name = name
        self.units_of_measurement = units_of_measurement
        self.quantity = quantity
        self.the_price_of_one_unit = the_price_of_one_unit

    @property
    def quantity(self):
        return self.__quantity

    @quantity.setter
    def quantity(self, a):
        if a >= 0:
            self.__quantity = a
        else:
            raise Exception('Некоректне значення')

    @property
    def the_price_of_one_unit(self):
        return self.__the_price_of_one_unit

    @the_price_of_one_unit.setter
    def the_price_of_one_unit(self, a):
        if a > 0:
            self.__the_price_of_one_unit = a
        else:
            raise Exception('Некоректне значення')

    @property
    def ToString(self):
        return (self.name,
                self.units_of_measurement,
                self.quantity,
                self.the_price_of_one_unit)

    def price(self):
        return self.the_price_of_one_unit * self.quantity

    def change_the_number(self, a):
        self.quantity += a

    def print(self):
        return self.quantity


f = TGoods("books", "object", 5, 20)
print(f.price())
print(f.print())
f.change_the_number(15)
print(f.price())
print(f.print())
print(f.ToString)
