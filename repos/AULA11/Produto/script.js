function register(){
    const resultH3 = document.getElementById('result')
    const product = {
        id_produto: parseInt(document.getElementById("idCadProd").value),
        nome_produto: document.getElementById("name").value,
        val_produto: document.getElementById("validity").value,
        idcat_produto: parseInt(document.getElementById("category").value)
    }

    $.ajax({
        headers:{
            "Accept": "application/json",
            "Content-Type": "application/json"
        },
        url: "https://localhost:7125/api/Product/new",
        type: "POST",
        data: JSON.stringify(product),
        success: function(result){
            resultH3.innerHTML = "Produto cadastrado com sucesso";
        },
        error: function(error){
            resultH3.innerHTML = error.responseJSON;
        }
    })
}

function getProduct(){

const id_query = document.getElementById("id_query").value;
const errorH3 = document.getElementById("error")

const id = document.getElementById("id");
const name = document.getElementById("name");
const validity = document.getElementById("validity");
const category = document.getElementById("category")

errorH3.innerHTML = "";
id.value = "";
name.value = "";
validity.value = "";
category.value = "";

$.ajax({
    url: `https://localhost:7125/api/Product/${id_query}`,
    type:"GET",
    success: function(result){
        console.log(result)
        id.value = result.id_produto;
        name.value = result.nome_produto;
        validity.value = result.val_produto.replace("T00:00:00","");
        category.value = result.category_produto.desc_cat;
    },
    error: function(error){
        errorH3.innerHTML = error.responseText;
    }
});
}

function loadCategory(){
    //Por não é necessário alterar a variaveis usamos const
    const categorySelect = document.getElementById("category")
    const errorH3 = document.getElementById("error");
    $.ajax({
        url: "https://localhost:7125/api/Category/all",
        Type: "GET",
        success: function(result){
            if (result.length == 0){
                errorH3.innerHTML = "Não existem categorias cadastrasdasadasadasadas!";
                return;
            }
            $.each(result,function(index,option){
                categorySelect.innerHTML += `<option value="${option.id_cat}">${option.desc_cat}</option>`;
            })
        },
        error: function(error){
            errorH3.innerHTML = error.responseText;
        }
    })

}

function listUnexpiredProduct(){
    const listDiv = document.getElementById("list");
    listDiv.innerHTML = "";

    $.ajax({
        url: "https://localhost:7125/api/Product/unexpired",
        type: "GET",
        success: function(result){
            if (result.length == 0) {
                listDiv.innerHTML = "<h3>Todos os produtos cadastrados estão vencidos ou não há produtos cadastrados</h3>"
                return;
            }

            $.each(result,function(index, product){
            listDiv.innerHTML += 
                `
                ID: ${product.id_produto}<BR>
                Nome: ${product.nome_produto}<br>
                Validade: ${new Date(product.val_produto).toDateString()}<br>
                Categoria: ${product.category_produto.desc_cat}<br><br>
                `
            })
            
        },
        error: function(error){
            listDiv.innerHTML = `<h3>${error.responseText}</h3>`;
        }
    })
}