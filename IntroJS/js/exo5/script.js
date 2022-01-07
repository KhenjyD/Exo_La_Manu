let find = 10;

let answer = prompt("Deviner le nombre.");

while (answer != find) {
    if(answer < find) {
        answer = prompt("Plus grand !")
    }
    else {
        answer = prompt("Plus petit !")
    }
}

alert("Vous avez trouvé !");

