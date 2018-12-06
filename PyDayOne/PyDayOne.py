
freq = int(0)
with open("input.txt") as input:
    for line in input:
        freq += int(line.split()[0])
print("final freq: %d" % freq)


