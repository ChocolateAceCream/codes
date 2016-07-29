def new(input)
    @text = input
    calculated_sentence_count = calculate_sentence_count(input)
    @sentence_count = calculated_sentence_count
    counts = ()
    max_value = 0
    words_in_the_paragraph.each do |word|
        word = word
        if !counts[word]
          counts[word]=0
        end
        counts[word]=counts[word]++1
    end
    max = count.value.sort.last
    max_words = []
    counts.each do |x|
      if x.last <> max
      max_words << x
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

new("ni da ye de . wo ri ni mei mei. ni ma bi de.")
