#Q1
array = 100.times.map{Random.rand(100)+1}
puts "the array generated is:"
p array
count = Hash.new(0)
for number in array
  count[number]+=1
end
sorted = count.sort_by{|number, count| count}

puts "\nThe most repeated number(s) is(are):\n"

for i in 1..100
  printf("%d ",sorted[-i][0])
  break if sorted[-i][1]!=sorted[-i-1][1]
end
puts

#Q2
sorted_array=Array.new
sorted_array[0]=array[0]
def binary_sort(low,up,array,target)
      mid=(low+up)/2
      if(up-low)>1 then
          if array[mid]>target then
              up= mid-1
              binary_sort(low,up,array,target)
          elsif array[mid]<target then
              low=mid+1
              binary_sort(low,up,array,target)
          else
              return mid
          end
      else
          if target>array[up]
          return up+1
          elsif target <array[low]
          return low
          else
          return up
          end
      end
  end

  for i in 1...array.length do
    index = binary_sort(0,i-1,sorted_array,array[i])
    sorted_array[index,0]=array[i]
end
puts "sorted array is #{sorted_array}"
puts

#Q3
sum=0
ave=Hash.new(0)
for i in 0...array.length do
  sum +=array[i]
  ave[i]=sum*1.0/(i+1)
end
sorted_ave = ave.sort_by{|number, average| average}
puts "The highest average number appeared at column:"
for i in 1..100
  printf("%d ",sorted_ave[-i][0]+1)
    break if sorted_ave[-i][1]!=sorted_ave[-i-1][1]
end
puts
