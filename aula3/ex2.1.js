const leia = require("prompt-sync")();

let cod = parseInt(leia("coloque o primeiro codigo:"))
let uni = parseInt(leia("coloque o primeira unidade:"))
let total = 0.0

if(cod == 1){
    total = 4 * uni
}

else if(cod == 2){
    total = 4.50 * uni
}

else if(cod == 3){
    total = (5 * uni)
}

else if(cod == 4){
    total = 2 * uni
}

else if(cod == 5){
    total = 1.5 * uni
}

console.log("total:",total)