Diesel.Login = function (params) {
    "use strict";

    var viewModel = {
//  Put the binding properties here
        galleryData: [
            "img/ATRC-LOGO.png"
        ],
        iniciarsesion: function () {

            var soapRequest;
            soapRequest = '<?xml version="1.0" encoding="utf-8"?>\
                <soap:Envelope xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema" xmlns:soap="http://schemas.xmlsoap.org/soap/envelope/">\
                  <soap:Body>\
                         <Checa xmlns="http://tempuri.org/">\
                         <Parameter>"1034|manual"</Parameter>\
                         </Checa>\
                  </soap:Body>\
                </soap:Envelope>';
            DevExpress.ui.dialog.alert(soapRequest);
            $.ajax({
                type: "POST",
                url: "http://localhost:62590/Consultas.asmx",
                //async: true,
                contentType: "text/xml",
                dataType: "xml",
                data: soapRequest,
                success: function (data) {
                    //var x = response.d.split("|");
                    DevExpress.ui.dialog.alert('entro');

                },
                error: function (jqXhr, textStatus, errorThrown) {
                    DevExpress.ui.dialog.alert(textStatus, errorThrown);
                }
            });
        }
    };

    return viewModel;
};