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
        Diesel.app.off("viewShown", onViewShown);
    }

    function onNavigatingBack(e) {
        if(e.isHardwareButton && !Diesel.app.canBack()) {
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

    var layoutSet = DevExpress.framework.html.layoutSets[Diesel.config.layoutSet],
        navigation = Diesel.config.navigation;

    function findController(name, controllers) {
        
        var result = $.grep(controllers, function (item, index) {
            return item.controller.name == name;
        });
        
        return result.length ? result[0].controller : null;
    }

    //var layoutSet = [];
    //layoutSet.push.apply(layoutSet, DevExpress.framework.html.layoutSets["slideout"]);
    //layoutSet.push.apply(layoutSet, DevExpress.framework.html.layoutSets["empty"]);

    Diesel.app = new DevExpress.framework.html.HtmlApplication({
        namespace: Diesel,
        layoutSet: layoutSet,
        animationSet: DevExpress.framework.html.animationSets[Diesel.config.animationSet],
        navigation: navigation,
        commandMapping: Diesel.config.commandMapping,
        navigateToRootViewMode: "keepHistory",
        useViewTitleAsBackText: true
    });

    $(window).on("unload", function() {
        Diesel.app.saveState();
    });

    Diesel.app.router.register(":view/:id", { view: startupView, id: undefined });
    Diesel.app.on("resolveLayoutController", function (args) {
        
        if (args.viewInfo.viewName == 'Login') {
            args.layoutController = findController('empty', args.availableLayoutControllers);
        }
    });
    Diesel.app.on("viewShown", onViewShown);
    Diesel.app.on("navigatingBack", onNavigatingBack);
    Diesel.app.navigate();
});