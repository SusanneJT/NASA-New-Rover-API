
function showInfo(type) {

    if (document.getElementById('FattyId').checked) 
        getRover(type, "Fatty");
    else if (document.getElementById('LazyId').checked) 
        getRover(type, "Lazy")
    else if (document.getElementById('SpeedyId').checked) 
        getRover(type, "Speedy")
    else
        document.getElementById('result').innerHTML = "Choose a rover!";
}

function getRover(type, name) {

    var apiUrl = "https://localhost:44308/api/rover/" + name +"/" + type;

    fetch(apiUrl)
        .then((resp) => resp.json())
        .then(function (rover) {

            if (type === "speed") 
                document.getElementById('result').innerHTML = rover.name + " has a speed of " + rover.speed + " km/h";
            
            else if (type === "weight") 
                document.getElementById('result').innerHTML = rover.name + " weighs " + rover.weight + " kg";
            
            else if (type === "wheels") 
                document.getElementById('result').innerHTML = rover.name + " has " + rover.wheels + " wheels";
            
            else if (type === "launchdate") 
                document.getElementById('result').innerHTML = rover.name + " is getting launched " + rover.launchDate;
        })
        .catch(function (error) {
            console.log(error);
        });
}

