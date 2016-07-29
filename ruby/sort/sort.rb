require 'benchmark'
size = 15 #size of random array
array = (1..100).to_a.sample(size)
array1 = array
gap=[]
n=size
while (size > 1)
    size = size/3+1
    gap<<size
end
p "origional array is:"
p array

def benchmark()
    start = Time.now
    yield
    start - Time.now
end

###############Shell sort############
def shell_sort(array,size,gap)
    for i in gap
        for j in (i...size)
            while((j-i)>=0)
                if(array[j] < array[j-i])
                    temp = array[j]
                    array[j]=array[j-i]
                    array[j-i]=temp
                end
                j-=i
            end
        end
    end
    p "after sorted"
    p array
end

p 0-benchmark{
    shell_sort(array,n,gap)
}

#######merge sort
def merge_sort(array)
    return array if array.size<=1
    mid = array.size/2
    left = array[0..mid-1]
    right = array[mid..-1]
    merge(merge_sort(left),merge_sort(right))
end

def merge(left,right)
    sorted=[]
    until left.empty? || right.empty?
        if left.first <= right.first
            sorted<<left.shift
        else
            sorted<<right.shift
        end
    end
        sorted= sorted+left+right
end
p "merge_sort"
p merge_sort(array1)
p 0-benchmark{
   merge_sort(array1)
}
##########quick sort################
def quick_sort(array)
    return array if array.size<=1
    pivot=array.sample
    group=array.group_by{|x| x<=>pivot }
	group.default = []
    sorted=quick_sort(group[-1])+group[0]+quick_sort(group[1])
end
p "quick sort"
p quick_sort(array1)
p 0-benchmark{
	quick_sort(array1)
}

p "default sort"
p 0-benchmark{
    array1.sort
}
