const text = document.getElementById("text");
const color = document.querySelectorAll("div.color");

color[0].addEventListener("click", (event) => {
    text.style.color = "green";
})

color[1].addEventListener("click", (event) => {
    text.style.color = "red";
})

color[2].addEventListener("click", (event) => {
    text.style.color = "blue";
})