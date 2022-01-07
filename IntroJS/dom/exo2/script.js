const text = document.getElementById("text");
const ref = document.querySelectorAll("a");

ref[0].addEventListener("click", (event) => {
    text.style.color = "black";
})

ref[1].addEventListener("click", (event) => {
    text.style.color = "white";
})