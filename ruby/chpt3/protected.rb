class Animal
  def animal_call
    protect_me
  end
  protected
  def protect_me
    p "protect_me called from #{self.class}"
  end  
end

n1= Animal.new
n1.animal_call #=> protect_me called from Animal
#n1.protect_me #=>error: protected method `protect_me' called

class Mammal < Animal
  def mammal_call
    protect_me
  end
end 

puts "n2"
n2= Mammal.new
n2.mammal_call #=> protect_me called from Mammal

class Amphibian < Animal
  def amphi_call
    Mammal.new.protect_me #Receiver same as self
    self.protect_me  #Receiver is self
  end   
end

puts"n3"
n3= Amphibian.new #=> protect_me called from Mammal
n3.amphi_call #=> protect_me called from Amphibian  



