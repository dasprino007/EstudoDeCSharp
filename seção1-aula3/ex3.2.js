let tentativa1 = [5,14,123,10,-25,32]
let fora = 0
let dentro = 0

for(i = 0; tentativa1.length > i; i++){
    if(tentativa1[i] >= 10 && tentativa1[i] <= 20){
        dentro++
    }

    else if(tentativa1[i] < 10 || tentativa1[i] > 20){
        fora++
    }
}

console.log(`in ${dentro}\nout ${fora}`)