<?php
    require "../Conection/methods.php";
    session_start();
    $user = $_POST["user"];
    $pass = $_POST["pass"];
    list($result, $num_row) = checkLogin($user, $pass);

    if ($num_row == "1") {
      $data = fetch($result);
      $_SESSION["user"] = $data["cedula"];
      $_SESSION["name"] = $data["nombre"];
      echo "1";
    } 
   
  
?>
