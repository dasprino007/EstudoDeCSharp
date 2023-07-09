const leia = require("prompt-sync")();

let raio = parseFloat(leia("coloque um valor:"))
const pi = 3.14159
let area = (raio**2)*pi

console.log(area)