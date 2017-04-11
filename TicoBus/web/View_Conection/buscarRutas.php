<?php
	require "../Conection/methods.php";

	if(isset($_POST["idParadaInicio"]) && isset($_POST["idParadaDestino"])){
		$idParadaInicio = $_POST["idParadaInicio"];
		$idParadaDestino = $_POST["idParadaDestino"];

		$consulta = obtenerRutas($idParadaInicio, $idParadaDestino);
		if(mysqli_num_rows($consulta)){
			echo "<br><h2>Rutas Posibles</h2><table><col width='200'><col width='130'><tr><th>Ruta</th><th>Tarifas</th></tr>";
			while($ruta = mysqli_fetch_assoc($consulta)){
				echo "<tr><td><big>".$ruta["nombre"]."</big></td><td><big>".$ruta["tarifa"]."</big></td><td><input type='button' id=".$ruta["idRuta"]." name='Recargar' onclick = 'getHorario(this.id, $idParadaInicio)' value='Horario' class='button text-center' data-toggle='modal' data-target='#myModal'></td></tr>";
			}
			echo "</table>";
		}else {
		    echo "0 resultados";
		}

	}

?>