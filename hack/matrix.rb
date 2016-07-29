n = gets.strip.to_i
a = Array.new(n)
for a_i in (0..n-1)
	a_t = gets.strip
	a[a_i] = a_t.split(' ').map(&:to_i)
end
primary_diagonal=0
secondary_diagonal=0
n.times do |i|
	primary_diagonal+=a[i][i]
	secondary_diagonal+=a[i][n-i-1]
end
p answer=(primary_diagonal-secondary_diagonal).abs
