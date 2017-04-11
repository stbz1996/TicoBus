<?php
    require "../Conection/methods.php";
?>

<!DOCTYPE html>
    <html class="no-js"> 
<head>
    <meta charset="utf-8">
    <title>Tico Bus Costa Rica</title>
    <meta name="description" content="">
    <meta name="viewport" content="width=device-width">
    <link href="http://fonts.googleapis.com/css?family=Open+Sans:300italic,400italic,600italic,700italic,800italic,400,300,600,700,800" rel="stylesheet">
    <!-- start style -->
    <link rel="stylesheet" href="css/bootstrap.min.css">
    <link rel="stylesheet" href="css/normalize.min.css">
    <link rel="stylesheet" href="css/font-awesome.min.css">
    <link rel="stylesheet" href="css/animate.css">
    <link rel="stylesheet" href="css/templatemo_misc.css">
    <link rel="stylesheet" href="css/templatemo_style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.3/css/font-awesome.min.css">
    <!-- start functions in javaScrip -->
    <script src="js/vendor/modernizr-2.6.2.min.js"></script>
    <script src="js/jquery-1.12.3.min.js" charset="utf-8"></script>
</head>

<!--#################################################################################################-->

<body>
    <!-- overlay menu -->
    <div class="bg-overlay"></div>
    <div class="container-fluid">
        <div class="row">
            <div class="col-md-4 col-sm-12">
                <div class="sidebar-menu">
                    <div class="logo-wrapper">
                        <h1 class="logo">
                            <!-- show who is using the web page -->
                            <a href="#"><img src="images/icono.png" alt="Circle Template">
                            <?php
                                session_start();
                                echo '<span id="info">Bienvenido '.$_SESSION["name"].'</span>'
                            ?>
                            <span id="info">Viví la nueva experiencia</span></a>
                        </h1>
                    </div> 

                    <!-- options of menu -->
                    <div class="menu-wrapper">
                        <ul class="menu">
                            <li><a class="homebutton" href="#"> Inicio</a></li>
                            <li><a class="show-2" href="#">     Funciones</a></li>
                            <li><a class="show-7" href="#">     Cuentas</a></li>
                            <li><a class="show-3" href="#">     Galeria</a></li>
                            <li><a class="show-1" href="#">     Acerca de</a></li>
                            <li><a class="show-5" href="#" onclick="templatemo_map();">Contáctenos</a></li><li><a class="show-6" href="#">     Cerrar sesión</a></li>
                        </ul>
                        <a href="#" class="toggle-menu"><i class="fa fa-bars"></i></a>
                    </div>
                </div> 
            </div>

            <!-- actions for buttoms on acount menu -->
            <div class="col-md-8 col-sm-12">
                <div id="menu-container">
                    
                    <!-- actions for functions submenu -->
                    <div id="menu-2" class="services content">
                        <div class="row">
                            <ul class="tabs">
                                <li class="col-md-3 col-sm-4">
                                    <a href="#tab4" class="icon-item">
                                    <i class="fa fa-money"></i></a> 
                                </li>

                                <li class="col-md-3 col-sm-4">
                                    <a href="#tab5" class="icon-item">
                                    <i class="fa fa-bus"></i></a> 
                                </li>

                                <li class="col-md-3 col-sm-4">
                                    <a href="#tab6" class="icon-item" id="buscarRuta">
                                    <i class="fa fa-road"></i></a> 
                                </li>

                                <li class="col-md-3 col-sm-4">
                                    <a href="#tab7" class="icon-item">
                                    <i class="fa fa-clock-o"></i></a>
                                </li>
                            </ul> 

                            <!-- 1 botton menu 'pagos' -->
                            <div class="col-md-12 col-sm-12">
                                <div class="toggle-content text-center" id="tab4">
                                    <h3> Pagos </h3>
                                    <p><font size="3"> Realiza tus pagos donde y cuando sea, tan solo digite su número de cuenta y el monto a recargar en su saldo.</font> </p>
                                    <br><br>
                                    <div class="input-form text-left">
                                        Cuenta:<br>
                                        <input type="text" name="cuenta" id="numberCuenta" maxlength="15" value=""><br>
                                        Monto:<br>
                                        <input type="text" name="monto" id="montoRecarga" maxlength="6"><br><br>
                                        <input type="button" name="Recargar" id="recargar" value="Recargar" class="button text-center"><br><br>
                                        <span id="resp3"></span>
                                    </div>   
                                </div>                                

                                <!-- 2 botton menu 'Consulta de viajes' -->
                                <div class="toggle-content text-center" id="tab5">
                                    <h3>Consulta de viajes</h3>
                                    <p>Consulta la información de sus viajes realizados.</p><br>
                                    <form class="col-md-12" action="#" method="post">
                                        <div class="input-form text-center">
                                        <h3>Seleccione rangos de fecha</h3>
                                            <big>Fecha inicio: </big>
                                            <input id="startdate" name="startdate" type="date">
                                            <big>Fecha final: </big>
                                            <input id="enddate" name="enddate" type="date"><br>  
                                        </div>                            
                                    </form>
                                    <input type="button" name="consultarViaje" id="consultarViaje" value="Consultar" class="button">
                                    <div class="input-form text-center">
                                        <span id="mostrarViajes"></span>
                                    </div>
                                </div>

                                <!-- 3 botton menu 'Búsqueda de ruta' -->
                                <div class="toggle-content text-center" id="tab6">
                                    <h3>Búsqueda de ruta</h3>
                                    <p>Seleccione su parada de inicio y destino, se le mostrará información de las rutas con esas paradas de bus.</p>
                                    <div class="select-form text-left">
                                        <form class="col-md-3 text-left" action="#" method="post">
                                            <big>Parada de Inicio</big><br>
                                            <select name="select-provincia" onchange="getIdProvinciaInicio(this.value)">
                                                <option value="-1">Elija una provincia</option>
                                                <!-- used for combobox menu -->
                                                <?php
                                                    $result = getProvincias();
                                                    foreach ($result as $provincia) {?>
                                                        <option value="<?php echo $provincia["idProvincia"]; ?>"><?php echo $provincia["nombreProvincia"]?></option>
                                                <?php }
                                                ?>  
                                            </select><br>
                                            <select name="paradaInicio" id="paradaInicio">
                                                <option value="-1">Elija una parada</option>
                                            </select><br>
                                        </form>
                                        <form class="col-md-9 text-right" action="#" method="post">
                                            <big>Parada de Destino</big><br>
                                            <select name="select-provincia" onchange="getIdProvinciaDestino(this.value)">
                                                <option value="-1">Elija una provincia</option>
                                                <!-- used for combobox menu -->
                                                <?php
                                                    $result = getProvincias();
                                                    foreach ($result as $provincia) {?>
                                                        <option value="<?php echo $provincia["idProvincia"]; ?>"><?php echo $provincia["nombreProvincia"]?></option>
                                                <?php }
                                                ?>  
                                            </select><br>
                                            <select name="paradaDestino" id="paradaDestino">
                                                <option value="-1">Elija una parada</option>
                                            </select>
                                        </form>
                                        <div class="text-center">
                                            <input type="button" name="busquedaRutas" id="busquedaRutas" value="Buscar Rutas" class="button"><br>
                                        </div>
                                        <div class="input-form text-center">
                                            <span id="resultadoRutas"></span>
                                        </div>
                                    </div>
                                </div>

                                 <!-- 4 botton menu 'Consulta en espera' -->
                                <div class="toggle-content text-center" id="tab7">
                                    <h3>Consulta en espera</h3>
                                    <p>Acá puedes seleccionar una ruta y una parada para que pueda consultar la hora a la que pasará su bus en la parada que indiques.</p>
                                    <div class="select-form text-left">
                                        <form class="col-md-12 text-left" action="#" method="post"> 
                                            <select name="select-compania" onchange="getIdEmpresa(this.value)">
                                                <option value="-1">Elija una compañía</option>
                                                <!-- used for combobox menu -->
                                                <?php
                                                    $result = getEmpresas();
                                                    foreach ($result as $empresa) {?>
                                                        <option value="<?php echo $empresa["cedulaJuridica"]; ?>"><?php echo $empresa["nombre"]?>
                                                            
                                                        </option>
                                                <?php }
                                                ?> 
                                            </select><br>
                                            <select name="rutaEmpresa" id="rutaEmpresa" onchange="getIdRuta(this.value)">
                                                <option value="-1">Elija una ruta</option>
                                            </select><br>

                                            <select name = "paradaEspera" id = "paradaEspera">
                                                <option value="-1">Elija una parada</option>
                                            </select>
                                        </form>
                                        <input type="button" name="mostrarEspera" id="mostrarEspera" value="Consulta Espera" class="button" data-toggle="modal" data-target="#myModal"><br>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div> 

                    <!-- Edit acounts -->
                    <div id="menu-7" class="about content">
                        <div class="row">
                            <div class="col-md-12 col-sm-12">
                                <ul class="tabs">
                                    <li class="col-md-3 col-sm-4">
                                        <a href="#tab10" class="icon-item">
                                        <i class="fa fa-plus"></i></a> 
                                    </li>

                                    <li class="col-md-3 col-sm-4">
                                        <a href="#tab18" class="icon-item">
                                        <i class="fa fa-dollar"></i></a> 
                                    </li>

                                    <li class="col-md-3 col-sm-4">
                                        <a href="#tab11" class="icon-item">
                                        <i class="fa fa-trash"></i></a> 
                                    </li>
                                </ul> 
                                <div class="col-md-12 col-sm-12">
                                    <!-- first button on acounts -->
                                    <div class="toggle-content text-center" id="tab10">
                                        <h3> Crea tú cuenta </h3>
                                        <p><font size="3"> Puedes crear tú cuenta fácilmente y sin complicaciones.</font></p>
                                        <br><br>
                                        <div class="input-form text-left">
                                            Número de Cuenta:<br>
                                            <input type="text" name="numeroCuenta" id="numeroCuenta" maxlength="15"><br><br>
                                            <input type="button" name="Crear" id="Cuenta" value="Crear" class="button text-center"><br><br>
                                            <span id="resp"></span>
                                        </div>
                                    </div>

                                    <!-- second button on acounts -->
                                    <div class="toggle-content text-center" id="tab18">
                                        <h3> Verifica tú saldo  </h3>
                                        <p><font size="3"> Preciona el boton de VER SALDO para actualizar la información de su saldo actual</font></p>
                                        <br><br>
                                        <div class="input-form text-center">
                                            <input type="button" name="verSaldo" id="verSaldo" value="Ver Saldo" class="button text-center"><br><br>
                                            <br><br>
                                            <h3 id="msjSaldo"> </h3>
                                        </div>
                                    </div>
                                    
                                    <!--  third button on acounts -->
                                    <div class="toggle-content text-center" id="tab11">
                                        <h3> Elimina tús cuenta </h3>
                                        <p><font size="3"> Puedes eliminar tús cuentas fácilmente y sin complicaciones.</font></p>
                                        <br><br>
                                        <div class="input-form text-left" name="form1">
                                            Número de Cuenta:<br>
                                            <input type="text" name="numeroCuenta" id="numeroCuentaEliminar" maxlength="15"><br><br>
                                            <input type="button" name="Eliminar" id="eliminarCuenta" value="eliminar" class="button text-center"><br><br>
                                            <span id="resp2"></span>
                                        </div>
                                    </div>
                                </div> 
                            </div>
                        </div>   
                    </div>



                    <!-- galery elements -->
                    <div id="menu-3" class="gallery content">
                        <div class="row">
                            <div class="col-md-4 col-ms-6">
                            
                            <div class="g-item">
                            <img src="images/gallery/1-1-1b.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/1-1-1b.png">
                            <span>+</span></a></div> </div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/624021.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/624021.png">
                            <span>+</span></a></div></div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/buses-de-lujo-5.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/buses-de-lujo-5.png">
                            <span>+</span></a></div> </div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/dddd.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/dddd.png">
                            <span>+</span></a> </div> </div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/dfs.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/dfs.png">
                            <span>+</span></a></div> </div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/DP-MDZ.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/DP-MDZ.png">
                            <span>+</span> </a></div> </div>

                             <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/fd.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/fd.png">
                            <span>+</span></a></div></div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/hqdefault (1).png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/hqdefault (1).png">
                            <span>+</span></a></div> </div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/hqdefault.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/hqdefault.png">
                            <span>+</span></a></div></div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/img01BusHeaderBox.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/img01BusHeaderBox.png">
                            <span>+</span></a></div> </div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/xx1.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/xx1.png">
                            <span>+</span></a></div></div>

                            <div class="col-md-4 col-ms-6">
                            <div class="g-item">
                            <img src="images/gallery/original.png" alt="">
                            <a data-rel="lightbox" class="overlay" href="images/gallery/original.png">
                            <span>+</span></a></div> </div>

                        </div> 
                    </div> <!-- /.gallery -->




                    <!-- info about the proyect -->
                    <div id="menu-1" class="about content">
                        <div class="row">
                            <div class="col-md-12 col-sm-12">
                                <div class="toggle-content text-center" id="tab1">
                                    <h3>Acerca De</h3>
                                        <p>
                                            <big>El transporte público es la solución ideal para la movilidad de personas en lugares con una alta concentración de habitantes. En ciudades en las que grandes cantidades de personas necesitan desplazarse entre puntos geográficos diferentes y en horarios similares, este tipo de transporte ha demostrado ser el que genera mejores resultados. La necesidad de un excelente sistema de transporte público es vital para cualquier ciudad del mundo, incluida la Gran Área Metropolitana de Costa Rica. Las ventajas son muchas: menor contaminación, menor costo para los usuarios y disminuye el tráfico de vehículos particulares en las calles, con lo cual se mejoran los tiempos de desplazamiento (MCP, 2016).
                                            <p></p>
                                            El transporte público en la GAM, constituido principalmente por la flota de autobuses, presenta muchas deficiencias que provocan que su servicio sea poco eficiente y de mala calidad. En primer lugar, existe una gran cantidad de rutas diferentes que los usuarios pueden tomar, pero que sin embargo atraviesan muchos puntos similares, lo que generalmente causa congestionamientos por la gran cantidad de buses en una misma calle, haciendo paradas en diferentes puntos.
                                            <p></p>
                                            Por otro lado, no existe una sectorización inteligente del transporte, es decir, todas las rutas de autobuses llegan a un mismo punto: San José. Son pocas las empresas autobuseras que cuentan con una terminal adecuada, por lo que acaban parqueando sus vehículos en la vía pública, causando congestionamientos.
                                            <p></p>
                                            La calidad del servicio a los usuarios es mala, siempre tienen que cargar dinero en efectivo para pagar. Además, no cuentan con un punto central donde consultar las rutas, ni ver en tiempo real cuánto hace falta para que el próximo autobús pase por la estación más cercana.
                                            <p></p>
                                            Estas y otras deficiencias han llevado a los ciudadanos a optar por vehículos particulares. En el 2014, la flota vehicular alcanzó el alarmante número de 1.25 millones de automóviles. Es claro que la infraestructura vial del país no está capacitada para esta cantidad de vehículos, por lo que los congestionamientos y accidentes de tránsito son situaciones que cada día aumentan (Financiero, 2016).
                                            </big>
                                        </p>     
                                </div>
                            </div>
                        </div>   
                    </div>


                    <!-- Sign off menu -->
                    <div id="menu-6" class="about content" method="post" >
                        <div class="row">
                            <div class="col-md-12 col-sm-12">
                                <div class="toggle-content text-center" id="tab1">
                                    <p><big>¿Seguro que desea cerrar sesión ahora?</big></p>
                                    <div class="input-form text-center">
                                        <input type="button" name="Salir" id="exit" value="Salir" class="button button-yellow">
                                    </div>
                                </div>
                            </div> 
                        </div>   
                    </div>
                    
                     <!-- contact us menu -->
                    <div id="menu-5" class="contact content">
                        <div class="row">
                            <div class="col-md-12">
                                <div class="toggle-content text-center spacing">
                                    <h3>Contáctenos</h3>
                                    <p>Puede contactarnos en el Instituto Tecnológico de Costa Rica
                                    <br><br><strong>Calles 5 y 7, Avenida 9, Av 9, San José, Costa Rica:</strong> 
                                    <br><strong>Email:</strong> TicoBus@company.com | <strong>Tel:</strong> 88377518 ó 88845209
                                    </p>
                                </div>
                            </div> 

                        <div class="row">
                            <div class="col-md-3 col-sm-3">
                                <div class="member-item">
                                <div class="thumb">
                                <img src="images/team/steven.png" alt="Tanya - Web Designer">
                                </div><h5> </h5>
                                <h5>Steven Bonilla</h5>
                                </div>
                            </div> 

                            <div class="col-md-3 col-sm-3">
                                <div class="member-item">
                                <div class="thumb">
                                <img src="images/team/jorge.png" alt="Julia - Creative Director">
                                </div><h5> </h5>
                                <h5>Jorge González</h5>
                                </div> 
                            </div> 

                            <div class="col-md-3 col-sm-3">
                                <div class="member-item">
                                <div class="thumb">
                                <img src="images/team/jason.png" alt="Candy - Web Developer">
                                </div><h5> </h5>
                                <h5>Jason Barrantes</h5>
                                </div> 
                            </div>

                            <div class="col-md-3 col-sm-3">
                                <div class="member-item">
                                <div class="thumb">
                                <img src="images/team/jos-1.png" alt="Julia - Creative Director">
                                </div><h5> </h5>
                                <h5>Jocelyn Román</h5>
                                </div> 
                            </div>
                        </div> <br> <br>

                         <!-- google map tools -->
                        <div class="col-md-12">
                            <div class="google-map"></div> 
                        </div> 
                            
                    </div> 
                </div> 
            </div> 
            </div> 
        </div> 
    </div>
    
    <!-- footer -->
    <div class="container-fluid">   
        <div class="row">
            <div class="col-md-12 footer">
                <p id="footer-text">
                	Copyright &copy; 2016 <a href="#">TicoBus</a>
                 </p>
            </div><
        </div>
    </div> 




    <!-- 
    ########################################################################
    ################                JS              ########################
    ######################################################################## 
    -->
    <!-- documents and funcions JavaScrip -->
    <script src="js/vendor/jquery-1.10.1.min.js"></script>
    <script>window.jQuery || document.write('<script src="Bus/js/vendor/jquery-1.10.1.min.js"><\/script>')</script>
    <script src="js/jquery.easing-1.3.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/plugins.js"></script>
    <script src="js/main.js"></script>
    <script src="js/functions.js" charset="utf-8"></script>
    <script type="text/javascript">

			jQuery(function ($) {
                $.supersized({
                    // Functionality
                    slide_interval: 3000, // Length between transitions
                    transition: 1, // 0-None, 1-Fade, 2-Slide Top, 3-Slide Right, 4-Slide Bottom, 5-Slide Left, 6-Carousel Right, 7-Carousel Left
                    transition_speed: 1000, // Speed of transition

                    // Components                           
                    slide_links: 'blank', // Individual links for each slide (Options: false, 'num', 'name', 'blank')
                    slides: [ // Slideshow Images
                        {   image: 'images/Fondo/Carretera-735.jpg'
                        }, {image: 'images/Fondo/Carreteras_WWW.fotoblogx.blogspot.COM_00.jpg'
                        }, {image: 'images/Fondo/Carreteras_WWW.fotoblogx.blogspot.COM_02.jpg'
                        }, {image: 'images/Fondo/carreteras-4k-hd-wallpapers-elviajeroazul.top-7.jpg'
                        }, {image: 'images/Fondo/carreteras-4k-hd-wallpapers-elviajeroazul.top-42.jpg'}, {image: 'images/Fondo/e_hd169_country-road-11.jpg'
                        }]
                });
            });
            
    </script>

    <!-- Google Map -->
    <script src="//maps.googleapis.com/maps/api/js?key=AIzaSyC5pm_oXfSHB6cAqP7xjRtEKoxnVFh4GAQ" async="" defer="defer" type="text/javascript"></script>
        <script src="js/vendor/jquery.gmap3.min.js"></script>
        <script type="text/javascript">
            function templatemo_map() {
                $('.google-map').gmap3({
                    marker:{
                        address: '9.9382322,-84.07553919999998' 
                    },
                    map:{
                        options:{
                        zoom: 15,
                        scrollwheel: false,
                        streetViewControl : true
                        }
                    }
                });
            }

            function getIdProvinciaInicio(val){
                //funcion ajax
                $.ajax({
                    type: "POST",
                    url: "../View_Conection/getParada.php",
                    data:"idProvincia="+val,
                    success: function(data){
                        $("#paradaInicio").html(data);
                    }
                });
            }

            function getIdProvinciaDestino(val){
                $.ajax({
                    type: "POST",
                    url: "../View_Conection/getParada.php",
                    data:"idProvincia="+val,
                    success: function(data){
                        $("#paradaDestino").html(data);
                    } 
                });
            }
            function getHorario(val1, val2){
                var ruta = val1;
                var parada = val2;
                $.ajax({
                    type: "POST",
                    url: "../View_Conection/getRangoHorario.php",
                    data:{ruta:ruta, parada:parada},
                    success: function(data){
                        $("#mostrarInformacion").html(data);
                    } 
                });
            }

            function getIdEmpresa(val){
                $.ajax({
                    type: "POST",
                    url: "../View_Conection/getRutas.php",
                    data:"idEmpresa="+val,
                    success: function(data){
                        $("#rutaEmpresa").html(data);
                    } 
                });
            }

            function getIdRuta(val){
                $.ajax({
                    type: "POST",
                    url: "../View_Conection/getParadasRuta.php",
                    data:"idRuta="+val,
                    success: function(data){
                        $("#paradaEspera").html(data);
                    } 
                });
            }
    </script>
</body>
</html>