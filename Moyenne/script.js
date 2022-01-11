let note = document.querySelectorAll("input");
let result = document.getElementById("result");
let grade = document.getElementById("grade");

result.addEventListener("click", () => {
    let average = 0;
    for (let i = 0; i < note.length; i++) {
        average += Number(note[i].value);
    }
    console.log(average);
    average = average / note.length;
    console.log(average);

    if(average >= 0 && average < 10){
        grade.textContent = `${average}/20, En dessous de la moyenne.`;
    }
    else if(average >= 10 && average < 13){
        grade.textContent = `${average}/20, Moyen.`;
    }
    else if(average >= 13 && average < 16){
        grade.textContent = `${average}/20, Bien.`;
    }
    else if(average >= 16 && average < 20){
        grade.textContent = `${average}/20, Très bien.`;
    }
    else{
        grade.textContent = `${average}/20, Excellent.`;
    }
})