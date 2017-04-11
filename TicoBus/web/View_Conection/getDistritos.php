<?php
	require "../Conection/conection.php";

	if(!empty($_POST["idCanton"])){
		$idCanton = $_POST["idCanton"];
		$consulta = "consultaDistritos($idCanton)";
		$result = execute_Query($consulta);
		echo "<option value='-1'>Elija un distrito</option>";
		foreach ($result as $distrito) {
		?>

		<option value="<?php echo $distrito["idDistrito"]; ?>"><?php echo $distrito["nombreDistrito"]; ?></option>
		<?php
		}
	}

?>