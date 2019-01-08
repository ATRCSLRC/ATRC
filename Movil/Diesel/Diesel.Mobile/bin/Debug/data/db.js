/// <reference path="../js/jquery-3.1.0.min.js" />
/// <reference path="../js/knockout-3.4.0.js" />
/// <reference path="../js/dx.all.js" />

(function() {
    var isWinJS = "WinJS" in window;
    var endpointSelector = new DevExpress.EndpointSelector(Diesel.config.endpoints);
    var serviceConfig = $.extend(true, {}, Diesel.config.services, {
        db: {
            url: endpointSelector.urlFor("db"),

            // To enable JSONP support, uncomment the following line
            //jsonp: !isWinJS,

            // To allow cookies and HTTP authentication with CORS, uncomment the following line
            // withCredentials: true,

            errorHandler: handleServiceError
        }
    });

    function handleServiceError(error) {
        if(isWinJS) {
            try {
                new Windows.UI.Popups.MessageDialog(error.message).showAsync();
            } catch(e) {
                // Another dialog is shown
            }
        } else {
            alert(error.message);
        }
    }

    // Enable partial CORS support for IE < 10    
    $.support.cors = true;
    
    Diesel.db = new DevExpress.data.ODataContext(serviceConfig.db);

}());
