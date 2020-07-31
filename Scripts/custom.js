// MASK PHONE NUMBERS
// ==============

$(document).ready(function () {
    $('.phonenum').blur(function () {
        var val = $(this).val();
        var newvalue = val.replace(/(\d{3})(\d{3})(\d{4})/, "($1) $2-$3");
        $(this).val(newvalue);
    });
});

// MASK DATE
// ==============

$(document).ready(function () {
    $('.date').blur(function () {
        var val = $(this).val();
        var newvalue = val.replace(/(\d{2})(\d{2})(\d{4})/, "$1/$2/$3");
        $(this).val(newvalue);
    });
});

// ONLY NUMBERS ALLOWED
// ==============
$(document).ready(function () {
    $(".onlynumbers").bind("keypress", function (e) {
        var keyCode = e.which ? e.which : e.keyCode

        if (!(keyCode >= 48 && keyCode <= 57)) {
            return false;
        }
    });
});

// COPY INPUT FROM PHYSICAL TO MAILING
// ==============
$(document).ready(function () {
    $('#cbxfilladdress').click(function () {

        // STREET
        $('#tbxMailingAddressStreet').val($('#tbxPhysicalAddressStreet').val());

        // CITY
        $('#tbxMailingAddressCity').val($('#tbxPhysicalAddressCity').val());

        // STATE
        $('#ddlMailingAddressState').val($('#ddlPhysicalAddressState').val());

        // ZIPCODE
        $('#tbxMailingAddressZipcode').val($('#tbxPhysicalAddressZipcode').val());
    });
});

