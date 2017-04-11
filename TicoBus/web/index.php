
<?php
	session_start();
	if(!isset($_SESSION["user"]) && !isset($_SESSION["name"])){
	  header("location:login.php");
	}
	header("location:Bus/inicio.php");
?>
