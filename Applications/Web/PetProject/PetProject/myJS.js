MyApp = {};

MyApp.Url = "https://petproject.firebaseio.com/"

MyApp.Pets = [];

//Write Pet
MyApp.WriteTable = function () {
    var holder = "<table>";
    for (var o in MyApp.Pets) {
        holder += "<tr>";
        for (var p in MyApp.Pets[o]) {
            holder += "<td>";
            holder += MyApp.Pets[o][p];
            holder += "</td>";
        }
        holder += "<td><button"+" onclick='MyApp.DeletePet(\""+MyApp.Pets[o].id+"\"); MyApp.ClearFields();'>Delete</button></td>";
        holder += "<td><div class='btn btn-warning' + onclick='MyApp.ShowUpdatePet(\"" + MyApp.Pets[o].id + "\")' >Edit</div></td>"
        holder += "</tr>";
   }
    holder += "</table>";
    document.getElementById("petOutput").innerHTML = holder;
};

//Create Pet
MyApp.AddPet = function () {
    var pet = {};
    pet.name = document.getElementById("Name").value;
    pet.species = document.getElementById("Species").value;
    pet.picture = document.getElementById("Picture").value;
    MyApp.PostPet(pet, MyApp.GetPets);
};

//Showinfo for update
MyApp.ShowUpdatePet = function (id) {
    var pet = MyApp.Pets[id];
    document.getElementById("EditName").value = pet.name;
    document.getElementById("EditSpecies").value = pet.species;
    document.getElementById("EditPicture").value = pet.picture;
    document.getElementById("EditId").value = id;
    document.getElementById("ModalTitle").innerHTML = "Editing " + pet.name;
    $('#EditModal').modal();
};

//Save info from update
//MyApp.SaveUpdatePet = function () {
   // var
    //};


//Delete Pet
MyApp.DeletePet = function(id){
    var request = new XMLHttpRequest();
    request.open("DELETE", MyApp.Url +id +"/.json");
    request.onload = function() {
        MyApp.GetPets();
   }
    request.send();
};

//Clear Fields
MyApp.ClearFields = function () {
    document.getElementById("Name").value = "";
    document.getElementById("Species").value = "";
    document.getElementById("Picture").value = "";
};

//Post Pet
MyApp.PostPet = function (pet, callback) {
    var request = new XMLHttpRequest();
    request.open('POST', MyApp.Url + '.json', true);
    request.onload = function () {
        if (this.status >= 200 && this.status < 400) {
            alert("Response Received");
            var data = JSON.parse(this.response);
            callback(data);
        }
        else {
            console.log(this.response);}
    };
    request.onerror = function () {
        console.log("Com Error on Post Pets");
    };
    request.send(JSON.stringify(pet));
};

//Delete Pet

//Update Pet

//GET PET ARRAY FROM FIREBASE
MyApp.GetPets = function (callback) {
    alert("Get Pets Is Running");
    var request = new XMLHttpRequest();
    request.open('GET', MyApp.Url + '.json', true);
    request.onload = function () {
        if(this.status >= 200 && this.status < 400) {
            var data = JSON.parse(this.response);
            if (typeof callback === "function") {
                callback(data);
            }
            else {
                MyApp.Pets = [];
                for (var x in data) {
                    data[x].id = x;
                    MyApp.Pets.push(data[x]);
                }
                MyApp.WriteTable();
            }
        }
    };
    request.onerror = function () {console.log("Com Error on Get Pets")};
    request.send();
};

MyApp.GetPets();
