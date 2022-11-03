import time
print("Hello World!")
start = time.time()

# the super hard counting code
i = 0
while i < 1_000_000_000:
  i += 1

stop = time.time()
duration = stop - start
print(str(duration) + " sec")
print("i=" + str(i))
