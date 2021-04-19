import random, time

print("When i say GO you press ENTER.")

time.sleep(1)

print("Ready")

time.sleep(1)

print("Steady")

time.sleep(random.randint(1, 8))

print("GO")

tic = time.perf_counter()

a = input()

toc = time.perf_counter()

timespent = toc-tic
print(timespent)


