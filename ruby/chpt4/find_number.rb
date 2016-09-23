def number_from_string(string)
str=string.scan(/\d+/)
str.each do
      |number|
      number.to_i
      print"#{number}  "
end
#str = str.map { |i| i.to_i }
end

p number_from_string("12/32/42/45/23/31/24")  