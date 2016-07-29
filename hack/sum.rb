
n = gets.strip.to_i
arr = gets.strip
arr = arr.split(' ').map(&:to_i)
answer= arr.inject(0) {|result,element| result+element}
p answer
