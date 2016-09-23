
sum=0.00
for i in 1...13
  sum+=i
  ave= (sum*1.00/i)
  puts sum
  puts i
  printf("%3f\n",ave)
  puts" "
end

array1=[0,1,2,3,"4"]
array2=[0,1,2,3,'4']

if array1==array2
  puts "same"
else puts"not same"
end

array=[1,2,3,4,5,6,7,8]
total=0
def total
  gg=0
  each do|value|
  gg+=value
  return gg
  end
end

puts "total is #{total}"
Float (ave)
ave=total*1.0/array.length()
puts "ave is #{ave}"

sorted_array=array.sort!
puts "max=#{sorted_array[-1]}"
puts "min=#{sorted_array[0]}"


array





