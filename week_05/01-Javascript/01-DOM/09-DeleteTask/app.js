'use strict';
let btnAdd = document.getElementById('btnAddNewTask');
let txtTaskName = document.getElementById('txtTaskName');


btnAdd.addEventListener('click', newTask);
txtTaskName.addEventListener('keypress', function(event){  
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});

let gorevListesi = [
    { 'id': 1, 'gorevAdi': 'Görev 1' },
    { 'id': 2, 'gorevAdi': 'Görev 2' },
    { 'id': 3, 'gorevAdi': 'Görev 3' },
    { 'id': 4, 'gorevAdi': 'Görev 4' },
    { 'id': 5, 'gorevAdi': 'Görev 5' },
];

displayTasks();
function displayTasks() {
    let ul = document.getElementById('task-list');
    ul.innerHTML='';
    for (const gorev of gorevListesi) {
        let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAdi}</label>
            </div>

            <div class="dropdown">
                <button class="btn btn-link dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                <i class="fa-solid fa-ellipsis"></i>
                </button>
                <ul class="dropdown-menu">
                    <li><a onclick="removeTask(${gorev.id})" class="dropdown-item" href="#"><i class="fa-solid fa-trash-can"></i> Sil</a></li>
                    <li><a class="dropdown-item" href="#"><i class="fa-solid fa-pen"></i> Düzenle</a></li>
                  
                </ul>
                </div>
        </li>
    `;
        ul.insertAdjacentHTML('beforeend', li);
    }
}


function newTask(event){
    event.preventDefault();
    

    if (isFull(txtTaskName.value)==true) {
        gorevListesi.push(
            {
                'id': gorevListesi.length + 1,
                'gorevAdi': ilkHarfiBuyut(txtTaskName.value)//her kelimenin ilk harfini büyütücek function u yazınız
            }
        );
        displayTasks();
    }else{
       alert('boş bırakma');
      
    }
    txtTaskName.value='';//her sfeerinde txtTaskName boş bırakılsın dedik.
    txtTaskName.focus();//ekle diyince tekrar inputun aktif olması
    
};

function isFull(value){
    if (value.trim()=='') { //trim başına boşluk bırakırsak onları yok eder
        return false;
    }
    return true;

};

function ilkHarfiBuyut(value){
    let ilkharf = value[0].toUpperCase();
    let gerikalan=value.slice(1);
     return ilkharf + gerikalan;
}

 function removeTask(id){
    let deletedId;
    for (const gorevIndex in gorevListesi) {

        if (gorevListesi[gorevIndex].id==id) {
            deletedId=gorevIndex;
        }
            
   };

    //alternatif modern js yöntemleri
    // deletedId=gorevListesi.findIndex(function(gorev){
    //     return gorev.id==id;//gorevid id ye eşitmi

    // })//findindex dizinin içinde tek tek dolaşıp verdiğimiz dizinin indexsini veriyor

    //alternatif modern js yöntemleri
    //deletedId=gorevListesi.findIndex(gorev=>gorev.id==id)//=> buranın function oldugunu söyler.görevlistesindekş her elamnan gorev adıyla anılıcak

     //console.log(id,deletedId);
   //artık görev listesi diziisnden kaçıncı sıradaki elemanın siliniecgini bilyoru
   //deletedıd'inci sıradaki elamenı silecegiz
        gorevListesi.splice(deletedId,1);
        displayTasks();
       // console.log(gorevListesi);
    
    }

displayTasks();

