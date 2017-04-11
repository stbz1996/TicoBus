
  $(document).ready(function() {
    // call a function to calculate 'saldo' 
     $('#verSaldo').click(function(){
      var user = 'Usuario'
      $.ajax({
            url:"../View_Conection/solicitarSaldo.php",
            method:"POST",
            data:{user:user},
            cache:"false",
            
            beforeSend:function() {
              $('#verSaldo').val("Buscando");
            },
        
            success:function(data) {
              $('#verSaldo').val("Ver Saldo");
              $('#msjSaldo').html(data);
            }
        });


    });

     // llok if exist any 'viaje'
    $('#consultarViaje').click(function(){
      var fechaInicio = $('#startdate').val();
      var fechaFinal = $('#enddate').val();
      
      if(!fechaInicio){
        $("#mostrarViajes").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Debe ingresar una fecha inicial</div>");   
      }
      else if(!fechaFinal){
        $("#mostrarViajes").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Debe ingresar una fecha final</div>"); 
      }
      else if(fechaInicio == fechaFinal){
        $("#mostrarViajes").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Ingresó la misma fecha</div>");  
      }
      else{
        $.ajax({
            url:"../View_Conection/getViajesUsuario.php",
            method:"POST",
            data:{fechaInicio:fechaInicio, fechaFinal:fechaFinal},
            cache:"false",
            
            beforeSend:function() {
              $('#consultarViaje').val("Cargando...");
            },
            
            success:function(data) {
              //Parte a modificar
              $('#consultarViaje').val("Consultar");
              $('#mostrarViajes').html(data);
            }
        });
      }
    });




    // look how much time a user need to wait
    $('#mostrarEspera').click(function(){
      var idRuta = $('#rutaEmpresa').val();
      var idParada = $('#paradaEspera').val();
      if(idRuta == -1){
        $("#mostrarInformacion").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Debe seleccionar una ruta primero</div>");   
      }
      else if(idParada == -1){
        $("#mostrarInformacion").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Debe seleccionar una parada primero</div>");  
      }
      else{
        $.ajax({
            url:"../View_Conection/getEspera.php",
            method:"POST",
            data:{idRuta:idRuta, idParada:idParada},
            cache:"false",
            
            beforeSend:function() {
              $('#mostrarEspera').val("Cargando...");
            },
            
            success:function(data) {
              //Parte a modificar
              $('#mostrarEspera').val("Consulta Espera");
              $('#mostrarInformacion').html(data);
            }
        });
      }
    });

    // look if exist a rute
    $('#busquedaRutas').click(function(){
      var idParadaInicio = $('#paradaInicio').val();
      var idParadaDestino = $('#paradaDestino').val();
      if (idParadaInicio == -1){
        $("#resultadoRutas").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Debe seleccionar una parada de inicio</div>");  
      }
      else if(idParadaDestino == -1){
        $("#resultadoRutas").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Debe seleccionar una parada de destino</div>");
      }
      else if (idParadaInicio == idParadaDestino){
        $("#resultadoRutas").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Seleccionó la misma parada</div>");  
      }
      else{
        $.ajax({
            url:"../View_Conection/buscarRutas.php",
            method:"POST",
            data:{idParadaInicio:idParadaInicio, idParadaDestino:idParadaDestino},
            cache:"false",
            
            beforeSend:function() {
              $('#busquedaRutas').val("Cargando...");
            },
            
            success:function(data) {
              $('#busquedaRutas').val("Buscar Rutas");
              $('#resultadoRutas').html(data);
            }
        });
      }
    });
    

    // recharge an acount
    $('#recargar').click(function(){
      var numAcount = $('#numberCuenta').val();
      var mountRechange = $('#montoRecarga').val();

      if($.trim(numAcount) == 0){
        $("#resp3").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>No ingreso el numero de cuenta</div>");
      }
      else if($.trim(mountRechange) == 0){
        $("#resp3").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>No se ingreso el monto a recargar</div>");
      }
      else if ($.trim(numAcount).length != 15){
        $("#resp3").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El número de cuenta debe contener 15 caracteres numéricos.</div>");  
      }
      else if (isNaN(parseInt(numAcount))){
        $("#resp3").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El número de cuenta debe contener solo caracteres numéricos</div>");  
      }
      else if (isNaN(parseInt(mountRechange))){
        $("#resp3").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Digite solo caracteres númericos en la recarga</div>");  
      }
      else{
        $.ajax({
          url:"../View_Conection/recharge.php",
          method:"POST",
          data:{numAcount:numAcount, mountRechange:mountRechange},
          cache:"false",

          beforeSend:function() {
            $('#recargar').val("Espere");
          },

          success:function(data) {
            $('#recargar').val("Recargar");
            if (data=="1") {
              $("#resp3").html("<div class='alert alert-dismissible alert-success'><button type='button' class='close' data-dismiss='alert'>&times;</button>La recarga se ha completado corréctamente</div>");
            }
            else{
              $("#resp3").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Verifique su número de cuenta o el saldo de su cuenta</div>");
            }
          }
        });
      }
    });

    // remove an acount
    $('#eliminarCuenta').click(function(){
      var acount = $('#numeroCuentaEliminar').val();
      if($.trim(acount) == 0){
        $("#resp2").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>No se ingresó un número de cuenta.</div>");
      }
      else if ($.trim(acount).length != 15){
        $("#resp2").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El número de cuenta debe contener 15 caracteres numéricos.</div>");  
      }
      else if (isNaN(parseInt(acount))){
        $("#resp2").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El número de cuenta debe contener solo caracteres numéricos</div>");  
      }
      else{
        $.ajax({
          url:"../View_Conection/deleteAcount.php",
          method:"POST",
          data:{acount:acount},
          cache:"false",
          
          beforeSend:function() {
            $('#eliminarCuenta').val("Eliminando");
          },
          
          success:function(data) {
            $('#eliminarCuenta').val("Eliminar");
            if (data=="1") {
              $("#resp2").html("<div class='alert alert-dismissible alert-success'><button type='button' class='close' data-dismiss='alert'>&times;</button>Cuenta eliminada corréctamente</div>");
            }
            else{
              $("#resp2").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Número de cuenta invalido</div>");
            }
          }
        });   
      }
    });


    // make an acount 
    $('#Cuenta').click(function(){
      var acount = $('#numeroCuenta').val();
      if($.trim(acount) == 0){
        $("#resp").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>No se ingresó un número de cuenta.</div>");
      }
      else if ($.trim(acount).length != 15){
        $("#resp").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El número de cuenta debe contener 15 caracteres numéricos.</div>");  
      }
      else if (isNaN(parseInt(acount))){
        $("#resp").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El número de cuenta debe contener solo caracteres numéricos</div>");  
      }
      else{
        $.ajax({
          url:"../View_Conection/registerAcount.php",
          method:"POST",
          data:{acount:acount},
          cache:"false",
          
          beforeSend:function() {
            $('#Cuenta').val("Creando");
          },
          
          success:function(data) {
            $('#Cuenta').val("Crear");
            if (data=="1") {
              $("#resp").html("<div class='alert alert-dismissible alert-success'><button type='button' class='close' data-dismiss='alert'>&times;</button>Cuenta creada corréctamente</div>");
            }
            else{
              $("#resp").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Número de cuenta invalido</div>");
            }
          }
        });   
      }
    });


    // for login
    $('#ver').click(function(){
      $("#verificar").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Existe un usuario con esa cedula.</div>");
    });


    $('#gotoinicio').click(function(){
      $(location).attr('href','../login.php');
    });

    // for exit 
    $('#exit').click(function(){
      $(location).attr('href','../logout.php');
    });
    $('#exit2').click(function(){
      $(location).attr('href','logout.php');
    });



    // check login
    $('#login').click(function(){
      var user = $('#user').val();
      var pass = $('#pass').val();

      if($.trim(user) == 0){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>No se ingresó usuario.</div>");
      }
      else if($.trim(pass) == 0){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>No se ingresó contraseña.</div>");
      }
      else{
        $.ajax({
          url:"View_Conection/validLogin.php",
          method:"POST",
          data:{user:user, pass:pass},
          cache:"false",
          beforeSend:function(){
            $('#login').val("Espere");
          },
          success:function(data) {
            $('#login').val("Login");
            if (data=="1") {
              $(location).attr('href','Bus/inicio.php');
            } else {
              $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Usuario no registrado.</div>");
            }
          }
        });
      }
    });



    // create an user acount
    $('#crearCuenta').click(function(){
      var cedula = $('#cedulaRegister').val();
      var firstName = $('#nameRegister').val();
      var lastName = $('#lastNameRegister').val();
      var pass = $('#passwordRegister').val();
      var distrito = $('#distrito').val();
      var detalle = $('#detalleDireccion').val();
      if (isNaN(parseInt(cedula))){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>La Cédula debe contener solo caracteres numéricos</div>");  
      }
      else if ($.trim(cedula).length != 9){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>La Cédula debe contener 9 caracteres numéricos</div>");  
      }
      else if($.trim(firstName).length < 3){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El Nombre debe contener al menos 3 caracteres</div>");
      }
      else if($.trim(lastName).length < 3){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El Apellido debe contener al menos 3 caracteres</div>");
      }
      else if($.trim(pass).length < 6){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>El Password debe contener al menos 6 caracteres</div>");
      }
      else if(distrito == -1){
        $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>Debe ingresar una dirección</div>");  
      }
      else{
        $.ajax({
          url:"../View_Conection/register.php",
          method:"POST",
          data:{cedula:cedula, 
                firstName:firstName, 
                lastName:lastName, 
                pass:pass,
                distrito:distrito,
                detalle:detalle},
          cache:"false",
          
          beforeSend:function() {
            $('#crearCuenta').val("Creando");
          },
          
          success:function(data) {
            $('#crearCuenta').val("Crear");
            if (data=="1") {
              $("#result").html("<div class='alert alert-dismissible alert-success'><button type='button' class='close' data-dismiss='alert'>&times;</button>Usuario creado corréctamente</div>");
            }
            else{
              $("#result").html("<div class='alert alert-dismissible alert-danger'><button type='button' class='close' data-dismiss='alert'>&times;</button>No podemos registrar el usuario con los datos actuales</div>");
            }
          }
        });
      }
    });
  });

  
