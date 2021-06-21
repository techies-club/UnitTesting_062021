//REST API demo in Node.js
var express = require("express"); // requre the express framework
var app = express();
var fs = require("fs"); //require file system object

//for CORS issue
app.use((req, res, next) => {
    res.header('Access-Control-Allow-Origin', '*');
    next();
  });

// Endpoint to Get a list of users
app.get("/getUsers", function (req, res) {
  fs.readFile(__dirname + "/data/" + "user.json", "utf8", function (err, data) {
    console.log(data);
    res.end(data); // you can also use res.send()
  });
});

app.get("/getUsers/:emailid", function (req, res) {
  fs.readFile(__dirname + "/data/" + "user.json", "utf8", function (err, data) {
    console.log(data);
    var users = JSON.parse(data);
    var user = getUserEmail(users, req.params.emailid);
    console.log(user);
    res.send(user);
  });
});

function getUserEmail(data, email) {
  return data.filter(function (data) {
    return data.email == email;
  });
}

// Create a server to listen at port 8088 for server 127.0.0.1 (optional of localhost)
var server = app.listen(8088, "127.0.0.1", function () {//make sur ethe port is different than vue app (8080). And 8081 thrown permission error
  console.log(server.address());
  var host = server.address().address;
  var port = server.address().port;
  console.log("REST API demo app listening at http://%s:%s", host, port);
});
