<?php
	require "../Conection/methods.php";
	session_start();
	$userActual = $_SESSION["user"];
	$saldo = verSaldoUsuario($userActual); 
	echo "Sú saldo es de: ".intval($saldo["saldo"]);
?>
