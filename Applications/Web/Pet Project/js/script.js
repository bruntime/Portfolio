$('#carousel').carousel();

var MyApp = {};
MyApp.Url = "https://runfirstapp.firebaseio.com/";
MyApp.Pets = [];
MyApp.Pet = function (name, type, picture) {
    this.name = name;
    this.type = type;
    this.picture = picture;
};

MyApp.UrlHelper = function () {
    var url = MyApp.Url;
    for (var x in arguments) {
        url += arguments[x] + "/";
    }
    return url + ".json";
};

MyApp.WriteTable = function () {
    var holder = "<table class='table table-striped table-bordered'>";
    holder += "<thead id=''>";
    holder += "<tr>";
    holder += "<th>" + 'Name' + "</th>";
    holder += "<th>" + 'Type' + "</th>";
    holder += "<th>" + 'Picture' + "</th>";
    holder += "<th>" + "</th>";
    holder += "</thead>";

    for (var i in MyApp.Pets) {
        holder += "<tr>";
        holder += "<td>" + MyApp.Pets[i].name + "</td>";
        holder += "<td>" + MyApp.Pets[i].type + "</td>";
        holder += "<td><img src=\"" + MyApp.Pets[i].picture + "\" id= 'petpic' ></td>";
        holder += "<td><div class = 'btn btn-warning' onclick = 'MyApp.ShowUpdatePet(" + i + ")'>Edit</div>" + "</td>";
        holder += "</tr>";
    }
    holder += "</table>";
    document.getElementById("TableOutput").innerHTML = holder;
};

MyApp.Ajax = function (Method, URL, SendingData, Success) {
    var request = new XMLHttpRequest();
    request.open(Method, URL);
    request.onload = function () {
        if (this.status >= 200 && this.status < 400) {
            var data = JSON.parse(this.response);
            Success(data);
        }
        else {
            alert("Error");
            console.log("Error: " + this.response + Method + " sent to " + URL + this.response);
        }
    };
    request.onerror = function () {
        alert("Comm Error");
        console.log("Comm Error on " + Method + " sent to " + URL);
    };
    if (SendingData) {
        SendingData = JSON.stringify(SendingData);
    }
    request.send(SendingData);
};

MyApp.Get = function (URL, Success) {
    MyApp.Ajax("GET", URL, null, Success);
};
MyApp.Post = function (URL, SendingData, Success) {
    MyApp.Ajax("POST", URL, SendingData, Success);
};
MyApp.Delete = function (URL, Success) {
    MyApp.Ajax("DELETE", URL, null, Success);
};
MyApp.Patch = function (URL, SendingData, Success) {
    MyApp.Ajax("PATCH", URL, SendingData, Success);
};

MyApp.AddPet = function () {
    var name = document.getElementById("Name").value;
    var type = document.getElementById("Type").value;
    var picture = document.getElementById("Picture").value;

    var pet = new MyApp.Pet(name, type, picture);

    var index = MyApp.Pets.push(pet) - 1;
    MyApp.WriteTable();
    MyApp.Post(MyApp.UrlHelper(), pet,
    function (key) {
        var holder = MyApp.Pets[index];
        holder.key = key.name;
        MyApp.WriteTable();
    });
};

MyApp.GetPets = function () {
    MyApp.Get(MyApp.UrlHelper(), function (allPets) {
        for (var t in allPets) {
            allPets[t].key = t;
            MyApp.Pets.push(allPets[t]);
        }
        MyApp.WriteTable();
    })
};

MyApp.DeletePet = function (id) {
    var id = document.getElementById("EditId").value;

    MyApp.Delete(MyApp.UrlHelper(MyApp.Pets[id].key),
        function () {
            MyApp.Pets.splice(id, 1);
            MyApp.WriteTable();
        }
    );
};

MyApp.ShowUpdatePet = function (id) {
    var pet = MyApp.Pets[id];
    document.getElementById("EditName").value = pet.name;
    document.getElementById("EditType").value = pet.type;
    document.getElementById("EditPicture").value = pet.picture;
    document.getElementById("EditId").value = id;
    document.getElementById("ModalTitle").innerHTML = "Editing: " + pet.name;
    $('#EditModal').modal();
};

MyApp.SaveUpdatePet = function () {

    var name = document.getElementById("EditName").value;
    var type = document.getElementById("EditType").value;
    var picture = document.getElementById("EditPicture").value;
    var id = document.getElementById("EditId").value;

    var pet = MyApp.Pets[id];

    MyApp.Pets[id].pet = name;
    MyApp.Pets[id].name = name;
    MyApp.Pets[id].type = type;
    MyApp.Pets[id].picture = picture;

    MyApp.Patch(MyApp.UrlHelper(MyApp.Pets[id].key), pet,
       function () {
           MyApp.Pets[id].pet = pet.name;
           MyApp.WriteTable();
       });
    $('#EditModal').modal('hide');
    MyApp.WriteTable();
};

MyApp.GetPets();
