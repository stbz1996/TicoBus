<?php
	require "../Conection/methods.php";

	if(isset($_POST["ruta"]) && isset($_POST["parada"])){
		$ruta = $_POST["ruta"];
		$parada = $_POST["parada"];

		$consulta = obtenerRangoHorario($ruta, $parada);
		if(mysqli_num_rows($consulta)){
			echo "<br><table><col width='250'><tr><th>Horas</th></tr>";
			while($horas = mysqli_fetch_assoc($consulta)){
				echo "<tr><td><big>".$horas["promedio"]."</big></td></tr>";
			}
			echo "</table>";
		}else {
		    echo "0 results";
		}

	}


?>