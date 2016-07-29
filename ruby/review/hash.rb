inst_section = Hash.new(0)
inst_section ={
    'cello'        =>    'string',
    'clarinet'     =>    'woodwind',
    'drum'         =>    'percussion',
    'oboe'         =>    'woodwind',
    'trumpet'      =>    'brass',
    'violin'       =>    'string'
}

p inst_section['cello']
p inst_section['clo']

inst_section = {
    cello:        'string',
    clarinet:     'woodwind',
    drum:         'percussion',
    oboe:         'woodwind',
    trumpet:      'brass',
    violin:       'string'
}
puts "An oboe is a #{inst_section[:oboe]} instrument"

histogram = Hash.new(0)
# The default value is zero
p histogram['ruby'] # => 0
histogram['ruby'] = histogram['ruby'] + 1
p histogram['ruby'] # => 1
