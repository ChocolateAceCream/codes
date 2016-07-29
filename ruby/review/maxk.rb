#find the Kth max number in a set of random numbers
p "Enter total random numbers:"
total=gets.chomp.to_i
a=total.times.map {Random.rand(11)}
p a
p "Enter K(k<=n)"
k = gets.chomp.to_i
p "the #{k}th largest number in #{a} is #{a.sort[-k]}"
