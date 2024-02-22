R = [(15, 1, 2), (14, 1, 5), (23, 1, 4), (19, 2, 3), (16, 2, 4),
     (15, 2, 5), (14, 3, 5), (26, 3, 6), (25, 4, 5), (23,4,7),(20,4,8),(24,5,6),(27,5,8),(18,5,9),(14,7,8),(18,8,9)]
U = []   # список соединенных вершин
otwet=0
tochki=[]
for l in R:
    if l[1] not in tochki:
        tochki.append(int(l[1]))
    if l[2] not in tochki:
        tochki.append(int(l[2]))
tochki=sorted(tochki)

new_tochki = [tochki[0]]
pos_ways = []
while len(new_tochki) != len(tochki):
    for x in range(len(R)):
        for u in new_tochki:
            if ((u == R[x][1] and not (R[x][2] in new_tochki)) or (
                    u == R[x][2] and not (R[x][1] in new_tochki))) and not (R[x] in pos_ways):
                pos_ways.append(R[x])
    pos_ways = sorted(pos_ways, key=lambda x: x[0])
    del_ways = []
    for i in pos_ways:
        if i[2] in new_tochki and i[1] in new_tochki:
            del_ways.append(i)
    for i in del_ways:
        pos_ways.remove(i)
    minim = pos_ways[0]
    if not minim[0] in new_tochki:
        new_tochki.append(minim[0])
    else:
        new_tochki.append(minim[1])
    otwet += minim[2]
    pos_ways.remove(minim)
    R.remove(minim)
print(otwet)