let text = document.getElementById("lastname");

text.addEventListener("keydown", (event) => {
    if (event.key === "Enter") {
        alert(event.target.value);
    }
})