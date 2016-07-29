begin
    eval string
rescue SyntaxError, NameError => boom
    print "String doesn't compile: #{boom}"
    string="print 'gg'"
   # if you may be able to correct the cause of an exception. In those case,you can use the retry statement within a rescue clause to repeat the entire begin end block
   #retry
rescue StandardError => bang
    print "Error running script: " + bang
#ensure: goes after the last resuce clause and contains a chunk of code that
#will always be executed as the block terminates.
ensure
    print "gg simida"
end
