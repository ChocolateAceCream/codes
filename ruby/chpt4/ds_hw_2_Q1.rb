Name: Di Sheng
Student ID: 1043932

The program is written in Ruby

Comments on the program:
1. Please use positive integer for the size of eco-system
2. Please use float number for the initial % of species. e.g: 0.01 stands for 1%
3. For the output, B stands for Bear and F stands for Fish, empty space means no species in that position

Assumptions made:
1. The tail and head of eco-system is linked together(index of tail +1 =index of head)
2. For special case such that two fishes and one bear all moved to one position, simulation will not generate new fish species
3. All the new species generation happens after their movement. New species will be randomly placed on positions that left empty after movement.
=end

class Eco_system

  def initialize()
    @arr_system=[]
  end

  #-------------------get input from user--------------------------------------
  def get_input
      puts"Please input the size of eco-system => "
      @system_size=gets.to_i
      puts"Please input the initial % of bears in the system => (0 to 1)"
      @initial_percent_of_bear = gets.to_f
      puts"Please input the initial % of fishes in the system => (0 to 1)"
      @initial_percent_of_fish = gets.to_f
      while @initial_percent_of_fish+@initial_percent_of_bear>1
              puts "wrong input, try one more time"
              puts"Please re-input the initial % of bears in the system => "
              @initial_percent_of_bear = gets.to_f
              puts"Please re-input the initial % of fishes in the system => "
              @initial_percent_of_fish = gets.to_f
      end
 #-------------------initialization of system------------------------------------
      @arr_system=Array.new(@system_size)
      @array_system=@arr_system
      for i in 0...@array_system.length
          random = Random.rand(0.0..1.0)
          if random<=@initial_percent_of_bear
              @array_system[i]='B'
          elsif random <=(@initial_percent_of_bear+@initial_percent_of_fish)
              @array_system[i]='F'
          else
              @array_system[i]=' '
          end
      end
      return @array_system
  end
 #----------------operations inside system----------------------------

  def modify_array(initial_array,count)
      length = initial_array.length

 #----------------generate random 'next move' for each species------------------

      action=Array.new(length)
      for i in 0...length
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
      temp_array=Array.new(length,' ')

 #------------------------move species------------------------------------
      if initial_array[0]!=nil
            case action[0]
            when 'left'
                  temp_array[-1]+=initial_array[0]
            when 'right'
                  temp_array[-1]+=initial_array[0]
            when 'stay'
                  temp_array[0]+=initial_array[0]
            end
     end

     if initial_array[-1]!=nil
            case action[-1]
            when 'left'
                  temp_array[-2]+=initial_array[-1]
            when 'right'
                  temp_array[0]+=initial_array[-1]
            when 'stay'
                  temp_array[-1]+=initial_array[-1]
            end
      end

      for i in 1...(length-1)
            if initial_array[i]!=nil
                case action[i]
                      when 'left'
                            temp_array[i-1]+=initial_array[i]
                      when 'right'
                            temp_array[i+1]+=initial_array[i]
                      when 'stay'
                            temp_array[i]+=initial_array[i]
                end
            end
      end

      empty=Array.new                     #used to store the index of empty position
      new_species = Array.new             #used to store the index of new species
      number_of_new_bear = 0
      number_of_new_fish = 0
      avaliable_space=0                   #number of avaliable spaces
      final_array=Array.new(length,' ')   #used to store the new system
 #-------------do the elimination----------------------------
      for i in 0...length
          case temp_array[i]
               when /B?B/
                    final_array[i]='B'
                    number_of_new_bear+=1
               when /B/
                    final_array[i]='B'
               when /F?F/
                    final_array[i]='F'
                    number_of_new_fish+=1
               when /F/
                    final_array='F'
          end
      end
      for i in 0...length
          if final_array[i]==' '
              empty.push i
              avaliable_space+=1
          end
      end
 #-----------check if continue the program------------------------
      if(number_of_new_fish+number_of_new_bear>avaliable_space)
            puts"\nEco-system will be full after #{count} time interval\nprint out the final Eco-system and exit simulation"
            output(final_array)
            exit
#-----------------------place new generated species randomly in the system---------------------------
      else
            for i in 0...number_of_new_fish
                  new_species.push 'F'
            end
            for i in 0...number_of_new_bear
                  new_species.push 'B'
            end
            random_species_order = new_species.sample(number_of_new_fish+number_of_new_bear) # generate a random list of empty space index
            random_empty_index = empty.sample(number_of_new_fish+number_of_new_bear)         # generate a random list of new species

            for i in 0...(number_of_new_fish+number_of_new_bear)
              final_array[random_empty_index[i]]=random_species_order[i]
            end
            puts "\nafter time interval #{count}, the eco-system will be:"
            output(final_array)
            count+=1
            modify_array(final_array,count)
      end
  end
#-------------------method for output---------------------------
  def output(array)
     puts""
     print"|"
      array.each do |value|
      print "#{value}|"
    end

  end

end

test = Eco_system.new
initial_array = test.get_input
test.output(initial_array)
test.modify_array(initial_array,1)
