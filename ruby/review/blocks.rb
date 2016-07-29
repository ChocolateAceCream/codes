def call_blocks
    yield("di","hello")
    yield('clare','bye')
end

call_blocks {|name, words| puts "#{words} yields #{name}"}

def who_says_what
    yield('Davex', "hello")
    yield("Andy", "goodbye")
end
who_says_what {|person, phrase| puts "#{person} says #{phrase}"}
