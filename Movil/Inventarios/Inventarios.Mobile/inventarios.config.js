// NOTE object below must be a valid JSON
window.Inventarios = $.extend(true, window.Inventarios, {
  "config": {
    "animationSet": "default",
    "layoutSet": "simple",
    "navigation": [
      {
        "title": "Extintores",
        "onExecute": "#Extintores",
        "icon": "extintores"
      },
      {
        "title": "Baterias",
        "onExecute": "#Baterias",
        "icon": "baterias"
      },
      {
          "title": "Cerrar sesion",
        "onExecute": "#LogOut",
        "icon": "logout"
      }
    ]
  }
});
