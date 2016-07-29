class Grade
  
  attr_reader :total
  def initialize(a,b,c,d,e,f,g,h)
      @midTerm=a
      @project=b
      @hw1=c
      @hw2=d
      @hw3=e
      @hw4=f
      @hw5=g
      @final=h
  end
  
  def calc
      
      @project=@midTerm if (@project<=@midTerm)
  
      @min=@hw1
  
      if  @hw2<@min
          @min=@hw2
      end
  
      if  @hw3<@min
          @min=@hw3
      end
  
      if  @hw4<@min
          @min=@hw4
      end
  
      if  @hw5<@min
          @min=@hw5
      end

      @total =@midTerm*0.2+@project*0.2+(@hw1+@hw2+@hw3+@hw4+@hw5-@min)*0.075+@final*0.4
      return @total
   end

end

puts "Please input your Mid-term grades=> "
midTerm = Float(gets)

puts "Please input your Project grades=> "
project=Float(gets)


puts "Please input your HW1 grades=> "
hw1= Float(gets)


puts "Please input your HW2 grades=> "
hw2= Float(gets)

puts "Please input your HW3 grades=> "
hw3= Float(gets)


puts "Please input your HW4 grades=> "
hw4= Float(gets)

puts "Please input your HW5 grades=> "
hw5= Float(gets)

puts "Please input your final exam grades=> "
final = Float(gets)

student1 = Grade.new(midTerm,project,hw1,hw2,hw3,hw4,hw5,final)
mark = student1.calc
printf("\nYour final grade is %6.2f\n",mark)
