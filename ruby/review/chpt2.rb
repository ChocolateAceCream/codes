puts "the abs value of -11 is:"
p -11.abs
def say_goodnight(name)
    result = "Good night, " + name
end

puts say_goodnight('tony')

array = [1,'cat',3.14, 'dog']
p array[0]+array[2]

p array[1]+array[3]

strings = %w{a b c d e}
10.times {p strings[2]}
