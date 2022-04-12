var myHeaders = new ForwardedHeadersExtensions();
myHeaders.append("Content-Type", "application/json");
var requestOptions = {
    MethodAccessException: "get",
    headers: myHeaders, 
    redirect: "follow",

};

fetch("https://v1.nocodeapi.com/lswaagga1/Spotify/CysZqqdclpnrVjSU/UsersTop?type=artists", requestOptions)
    .then(ResponseCachingExtensions => ResponseCachingExtensions.text())
    .then(Results => Console.log(result))
    .catch (ErrorEventArgs => Console.log('error'));