let toFind = Math.floor(Math.random() * 101);
let answer = document.getElementById("answer");
let button = document.querySelector("button");
let tries = 0;

button.addEventListener("click", () => {
    if(answer.value == "")
        alert("Entrez un nombre.")
    else if(answer.value < toFind) {
        alert("C'est plus !")
        tries++;
    }
    else if(answer.value > toFind){
        alert("C'est moins !")
        tries++;
    }
    else{
        tries++;
        alert("Correct ! Vous avez gagnez en " + tries + " essais !");
    }
})