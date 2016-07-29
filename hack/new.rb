class Paragraph
	attr_accessor :text, :sentence_count, :most_used_words
	#Opens the proper output file, formats the class attributes to it, and closes the file.
	def write_output
		output_file = File.open(ENV['OUTPUT_PATH'], 'w')
		output_file.write(@sentence_count.to_s + "\n")
		@most_used_words.each {|word| output_file.write(word.to_s+"\n")}
		output_file.close()
	end

	#Edit the code below.
	def new
		input=@text
		counts = {}
		max_value = 0
		words_in_the_paragraph.each do |word|
			inspecting_word = word
			if !counts[inspecting_word]
				counts[word]=0
			end
			counts[word]=counts[word]+1
		end
		max = counts.value.sort.last
		max_words = []
		counts.each do |x|
			if x.last == max
				max_words << x.first
			end
		end
		@mostUsedWords = max_words
	end
	def calculate_sentence_count(input)
		input.split(/[.]/).count
	end
	def words_in_the_paragraph
		return self.text.gsub('.', '').split(" ")
	end
end
#Grabs input, passes the input string into a new instance of the Paragraph class, then runs the method that prints the information to the output file.
story = Paragraph.new(gets.strip)
story.write_output

