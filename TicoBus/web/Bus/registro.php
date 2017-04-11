<?php
    require "../Conection/methods.php";
?>

<!DOCTYPE html>
    <html class="no-js"> 
<head>
    <meta charset="utf-8">
    <title>Circle by templatemo</title>
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

<!--###########################################################################################-->

<body>
    <div class="bg-overlay"></div>
    <div class="login-menu">
        <div class="toggle-content text-center">
        	<h1 class="logo">
                <a href="#"><img src="images/icono.png" alt="Circle Template"></a>
            </h1>
            <div class="col-md-2"></div>
            <div class="text-center">
            	 <!-- create a new user menu -->
                <form class="input-form col-md-8" action="#" method="post" target="Bus/inicio.html">
                    <big>Cedula<input type="text" name="cedulaRegister" id="cedulaRegister" maxlength="9"></big>
                    <big>Nombre<input type="text" name="nameRegister" id="nameRegister" maxlength="45"> </big>
                    <big>Apellido<input type="text"  name="lastNameRegister" id="lastNameRegister"  maxlength="45"> </big>
                    <big>Contraseña<input type="password" name="passwordRegister" id="passwordRegister"  maxlength="12" > </big>
                    <big><strong>Direccion</strong></big><br><br>
                    <big>Provincia</big>
                    
                    <select name="select-provincia" onchange="getIdProvincia(this.value)">
                        <option value="-1">Elija una provincia</option>
                         <!-- function for combobox -->
                        <?php
                            $result = getProvincias();
                            foreach ($result as $provincia) {?>
                                <option value="<?php echo $provincia["idProvincia"]; ?>"><?php echo $provincia["nombreProvincia"]?></option>
                        <?php }
                        ?>  
                    </select>

                    <big>Cantón</big>
                    <select name="canton" id="canton" onchange="getIdCanton(this.value)">
                        <option value="-1">Elija un cantón</option>
                    </select>

                    <big>Distrito</big>
                    <select name="distrito" id="distrito">
                        <option value="-1">Elija un distrito</option>
                    </select>

                    <big>Detalle</big>
                    <textarea name="detalleDireccion" id="detalleDireccion" rows="10" cols="40" maxlength="500"></textarea>
                    
                    <div class="input-form text-center">
                        <input type="button" name="Crear" id="crearCuenta" value="Crear" class="button button-yellow">
                        <input type="button" name="inicio" id="gotoinicio" value="Inicio" class="button button-yellow">
                    </div>
                    <span id="result"></span>
                </form>
            </div>
        </div>
    </div>
    


    <!-- 
    ########################################################################
    ################                JS              ########################
    ######################################################################## 
    -->
    <!-- documents and funcions JavaScrip -->
    <script src="js/vendor/jquery-1.10.1.min.js"></script>
    <script>window.jQuery || document.write('<script src="js/vendor/jquery-1.10.1.min.js"><\/script>')</script>
    
    <script src="js/jquery.easing-1.3.js"></script>
    <script src="js/bootstrap.js"></script>
    <script src="js/plugins.js"></script>
    <script src="js/main.js"></script>
    <script src="js/functions.js" charset="utf-8"></script>
    <script type="text/javascript">
            
			jQuery(function ($) {
                $.supersized({
                    // Functionality
                    slide_interval: 3000, 
                    transition: 1, 
                    transition_speed: 1000, 

                    // Components                           
                    slide_links: 'blank',
                    slides: [ 
                        {
                            image: 'images/Fondo/Carretera-735.jpg'
                        }, {
                            image: 'images/Fondo/Carreteras_WWW.fotoblogx.blogspot.COM_00.jpg'
                        }, {
                            image: 'images/Fondo/Carreteras_WWW.fotoblogx.blogspot.COM_02.jpg'
                        }, {
                            image: 'images/Fondo/carreteras-4k-hd-wallpapers-elviajeroazul.top-7.jpg'
                        }, {
                            image: 'images/Fondo/carreteras-4k-hd-wallpapers-elviajeroazul.top-42.jpg'
                        }, {
                            image: 'images/Fondo/e_hd169_country-road-11.jpg'
                        }

                    ]

                });
            });
            
    </script>

    <script>
        function getIdProvincia(val){
            //funcion ajax
            $.ajax({
                type: "POST",
                url: "../View_Conection/getcantones.php",
                data:"idProvincia="+val,
                success: function(data){
                    $("#canton").html(data);
                }
            });
        }
        function getIdCanton(val){
            $.ajax ({
                type:"POST",
                url: "../View_Conection/getdistritos.php",
                data:"idCanton="+val,
                success: function(data){
                    $("#distrito").html(data);
                }
            });
        }
    </script> 
</body>
</html>