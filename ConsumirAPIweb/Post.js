function insertarGrupo(){
    let F_ProgEd = document.getElementById("ProgEd").value;
    let F_Grupo = document.getElementById("Grupo").value;
    let F_Cuatri = document.getElementById("Cuatri").value;
    let Turno = document.getElementById("Turno").value;
    let Modalidad = document.getElementById("Modalidad").value;
    let Extra = document.getElementById("Extra1").value;

    let nuevo={
        F_ProgEd : F_ProgEd, 
        F_Grupo : F_Grupo, 
        F_Cuatri : F_Cuatri, 
        Turno : Turno, 
        Modalidad : Modalidad, 
        Extra : Extra,   
    };

    let recurso2="http://localhost:52832/api/GrupoCuatrimestre?type=json";
    fetch(recurso2,{
        method: 'POST', //formato de la petición
        body:JSON.stringify(nuevo), // Convertir los datos a enviar en un flujo(stream)
        headers: {
            'Content-Type':'application/json'
        }
    })
    .then( resp => {
        console.log(resp);
        return resp.json();
    })
    .then(respuestajson=> {
       console.log(respuestajson);
       console.log("Insertado");
        
    }
    )
    .catch(error2 => console.log(error2));
}

function insertarSeguimiento(){
    let F_PositivoAL = document.getElementById("Seguimiento").value;
    let F_medico = document.getElementById("Medico").value;
    let Fecha = document.getElementById("Fecha").value;
    let Form_Comunica = document.getElementById("Form_Comunica").value;
    let Reporte = document.getElementById("Reporte").value;
    let Entrevista = document.getElementById("Entrevista").value;
    let Extra = document.getElementById("Extra2").value;

    let nuevo={
        F_PositivoAL : F_PositivoAL,
        F_medico : F_medico,
        Fecha : Fecha,
        Form_Comunica : Form_Comunica,
        Reporte : Reporte,
        Entrevista : Entrevista,
        Extra : Extra,   
    };

    let recurso2="http://localhost:52832/api/SeguimientoAL?type=json";
    fetch(recurso2,{
        method: 'POST', //formato de la petición
        body:JSON.stringify(nuevo), // Convertir los datos a enviar en un flujo(stream)
        headers: {
            'Content-Type':'application/json'
        }
    })
    .then( resp => {
        console.log(resp);
        return resp.json();
    })
    .then(respuestajson=> {
       console.log(respuestajson);
       console.log("Insertado");
        
    }
    )
    .catch(error2 => console.log(error2));
}

function insertarPositivo(){
    let FechaConfirmado = document.getElementById("FechaConfirmado").value;
    let Comprobacion = document.getElementById("Comprobacion").value;
    let Antecendentes = document.getElementById("Antecendentes").value;
    let Riesgo = document.getElementById("Riesgo").value;
    let NumContagio = document.getElementById("NumContagio").value;
    let Extra = document.getElementById("Extra3").value; 
    let F_Alumno = document.getElementById("Alumno").value;

    let nuevo={
        FechaConfirmado : FechaConfirmado,
        Comprobacion : Comprobacion,
        Antecendentes : Antecendentes,
        Riesgo : Riesgo,
        NumContagio : NumContagio,
        Extra : Extra,
        F_Alumno : F_Alumno  
    };

    let recurso2="http://localhost:52832/api/PositivoAlumno?type=json";
    fetch(recurso2,{
        method: 'POST', //formato de la petición
        body:JSON.stringify(nuevo), // Convertir los datos a enviar en un flujo(stream)
        headers: {
            'Content-Type':'application/json'
        }
    })
    .then( resp => {
        console.log(resp);
        return resp.json();
    })
    .then(respuestajson=> {
       console.log(respuestajson);
       console.log("Insertado");
        
    }
    )
    .catch(error2 => console.log(error2));
}