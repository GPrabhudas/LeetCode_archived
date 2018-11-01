func romanToInt(str string) int {
    hash := make(map[byte]int)
    hash['I'] = 1
    hash['V'] = 5
    hash['X'] = 10
    hash['L'] = 50
    hash['C'] = 100
    hash['D'] = 500
    hash['M'] = 1000
    
    sum :=0
    
    for i:=len(str)-1;i>=0;i-- {
        price1 := hash[str[i]]
        price2 :=0
        if i > 0 {
            price2 = hash[str[i-1]]
        }
        if price2 != 0 && price1 > price2 {
            sum += (price1-price2)
            i--
        } else {
            sum+=price1
        }
    }
    return sum
}
