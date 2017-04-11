<?php
  	require "../Conection/methods.php";
  	session_start();
	$userActual = $_SESSION["user"];
	$numAcount = $_POST["numAcount"];
	$mountRechange = $_POST["mountRechange"];
    $verification = recharge($userActual, $numAcount, $mountRechange);  
	if($verification == "1"){echo "1";}
?>