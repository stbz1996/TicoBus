<?php
	require "../Conection/conection.php";

	if(!empty($_POST["idProvincia"])){
		$idProvincia = $_POST["idProvincia"];
		$consulta = "consultaParadasProvincias($idProvincia)";
		$result = execute_Query($consulta);
		echo "<option value='-1'>Elija una parada</option>";
		foreach ($result as $parada) {
		?>

		<option value="<?php echo $parada["idParada"]; ?>"><?php echo $parada["nombre"]; ?></option>
		<?php
		}
	}

?>