const leia = require("prompt-sync")();

let a = parseFloat(leia("coloque o a:"))
let b = parseFloat(leia("coloque o b:"))
let c = parseFloat(leia("coloque o c:"))
let delta = 0.0
let x1 = 0.0
let x2 = 0.0

delta = (b**2) - (4*a*c)

if(a == 0 || delta < 0){
    console.log("conta impossivel")
}

else{
x1 = (-Math.abs(b) + Math.sqrt(delta))/(2*a)
x2 = (-Math.abs(b) - Math.sqrt(delta))/(2*a)
console.log(x1+"\n"+x2)
}
