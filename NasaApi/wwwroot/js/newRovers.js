


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

            if (type === "speed") {
                var text = rover.name + " has a speed of " + rover.speed + " km/h";
                document.getElementById('result').innerHTML = text;
            }
            else if (type === "weight") {
                var text = rover.name + " weighs " + rover.weight + " kg";
                document.getElementById('result').innerHTML = text;
            }
            else if (type === "wheels") {
                var text = rover.name + " has " + rover.wheels + " wheels";
                document.getElementById('result').innerHTML = text;
            }
            else if (type === "launchdate") {
                var text = rover.name + " is getting launched " + rover.launchDate;
                document.getElementById('result').innerHTML = text;
            }
        })
        .catch(function (error) {
            console.log(error);
        });
}








