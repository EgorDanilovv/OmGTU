mas = [0, 0, 0, 1]
line = int(open('input_s1_10.txt').readline())
for i in range(4, line + 1):
    mas.append(mas[(i + 1) // 2] + mas[i // 2])
print(mas[line])