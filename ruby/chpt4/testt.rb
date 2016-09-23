
array=[0,1,2,3,4,5,6,7,8,9]


  k=array.sample(19)


p k










=begin
array= Array.new(10)
array2=['0','F  ',' F ','FF','FB','FFF','FFB','FBF','FBB','B','BB','BF','BBB','BBF','BFB','BFF']
array= ['0','']

  for i in 0...10
      puts i
      if i>6
        exit('done')
      end


  end






final_array=Array.new(length)
for i in 0...length
    case temp_array[i]
         when  /B?B/ 
               final_array[i]='B'
         
    end










,

final_array=Array.new(length)
  for i in 0 ...length
        case temp_array[i]
              when  
              
        end
  end
















array=Array.new(10)
array[3]=12
array[7]=9
array[2]=3

empty1=Array.new
for i in 0...10
    if array[i]==nil
        empty1.push i
        end

end
p empty1

action=Array.new(5)
for i in 0...5
   random = Random.rand(0.0..1.0)
   case random
   when 0..(1.0/3)
       action[i]='left'
   when (1.0/3)...(2.0/3)
       action[i]='stay'
   when (2.0/3)..1
        action[i]='right'
   end
end

p action   


puts"Please input the size of eco-system => "
     system_size=gets.chomp.to_i
     puts"Please input the initial % of bears in the system => (0 to 1)"
     initial_percent_of_bear = gets.chomp.to_i
     puts "#{initial_percent_of_bear}"
     
     puts"Please input the initial % of bears in the system => (0 to 1)"
     initial_percent_of_fish = gets.chomp.to_i
p (initial_percent_of_bear+initial_percent_of_fish)
     while initial_percent_of_fish+initial_percent_of_bear>1
             puts "wrong input, try one more time"
             puts"Please re-input the initial % of bears in the system => "
             initial_percent_of_bear = gets.chomp.to_i
             puts"Please re-input the initial % of bears in the system => "
             initial_percent_of_fish = gets.chomp.to_i
     end
p initial_percent_of_bear
        p (initial_percent_of_bear+initial_percent_of_fish)
     arr_system=Array.new(system_size)
     array_system=arr_system
     for i in 0...array_system.length
         random = Random.rand(0.0..1.0)
         p initial_percent_of_bear
         p (initial_percent_of_bear+initial_percent_of_fish)
         p random
         if random<=initial_percent_of_bear
             array_system[i]='O'
             puts"1"
         elsif random <=(initial_percent_of_bear+initial_percent_of_fish)
             array_system[i]='X'
             puts"2"
         else
             array_system[i]=' ' 
             puts"3"
             
         end
     end



count = Array.new(0)
queue = Array.new(0)
count[0]='a'
count[1]='b'
queue[0]=0
queue[2]=nil
queue[1]=1
queue[3]=4

puts count[queue[1]]


if count.include?(nil) == true
  puts "not full"
else 
  puts "full"
end
sleep 2
puts 'a'

puts "enter enter to continue\n enter 2 to exit"
input = gets
while input != 1
  input = gets
  if input == 1
    abort("exit")
  end
end
=end


