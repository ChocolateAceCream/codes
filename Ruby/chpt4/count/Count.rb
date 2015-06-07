require_relative"word_from_string.rb"
require_relative"count_frequency.rb"

raw_text = %{The problem breaks down into two parts. First, given some text
as a string, return a list of words. That sounds like an array. Then, build
a count for each distinct word. That sounds like a use for a hash---we can
index it with the word and use the corresponding entry to keep a count.}

raw_text2 = "xiao ming shuo, xiao ming you ge nv peng you jiao xiao li"

word_list= words_from_string(raw_text2)
counts = count_frequency (word_list)
sorted = counts.sort_by{|word, count| count}

#When you use sort_by , you give it a block that tells 
#the sort what to use when making comparisons.
top_five = sorted.last(5)

for i in 0...5
  word = top_five[i][0]
  count = top_five[i][1]
  puts "#{word} #{count}"
  
end