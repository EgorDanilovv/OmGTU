a,b,c = [int(i) for i in input().split(" ")]
Sx, Sy, Sz = [int(i) for i in input().split(" ")]
Fx, Fy, Fz = [int(i) for i in input().split(" ")]

def Vector(a, b):
    vector = []
    for i in range(0, 3):
        vector.append(b[i]-a[i])
    return vector

def Vector_length(vector):
    length = 0
    for i in vector:
        length += i**2
    return length**(1/2)
if (Fx == 0):
    if (Sx == 0):
        interval = Vector_length(Vector([Fx, Fy, Fz], [Sx, Sy, Sz]))
    if Sz == c:
        interval = Vector_length(Vector([Fy, Fz, 0], [Sy, c + Sx, 0]))
    if Sz == 0:
        interval = Vector_length(Vector([Fy, Fz, 0], [Sy, -Sx, 0]))
    if Sy == 0:
        interval = Vector_length(Vector([-Fy, Fz, 0], [Sx, Sz, 0]))
    if Sy == b:
        interval = Vector_length(Vector([Fy, Fz, 0], [b + Sx, Sz, 0]))
    if Sx == a:
        interval = min(Vector_length(Vector([-Fy, Fz, 0], [a + Sx, Sz, 0])),
                       Vector_length(Vector([Fy, Fz, 0], [Sy, c - Sz + c + a, 0])),
                       Vector_length(Vector([Fy, Fz, 0], [Sy, -(a + Sz), 0])),
                       Vector_length(Vector([Fy, Fz, 0], [b + a + b - Sy, Sz, 0])))
if Fy == 0:
    if (Sy == 0):
        interval = Vector_length(Vector([Fx, Fy, Fz], [Sx, Sy, Sz]))
    if (Sx == 0):
        interval = Vector_length(Vector([Fx, Fz, 0], [-Sy, Sz, 0]))
    if (Sz == 0):
        interval = Vector_length(Vector([Fx, Fz, 0], [Sx, -Sy, 0]))
    if (Sz == c):
        interval = Vector_length(Vector([Fx, Fz, 0], [Sx, c + Sy, 0]))
    if (Sx == a):
        interval = Vector_length(Vector([Fx, Fz, 0], [a + Sy, Sz, 0]))
    if Sy == b:
        interval = min(Vector_length(Vector([Fx, Fz, 0], [Sx, c + b + c - Sz, 0])),
                       Vector_length(Vector([Fx, Fz, 0], [a + b + a - Sx, Sz, 0])),
                       Vector_length(Vector([Fx, Fz, 0], [-(b + Sx), Sz, 0])),
                       Vector_length(Vector([Fx, Fz, 0], [Sx, -(b + Sz), 0])))
if Fz == 0:
    if (Sz == 0):
        interval = Vector_length(Vector([Fx, Fy, Fz], [Sx, Sy, Sz]))
    if (Sx == 0):
        interval = Vector_length(Vector([Fy, -Fx, 0], [Sy, Sz, 0]))
    if (Sy == 0):
        interval = Vector_length(Vector([Fx, -Fy, 0], [Sx, Sz, 0]))
    if (Sx == a):
        interval = Vector_length(Vector([Fy, Fx, 0], [Sy, a + Sz, 0]))
    if (Sy == b):
        interval = Vector_length(Vector([Fx, Fy, 0], [Sx, b + Sz, 0]))
    if Sz == c:
        interval = min(Vector_length(Vector([Fx, -Fy, 0], [Sx, c + Sy, 0])),
                       Vector_length(Vector([Fy, -Fx, 0], [Sy, c + Sx, 0])),
                       Vector_length(Vector([Fx, Fy, 0], [Sx, b + c + b - Sy, 0])),
                       Vector_length(Vector([Fy, Fx, 0], [Sy, a + c + a - Sx, 0])))
if Fz == c:
    if (Sz == c):
        interval = Vector_length(Vector([Fx, Fy, Fz], [Sx, Sy, Sz]))
    if (Sx == 0):
        interval = Vector_length(Vector([Fy, c + Fx, 0], [Sy, Sz, 0]))
    if (Sy == 0):
        interval = Vector_length(Vector([Fx, c + Fy, 0], [Sx, Sz, 0]))
    if (Sy == b):
        interval = Vector_length(Vector([Fx, c + Fy, 0], [Sx, c + b + c - Sz, 0]))
    if (Sx == a):
        interval = Vector_length(Vector([Fy, c + Fx, 0], [Sy, c + a + c - Sz, 0]))
    if (Sz == 0):
        interval = min(Vector_length(Vector([Fy, c + Fx, 0], [Sy, -Sx, 0])),
                       Vector_length(Vector([Fx, c + Fy, 0], [Sx, -Sy, 0])),
                       Vector_length(Vector([Fy, c + Fx, 0], [Sy, c + a + c + a - Sx, 0])),
                       Vector_length(Vector([Fx, c + Fy, 0], [Sx, c + b + c + b - Sy, 0])))
if Fy == b:
    if (Sy == b):
        interval = Vector_length(Vector([Fx, Fy, Fz], [Sx, Sy, Sz]))
    if (Sx == 0):
        interval = Vector_length(Vector([b + Fx, Fz, 0], [Sy, Sz, 0]))
    if (Sz == 0):
        interval = Vector_length(Vector([b + Fx, Fz, 0], [Sy, -Sx, 0]))
    if (Sz == c):
        interval = Vector_length(Vector([b + Fx, Fz, 0], [Sy, c + Sx, 0]))
    if (Sx == a):
        interval = Vector_length(Vector([b + Fx, Fz, 0], [b + a + b - Sy, Sz, 0]))
    if (Sy == 0):
        interval = min(Vector_length(Vector([Fx, c + b + c - Fz, 0], [Sx, Sz, 0])),
                       Vector_length(Vector([a + b + a - Fx, Fz, 0], [Sx, Sz, 0])),
                       Vector_length(Vector([Fx, -(b + Fz), 0], [Sx, Sz, 0])),
                       Vector_length(Vector([-(b + Fx), Fz, 0], [Sx, Sz, 0])))
if Fx == a:
    if (Sx == a):
        interval = Vector_length(Vector([Fx, Fy, Fz], [Sx, Sy, Sz]))
    if (Sy == 0):
        interval = Vector_length(Vector([a + Fy, Fz, 0], [Sx, Sz, 0]))
        print(round(interval, 3))
        exit()
    if (Sz == 0):
        interval = Vector_length(Vector([Fy, a + Fz, 0], [Sy, Sx, 0]))
    if (Sz == c):
        interval = Vector_length(Vector([Fy, c + a + c - Fz, 0], [Sy, c + Sx, 0]))
    if (Sy == b):
        interval = Vector_length(Vector([b + a + b - Fy, Fz, 0], [b + Sx, Sz, 0]))
    if (Sx == 0):
        interval = min(Vector_length(Vector([Fy, c + a + c - Fz, 0], [Sy, Sz, 0])),
                       Vector_length(Vector([a + Fy, Fz, 0], [-Sy, Sz, 0])),
                       Vector_length(Vector([Fy, -(a + Fz), 0], [Sy, Sz, 0])),
                       Vector_length(Vector([b + a + b - Fy, Fz, 0], [Sy, Sz, 0])))
print(round(interval, 3))
