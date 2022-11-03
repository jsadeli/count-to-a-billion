puts "Hello, World!"
start = Time.now

i = 0
while i < 1_000_000_000
  i += 1
end

stop = Time.now
elapsed = stop - start
puts "duration " + elapsed.to_s + "s"
puts "i=" + i.to_s
