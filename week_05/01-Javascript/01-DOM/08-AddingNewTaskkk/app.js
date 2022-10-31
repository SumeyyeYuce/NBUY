'use strict'; //deger ataması yapmassam beni uyar
let gorevListesi = [
    {'id':1,'görevAdı':'Görev 1'},
    {'id':2,'görevAdı':'Görev 2'},
    {'id':3,'görevAdı':'Görev 3'},
    {'id':4,'görevAdı':'Görev 4'},
    {'id':4,'görevAdı':'Görev 5'}



];
displayTasks();
function displayTasks(){
    let ul = document.getElementById('task-list');
    ul.innerHTML='';//birşey eklendiğinde herşeyi tamamen sil içini boşalt
    for (const gorev of gorevListesi) {
        let li = `
        <li class="task list-group-item">
        <div class="form-check">
            <input type="checkbox"  id="${gorev.id}" class="form-check-input"><label for="${gorev.id}" class="form-check-label">${gorev.görevAdı}</label>
        </div>
        </li>

        `;
        ul.insertAdjacentHTML('beforeend',li);  
    }

}

let btnAdd = document.getElementById('btnAddNewTask');
btnAdd.addEventListener('click',newTask);

function newTask(event){
    event.preventDefault();
    let txtTaskName = document.getElementById('txtTaskName');//inputu aldık
    if (txtTaskName.value=='') {
        alert('boş bırakma')
    }
    else{
        gorevListesi.push(
            {
                'id': gorevListesi.length + 1,
                'görevAdı':txtTaskName.value
            }
        );
        displayTasks();
    }
   
    
    //console.log(gorevListesi);
    // console.log(txtTaskName.value);
};
console.log(gorevListesi);