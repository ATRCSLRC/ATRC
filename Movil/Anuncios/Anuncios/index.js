window.Anuncios = window.Anuncios || {};

$(function() {
    // Uncomment the line below to disable platform-specific look and feel and to use the Generic theme for all devices
    // DevExpress.devices.current({ platform: "generic" });
    // To customize the Generic theme, use the DevExtreme Theme Builder (http://js.devexpress.com/ThemeBuilder)
    // For details on how to use themes and the Theme Builder, refer to the http://js.devexpress.com/Documentation/Guide/#themes article

    if (DevExpress.devices.real().platform === "win") {
        $("body").css("background-color", "#000");
    }

    var isDeviceReady = false,
        isViewShown = false;

    function hideSplashScreen() {
        if(isDeviceReady && isViewShown) {
            navigator.splashscreen.hide();
        }
    }

    if(document.addEventListener) {
        document.addEventListener("deviceready", function () {
            isDeviceReady = true;
            hideSplashScreen();
            document.addEventListener("backbutton", function () {
                DevExpress.processHardwareBackButton();
            }, false);
        }, false);
    }

    function onViewShown() {
        isViewShown = true;
        hideSplashScreen();
        Anuncios.app.off("viewShown", onViewShown);
    }

    function onNavigatingBack(e) {
        if(e.isHardwareButton && !Anuncios.app.canBack()) {
            e.cancel = true;
            exitApp();
        }
    }

    function exitApp() {
        switch(DevExpress.devices.real().platform) {
            case "android":
                navigator.app.exitApp();
                break;
            case "win":
                MSApp.terminateApp('');
                break;
        }

    }

    Anuncios.app = new DevExpress.framework.html.HtmlApplication({
        namespace: Anuncios,
        layoutSet: DevExpress.framework.html.layoutSets[Anuncios.config.layoutSet],
        navigation: Anuncios.config.navigation,
        commandMapping: Anuncios.config.commandMapping
    });
    Anuncios.app.router.register(":view/:id", { view: "LugarPublicacion", id: undefined });
    Anuncios.app.on("viewShown", onViewShown);
    Anuncios.app.on("navigatingBack", onNavigatingBack);
    Anuncios.app.navigate();
});
