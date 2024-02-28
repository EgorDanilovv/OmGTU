import locale

R = [(1,2),(1,4),(1,3),(4,5),(3,6),(5,6),(5,7),(6,7),(8,9),(9,10),(10,8),(11,12)]
serie=[]
black=[]
vrblack=[]
k=R[0]
serie.append(k[0])

for i in R:
    per=i[0]
    if per not in vrblack:
        for j in R:
            if per == j[0] and j[1] not in serie:
                serie.append(j[1])
            elif per == j[1] and j[0] not in serie:
                serie.append(j[0])
        vrblack.append(per)
    if per in vrblack and (per not in serie):
        vrblack.remove(per)
        l=[]
        for h in vrblack:
            l.append(h)
        black.append(l)
        vrblack.clear()
        vrblack.append(per)
l=[]
for h in vrblack:
    l.append(h)
black.append(l)
for k in black:
    y=len(k)-1
    for l in R:
        if l[0]==k[y]:
            if l[1] not in k:
                k.append(l[1])
print(black)
