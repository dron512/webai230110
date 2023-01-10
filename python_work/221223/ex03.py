delta_x = 1e-4

def mibun(x):
    return ((x+delta_x)**2-x**2)/delta_x

value = mibun(2)
print(value)
