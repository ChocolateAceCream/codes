
class BookInStock
  attr_accessor  :price,:isbn
  def initialize(a, b)
      @isbn = a
       @price = Float(b)
  end
  
  def price_in_cents
      Integer(price*100 + 0.5)
  end
  

end
book = BookInStock.new("isbn", 12.34)
puts "ISBN= #{book.isbn}"
puts "Price = #{book.price1}"
book.price = book.price*5
puts "#{book.pricel}"

puts "#{book.price_in_cents}"

  