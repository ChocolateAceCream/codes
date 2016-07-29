n = gets.strip.to_i
arr = gets.strip
arr = arr.split(' ').map(&:to_i)
neg=0
pos=0
zer=0
arr.each do |i|
	p "No.#{i}" 
    if i>0
        pos+=1
    elsif i<0
        neg+=1
    else
        zer+=1
    end  
	p "zer#{zer}"
	p "neg#{neg}"
	p "pos#{pos}"
end
a1=pos.to_f/n
a2=neg.to_f/n
a3=zer.to_f/n

puts "%0.4f" %a1
puts "%0.4f" %a2
puts "%0.4f" %a3

