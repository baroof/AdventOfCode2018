
file = "input.txt"

freq = int(0)
with open(file) as input:
    for line in input:
        freq += int(line.split()[0])
print("final freq: %d" % freq)

freq = int(0)
freqs = [freq]
loops = int(0)
while(True):
    with open(file) as input:
        for line in input:
            freq += int(line.split()[0])
            if (freq in freqs):
                print("repeated freq: %d" % freq)
                exit(0)
            else:
                freqs.append(freq)
        print("completed loop # %d" % loops)
        loops += 1