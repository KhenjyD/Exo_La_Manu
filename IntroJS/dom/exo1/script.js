let img = document.getElementById("image1");

img.addEventListener("mouseover", (event) => {
    event.target.style.border = "3px solid red";
}, false);

img.addEventListener("mouseout", (event) => {
    event.target.style.border = "";
}, false);