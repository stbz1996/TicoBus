<?php
	require "../Conection/conection.php";

	if(!empty($_POST["idProvincia"])){
		$idProvincia = $_POST["idProvincia"];
		$consulta = "consultaCantones($idProvincia)";
		$result = execute_Query($consulta);
		echo "<option value='-1'>Elija un canton</option>";
		foreach ($result as $canton) {
		?>

		<option value="<?php echo $canton["idCanton"]; ?>"><?php echo $canton["nombreCanton"]; ?></option>
		<?php
		}
	}

?>