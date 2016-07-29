n=gets.to_i
a=[]
(1..n).each do
	a<<gets.to_i
end

def ways(number)
	if number==0
		return total=0
	elsif number<4
		return total = 1
	else
		total=1
		ways_count=number/4
		for i in 1..ways_count
			total+=c((number-i*4+i),i)
			return total
		end
	end
end

def c(n,m)
	return	(n.!)/(((n-m).!)*(m.!))
end

class Fixnum
	def !
		(1..self).inject(:*)
	end
end

b=[]
a.each do |i|
	b<<ways(i)
end

def is_prime(number)
	return false if number <=1
	2.upto(Math.sqrt(number).to_i) do |x|
		return false if number % x ==0
	end
	true
end
b.each do |i|
	count=0
	for n in (0..i)
		if is_prime(n)
			count+=1
		end
	end
	puts count
end
