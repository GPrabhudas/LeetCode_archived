type freqArray struct {
    key,value int    
}

func topKFrequent(nums []int, k int) []int {
    n := len(nums)
    count := make(map[int]int)
    totalUnique :=0
    for i:=0;i<n;i++ {
        if _,ok := count[nums[i]]; ok == false {
            count[nums[i]] = 1
            totalUnique++
        } else {
            count[nums[i]]++        
        }
    }
    arr := make([]freqArray,totalUnique)
    heap := make([]freqArray,k)
    ans := make([]int,k)
    hash := make(map[int]bool)
    j:=0
    for i:=0; i<n;i++ {
        if _,ok:=hash[nums[i]]; ok == false {
            arr[j] = freqArray{nums[i],count[nums[i]]}
            hash[nums[i]] = true
            j++
        }
    }
    
    for i:=0;i<k;i++ {
        heap[i] = arr[i]
    }
    for i:=(k/2) - 1; i>=0; i-- {
        heapify(heap,i)
    }
    
    for i:=k;i<totalUnique;i++ {
        if heap[0].value < arr[i].value {
            heap[0] = arr[i]
            heapify(heap,0)
        }
    }
    
    for i,value := range heap {
       ans[i] = value.key
    }
    return ans
}
func heapify(heap[] freqArray,i int ) {
    left := 2 * i + 1
    right := 2 *i + 2
    smallest := i
    n := len(heap)
    if left < n && heap[left].value < heap[smallest].value {
        smallest = left
    }
    
    if right < n && heap[right].value < heap[smallest].value {
        smallest = right
    }
    
    if smallest != i {
        temp := heap[i]
        heap[i] = heap[smallest]
        heap[smallest] = temp
        heapify(heap,smallest)
    }
}
