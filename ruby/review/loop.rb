today = Time.now

if today.saturday?
    p 'sat'
elsif today.sunday?
    p 'sun'
else
    p today.month
end

while line = gets and line.chomp != 'quit'
    puts line.downcase
end
