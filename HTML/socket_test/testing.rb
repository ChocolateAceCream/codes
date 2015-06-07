#!/usr/bin/env ruby -w
require "socket"
class Server
  def initialize( ip, port )
    @server = TCPServer.open( ip, port )
    @socket = Hash.new
    @clients = Hash.new
    @socket[:server] = @server
    @socket[:clients] = @clients
    chat
  end
 
  def chat
      loop {  
            Thread.start(@server.accept) do | client |
                chat_name = client.gets.chomp
                
                @socket[:clients].each do |else_name, else_client|
                    while chat_name == else_name
                          client.puts "This name already exist,please re-enter"
                          chat_name = client.gets.chomp         
                    end
                end
                
                puts "#{chat_name} has established connection"
                @socket[:clients][chat_name] = client
                client.puts "Welcome to the chatting room, enjoy chatting!"
                listen( chat_name, client )
            end 
      }.join
  end
 
  def listen( chat_name, client )
    loop {
      messages = client.gets.chomp
      if messages == '-quit'
          client.puts"exit program"
          client.close
          messages = nil
      end
      @socket[:clients].each do |each_name, each_client|
        if chat_name != each_name 
            each_client.puts "#{chat_name.to_s}: #{messages}"
        else
            client.puts "Me: #{messages}"
        end
      end
    }
  end
end
 

puts "The following is your local IP address, please use it as both server and client ip address"
temp=Socket.ip_address_list
temp.each do |value|
  test=value.ip_unpack[0].to_s
  if test.include? "192.168"
     @ip = test
  end
end
p @ip
puts "Enter Port of Server"
port=gets.chomp

Server.new( @ip,port )