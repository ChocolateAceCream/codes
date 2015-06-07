line = gets
if line=~ /GG|gg+/
  puts "#{line}"
end

newline=line.sub(/GG/,'ff')
puts newline
newerline=line.gsub(/gg/,'FF')
puts "#{newerline}"