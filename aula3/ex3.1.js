const leia = require("prompt-sync")();

let resp = 2002;
let valor = 0;
let x = 0

while(x < 1){
    valor = parseInt(leia("coloque a senha:"))
    if(valor != resp){
        console.log("Senha Invalida")
    }
    else{
        console.log("Acesso Permitido")
        x++
    }
}