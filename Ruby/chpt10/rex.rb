string=gets.chomp
sub=string.gsub(/http:\/\//,'').gsub(/\./,'_')
p sub
