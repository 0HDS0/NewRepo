function salvar(){

    let pessoa = {
        id: ParseInt(document.getElementById("id").value),
        nome: document.getElementById("nome").value
    };    

    $.ajax({
        headers:{ 
            "Accept": "application/json", 
            "Content-Type":"application/json"
        },
        url:"https://localhost:7239/api/Pessoa/novo",
        type:"POST",
        data: JSON.stringify(pessoa),
        success: function(result){console.log(result);},
        error: function(error){console.error(error);}
    });
    // const request = new XMLHttpRequest(); 
    // request.open("GET","https://localhost:7239/api/pessoa/teste")
    // request.onload = function() {
    //     console.log(this.responseText)
    // }
    // request.onerror = function() {

    // }
    // request.send();


    // fetch("https://localhost:7239/api/pessoa/teste", 
    // {method: "GET"}).then
    //     (result => 
    //     {
    //     result.text().then(text=>{console.log(text);});
    //     }
    //     ).catch(error => {console.error(error);
    // });
    
}

function consultar(){
    let idconsulta = parseInt(document.getElementById("consulta").value);
    let inputId = document.getElementById("id");
    let inputName = document.getElementById("nome");
    
$.ajax(
    {
        url:"https://localhost:7239/api/Pessoa/"+ idconsulta, 
        type: "GET", 
        success:function(result) {
            console.log(result);
            inputId.value = result.id;
            inputName.value = result.nome;
        },
        error: function(error){console.error(error)} 
    }
    )
}