<?php
	require "../Conection/methods.php";
	if(isset($_POST["idRuta"]) && isset($_POST["idParada"])){
		$idRuta = $_POST["idRuta"];
		$idParada = $_POST["idParada"];

		$consulta = obtenerEspera($idRuta, $idParada);
		if(mysqli_num_rows($consulta)){
			while($espera = mysqli_fetch_assoc($consulta)){
				echo "Aproximadamente en ".$espera["espera"]." llega el bus";
			}
		}
	}
?>