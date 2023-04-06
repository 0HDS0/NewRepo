function Calculation() {
    let calcular = {
        valor_1: parseFloat(document.getElementById("Valor_1").value),
        valor_2: parseFloat(document.getElementById("Valor_2").value),
        operacoes: parseInt(document.getElementById("Operacoes").value)
    }

    console.log(JSON.stringify(calcular));
    
    $.ajax({
        headers:{ 
            "Accept": "application/json", 
            "Content-Type":"application/json"
        },
        url:"https://localhost:7101/api/Calculator/Execute",
        type:"POST",
        data: JSON.stringify(calcular),
        success: function(result){console.log(result);},
        error: function(error){console.error(error);}
    });
}