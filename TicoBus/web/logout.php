
<?php
	// this part is in charge to control the access on page
	session_start();
	session_destroy();
	header("location:login.php");
?>
