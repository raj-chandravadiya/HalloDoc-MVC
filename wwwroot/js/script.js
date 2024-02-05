function password() {
    var x = document.getElementById("pass_input");
    var y = document.getElementById("eye_btn");


    if (x.type === "password") {
        x.type = "text";
        y.src = "/Images/SRS Screen Shorts/eye-password-hide-svgrepo-com.svg";

    } else {
        x.type = "password";
        y.src = "/Images/SRS Screen Shorts/password_icon.svg";

    }
}