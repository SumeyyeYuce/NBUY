'use strict'; //deger ataması yapmassam beni uyar
let gorevListesi = [
    {'id':1,'görevAdı':'Görev 1'},
    {'id':2,'görevAdı':'Görev 2'},
    {'id':3,'görevAdı':'Görev 3'},
    {'id':4,'görevAdı':'Görev 4'},
    {'id':4,'görevAdı':'Görev 5'}



];

let ul = document.getElementById('task-list');
// let ul = document.querySelector('#task-list'); yukarıdaiyle aynı işi yapar

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
//let btnEkle = document.querySelector('#btnAddNewTask');
//btnEkle.addEventListener('click',function(event){
    //btn ekle adlı elemetne tıklandıgında çalışıcak kodlar burada
    //buraya gelen event parametresi ilgili elementin gerçekleşen click olayı ile ilgili blgildeini barındırıyor
    //event.preventDefault();//bu olayın defolut davranışı var ve onu kapat dedik.yani sayfayı  yenileme dedik
    //console.log('btnEkle tıklandı');
//});//click dedik üstüne tıklansın sonra 



// let btnTemizle = document.querySelector('#btnClear');
// btnTemizle.addEventListener('click',clearAll);

// function clearAll(event){
//     event.preventDefault();
//     console.log('tıklandı');
// }

let btnAdd= document.querySelector('#btnAddNewTask');
btnAdd.addEventListener('click',newTask);

function newTask(event){
    event.preventDefault();
    event.target.classList.add('btn-warning');
    // event.target.style.display='none'; bunu yapınca kaybolur
    console.log(event.target);
}

