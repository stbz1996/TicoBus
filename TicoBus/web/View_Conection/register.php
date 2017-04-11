<?php
  	require "../Conection/methods.php";
 	session_start();
    $num_row = createUser($_POST["cedula"],  $_POST["distrito"], $_POST["firstName"], $_POST["lastName"], $_POST["pass"], $_POST["detalle"]);
    if($num_row == "1"){echo "1";}
  
?>