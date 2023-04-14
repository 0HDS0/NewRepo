function getCategory(){
    let IdQuery = document.getElementById("id_query").value;
    let idInput = document.getElementById("id");
    let descriptionInput = document.getElementById("description");
    let errorH3 = document.getElementById("error");

    idInput.value = "";
    descriptionInput.value = "";
    errorH3.value = "";
    $.ajax({
        url: `https://localhost:7125/api/Category/${IdQuery}`,
        type:"GET",
        success: function(result){
            idInput.value = result.id_cat;
            descriptionInput.value = result.desc_cat
        },
        error: function(error){
            errorH3.innerHTML = error.responseText;
        }
    });
}

function register(){
    let Category = {
        id_cat: parseInt(document.getElementById("id").value),
        desc_cat: document.getElementById("description").value
    }
    
    $.ajax({
        headers: {
            "Accept": "application/json",
            "Content-Type": "application/json"
        },
        url: "https://localhost:7125/api/Category/new",
        type: "POST",
        data: JSON.stringify(Category),
        success: function(result) {
            document.getElementById("response").innerHTML = "Categoria cadastrada com sucesso!";
        },
        error: function(error){
            let jsonObj = { };
            $.each(error,function(index, value){
                jsonObj[index] = value
            })

            console.log(jsonObj);
            document.getElementById("response").innerHTML = 
            error.responseJSON;
        }
    })
}