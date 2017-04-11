<?php
	require "../Conection/methods.php";

	if(isset($_POST["idEmpresa"])){
		$idEmpresa = $_POST["idEmpresa"];
		$result = getRutasEmpresa($idEmpresa);
		echo "<option value='-1'>Elija una ruta</option>";
		foreach ($result as $ruta) {
		?>

		<option value="<?php echo $ruta["idRuta"]; ?>"><?php echo $ruta["nombre"]; ?></option>
		<?php
		}
	}


?>