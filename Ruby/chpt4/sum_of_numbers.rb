sum = 0
[1, 2, 3, 4].each do |value|
sum+= value * value
puts sum
end
puts sum

=begin
The block is being called by the each method once for each element in the array. The element
is passed to the block as the value parameter.
=end

value = "some shape"
[ "ds", "as" ].each {|value| puts value }
puts value
puts"Fibonacci series up to a 1000"

def fib_up_to(max)
i1, i2 = 1, 1
# parallel assignment (i1 = 1 and i2 = 1)
while i1 <= max
yield i1
i1, i2 = i2, i1+i2
end
end
fib_up_to(1000) {|f| print f, " " }
puts