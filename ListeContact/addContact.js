let confirmAdd = document.getElementById("confirmAdd");

confirmAdd.addEventListener("click", () => {
    let civ = document.getElementById("civ").value;
    let lastName = document.getElementById("lastNameInput").value;
    let firstName = document.getElementById("firstNameInput").value;
    let phoneNumber = document.getElementById("numberInput").value;

    if(verifContactInfo(civ, lastName, firstName, phoneNumber)){
        let newContact = JSON.stringify(createContact(civ, lastName, firstName, phoneNumber));
        localStorage.setItem(phoneNumber,newContact);
        alert("Contact ajouté","success","Add");
    }
})

createContact = (civ, lastName, firstName, phoneNumber) => {
    let contact = {
        civ: civ,
        lastName: lastName,
        firstName: firstName,
        phoneNumber: phoneNumber
    };

    return contact;
}

verifContactInfo = (civ, lastName, firstName, phoneNumber) => {
    let correct = true;
    if(civ == "Choisir..."){
        correct = false;
        alert("Civilité incorrect", "danger","Civ");
    }
    
    if(lastName == "" || !verifString(lastName)){
        correct = false;
        alert("Champ nom vide ou contenant des chiffres ou caractères spéciaux", "danger", "LastName");
    }
    if(firstName == "" || !verifString(firstName)){
        correct = false;
        alert("Champ prénom vide ou contenant des chiffres ou caractères spéciaux", "danger", "FirstName");
    }
    if(phoneNumber == "" || phoneNumber.length != 10){
        correct = false;
        alert("Champ numéro vide ou numéro pas au normes (10 chiffres).", "danger", "Number");
    }
    
    return correct;
}

alert = (message, type, field) => {
    let alertPlaceholder = document.getElementById('liveAlertPlaceholder' + field);
    let wrapper = document.createElement('div');
    wrapper.innerHTML = '<div class="alert alert-' + type + ' alert-dismissible" role="alert">' + message + '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button></div>';
  
    alertPlaceholder.append(wrapper);
}

verifString = (str) => {
    let format = /[/\d/!@#$%^&*()_+\=\[\]{};':"\\|,.<>\/?]/;
    if(format.test(str))
        return false;
    return true;
}