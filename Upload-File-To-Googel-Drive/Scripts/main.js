$(document).ready(function () {

    // client id of the project

    var clientId = "159820900757-ogk1k4jlq4btl5alt61edmrroei4bk2r.apps.googleusercontent.com";

    // redirect_uri of the project

    var redirect_uri = "https://localhost:44345/home/UploadFileToDrive";

    // scope of the project

    var scope = "https://www.googleapis.com/auth/drive";

    // the url to which the user is redirected to

    var url = "https://localhost:44345";


    // this is event click listener for the button

    $("#login").click(function () {

        // this is the method which will be invoked it takes four parameters

        signIn(clientId, redirect_uri, scope, url);

    });

    function signIn(clientId, redirect_uri, scope, url) {

        // the actual url to which the user is redirected to 

        url = "https://accounts.google.com/o/oauth2/v2/auth?redirect_uri=" + redirect_uri
            + "&prompt=consent&response_type=code&client_id=" + clientId + "&scope=" + scope
            + "&access_type=offline";

        // this line makes the user redirected to the url

        window.location = url;




    }



});