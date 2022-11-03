import Foundation

print("Hello World!")
let start = DispatchTime.now()

var i = 0
while (i < 1_000_000_000) {
  i += 1
}

let stop = DispatchTime.now()
let duration = (stop.uptimeNanoseconds - start.uptimeNanoseconds) / 1_000_000
print(String(duration) + "ms")
print("i=" + String(i))
