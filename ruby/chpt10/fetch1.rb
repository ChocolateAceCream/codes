require 'open-uri'
page = gets.chomp
web_page = open(page)
page=page.gsub(/https*:\/\//,'').gsub(/(\.)|(\/)/,'_')
file_name = "#{page}.html"
p file_name
output = File.open(file_name, "w")
begin
    while line = web_page.gets
        output.puts line
    end
    output.close
rescue Exception
    STDERR.puts "Failed to download #{page}: #{$!}"
    output.close
    File.delete(file_name)
    raise
end
