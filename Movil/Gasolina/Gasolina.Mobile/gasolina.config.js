// NOTE object below must be a valid JSON
window.Gasolina = $.extend(true, window.Gasolina, {
    "config": {
        "layoutSet": "simple",
        "animationSet": "default",
        "navigation": [
            {
                "title": "Gasolina",
                "onExecute": "#Main",
                "icon": "Gasolina"
            },
            {
                "title": "Tanques",
                "onExecute": "#Tanques",
                "icon": "tanques"
            },
            {
                "title": "Recarga de gasolina",
                "onExecute": "#RecargaGasolina",
                "icon": "recargaGasolina"
            },
            {
                "title": "Pedido de gasolina",
                "onExecute": "#UnidadGasolina",
                "icon": "unidadGasolina"
            },
            {
                "title": "Medidores",
                "onExecute": "#Medidores",
                "icon": "medidores"
            },
            {
                "title": "Cerrar sesion",
                "onExecute": "#LogOut",
                "icon": "logout"
            }
        ]
    }
});
