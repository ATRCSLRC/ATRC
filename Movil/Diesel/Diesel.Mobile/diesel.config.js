// NOTE object below must be a valid JSON
window.Diesel = $.extend(true, window.Diesel, {
  "config": {
    //"layoutSet": "slideout",
    "animationSet": "default",
    "navigation": [
      {
        "title": "About",
        "onExecute": "#About",
        "icon": "info"
      },
      {
        "title": "Login",
        "onExecute": "#Login",
        "icon": "login"
      }
    ]
  }
});
