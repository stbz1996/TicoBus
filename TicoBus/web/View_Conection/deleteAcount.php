<?php
  	require "../Conection/methods.php";
  	session_start();
  	$acount = $_POST["acount"];
  	$user = $_SESSION["user"];
  	$verification = deleteAcount($acount, $user);
    if($verification == "1"){echo "1";}
  
?>