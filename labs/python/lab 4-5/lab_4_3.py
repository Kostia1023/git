x1 = float(input('x1='))
x2 = float(input('x2='))
x3 = float(input('x3='))
x4 = float(input('x4='))
y1 = float(input('y1='))
y2 = float(input('y2='))
y3 = float(input('y3='))
y4 = float(input('y4='))
first_pair_of_sides = (x2-x1)/(x4-x3) == (y2-y1)/(y4-y3)
second_pair_of_sides = (x3-x2)/(x1-x4) == (y3-y2)/(y1-y4)
if first_pair_of_sides and second_pair_of_sides:
    print('Так, вони можуть бути вершинами паралеограма')
else:
    print('Ні, вони не можуть бути вершинами паралеограма')
