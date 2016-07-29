#!/bin/ruby

time = gets.strip
time = time.split(":")
if (time[-1]=~/\d*PM/)
        time[0]=time[0].to_i+12
end
time[-1]=time[-1].gsub(/PM/,'')
puts time[0].to_s+':'+time[1]+':'+time[2]
