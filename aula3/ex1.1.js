const leia = require("prompt-sync")();

let cod1 = parseInt(leia("coloque o primeiro codigo:"))
let un1 = parseInt(leia("coloque o primeira unidade:"))
let valor1 = parseFloat(leia("coloque o primeiro valor:"))

let cod2 = parseInt(leia("coloque o segundo codigo:"))
let un2 = parseInt(leia("coloque o segunda unidade:"))
let valor2 = parseFloat(leia("coloque o segundo valor:"))

let total = 0.0

total = total + (un1*valor1)
total = total + (un2*valor2)

console.log("o valor total é",total)

