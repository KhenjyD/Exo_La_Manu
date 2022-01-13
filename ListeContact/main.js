let contactList = [];

alert = (message, type, field) => {
    let alertPlaceholder = document.getElementById('liveAlertPlaceholder' + field);
    let wrapper = document.createElement('div');
    wrapper.innerHTML = '<div class="alert alert-' + type + ' alert-dismissible" role="alert">' + message + '<button type="button" class="btn-close" data-bs-dismiss="alert" aria-label="Close"></button></div>';
  
    alertPlaceholder.append(wrapper);
}

document.addEventListener("click", event => {
    for (let i = 0; i < contactList.length; i++) {
        let contactId = contactList[i]["phoneNumber"];
        if(event.target.matches('#del'+contactId)) {
            localStorage.removeItem(contactId);
        }
    }
    location.reload();
})

getStorage = () => {

    let contacts = [],
        keys = Object.keys(localStorage),
        i = keys.length;

    while ( i-- ) {
        contacts.push( JSON.parse(localStorage.getItem(keys[i])) );
    }

    contactList = contacts;
}

generateContactTable = (contactList) => {
    if(contactList.length == 0)
        return;

    let tbody = document.querySelector("tbody");

    for (let rows = 0; rows < contactList.length; rows++) {
        let row = document.createElement("tr");

        for (let info in contactList[rows]) {
            let cell = document.createElement("td");
            let cellText = document.createTextNode(contactList[rows][info]);
            cell.appendChild(cellText);
            row.appendChild(cell);
        }
        let cellBtn = document.createElement("td");
        let deleteBtn = document.createElement("button");
        deleteBtn.className = "btn btn-danger";
        deleteBtn.id = "del" + contactList[rows]["phoneNumber"];
        cellBtn.appendChild(deleteBtn);
        deleteBtn.textContent = "Supprimer";
        row.appendChild(cellBtn);
        tbody.appendChild(row);
    }
}

getStorage();
generateContactTable(contactList);