s1 = gets.chomp
p s1
s2 = s1.gsub(/(ab)+/,'')#match any a(ab) pair for n times
s3 = s2.gsub(/c+/,'')
p s3
