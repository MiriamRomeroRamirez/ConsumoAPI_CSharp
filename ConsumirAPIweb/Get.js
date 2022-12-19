
let recurso="http://localhost:52832/api/GrupoCuatrimestre?type=json";
fetch(recurso)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson); 
    var row = "<tr><th>Id_GruCuat</th><th>F_ProgEd</th><th>F_Grupo</th><th>F_Cuatri</th><th>Turno</th><th>Modalidad</th><th>Extra</th></tr>"
    for(var i = 0; i < datosjson.length; i++){
        row +=  
        `<tr>
            <td>${datosjson[i].Id_GruCuat}</td>
            <td>${datosjson[i].F_ProgEd}</td>
            <td>${datosjson[i].F_Grupo}</td>
            <td>${datosjson[i].F_Cuatri}</td>
            <td>${datosjson[i].Turno}</td>
            <td>${datosjson[i].Modalidad}</td>
            <td>${datosjson[i].Extra}</td> 
        </tr>`; 
    }
    var row1 = "<tr><th>Turno</th><th>Modalidad</th><th>Extra</th></tr>"
    for(var i = 0; i < datosjson.length; i++){ 
        row1 +=  
        `<tr>
            <td>${datosjson[i].Turno}</td> 
            <td>${datosjson[i].Modalidad}</td>
            <td>${datosjson[i].Extra}</td> 
        </tr>`; 
    }

    document.getElementById("tabla").innerHTML = row; 
    document.getElementById("tablasinid").innerHTML = row1; 
}) 
.catch(err => console.log("Algo salio mal: "+ err));

let recurso_1="http://localhost:52832/api/SeguimientoAL?type=json";
fetch(recurso_1)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson); 
    var row = "<tr><th>F_PositivoAL</th><th>F_medico</th><th>Fecha</th><th>Form_Comunica</th><th>Reporte</th><th>Entrevista</th><th>Extra</th></tr>"
    for(var i = 0; i < datosjson.length; i++){
        row +=  
        `<tr>
            <td>${datosjson[i].F_PositivoAL}</td>
            <td>${datosjson[i].F_Medico}</td>
            <td>${datosjson[i].Fecha}</td>
            <td>${datosjson[i].Form_Comunica}</td>
            <td>${datosjson[i].Reporte}</td>
            <td>${datosjson[i].Modalidad}</td>
            <td>${datosjson[i].Extra}</td> 
        </tr>`; 
    }
    var row1 = "<tr><th>Fecha</th><th>Form_Comunica</th><th>Reporte</th><th>Entrevista</th><th>Extra</th></tr>"
    for(var i = 0; i < datosjson.length; i++){
        row1 +=  
        `<tr>
            <td>${datosjson[i].Fecha}</td>
            <td>${datosjson[i].Form_Comunica}</td>
            <td>${datosjson[i].Reporte}</td>
            <td>${datosjson[i].Modalidad}</td>
            <td>${datosjson[i].Extra}</td> 
        </tr>`; 
    }

    document.getElementById("tablas").innerHTML = row; 
    document.getElementById("tablasinids").innerHTML = row1; 
}) 
.catch(err => console.log("Algo salio mal: "+ err));


let recurso_2="http://localhost:52832/api/PositivoAlumno?type=json";
fetch(recurso_2)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson); 
    var row = "<tr><th>FechaConfirmado</th><th>Comprobacion</th><th>Antecendentes</th><th>Riesgo</th><th>NumContagio</th><th>Extra</th><th>F_Alumno</th></tr>"
    for(var i = 0; i < datosjson.length; i++){
        row +=  
        `<tr>
            <td>${datosjson[i].FechaConfirmado}</td>
            <td>${datosjson[i].Comprobacion}</td>
            <td>${datosjson[i].Reporte}</td>
            <td>${datosjson[i].Antecendentes}</td>
            <td>${datosjson[i].Riesgo}</td> 
            <td>${datosjson[i].NumContagio}</td> 
            <td>${datosjson[i].Extra}</td> 
            <td>${datosjson[i].F_Alumno}</td> 
        </tr>`; 
    }
    var row1 = "<tr><th>FechaConfirmado</th><th>Comprobacion</th><th>Antecendentes</th><th>Riesgo</th><th>NumContagio</th><th>Extra</th></tr>"
    for(var i = 0; i < datosjson.length; i++){
        row1 +=  
        `<tr>
        <td>${datosjson[i].FechaConfirmado}</td>
        <td>${datosjson[i].Comprobacion}</td>
        <td>${datosjson[i].Reporte}</td>
        <td>${datosjson[i].Antecendentes}</td>
        <td>${datosjson[i].Riesgo}</td> 
        <td>${datosjson[i].NumContagio}</td> 
        <td>${datosjson[i].Extra}</td> 
        </tr>`; 
    }

    document.getElementById("tablap").innerHTML = row; 
    document.getElementById("tablasinidp").innerHTML = row1; 
}) 
.catch(err => console.log("Algo salio mal: "+ err));


//GruposCuatrimestre
let recurso2="http://localhost:52832/api/ProgramaEducativo?type=json";
fetch(recurso2)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson);
    for(var i = 0; i < datosjson.length; i++){
        var option = document.createElement("option");
        option.text = datosjson[i].ProgramaEd;
        option.value = datosjson[i].Id_pe;
        document.getElementById("ProgEd").appendChild(option); 
    }
}) 
.catch(err => console.log("Algo salio mal: "+ err));

let recurso3="http://localhost:52832/api/Grupo?type=json";
fetch(recurso3)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson);
    for(var i = 0; i < datosjson.length; i++){
        var option = document.createElement("option");
        option.text = datosjson[i].Grado + " " + datosjson[i].Letra;
        option.value = datosjson[i].Id_grupo;
        document.getElementById("Grupo").appendChild(option); 
    }
}) 
.catch(err => console.log("Algo salio mal: "+ err));


let recurso4="http://localhost:52832/api/Cuatrimestre?type=json";
fetch(recurso4)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson);
    for(var i = 0; i < datosjson.length; i++){
        var option = document.createElement("option");
        option.text = datosjson[i].Periodo + " " + datosjson[i].Inicio + "-" + datosjson[i].Fin;
        option.value = datosjson[i].id_Cuatrimestre;
        document.getElementById("Cuatri").appendChild(option); 
    }
}) 
.catch(err => console.log("Algo salio mal: "+ err));


let recurso5="http://localhost:52832/api/Medico?type=json";
fetch(recurso5)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson);
    for(var i = 0; i < datosjson.length; i++){
        var option = document.createElement("option");
        option.text = datosjson[i].Nombre + " " + datosjson[i].App + "-" + datosjson[i].Apm;
        option.value = datosjson[i].ID_Dr;
        document.getElementById("Medico").appendChild(option); 
    }
}) 
.catch(err => console.log("Algo salio mal: "+ err));



let recurso6="http://localhost:52832/api/Alumno?type=json";
fetch(recurso6)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson);
    for(var i = 0; i < datosjson.length; i++){
        var option = document.createElement("option");
        option.text = datosjson[i].Matricula + "-" + datosjson[i].Nombre + "-" + datosjson[i].Ap_pat + "-" + datosjson[i].Ap_mat;
        option.value = datosjson[i].ID_Alumno;
        document.getElementById("Alumno").appendChild(option); 
    }
}) 
.catch(err => console.log("Algo salio mal: "+ err));


let recurso7="http://localhost:52832/api/PositivoAlumno?type=json";
fetch(recurso7)
.then(resp => resp.json())
.then(datosjson => {
    console.log(datosjson);
    for(var i = 0; i < datosjson.length; i++){
        var option = document.createElement("option");
        option.text = datosjson[i].Nombre +" " + datosjson[i].Ap_pat + " " + datosjson[i].Ap_mat + "-" + datosjson[i].Riesgo;
        option.value = datosjson[i].ID_posAl;
        document.getElementById("Seguimiento").appendChild(option);  
    }
}) 
.catch(err => console.log("Algo salio mal: "+ err));
