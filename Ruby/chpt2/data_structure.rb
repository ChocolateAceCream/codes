# Program was written in Ruby
class Grade
  attr_reader :total
  def initialize(string)
      @midTerm,@project,@final=string[0],string[1],string[7]
      @hw=[string[2],string[3],string[4],string[5],string[6]]
  end  
  def calc
      @project=@midTerm if (@project<=@midTerm)      
      @total =@midTerm*0.2+@project*0.2+@final*0.4 
      hw_sorted=@hw.sort!().last(4)
      for i in 0...4
        @total+=hw_sorted[i]*0.075
      end
      return @total
   end

end

puts "Please input your grades one by one,separated by any characters, in the sequence of the
mid-term, project, homework 1,2,3,4,5 and the final=> (total 8 marks)"
input=gets
str_input=input.scan(/\d+/)
int_input=str_input.map{|i| i.to_i}
student1 = Grade.new(int_input)
mark = student1.calc
printf("\nYour final grade is %6.2f\n",mark)
