<?php
	require "conection.php";
	
	function obtenerViajesUsuario($usuario, $fechaInicio, $fechaFinal){
		$consulta = "viajesPorUsuario($usuario, '$fechaInicio', '$fechaFinal')";
		return execute_Query($consulta);
	}

	function verSaldoUsuario($usuario){
		$sqlConsulta = "verSaldo('$usuario')";
  		$result = execute_Query($sqlConsulta);
  		return mysqli_fetch_assoc($result);
	}

	function obtenerRutas($pParadaInicio, $pParadaDestino){
		$consulta = "consultarRutas($pParadaInicio, $pParadaDestino)";
		return execute_Query($consulta);
	}

	function obtenerRangoHorario($pRuta, $pParada){
		$consulta = "consultaRangoHorario($pRuta, $pParada)";
		return execute_Query($consulta);
	}

	function getEmpresas(){
		$consulta = "consultaEmpresa()";
		return execute_Query($consulta);
	}

	function getRutasEmpresa($idEmpresa){
		$consulta = "consultaRutasEmpresa($idEmpresa)";
		return execute_Query($consulta);
	}

	function getParadaEspera($idRuta){
		$consulta = "consultaParadasRuta($idRuta)";
		return execute_Query($consulta);
	}

	function obtenerEspera($idRuta, $idParada){
		$consulta = "consultaEsperaParada($idRuta, $idParada)";
		return execute_Query($consulta);
	}
	
	function recharge($userActual, $acountNum, $mountRecharge){
        $sqlConsulta = "recargarSaldo($userActual, $acountNum, $mountRecharge)";
  		$result = execute_Query($sqlConsulta);
    	return num_rows($result);
	}

	function getProvincias(){
		$consulta = "consultaProvincias()";
        return execute_Query($consulta);
	}

	function createAcount($pAcount, $pUser){
		$sqlConsulta = "insertarCuenta($pAcount, $pUser)";
  		$result = execute_Query($sqlConsulta);
    	return num_rows($result);
	}

	function checkLogin($user, $pass){
		$sqlConsulta = "validarLogin($user,'$pass')";
  		$result = execute_Query($sqlConsulta);
  		return array($result, num_rows($result));  
	}

	function deleteAcount($pAcount, $pUser){
		$sqlConsulta = "eliminarCuenta($pAcount, $pUser)";
  		$result = execute_Query($sqlConsulta);
    	return num_rows($result);
	}

	function createUser($cedula, $distrito, $firstName, $lastName, $pass, $detalle){
		$sqlConsulta = "insertarUsuario($cedula,$distrito,'$firstName','$lastName','$pass','$detalle');";
  		$result = execute_Query($sqlConsulta);
    	return num_rows($result);
	}


?>