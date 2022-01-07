const password = document.getElementById("password");
const confirmPassword = document.getElementById("confirmPassword");
const verif = document.getElementById("submit");

verif.addEventListener("click", (event) => {
    if(password.value == confirmPassword.value)
    {
        password.style.border = "3px solid green";
        confirmPassword.style.border  = "3px solid green";
    } 
    else {
        password.style.border = "3px solid red";
        confirmPassword.style.border  = "3px solid red";
    }
})
