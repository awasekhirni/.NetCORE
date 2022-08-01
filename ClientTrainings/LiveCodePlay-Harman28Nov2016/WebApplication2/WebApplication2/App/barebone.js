var http = require('http');
http.createServer(function (req, res) {
    res.writeHead(200, { 'Content-type': 'text/html' });
    res.write("<h1>Hello Harman! Sorry Samsung!<h1>");
    res.end("We are logging out !!")
}).listen(9999, "127.0.0.1");
console.log("please look at localhost:9999");