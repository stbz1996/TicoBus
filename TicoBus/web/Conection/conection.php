<?php
	// establish conection with DB
	function conection(){
		$server = "localhost";
		$user = "webUser";
		$password = "webUser";
		$dataBase = "proyecto";
		$conection = mysqli_connect($server, $user, $password);
		if($conection){
			mysqli_select_db($conection, $dataBase);
			return $conection;
		}
	}
	
	// return values from the last query
	function fetch($query){
		return mysqli_fetch_array($query);
	}

	// execute a query
	function execute_Query($query){
		$conection = conection();
		$result = mysqli_query($conection, call_SP().$query);
		mysqli_close($conection);
		return $result;
	}

	// return num of rows
	function num_rows($result){
		return mysqli_num_rows($result);
	}

	// command needed for call SP in some DB
	function call_SP(){
		return "call ";
	}
?>