<?php
	session_start();
	require "../Conection/methods.php";
	if(isset($_POST["fechaInicio"]) && isset($_POST["fechaFinal"])){
		$fechaInicio = $_POST["fechaInicio"];
		$fechaFinal = $_POST["fechaFinal"];
		$usuario = $_SESSION["user"];
		$consulta = obtenerViajesUsuario($usuario, $fechaInicio, $fechaFinal);
		if(mysqli_num_rows($consulta)){
			echo "<br><table><col width='200'><tr><th>Fecha</th><th>Ruta</th><th>Tarifa</th><th>Parada Inicio</th><th>Parada Final</th></tr>";
			while($viaje = mysqli_fetch_assoc($consulta)){
				echo "<tr><td><big>".$viaje["fecha"]."</big></td><td><big>".$viaje["ruta"]."</big></td><td><big>".$viaje["tarifa"]."</big></td><td><big>".$viaje["paradaInicio"]."</big></td><td><big>".$viaje["paradaDestino"]."</big></td></tr>";
			}
			echo "</table>";
		}else {
		    echo "0 results";
		}

	}



?>