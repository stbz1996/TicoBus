<?php
	require "../Conection/methods.php";

	if(isset($_POST["idRuta"])){
		$idRuta = $_POST["idRuta"];
		$result = getParadaEspera($idRuta);
		echo "<option value='-1'>Elija una parada</option>";
		foreach ($result as $parada) {
		?>

		<option value="<?php echo $parada["idParada"]; ?>"><?php echo $parada["nombre"]; ?></option>
		<?php
		}
	}


?>