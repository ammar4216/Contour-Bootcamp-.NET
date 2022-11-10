$(document).ready(function () {
    // Validate Username
    $('#usercheck').hide();
    let usernameError = true;
    $('#usernames').keyup(function (e) { 
        usernameValidation();
    }); 

    function usernameValidation(){
        let usernameValue = $('#usernames').val();
        if(usernameValue.length == ""){
            $('#usercheck').show();
            usernameError = false;
            return false;
        } else if(usernameValue.length < 3 || usernameValue.length > 10 ){
            $('#usercheck').show();
            $('#usercheck').html("**Username length must between 3 and 10");
            usernameError = false;
            return false;
        } else{
            $('#usercheck').hide();
        }
    }

    // Validate Email
    const emailVal = document.getElementById('email');
    let emailError = true;
    function ValidateEmail(){
        let regex = /^([_\-\.0-9a-zA-Z]+)@([_\-\.0-9a-zA-Z]+)\.([a-zA-Z]){2,7}$/;
        let emailValue = emailVal.value;

        if(regex.test(emailValue)){
            emailVal.classList.remove('is-invalid');
            emailError = true;
        } else{
            emailVal.classList.add('is-invalid');
            emailError = false;
        }
    }

    emailVal.addEventListener("blur", ValidateEmail);

    // Validate Password
    $('#passcheck').hide();
    let passwordError = true;
    $('#password').keyup(function(){
        passwordValidate();
    });

    function passwordValidate(){
        let passwordVal = $('#password').val();
        if(passwordVal.length == ""){
            $('#passcheck').show();
            passwordError = false;
            return false;
        }
    }
});