
$('#btnBasicInfo').on('click', function () {
    $("#BasicInfo").valid();
});


function UpdateModal() {
    
    var reDirect = "/Home/ViewDashboard";
    swal({
        title: "Successful!",
        text: "Profile Updated Successfully!",
        icon: "success",
        buttons: true
        //function() {
        //    window.location.href = 'http://localhost:50176/Home/ViewDashboard';
        //}
    }).then(val => {
        if (val) {
            window.location.href = "/CorporatePartner/Dashboard";
        }
    });
}

function UpdateModalSME() {

    var reDirect = "/Home/ViewDashboard";
    swal({
        title: "Successful!",
        text: "Profile Updated Successfully!",
        icon: "success",
        buttons: true
        //function() {
        //    window.location.href = 'http://localhost:50176/Home/ViewDashboard';
        //}
    }).then(val => {
        if (val) {
            window.location.href = "/SME/Dashboard";
        }
    });
}

function ConfirmLogout() {
    swal("Are you sure you want to Logout?", {
        buttons: ["No", "Yes"]
    });
}

$(document).ready(function () {
    //$("#modalBasicInfo").on('submit', function () {
    //    console.log("Loading...");
    //});
    //console.log("ksadf");
    //$('#example').DataTable({
    //    dom: 'Bfrtip',
    //    buttons: [
    //        'copy', 'csv', 'excel', 'pdf', 'print'
    //    ],
    //    pageLength: 4,
    //    lengthMenu: [[4, 8, 12], [4, 8, 12]],
    //    lengthChange: false

    //});
    //$('#example1').DataTable({
    //    dom: 'Bfrtip',
    //    buttons: [
    //        'copy', 'csv', 'excel', 'pdf', 'print'
    //    ],
    //    pageLength: 4,
    //    lengthMenu: [[4, 8, 12], [4, 8, 12]],
    //    paging: false

    //});

    //$('input[name="dates"]').daterangepicker();
});

function UpdatedKYC() {
    ConfirmIdUpdate();
    var reDirect = "/Home/ViewDashboard";
    swal({
        title: "Thank you for updating your information",
        text: "Your KYC status will be effected after validation",
        icon: "success",
        buttons: [ "Back", "Ok"]
        //function() {
        //    window.location.href = 'http://localhost:50176/Home/ViewDashboard';
        //}
    }).then(val => {
        if (val) {
            window.location.href = "/CorporatePartner/Dashboard";
        } else {
            //ConfirmIdUpdate();
            window.location.href = "/CorporatePartner/IdInfo";
        }
    });
}

function CreateCustomer() {
    swal({
        title: "Customer account created successfully",
        text: "",
        icon: "success",
        buttons: {
            cancel: false,
            confirm: true
        }
        //function() {
        //    window.location.href = 'http://localhost:50176/Home/ViewDashboard';
        //}
    }).then(val => {
        if (val) {
            window.location.href = "/CorporatePartner/AutoMoovers";
        }
        //} else {
        //    //ConfirmIdUpdate();
        //    window.location.href = "/CorporatePartner/IdInfo";
        //}
    });
}

function changePassword() {
    swal({
        title: "Password Changed successfully.",
        //text: "Your KYC status will be effected after validation",
        icon: "success"
        //buttons: ["Back", "Ok"]
        //function() {
        //    window.location.href = 'http://localhost:50176/Home/ViewDashboard';
        //}
    }).then(val => {
        if (val) {
            window.location.href = "/CorporatePartner/Dashboard";
        } else {
            window.location.href = "/CorporatePartner/IdInfo";
        }
    });
}

function UpdatedProfile() {
    swal({
        title: "Profile Update Successful",
        icon: "success",
        buttons: ["Back", "Ok"]
    }).then(val => {
        if (val) {
            window.location.href = "/CorporatePartner/Profile";
        } else {
            //window.location.href = "/CorporatePartner/IdInfo";
        }
    });
}

function ConfirmIdUpdate() {
    //console.log("entered");
    var v = $('#drpTypeOfIdent').val();
    console.log(v);
    document.getElementById("IdType").setAttribute("value", v);
    //console.log("entered");
    var w = $('#modalCardIdNumber').val();
    document.getElementById("CardIdNumber").setAttribute("value", w);
    console.log(w);
    var x = $('#modalCardCountry').val();
    document.getElementById("drpCountryOfIssue").setAttribute("value", x);
    console.log(x);
    var y = $('#modalCardIdExpiryDate').val();
    document.getElementById("CardIdExpiryDate").setAttribute("value", y);
    console.log(y);
    //var z = $('#companyWebsite').val();
    //document.getElementById("companyWebsiteMain").setAttribute("value", z.toString());

    //var x = $('#businessEmail').val();
    //document.getElementById("businessEmailMain").setAttribute("value", x);

    //var y = $('#directorName').val();
    //document.getElementById("directorNameMain").setAttribute("value", y);

    //var z = $('#companyWebsite').val();
    //document.getElementById("companyWebsiteMain").setAttribute("value", z.toString());

    ////toastr["success"]("Profile Updated. Successfully!")
    //if (w.length > 9) {

    //    if (validate()) {
    //        $('#profileValdidationMsg1').html('').css('color', 'red');
    //        if (v !== '' && w !== '' && x !== '' && y !== '' && z !== '') {
    //            $('#message').html('').css('color', 'red');
    //            toastr["success"]("Profile Updated. Successfully!");
    //        } else {
    //            $('#message').html('All fields are required').css('color', 'red');
    //        }
    //    } else {

    //    }

    //} else {
    //    $('#profileValdidationMsg1').html('Phone number length invalid').css('color', 'red');
    //}
}


//function validateEmail(email) {
//    var re = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
//    return re.test(email);
//}

//function ConfirmLogout1() {

//    var v = $('#businessAddress').val();
//    document.getElementById("businessAddressMain").setAttribute("value", v);

//    var w = $('#phoneNo').val();
//    document.getElementById("phoneNoMain").setAttribute("value", w);

//    var x = $('#businessEmail').val();
//    document.getElementById("businessEmailMain").setAttribute("value", x);

//    var y = $('#directorName').val();
//    document.getElementById("directorNameMain").setAttribute("value", y);

//    var z = $('#companyWebsite').val();
//    document.getElementById("companyWebsiteMain").setAttribute("value", z.toString());

//    //toastr["success"]("Profile Updated. Successfully!")
//    if (w.length > 9) {
//        $('#profileValdidationMsg1').html('').css('color', 'red');
//        if (v !== '' && w !== '' && x !== '' && y !== '' && z !== '') {
//            $('#message').html('').css('color', 'red');
//            toastr["success"]("Profile Updated. Successfully!");
//        } else {
//            $('#message').html('All fields are required').css('color', 'red');
//        }
//    } else {
//        $('#profileValdidationMsg1').html('Phone number length invalid').css('color', 'red').fadeIn(1000);
//    }
//}

//function validate() {
//    var $result = $("#profileValdidationMsg2");
//    var email = $("#businessEmail").val();
//    $result.text("");

//    if (validateEmail(email)) {
//        $result.text("Email is valid");
//        $result.css("color", "green");
//    } else {
//        $result.text("Email is invalid");
//        $result.css("color", "red");
//    }
//    return false;
//}

