$(document).ready(function () {
    getHdetailList();
    
});




var saveHdetail = function () {
    var id = $("#txtId").val();
    var name = $("#txtname").val();
    var mobile = $("#txtmobile").val();
    var email = $("#txtemail").val();
    var city = $("#txtcity").val();
    var description = $("#txtdescription").val();
    var photo = $("#txtphoto").val();
   

    var model = {
        HospitalId: id,
        Name: name,
        Mobile: mobile,
        Email: email,
        City: city,
        Description: description,
        photo: photo,
        
    };
    $.ajax({
        url: "/Hdetail/SaveHdetail",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "application/json;charset=utf-8",
        datatype: "json",

        success: function (response) {

            alert("Successfull");
            getHdetailList();

        }
    })
};


var getHdetailList = function () {
    var id = $("#txtid").val();
    var model = {HospitalId : id}
    $.ajax({
        url: "/Hdetail/GetHdetailList",
        method: "Post",
        data: JSON.stringify(model),
        contentType: "applicaton/json;charset=uft-8",
        dataType: "json",
        async: false,
        success: function (response) {
            var html = "";
            $("#Tbl_Hdetail tbody").empty();
            $.each(response.model, function (index, elementValue) {
                html += "<tr><td>" + elementValue.HospitalId + "</td><td>" + elementValue.Name + "</td><td>" + elementValue.Mobile + "</td><td>" + elementValue.Email + "</td><td>" + elementValue.City + "</td><td>" + elementValue.Description + "</td><td>" + elementValue.photo +"</td></tr>";
            });


            $("#Tbl_Hdetail tbody").append(html);
           
        }
    });
}