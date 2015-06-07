
require_relative 'word_from_string.rb'
require 'test/unit'

class 
      TestWordsFromString<Test::Unit::TestCase
      
      def test_empty_string
          assert_equal([],words_from_string(""))
          assert_equal([],words_from_string("   "))
      end
      
      def test_single_word
          assert_equa l(["cat"],words_from_string(" cat "))
          assert_equal(["cat"],words_from_string("-cat - "))  
      end
      
      def test_many_words
          assert_equal(["I","am","a","CSer"],words_from_string("I am a CSer"))
      end
      
      def test_ignores_puntuation
          assert_equal(["I'","am","a","CSer"],words_from_string("I' am a !@@#CSer"))
      end
end
