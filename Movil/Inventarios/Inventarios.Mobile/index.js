$(function() {
    var startupView = "Login";

    // Uncomment the line below to disable platform-specific look and feel and to use the Generic theme for all devices
    // DevExpress.devices.current({ platform: "generic" });

    if(DevExpress.devices.real().platform === "win") {
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
        Inventarios.app.off("viewShown", onViewShown);
    }

    function onNavigatingBack(e) {
        if(e.isHardwareButton && !Inventarios.app.canBack()) {
            e.cancel = true;
            exitApp();
        }
    }

    function exitApp() {
        switch (DevExpress.devices.real().platform) {
            case "android":
                navigator.app.exitApp();
                break;
            case "win":
                MSApp.terminateApp('');
                break;
        }
    }

    //var layoutSet = DevExpress.framework.html.layoutSets[Inventarios.config.layoutSet],
       var navigation = Inventarios.config.navigation;

    function findController(name, controllers) {

        var result = $.grep(controllers, function (item, index) {
            return item.controller.name == name;
        });

        return result.length ? result[0].controller : null;
    }

    var layoutSet = [];
    layoutSet.push.apply(layoutSet, DevExpress.framework.html.layoutSets["slideout"]);
    layoutSet.push.apply(layoutSet, DevExpress.framework.html.layoutSets["empty"]);

    Inventarios.app = new DevExpress.framework.html.HtmlApplication({
        namespace: Inventarios,
        layoutSet: layoutSet,
        animationSet: DevExpress.framework.html.animationSets[Inventarios.config.animationSet],
        navigation: navigation,
        commandMapping: Inventarios.config.commandMapping,
        navigateToRootViewMode: "keepHistory",
        useViewTitleAsBackText: true
    });

    $(window).on("unload", function() {
        Inventarios.app.saveState();
    });

    Inventarios.app.router.register(":view/:id", { view: startupView, id: undefined });
    Inventarios.app.on("resolveLayoutController", function (args) {

        if (args.viewInfo.viewName === 'Login') {
            args.layoutController = findController('empty', args.availableLayoutControllers);
        }
    });
    Inventarios.app.on("viewShown", onViewShown);
    Inventarios.app.on("navigatingBack", onNavigatingBack);
    Inventarios.app.navigate();
});