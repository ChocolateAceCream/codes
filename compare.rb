require 'openssl'
require 'digest/sha1'
require 'base64'
require 'net/ping'
require 'json'
require 'time'

def decrypt_whole_record(id,key)
	record = `curl -v -GET http://localhost:3000/api/v1/patients/#{id}`
	record = JSON.parse(record).to_a
	for i in 1..record.length-1
		record[i]=decryption(record[i].to_s,key) 
	end
	return record
end

def encrypt_whole_record(record,key)
	for i in 1..record.length-1
		record[i]=encryption(record[i].to_s,key) 
	end
	return record
end


def create_record
#-------get user input----------
	key = get_key()
	record=[]
	record[1] = get_patient_last_name()
	record[2] = get_patient_first_name()
	record[3] = get_patient_age()
	record[4] = get_patient_phone()

#----data encryption----------
	start_time = Time.now
	record = encrypt_whole_record(record,key)
	uploading = `curl -v -PUT http://localhost:3000/patients -d "patient[last_name]=#{record[1]}" -d "patient[first_name]=#{record[2]}" -d "patient[phone]=#{record[3]}" -d "patient[age]=#{record[4]}" `
	end_time = Time.now
	cost = end_time-start_time
	p '****************************'
	p "creation cost #{cost} second" 
	p '****************************'
end

def update_record(id, entry, attribute,key)
	start_time = Time.now
	record = decrypt_whole_record(id,key)
	record[entry]=attribute
	crypt_record = encrypt_whole_record(record,key)
	uploading = `curl -v -XPATCH http://localhost:3000/patients/#{id} -d "patient[last_name]=#{record[1]}" -d "patient[first_name]=#{record[2]}" -d "patient[phone]=#{record[3]}" -d "patient[age]=#{record[4]}" `
	end_time = Time.now
	cost = end_time-start_time
	p '****************************'
	p "update cost #{cost} second" 
	p '****************************'
end
#-------get user input----------

def get_record(id,title,entry,key)
	start_time = Time.now
	record = decrypt_whole_record(id,key)
	end_time = Time.now
	cost = end_time-start_time
	p '****************************'
	p "Patient id: #{id}"
	p "#{title}: #{record[entry]}"
	p "Decryption cost #{cost} second" 
	p '****************************'
end

def delete_record()
	id = get_patient_id()
	start_time = Time.now			
	a= `curl -X DELETE http://localhost:3000/patients/#{id}`
	end_time = Time.now
	cost = end_time-start_time
	p '****************************'			
	p "Deletion cost #{cost} second" 
	p '****************************'
end

def get_key
	p "Enter your key"
	key=gets.chomp
	if key.length<42
		(42-key.length).times do 
			key+='*'
		end
	end
	return key
end

def get_patient_id
	p "Enter patient id"
	id=gets.chomp

	return id
end

def get_patient_last_name
	p "Enter patient last name"
	last_name=gets.chomp
	return last_name
end

def get_patient_first_name
	p "Enter patient first name"
	first_name=gets.chomp
	return first_name
end

def get_patient_age
	p "Enter patient age"
	age=gets.chomp
	return age
end

def get_patient_phone
	p "Enter patient phone"
	phone=gets.chomp
	return phone
end

def encryption(msg,key)
	cipher = OpenSSL::Cipher.new('AES-128-ECB')
	cipher.encrypt
	cipher.key = key
	encrypted = cipher.update(msg)
	encrypted << cipher.final
	crypt_string = (Base64.encode64(encrypted))
	return crypt_string
end

def decryption(msg,key)
	cipher = OpenSSL::Cipher.new('AES-128-ECB')
	cipher.decrypt
	cipher.key = key
	crypt=msg
	crypt=crypt.gsub(/\n/, '%')
	crypt=crypt.gsub(/\s/, '+')
	crypt=crypt.gsub(/'%'/, '\n')
	crypt
	tempkey = Base64.decode64(crypt)
	crypt = cipher.update(tempkey)
	crypt << cipher.final()
	return crypt
end

def menu
	p "Please select from (1,2,3,4)"
	p "1. Create patient record"
	p "2. Show patient record"
	p "3. Update patient record"
	p "4. Delete patient record"
	p "5. Exit"
	option = gets.chomp
	return option
end

def get_title
	p "Please select data field from (1,2,3,4)"
	p "1. Patient last name"
	p "2. Patient first name"
	p "3. Patient phone"
	p "4. Patient age"
	p "5. Go back"
	title = gets.chomp
	return title
end



def get_menu
	loop do 
		a=menu()
		case a
		when '1'
			create_record()
		when '3'
			id = get_patient_id
			key = get_key()
			loop do 
				title = get_title
				case title
				when '1'
					entry = 1
					last_name = get_patient_last_name
					update_record(id,entry,last_name,key)
				when '2'
					entry = 2
					first_name = get_patient_first_name
					update_record(id,entry,first_name,key)
				when '3'
					entry = 3
					phone = get_patient_phone
					update_record(id,entry,phone,key)
				when '4'
					entry = 4
					age = get_patient_age
					update_record(id,entry,age,key)
				when '5'
					break
				else
					p "Wrong input, try again"		
				end
			end
		when '2'
			id = get_patient_id
			key = get_key()
			loop do 
				title = get_title
				case title
				when '1'
					title = 'last_name'
					entry = 1
					get_record(id,title,entry,key)
				when '2'
					title = 'first_name'
					entry = 2
					get_record(id,title,entry,key)
				when '3'
					title = 'phone'
					entry = 3
					get_record(id,title,entry,key)
				when '4'
					title = 'age'
					entry = 4
					get_record(id,title,entry,key)
				when '5'
					break
				else
					p "Wrong input, try again"		
				end
			end
		when '4'
			delete_record()
		when '5'
			p "exit"
			exit
		else
			p "Wrong input, try again"		
		end
	end
end
get_menu

=begin

--------------menu--------------


def menu
	p "Please select from (1,2,3,4)"
	p "1. Create patient record"
	p "2. Show patient record"
	p "3. Update patient record"
	p "4. Delete patient record"
	p "5. Exit"
	option = gets.chomp
	return option
end

loop do 
	a=menu()
	case a
	when '1'
		create_record()
	when '2'
		p "show"
	when '3'
		p "update"
	when '4'
		p "delete"
	when '5'
		p "exit"
		exit
	else
		p "Wrong input, try again"		
	end
end




--------------------------------



-------------------------------------
#append key to 39 character length

key = 'hello world'
if key.length<39
	(39-key.length).times do 
		key+='*'
	end
		p key
end

--------------------------------------
=end