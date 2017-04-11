<?php
  session_start();
  if (isset($_SESSION["user"])) {
    header("location:index.php");
  }
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
    <link rel="stylesheet" href="Bus/css/bootstrap.min.css">
    <link rel="stylesheet" href="Bus/css/normalize.min.css">
    <link rel="stylesheet" href="Bus/css/font-awesome.min.css">
    <link rel="stylesheet" href="Bus/css/animate.css">
    <link rel="stylesheet" href="Bus/css/templatemo_misc.css">
    <link rel="stylesheet" href="Bus/css/templatemo_style.css">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.6.3/css/font-awesome.min.css">
     <!-- start functions in javaScrip -->
    <script src="Bus/js/vendor/modernizr-2.6.2.min.js"></script>
    <script src="Bus/js/jquery-1.12.3.min.js" charset="utf-8"></script>
</head>

<!--######################################################################################-->

<body>
     <!-- login page -->
    <div class="bg-overlay"></div>
    <div class="login-menu">
        <div class="toggle-content text-center">
        	<h1 class="logo">
                <a href="#"><img src="Bus/images/icono.png" alt="Circle Template"></a>
            </h1>
            <div class="col-md-2"></div>
            <div class="text-center">
            	<form class="input-form col-md-8" action="#" method="post" target="Bus/inicio.html">
                    <big>Usuario</big>
                    <input type="text" name="user" id="user" maxlength="9">
                    <big>Contraseña</big>
                    <input type="password" name="pass" id="pass" maxlength="12">
                    <input type="button" name="login" id="login" value="Login" class="button button-yellow">
                    <p align=center><a href="Bus/registro.php">¿No tienes una Cuenta?</a></p>
                    <span id="result"></span>
                </form>
            </div>
        </div>
    </div>
    

    <!-- 
    ########################################################################
    ################         Funcionalidad JS       ########################
    ######################################################################## 
    -->
    <script src="Bus/js/vendor/jquery-1.10.1.min.js"></script>
    <script>window.jQuery || document.write('<script src="Bus/js/vendor/jquery-1.10.1.min.js"><\/script>')</script>
    <script src="Bus/js/jquery.easing-1.3.js"></script>
    <script src="Bus/js/bootstrap.js"></script>
    <script src="Bus/js/plugins.js"></script>
    <script src="Bus/js/main.js"></script>
    <script src="Bus/js/functions.js" charset="utf-8"></script>
    <script type="text/javascript">
            
			jQuery(function ($) {
                $.supersized({
                    slide_interval: 3000, 
                    transition: 1, 
                    transition_speed: 1000,                      
                    slide_links: 'blank', 
                    slides: [ 
                        {
                            image: 'Bus/images/Fondo/Carretera-735.jpg'
                        }, {
                            image: 'Bus/images/Fondo/Carreteras_WWW.fotoblogx.blogspot.COM_00.jpg'
                        }, {
                            image: 'Bus/images/Fondo/Carreteras_WWW.fotoblogx.blogspot.COM_02.jpg'
                        }, {
                            image: 'Bus/images/Fondo/carreteras-4k-hd-wallpapers-elviajeroazul.top-7.jpg'
                        }, {
                            image: 'Bus/images/Fondo/carreteras-4k-hd-wallpapers-elviajeroazul.top-42.jpg'
                        }, {
                            image: 'Bus/images/Fondo/e_hd169_country-road-11.jpg'
                        }

                    ]

                });
            });
            
    </script>
    
</body>
</html>