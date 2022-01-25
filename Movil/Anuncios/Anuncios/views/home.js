Anuncios.home = function (params) {
    var Lugar = Number(params.id);  
    "use strict";

    $(document).ready(function () {
        setInterval(UpdateTime, 60000);
    });
    function UpdateTime(s, e) {
        // viewModel.gallery.dataSource = viewModel.dSource;
        viewModel.dSource.load();
        //viewModel.gallery.repaint();
        //$("#galleryContainer").dxGallery('instance').repaint();
        //alert('d');
    }

    var viewModel = {
//  Put the binding properties here
        
        viewShown: function () {
           // UpdateGallery();
        },
        onInicial: function (e) {
            viewModel.gallery = e.component;
        },
        dSource: new DevExpress.data.DataSource({
            load: function (loadOptions) {

                var deferred = $.Deferred();
                $.ajax({
                    type: "POST",
                    url: ObtenerUrl() + "/ObtenerAnuncios",
                    contentType: "application/json; charset=utf-8",
                    dataType: "json",
                    data: '{Lugar:' + Lugar +  '}',
                    success: function (result) {
                        deferred.resolve(result.d);

                    },
                    error: function (jqXhr, textStatus, errorThrown) {
                        DevExpress.ui.notify(errorThrown, 'error', 4000);
                    }
                });
                return deferred.promise();
            }
            
        }),
        OnActualizar: function () {
            
        }


    };

    return viewModel;
};