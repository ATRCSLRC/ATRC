// NOTE object below must be a valid JSON
window.Diesel = $.extend(true, window.Diesel, {
  "config": {
    "animationSet": "default",
    "layoutSet": "simple",
    "navigation": [
      {
        "title": "Diesel",
        "onExecute": "#Main",
            "icon": "Diesel"
      },
      {
        "title": "Tanques",
        "onExecute": "#Tanques",
        "icon": "tanques"
      },
      {
        "title": "Recarga de diesel",
        "onExecute": "#RecargaDiesel",
        "icon": "recargadiesel"
      },
      {
        "title": "Pedido de diesel",
        "onExecute": "#UnidadDiesel",
        "icon": "unidaddiesel"
      }
    ]
  }
});
