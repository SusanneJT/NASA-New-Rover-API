
function inputDate(){
  let roverOnMars = document.getElementById("rover").value;
  let dateOnMars = document.getElementById("date").value;
  //let dateOnMars = "2016-05-29"; // här ska datumet vara

  fetch("https://api.nasa.gov/mars-photos/api/v1/rovers/" + roverOnMars + "/photos?earth_date=" + dateOnMars + "&api_key=0aQk19tdETuiM8F0sa5NCmVwNGTHILMnPWp9lO0j")
  .then(function(response){return response.json()})
  .then(function(response) {
      
      rover = response;
      
      console.log(response);

      document.getElementById("show-rover-name").innerHTML = roverOnMars;
      
      if(rover.photos.length <= 0){
        document.getElementById("rover-image").innerHTML = "No image!";
      }else {
        
      let caruselLoop = "";
      let x = rover.photos.length;
        
      if (x > 9){
        x = 9;
      }
      
      for (i = 0; i < x; i++){
          console.log(rover.photos, i, rover.photos.length)
          //// här ska koden fär karusellen ligga

          caruselLoop += "<img src='" + rover.photos[i].img_src + "'>";
          document.getElementById("rover-image").innerHTML = caruselLoop;
      }
    }
  })

  .catch(function(response) {

    console.log('Error! Please try again', response);
  });
}