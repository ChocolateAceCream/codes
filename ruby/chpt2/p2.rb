def say_goodnight(name)
    result = "Good night, " + name
    return result
end

# Time for bed...
puts say_goodnight("John-Boy")
puts say_goodnight("Mary-Ellen")

def say_goodbye(name)
result = "Goodbye, #{name}"
return result
end

puts say_goodbye("maliya")

def good_morning(name)
  return "Good Morning,#{name.capitalize}"
end

puts "\n#{good_morning("mom")}"

#array
a = [1,'word',1.23]
b=%w{a b c d e f 1 2 3}
puts"first element is #{a[0]}"
a[4]=nil   #fill the array with nil
puts"#{a.inspect}"
puts"#{b.inspect}"

inst_section={
    :cello  => 'string'

}

puts inst_section[:cello]

today = Time.now
puts today
if today.thursday?
puts "Do chores around the house"
elsif today.sunday?
puts "Relax"
else
puts "Go to work"
end

def call_block
puts "Start of method"
yield
yield
puts "End of method"
end
call_block { puts "In the block" }

def who_says_what
yield("Dave", "hello")
yield("Andy", "goodbye")
end
who_says_what {|person, phrase| puts "#{person} says #{phrase}"}

[ 'cat', 'dog', 'horse' ].each {|name| print name, " " }
5.times { print "*" }
3.upto(6) {|i| print i }
('a'..'e').each {|char| print char }
printf("%5.2f",1.2345668)

line = Float(gets)
print line+10
