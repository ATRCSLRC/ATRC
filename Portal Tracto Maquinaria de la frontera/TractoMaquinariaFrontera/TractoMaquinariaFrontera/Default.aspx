<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TractoMaquinariaFrontera._Default" %>

<!DOCTYPE html>
<html lang="en">
<head runat="server">
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1">
    <title>TractoMaquinarias de la frontera</title>

    <link href='http://fonts.googleapis.com/css?family=Open+Sans:400,800italic,800,700italic,700,600italic,400italic,600,300italic,300|Oswald:400,300,700' rel='stylesheet' type='text/css'>
    <!-- Bootstrap -->
    <link href="css/bootstrap.min.css" rel="stylesheet">
    <link href="css/font-awesome.min.css" rel="stylesheet">


    <link href="css/owl.carousel.css" rel="stylesheet">
    <link href="css/owl.theme.css" rel="stylesheet">
    <link href="css/owl.transitions.css" rel="stylesheet">
    <link href="css/lightbox/css/lightbox.css" rel="stylesheet">
    <link href="css/style.css" rel="stylesheet">
</head>
<body data-spy="scroll" data-target=".main-nav">
    <header class="st-navbar">
        <nav class="navbar navbar-default navbar-fixed-top clearfix" role="navigation">
            <div class="container">
                <!-- Brand and toggle get grouped for better mobile display -->
                <div class="navbar-header">
                    <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#sept-main-nav">
                        <span class="sr-only">Toggle navigation</span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                        <span class="icon-bar"></span>
                    </button>
                    <a class="navbar-brand" href="#">
                        <img src="photos/logoTracto.png" alt="" class="img-responsive"></a>
                </div>

                <!-- Collect the nav links, forms, and other content for toggling -->
                <div class="collapse navbar-collapse main-nav" id="sept-main-nav">
                    <ul class="nav navbar-nav navbar-right">
                        <li class="active"><a href="#home">Inicio</a></li>
                        <li><a href="#about">Nosotros</a></li>
                        <li><a href="#service">Servicios</a></li>
                        <li><a href="#portfolio">Inventario</a></li>
                        <li><a href="#PreguntasFrecuentes">Preguntas frecuentes</a></li>
                        <li><a href="#contact">Contacto</a></li>
                    </ul>
                </div>
                <!-- /.navbar-collapse -->
            </div>
        </nav>
    </header>

    <section class="home" id="home" data-stellar-background-ratio="0.4">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="st-home-unit">
                        <div class="hero-txt">
                            <p class="hero-work">Compra - Venta - Translados</p>
                            <h1 class="hero-title">TractoMaquinarias de la frontera</h1>
                            <!-- <p class="hero-sub-title">We Provide Hight Quality Bootstrap Template</p> -->
                            <!-- <a href="#" class="btn btn-default btn-lg left-btn">Purchase Now</a> -->
                            <%--<a href="#" class="btn btn-main btn-lg">Find Out More</a>--%>
                        </div>

                    </div>
                </div>
            </div>
        </div>
        <div class="mouse-icon">
            <div class="wheel"></div>
        </div>
    </section>

    <section class="about" id="about">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title st-center">
                        <h3>Bienvenidos a</h3>
                        <p>TractoMaquinarias de la frontera</p>
                    </div>
                    <div class="row mb90">
                        <div class="col-md-6">
                            <p>Somos una empresa especializada en venta - compra de equipos de maquinaria usuada, que garantiza el correcto funcionamiento de todos sus equipos para que los clientes tengan la confianza de contactarnos. Además realizamos envíos seguros a toda la república mexicana, garantizando una emtraga óptima del equipo. TractoMaquinaria de la frontera cuenta con años de experiencia en la industria de la maquinaria que nos respalda.</p>
                        </div>
                        <div class="col-md-6">
                            <img src="photos/about.jpg" alt="" class="img-responsive">
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="funfacts" data-stellar-background-ratio="0.4">
        <div class="container">
            <div class="row">
                <div class="col-md-3">
                    <div class="funfact">
                        <div class="st-funfact-icon"><i class="fa fa-briefcase"></i></div>
                        <div class="st-funfact-counter"><span class="st-ff-count" data-from="0" data-to="8964" data-runit="1">0</span>+</div>
                        <strong class="funfact-title">Compras concretadas</strong>
                    </div>
                    <!-- .funfact -->
                </div>
                <div class="col-md-3">
                    <div class="funfact">
                        <div class="st-funfact-icon"><i class="fa fa-clock-o"></i></div>
                        <div class="st-funfact-counter"><span class="st-ff-count" data-from="0" data-to="8902" data-runit="1">0</span>+</div>
                        <strong class="funfact-title">Ventas concretadas</strong>
                    </div>
                    <!-- .funfact -->
                </div>
                <div class="col-md-3">
                    <div class="funfact">
                        <div class="st-funfact-icon"><i class="fa fa-send"></i></div>
                        <div class="st-funfact-counter"><span class="st-ff-count" data-from="0" data-to="6214" data-runit="1">0</span>+</div>
                        <strong class="funfact-title">Translados entregados</strong>
                    </div>
                    <!-- .funfact -->
                </div>
                <div class="col-md-3">
                    <div class="funfact">
                        <div class="st-funfact-icon"><i class="fa fa-magic"></i></div>
                        <div class="st-funfact-counter"><span class="st-ff-count" data-from="0" data-to="3647" data-runit="1">0</span>+</div>
                        <strong class="funfact-title">Clientes satisfechos</strong>
                    </div>
                    <!-- .funfact -->
                </div>
            </div>
        </div>
    </section>

    <section class="service" id="service">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title st-center">
                        <h3>Conoce nuestros</h3>
                        <p>diversos servicios</p>
                    </div>
                    <div class="row">
                        <div class="col-md-4">
                            <div class="st-feature">
                                <div class="st-feature-icon"><i class="fa fa-money"></i></div>
                                <strong class="st-feature-title">Compra</strong>
                                <p>Se compra todo tipo de maquinaria y transportes.</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="st-feature">
                                <div class="st-feature-icon"><i class="fa fa-shopping-cart"></i></div>
                                <strong class="st-feature-title">Venta</strong>
                                <p>En nuestro inventario podras encontrar camiones escolares, grúas, motoconformadoras, retroexcavadoras, camiones de volteo, excavadoras y más.</p>
                            </div>
                        </div>
                        <div class="col-md-4">
                            <div class="st-feature">
                                <div class="st-feature-icon"><i class="fa fa-road"></i></div>
                                <strong class="st-feature-title">Translados</strong>
                                <p>Brindamos la oportunidad de entregar cualquier equipo hasta la puerta de su negocio. Rápido, seguro y confiable.</p>
                            </div>
                        </div>
                        <%--<div class="col-md-3">
                            <div class="st-feature">
                                <div class="st-feature-icon"><i class="fa fa-life-ring"></i></div>
                                <strong class="st-feature-title">Option Panel</strong>
                                <p>Pro adiuvet, honesto foris liberiusque statuat theseo scribimus mererer percurri geometria.</p>
                            </div>
                        </div>--%>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="call-2-acction" data-stellar-background-ratio="0.4">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <%-- <div class="section-title st-center">
                        <p>Detalles</p>
                    </div>--%>
                </div>
            </div>
        </div>
    </section>


    <section class="portfolio" id="portfolio">
        <div class="container-fluid ">
            <div class="row">
                <div class="col-md-12 no-padding ">
                    <div class="section-title st-center">
                        <h3>Conoce nuestros</h3>
                        <p>diversos equipos</p>
                    </div>
                    <div class="filter mb40">
                        <form id="filter">
                            <fieldset class="group">
                                <%--<label class="btn btn-default btn-main">
                                    <input type="radio" name="filter" value="camiones" checked="checked">Todo</label>--%>
                                <label class="btn btn-default btn-main">
                                    <input type="radio" name="filter" value="camiones" checked="checked">Camiones</label>
                                <label class="btn btn-default">
                                    <input type="radio" name="filter" value="carros">Carros</label>
                                <label class="btn btn-default">
                                    <input type="radio" name="filter" value="maquinaria">Maquinarias</label>
                            </fieldset>
                        </form>
                        <!-- #filter -->
                    </div>
                    <!-- .filter .mb40 -->

                    <div class="grid">
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-269/IMG_7557.JPG" data-lightbox="C-269" ><img src="photos/Camiones/C-269/IMG_7557.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2004 Nacional</span><br/>Internacional</h2>
                                <p>Motor: Navistar<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 60 pasajeros<br />Unidad: C-269</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-269/IMG_7558.JPG" data-lightbox="C-269" title="Motor: Navistar, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 60 pasajeros, unidad: C-269"></a>
                            <a href="photos/Camiones/C-269/IMG_7559.JPG" data-lightbox="C-269" title="Motor: Navistar, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 60 pasajeros, unidad: C-269"></a>
                            <a href="photos/Camiones/C-269/IMG_7560.JPG" data-lightbox="C-269" title="Motor: Navistar, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 60 pasajeros, unidad: C-269"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-288/IMG_6502.JPG" data-lightbox="C-288" ><img src="photos/Camiones/C-288/IMG_6502.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Caterpillar<br/>Transmición: Automático<br/>Frenos: Hidráulico<br/>Suspeción: Muelles<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-288</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-288/IMG_6503.JPG" data-lightbox="C-288" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulico, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-288"></a>
                            <a href="photos/Camiones/C-288/IMG_6504.JPG" data-lightbox="C-288" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulico, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-288"></a>
                            <a href="photos/Camiones/C-288/IMG_6505.JPG" data-lightbox="C-288" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulico, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-288"></a>
                            <a href="photos/Camiones/C-288/IMG_6506.JPG" data-lightbox="C-288" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulico, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-288"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-290/IMG_8240.JPG" data-lightbox="C-290" ><img src="photos/Camiones/C-290/IMG_8240.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-290</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-290/IMG_8241.JPG" data-lightbox="C-290" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-290"></a>
                            <a href="photos/Camiones/C-290/IMG_8242.JPG" data-lightbox="C-290" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-290"></a>
                            <a href="photos/Camiones/C-290/IMG_8243.JPG" data-lightbox="C-290" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-290"></a>
                            <a href="photos/Camiones/C-290/IMG_8244.JPG" data-lightbox="C-290" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-290"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-291/IMG_6488.JPG" data-lightbox="C-291" ><img src="photos/Camiones/C-291/IMG_6488.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-291</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-291/IMG_6490.JPG" data-lightbox="C-291" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-291"></a>
                            <a href="photos/Camiones/C-291/IMG_6491.JPG" data-lightbox="C-291" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-291"></a>
                            <a href="photos/Camiones/C-291/IMG_6492.JPG" data-lightbox="C-291" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-291"></a>
                            <a href="photos/Camiones/C-291/IMG_6493.JPG" data-lightbox="C-291" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-291"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-292/IMG_6496.JPG" data-lightbox="C-292" ><img src="photos/Camiones/C-292/IMG_6496.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-292</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-292/IMG_6497.JPG" data-lightbox="C-292" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-292"></a>
                            <a href="photos/Camiones/C-292/IMG_6498.JPG" data-lightbox="C-292" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-292"></a>
                            <a href="photos/Camiones/C-292/IMG_6499.JPG" data-lightbox="C-292" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-292"></a>
                            <a href="photos/Camiones/C-292/IMG_6500.JPG" data-lightbox="C-292" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-292"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-296/IMG_8230.JPG" data-lightbox="C-296" ><img src="photos/Camiones/C-296/IMG_8230.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioVendido-text"><span>Vendido</span></div>
                                <h2><span>2004 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 44 pasajeros<br />Unidad: C-296</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-296/IMG_8231.JPG" data-lightbox="C-296" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-296"></a>
                            <a href="photos/Camiones/C-296/IMG_8232.JPG" data-lightbox="C-296" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-296"></a>
                            <a href="photos/Camiones/C-296/IMG_8233.JPG" data-lightbox="C-296" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-296"></a>
                            <a href="photos/Camiones/C-296/IMG_8234.JPG" data-lightbox="C-296" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-296"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-297/IMG_8235.JPG" data-lightbox="C-297" ><img src="photos/Camiones/C-297/IMG_8235.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioVendido-text"><span>Vendido</span></div>
                                <h2><span>2004 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 44 pasajeros<br />Unidad: C-297</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-297/IMG_8236.JPG" data-lightbox="C-297" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-297"></a>
                            <a href="photos/Camiones/C-297/IMG_8237.JPG" data-lightbox="C-297" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-297"></a>
                            <a href="photos/Camiones/C-297/IMG_8238.JPG" data-lightbox="C-297" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-297"></a>
                            <a href="photos/Camiones/C-297/IMG_8239.JPG" data-lightbox="C-297" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 44 pasajeros, unidad: C-297"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-298/IMG_8250.JPG" data-lightbox="C-298" ><img src="photos/Camiones/C-298/IMG_8250.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-298</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-298/IMG_8251.JPG" data-lightbox="C-298" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-298"></a>
                            <a href="photos/Camiones/C-298/IMG_8252.JPG" data-lightbox="C-298" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-298"></a>
                            <a href="photos/Camiones/C-298/IMG_8253.JPG" data-lightbox="C-298" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-298"></a>
                            <a href="photos/Camiones/C-298/IMG_8254.JPG" data-lightbox="C-298" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-298"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-301/IMG_8259.JPG" data-lightbox="C-301" ><img src="photos/Camiones/C-301/IMG_8259.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-301</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-301/IMG_8255.JPG" data-lightbox="C-301" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-301"></a>
                            <a href="photos/Camiones/C-301/IMG_8256.JPG" data-lightbox="C-301" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-301"></a>
                            <a href="photos/Camiones/C-301/IMG_8257.JPG" data-lightbox="C-301" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-301"></a>
                            <a href="photos/Camiones/C-301/IMG_8258.JPG" data-lightbox="C-301" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-301"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-304/IMG_8220.JPG" data-lightbox="C-304" ><img src="photos/Camiones/C-304/IMG_8220.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-304</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-304/IMG_8221.JPG" data-lightbox="C-304" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-304"></a>
                            <a href="photos/Camiones/C-304/IMG_8222.JPG" data-lightbox="C-304" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-304"></a>
                            <a href="photos/Camiones/C-304/IMG_8223.JPG" data-lightbox="C-304" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-304"></a>
                            <a href="photos/Camiones/C-304/IMG_8224.JPG" data-lightbox="C-304" title="Motor: Mercedez benz, transmición: Automático, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-304"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-306/IMG_7664.JPG" data-lightbox="C-306" ><img src="photos/Camiones/C-306/IMG_7664.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2006 Nacional</span><br/>Internacional</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automatico<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-306</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-306/IMG_7665.JPG" data-lightbox="C-306" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-306"></a>
                            <a href="photos/Camiones/C-306/IMG_7666.JPG" data-lightbox="C-306" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-306"></a>
                            <a href="photos/Camiones/C-306/IMG_7667.JPG" data-lightbox="C-306" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-306"></a>
                            <a href="photos/Camiones/C-306/IMG_7668.JPG" data-lightbox="C-306" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-306"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-307/IMG_7550.JPG" data-lightbox="C-307" ><img src="photos/Camiones/C-307/IMG_7550.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioVendido-text"><span>Vendido</span></div>
                                <h2><span>2006 Nacional</span><br/>Internacional</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automatico<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-307</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-307/IMG_7551.JPG" data-lightbox="C-307" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-307"></a>
                            <a href="photos/Camiones/C-307/IMG_7552.JPG" data-lightbox="C-307" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-307"></a>
                            <a href="photos/Camiones/C-307/IMG_7553.JPG" data-lightbox="C-307" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-307"></a>
                            <a href="photos/Camiones/C-307/IMG_7554.JPG" data-lightbox="C-307" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-307"></a>
                            <a href="photos/Camiones/C-307/IMG_7555.JPG" data-lightbox="C-307" title="Motor: Mercedez benz, transmición: Automatico, frenos: Aire, suspeción: Aire, A/C: N/A, capacidad: 48 pasajeros, unidad: C-307"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-308/IMG_8225.JPG" data-lightbox="C-308" ><img src="photos/Camiones/C-308/IMG_8225.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Caterpillar<br/>Transmición: Automático<br/>Frenos: Hidráulicos<br/>Suspeción: Muelles<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-308</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-308/IMG_8226.JPG" data-lightbox="C-308" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-308"></a>
                            <a href="photos/Camiones/C-308/IMG_8227.JPG" data-lightbox="C-308" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-308"></a>
                            <a href="photos/Camiones/C-308/IMG_8228.JPG" data-lightbox="C-308" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-308"></a>
                            <a href="photos/Camiones/C-308/IMG_8229.JPG" data-lightbox="C-308" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-308"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-309/IMG_8215.JPG" data-lightbox="C-309" ><img src="photos/Camiones/C-309/IMG_8215.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2005 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Caterpillar<br/>Transmición: Automático<br/>Frenos: Hidráulicos<br/>Suspeción: Muelles<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-309</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-309/IMG_8216.JPG" data-lightbox="C-309" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-309"></a>
                            <a href="photos/Camiones/C-309/IMG_8217.JPG" data-lightbox="C-309" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-309"></a>
                            <a href="photos/Camiones/C-309/IMG_8218.JPG" data-lightbox="C-309" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-309"></a>
                            <a href="photos/Camiones/C-309/IMG_8219.JPG" data-lightbox="C-309" title="Motor: Caterpillar, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-309"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["camiones"]'>
                             <a href="photos/Camiones/C-311/IMG_8245.JPG" data-lightbox="C-311" ><img src="photos/Camiones/C-311/IMG_8245.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2004 Nacional</span><br/>Freightliner</h2>
                                <p>Motor: Mercedez benz<br/>Transmición: Automático<br/>Frenos: Hidráulicos<br/>Suspeción: Muelles<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-311</p>
                            </figcaption></a>
                            <a href="photos/Camiones/C-311/IMG_8246.JPG" data-lightbox="C-311" title="Motor: Mercedez benz, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-311"></a>
                            <a href="photos/Camiones/C-311/IMG_8247.JPG" data-lightbox="C-311" title="Motor: Mercedez benz, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-311"></a>
                            <a href="photos/Camiones/C-311/IMG_8248.JPG" data-lightbox="C-311" title="Motor: Mercedez benz, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-311"></a>
                            <a href="photos/Camiones/C-311/IMG_8249.JPG" data-lightbox="C-311" title="Motor: Mercedez benz, transmición: Automático, frenos: Hidráulicos, suspeción: Muelles, A/C: N/A, capacidad: 48 pasajeros, unidad: C-311"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["carros"]'>
                             <a href="photos/Carros/Camaro/4b00e340-8e70-4b0d-9ff8-98a46a37d053.JPG" data-lightbox="Camaro" ><img src="photos/Carros/Camaro/4b00e340-8e70-4b0d-9ff8-98a46a37d053.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2006 Nacional</span><br/>Camaro</h2>
                                <%--<p>Motor: Mercedez benz<br/>Transmición: Automatico<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-311</p>--%>
                            </figcaption></a>
                            <a href="photos/Carros/Camaro/20d6398d-ed00-49f1-9bb1-360924766c03.JPG" data-lightbox="Camaro"></a>
                            <a href="photos/Carros/Camaro/7283b331-615f-45c3-83ad-dd4f5382246f.JPG" data-lightbox="Camaro"></a>
                            <a href="photos/Carros/Camaro/88971e6a-3a85-4947-a719-2ca850680f3b.JPG" data-lightbox="Camaro"></a>
                            <a href="photos/Carros/Camaro/a895888c-ee62-4df7-87cd-2ab69fea70e6.JPG" data-lightbox="Camaro"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["maquinaria"]'>
                             <a href="photos/Maquinaria/Barredora/IMG_5687.JPG" data-lightbox="Barredora" ><img src="photos/Maquinaria/Barredora/IMG_5687.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2006 Nacional</span><br/>Barredora</h2>
                                <%--<p>Motor: Mercedez benz<br/>Transmición: Automatico<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-311</p>--%>
                            </figcaption></a>
                            <a href="photos/Maquinaria/Barredora/IMG_5686.JPG" data-lightbox="Barredora"></a>
                            <a href="photos/Maquinaria/Barredora/IMG_5685.JPG" data-lightbox="Barredora"></a>
                            <a href="photos/Maquinaria/Barredora/IMG_5684.JPG" data-lightbox="Barredora"></a>
                            <a href="photos/Maquinaria/Barredora/IMG_5683.JPG" data-lightbox="Barredora"></a>
                            <a href="photos/Maquinaria/Barredora/IMG_5682.JPG" data-lightbox="Barredora"></a>
                            <a href="photos/Maquinaria/Barredora/IMG_5681.JPG" data-lightbox="Barredora"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["maquinaria"]'>
                             <a href="photos/Maquinaria/Barredora 2/IMG_5204.JPG" data-lightbox="Barredora2" ><img src="photos/Maquinaria/Barredora 2/IMG_5204.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2006 Nacional</span><br/>ELGIN</h2>
                                <%--<p>Motor: Mercedez benz<br/>Transmición: Automatico<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-311</p>--%>
                            </figcaption></a>
                            <a href="photos/Maquinaria/Barredora 2/IMG_5205.JPG" data-lightbox="BarrBarredora2edora"></a>
                            <a href="photos/Maquinaria/Barredora 2/IMG_5206.JPG" data-lightbox="Barredora2"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["maquinaria"]'>
                             <a href="photos/Maquinaria/Cargador frontal/IMG_6318.JPG" data-lightbox="cargador" ><img src="photos/Maquinaria/Cargador frontal/IMG_6318.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2006 Nacional</span><br/>Cargador frontal</h2>
                                <%--<p>Motor: Mercedez benz<br/>Transmición: Automatico<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-311</p>--%>
                            </figcaption></a>
                            <a href="photos/Maquinaria/Cargador frontal/IMG_6315.JPG" data-lightbox="cargador"></a>
                            <a href="photos/Maquinaria/Cargador frontal/IMG_6320.JPG" data-lightbox="cargador"></a>
                            <a href="photos/Maquinaria/Cargador frontal/IMG_6321.JPG" data-lightbox="cargador"></a>
                        </figure>
                        <figure class="portfolio-item featured" data-groups='["maquinaria"]'>
                             <a href="photos/Maquinaria/Motoconformadora/IMG_6323.JPG" data-lightbox="cargador" ><img src="photos/Maquinaria/Motoconformadora/IMG_6323.JPG" alt="" class="img-responsive" />
                            <figcaption>
                                <div class="PrecioActual-text"><span>&nbsp;</span></div>
                                <h2><span>2006 Nacional</span><br/>Galion</h2>
                                <%--<p>Motor: Mercedez benz<br/>Transmición: Automatico<br/>Frenos: Aire<br/>Suspeción: Aire<br/>A/C: N/A<br/>Capacidad: 48 pasajeros<br />Unidad: C-311</p>--%>
                            </figcaption></a>
                            <a href="photos/Maquinaria/Motoconformadora/IMG_6322.JPG" data-lightbox="cargador"></a>
                            <a href="photos/Maquinaria/Motoconformadora/IMG_6324.JPG" data-lightbox="cargador"></a>
                            <a href="photos/Maquinaria/Motoconformadora/IMG_6325.JPG" data-lightbox="cargador"></a>
                        </figure>
                    </div>

                </div>
            </div>
        </div>
    </section>

    <section class="clients">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <!-- <div class="section-title st-center">
							<h3>Some Of our clients</h3>
							<p>Avocent deditum long</p>
						</div> -->
                    <ul class="clients-carousel">
                        <li>
                            <img src="photos/client.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client2.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client3.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client4.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client5.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client6.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client7.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client8.png" class="img-responsive" alt=""></li>
                        <li>
                            <img src="photos/client9.png" class="img-responsive" alt=""></li>
                    </ul>
                </div>
            </div>
        </div>
    </section>

    <section class="testimonials">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="testimonials-carousel">
                        <ul>
                            <%--<li>
                                <div class="testimonial">
                                    <div class="testimonial-img">
                                        <img src="photos/client.jpg" alt="">
                                    </div>
                                    <blockquote>
                                        <p>Camión escolar año 2007, frenos de aire, para 52 pasajeros, cuenta con sistemas de aire acondicionado, nacional.</p>
                                        <footer>PRÓXIMO A LLEGAR, <cite title="Source Title">Contactenos para mayor información</cite></footer>
                                    </blockquote>
                                </div>
                            </li>--%>
                            <li>
                                <div class="testimonial">
                                    <div class="testimonial-img">
                                        <img src="photos/client2.jpg" alt="">
                                    </div>
                                    <blockquote>
                                        <p>Montacargas modelo RC-60, nacional, sin detalles.</p>
                                        <footer>PRÓXIMO A LLEGAR, <cite title="Source Title">Contactenos para mayor información</cite></footer>
                                    </blockquote>
                                </div>
                            </li>
                            <%--<li>
                                <div class="testimonial">
                                    <div class="testimonial-img">
                                        <img src="photos/client3.jpg" alt="">
                                    </div>
                                    <blockquote>
                                        <p>Illas, volumus prosperum. Nostras eoque statua cuius corrumpit praetor aliter quaeso propter ei, quam inducitur ruant doctiores sanguinem atomum molestiae, antiqua inculta dicent.</p>
                                        <footer>Arthur Fernandez, <cite title="Source Title">Example Inc.</cite></footer>
                                    </blockquote>
                                </div>
                            </li>--%>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
    </section>

    <section class="faq-sec" id="PreguntasFrecuentes">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <!-- <h2 class="tac">frequently asked questions</h2> -->
                    <div class="section-title st-center">
                        <h3>¿Tienes dudas?</h3>
                        <p>preguntas frecuentes</p>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <div class="faq">
                        <h3><i class="fa fa-question-circle"></i>¿Como realizar una compra?</h3>
                        <p>Necesitamos revisar el inventario, seleccionar la unidad deseada para tomar la clave que se encuentra en la parte inferior de la descripción, una vez tomada la clave, seleccionar en el menú "Contacto", se llenaran los campos requeridos, en comentarios ingresar la leyenda "Me interesa compra" con la clave de la unidad y enseguida nos comunicaremos con usted.</p>
                    </div>
                    <%--<div class="faq">
                        <h3><i class="fa fa-question-circle"></i>¿Se hacen translados?</h3>
                        <p>Pertinerent non importari, populo faciendi civium vetuit. Gravitate numquam praesentium fabulas. Abest ponatur ineruditus restat consoletur causam, ordiamur temperantiam repellat desistemus conquirendae molestia aiunt discenda monet.</p>
                    </div>--%>
                </div>                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                       
                <div class="col-md-6">
                    <div class="faq">
                        <h3><i class="fa fa-question-circle"></i>¿Como puedo obtener mas detalles?</h3>
                        <p>Para obtener detalles específicos de una unidad, necesitamos revisar el inventario, seleccionar la unidad deseada para tomar la clave que se encuentra en la parte inferior de la descripción, una vez tomada la clave, seleccionar en el menú "Contacto", se llenaran los campos requeridos, en comentarios ingresar la leyenda "Mas detalles" con la clave de la unidad y posteriormente en su correo electrónico le llegaran mas detalles de la unidad.</p>
                    </div>
                   <%-- <div class="faq">
                        <h3><i class="fa fa-question-circle"></i>Me interesa un producto</h3>
                        <p>Habeo mala nocet perpetiuntur legendos dicemus levitatibus abducat futura, occultarum probant vitae evertunt laudantium docendi difficilem, offendit concederetur tuo hortensio deserere, molita gaudemus titillaret difficilius, parum timeret unum molestiam omnis vitae.</p>
                    </div>--%>
                </div>
            </div>
        </div>
    </section>
    <section class="call-us">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <h3>Somos tu mejor opción</h3>
                    <%--<a href="#" class="btn btn-default-o btn-lg">Call Us Now</a>--%>
                </div>
            </div>
        </div>
    </section>

    <section class="contact" id="contact">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div class="section-title st-center">
                        <h3>Contacto</h3>
                        <p>Si necesitas más información no dudes en contactarnos, estaremos felices de ayudarte.</p>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-md-6">
                    <form class="contact-form" role="form" id="EnviarContacto" runat="server">

                        <div class="form-group ">
                            <dx:BootstrapTextBox ID="txtNombre" ClientInstanceName="txtNombre" NullText="Nombre" runat="server">
                                <ValidationSettings ValidationGroup="EnviarCorreo" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                            </dx:BootstrapTextBox>
                        </div>
                        <div class="form-group ">
                            <dx:BootstrapTextBox ID="txtCorreo" ClientInstanceName="txtCorreo" NullText="Correo electrónico" runat="server">

                                <ValidationSettings SetFocusOnError="true" ValidationGroup="EnviarCorreo" RequiredField-IsRequired="true" CausesValidation="false">
                                    <RegularExpression ErrorText="El formato de la dirección de correo es incorrecto." ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" />
                                </ValidationSettings>
                            </dx:BootstrapTextBox>
                        </div>
                        <div class="form-group ">
                            <dx:BootstrapTextBox ID="txtCelular" ClientInstanceName="txtCelular" NullText="Teléfono" runat="server">
                                <MaskSettings Mask="(999) 000-0000" IncludeLiterals="None" />
                                <ValidationSettings ValidationGroup="EnviarCorreo" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                            </dx:BootstrapTextBox>
                        </div>
                        <div class="form-group ">
                            <dx:BootstrapMemo ID="memoComentario" ClientInstanceName="memoComentario" NullText="Comentarios" runat="server">
                                <ValidationSettings ValidationGroup="EnviarCorreo" RequiredField-IsRequired="true" CausesValidation="false"></ValidationSettings>
                            </dx:BootstrapMemo>
                        </div>
                        <div class="form-group ">
                            <dx:ASPxCallback ID="CallbackEnviar" ClientInstanceName="CallbackEnviar" OnCallback="CallbackEnviar_Callback" runat="server">
                                <ClientSideEvents CallbackComplete="function(s,e){ LoadingPanel.Hide(); if(e.result != ''  && e.result != null){  alert('Ocurrió un problema al enviar el correo electrónico.'); txtNombre.SetText(''); txtCorreo.SetText(''); txtCelular.SetText(''); memoComentario.SetText('');}else{alert('El correo electrónico se envío correctamente.'); txtNombre.SetText(''); txtCorreo.SetText(''); txtCelular.SetText(''); memoComentario.SetText('');}}" />
                            </dx:ASPxCallback>
                            <dx:BootstrapButton ID="btnEnviar" ClientInstanceName="btnEnviar" ValidationGroup="EnviarCorreo" CssClasses-Control="btn btn-main btn-lg" runat="server" AutoPostBack="false" Text="Enviar">
                                <ClientSideEvents Click="function(s,e){ if (ASPxClientEdit.AreEditorsValid('ContactUs')){LoadingPanel.Show(); CallbackEnviar.PerformCallback(txtNombre.GetText() +'|'+ txtCorreo.GetText() +'|'+ txtCelular.GetText() + '|' + memoComentario.GetText());}}" />
                            </dx:BootstrapButton>
                        </div>
                        <dx:ASPxLoadingPanel ID="LoadingPanel" CssClass="alertas" ClientInstanceName="LoadingPanel" Modal="true" LoadingDivStyle-BackColor="Yellow" LoadingDivStyle-Opacity="20" runat="server"></dx:ASPxLoadingPanel>
                    </form>
                </div>
                <div class="col-md-6">
                    <div>
                        <div id="googlemaps" style="width: 100%; height: 300px; background: yellow"></div>
                    </div>

                    <address>
                        Av. Obregon 26 y 27<br>
                        San Luis Rio Col, Sonora<br>
                        <abbr title="Teléfono">Tel:</abbr>
                        (653) 112-4206
                    </address>
                </div>
            </div>
        </div>
    </section>
    <footer class="site-footer">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    TractoMaquinaria de la frontera 2018.	<a href="#" class="facebook" data-toggle="tooltip" data-placement="top" title="Facebook"><i class="fa fa-facebook"></i></a>
                </div>
            </div>
        </div>
    </footer>

    <!-- jQuery (necessary for Bootstrap's JavaScript plugins) -->
    <script src="js/jquery.min.js"></script>
    <!-- Include all compiled plugins (below), or include individual files as needed -->
    <script src="js/bootstrap.min.js"></script>
    <script src="js/jquery.easing.min.js"></script>
    <script src="js/jquery.stellar.js"></script>
    <script src="js/jquery.appear.js"></script>
    <script src="js/jquery.nicescroll.min.js"></script>
    <script src="js/jquery.countTo.js"></script>
    <script src="js/jquery.shuffle.modernizr.js"></script>
    <script src="js/jquery.shuffle.js"></script>
    <script src="js/owl.carousel.js"></script>
    <script src="js/jquery.ajaxchimp.min.js"></script>
    <script src="css/lightbox/js/lightbox.min.js"></script>
    <script src="js/script.js"></script>

    <!-- Global site tag (gtag.js) - Google Analytics -->
    <script async src="https://www.googletagmanager.com/gtag/js?id=UA-114711708-1"></script>
    <script>
        window.dataLayer = window.dataLayer || [];
        function gtag() { dataLayer.push(arguments); }
        gtag('js', new Date());

        gtag('config', 'UA-114711708-1');
    </script>
    <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?key=AIzaSyDeKBBPJTG3v5w3cNPAgM6ZsJiPyL1mP_o&amp;"></script>

    <script>
        // When the window has finished loading create our google map below
        google.maps.event.addDomListener(window, 'load', init);

        function init() {
            // Basic options for a simple Google Map
            // For more options see: https://developers.google.com/maps/documentation/javascript/reference#MapOptions
            var mapOptions = {
                // How zoomed in you want the map to start at (always required)
                zoom: 15,

                scrollwheel: false,

                // The latitude and longitude to center the map (always required)
                center: new google.maps.LatLng(32.473481, -114.7480961), // New York 

                // How you would like to style the map. 
                // This is where you would paste any style found on Snazzy Maps.
                styles: [{ featureType: 'water', stylers: [{ color: '#F2F2F2' }, { visibility: 'on' }] }, { featureType: 'landscape', stylers: [{ color: '#FFFFFF' }] }, { featureType: 'road', stylers: [{ saturation: -100 }, { lightness: 45 }] }, { featureType: 'road.highway', stylers: [{ visibility: 'simplified' }] }, { featureType: 'road.arterial', elementType: 'labels.icon', stylers: [{ visibility: 'off' }] }, { featureType: 'administrative', elementType: 'labels.text.fill', stylers: [{ color: '#ADADAD' }] }, { featureType: 'transit', stylers: [{ visibility: 'off' }] }, { featureType: 'poi', stylers: [{ visibility: 'off' }] }]
            };

            // Get the HTML DOM element that will contain your map 
            // We are using a div with id="map" seen below in the <body>
            var mapElement = document.getElementById('googlemaps');

            // Create the Google Map using out element and options defined above
            var map = new google.maps.Map(mapElement, mapOptions);
            var marker = new google.maps.Marker({
                position: new google.maps.LatLng(32.473481, -114.7480961),
                map: map,
                icon: 'http://maps.google.com/mapfiles/ms/icons/yellow-dot.png'
            });
        }

    </script>


</body>
</html>
