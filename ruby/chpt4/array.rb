a=[1,'adf',33.33]
puts "#{a}"
puts a[0]
puts a.length()
puts a[3]
puts a.class

puts 

puts a[-0]
puts a[-2]

=begin
You can also index arrays with a pair of numbers, [start,count] . 
This returns a new array consisting of references to count objects starting at position start : 
=end
  
b = [ 1, 3, 5, 7, 9 ]
c=b[1, 3] # => [3, 5, 7]
d=[3, 1] # => [7]
e=[-3, 2] # => [5, 7]
  puts "#{c}\n#{d}\n#{e}"


=begin
you can index arrays using ranges, in which start and end positions are separated by two or three periods. 
The two-period form includes the end position; the three-period form does not:
=end
puts
f=b[-4..-1]
g=b[1...4]
puts"#{f}\n#{g}"  

=begin
The [ ] operator has a corresponding [ ]= operator, which lets you set elements in the array. 
If used with a single integer index, the element at that position is replaced by whatever is
on the right side of the assignment. Any gaps that result will be filled with nil :

=end

  
h=[ 1, 3, 5, 7, 9 ]
h[3]=['a','b','c','d']
h[4]='baba'
h[1]=h[3]
puts "\n#{h}"  
 



=begin
If the index to [ ]= is two numbers (a start and a length) or a range, 
then those elements in the original array are replaced by whatever is on the right side of the assignment. 
If the length is zero, the right side is inserted into the array before the start position; 
no elements are removed. If the right side is itself an array, its elements are used in the replacement. 
The array size is automatically adjusted if the index selects a different number of elements 
than are available on the right side of the assignment.
  
=end
 
array=[0,1,2,3,4,5,6,7,8]
array[3,2]='bob'
puts "\narray = #{array}"
array[3,1]='cathy'
puts"#{array}"
array[0,0]=-1
puts"#{array}"
array[1..3]=[]
puts"#{array}"
array[1..3]=[1,2,3,4,5]
puts"#{array}"



=begin
push and pop add and remove elements from the end of an array, so you can
use the array as a stack:
=end

array=[0,1,2,3,4,5]
array.push 'f'
puts
puts"#{array}"
4.times {puts"#{array.pop}"}
puts"#{array}"
=begin
The first and last methods return (but don’t remove) the n entries at the head or end of an
array.
=end
array=[0,1,2,3,4,5]
puts
puts"#{array.first(4)}"
puts"#{array.last(4)}"
puts



#hash
h = { 'dog' => 'canine', 'cat' => 'feline', 'donkey' => 'asinine' ,1=>"wangwang"}
#alternative way:(keys are symbols.)
g = { dog: 'canine', cat: 'feline', donkey: 'asinine' }
  
puts h.length
puts "#{h['cat']}"
puts "#{h[1]}"
h[12] = 'pipi'
h['12']='122'
puts h
puts g[:dog]

  
=begin
Compared with arrays, hashes have one significant advantage: they can use any object as
an index. And you’ll find something that might be surprising: Ruby remembers the order
in which you add items to a hash. When you subsequently iterate over the entries, Ruby will
return them in that order.
=end

def word_from_string(string)
    string.downcase.scan(/[\w'-]+/)
end

array=word_from_string("I xxxoo's worrdd'")
b=[1,2,3,4,5,6-4,"2"]
p b
b[0,0]=array
p b
puts

=begin
If we create a hash object using Hash.new(0) , the parameter, 0
in this case, will be used as the hash’s default value—it will be the value returned if you look
up a key that isn’t yet in the hash.
=end

def count_frequency(word_list)
  counts = Hash.new(0)
    for word in word_list
        counts[word] += 1
    end
    counts
end
p count_frequency(b)

