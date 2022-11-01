'use strict';
const btnAdd = document.getElementById('btnAddNewTask');
const txtTaskName = document.getElementById('txtTaskName');
const btnClear = document.getElementById('btnClear');
const filters = document.querySelectorAll('.filters span')// querySelectorAll ile filertes clasındaki spanları seç dedik
const taskBox=document.getElementById('task-box');
let isEditMode = false;
let editedId;

btnAdd.addEventListener('click', newTask);
txtTaskName.addEventListener('keypress', function(event){  
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});

btnClear.addEventListener('click',clearAll);
for (const span of filters) { //spanların içinde dolaşıyoruz
   span.addEventListener('click',function(){
        document.querySelector('span.active').classList.remove('active')// span.active spanın içindeki classı active olanı bul dedik
        span.classList.add('active');
        displayTasks(span.id)//buraya hangi id geliyorsa orayı gösterisn
    });
}

//bunun içindekileri sildik
let gorevListesi = [];
if (localStorage.getItem('gorevListesi')!=null) { //görevlistesi boş dedirttik
    gorevListesi = JSON.parse(localStorage.getItem('gorevListesi')); //görevlistesini karşıdan alıcaz bu şekilde
}

console.log(gorevListesi);

displayTasks();
function displayTasks(filter) {//filter ile yukarıdaki id yi karşılıyoruz
    let ul = document.getElementById('task-list');//buraayı alıyoruz
    ul.innerHTML='';//içini boşaltyoruz
    if (gorevListesi.length==0) { //görevlistsinin uzunlugu 0 ise aşşagıdaki kodu göstersin dedik
        ul.innerHTML='<span class="alert alert-danger mb-0">Görev Listeniz Boş</span>';
    }

    for (const gorev of gorevListesi) {
        let completed = gorev.durum=='completed' ? 'checked' : ' '; //eger gorevin durumu complteds ise checked koy değilse bişey yapma
        if (filter==gorev.durum || filter=='all') {
            
       

        let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input onclick="updateStatus(this)" type="checkbox" id="${gorev.id}" class="form-check-input" ${completed}>
                <label for="${gorev.id}" class="form-check-label ${completed}">${gorev.gorevAdi}</label>
            </div>

            <div class="dropdown">
                <button class="btn btn-link dropdown-toggle" type="button" data-bs-toggle="dropdown" aria-expanded="false">
                <i class="fa-solid fa-ellipsis"></i>
                </button>
                <ul class="dropdown-menu">
                    <li><a onclick="removeTask(${gorev.id})" class="dropdown-item" href="#"><i class="fa-solid fa-trash-can"></i> Sil</a></li>
                    <li><a onclick="editTask(${gorev.id},'${gorev.gorevAdi}')" class="dropdown-item" href="#"><i class="fa-solid fa-pen"></i> Düzenle</a></li>
                  
                </ul>
                </div>
        </li> `;
        ul.insertAdjacentHTML('beforeend', li);
    };
 };
}


function newTask(event){
    event.preventDefault();
    if (isFull(txtTaskName.value)==true) {
        if (!isEditMode) {//isedit modundaysan
            //yeni kayıt işlemleri
            let id;
            if (gorevListesi.length==0) {
                id=1;
            }
            else{
               id = gorevListesi[gorevListesi.length-1].id + 1;//listenin uzunluğunu bul bir çıkar sonra id ye bir ekle
            }
            gorevListesi.push(
                {
                    'id': id,
                    'gorevAdi': ilkHarfiBuyut(txtTaskName.value),//her kelimenin ilk harfini büyütücek function u yazınız
                    'durum' : 'pending'
                }
            );
        }
        else{
            //güncellleme işlemleri
           for (const gorev of gorevListesi) {
            if (gorev.id==editedId) {
               gorev.gorevAdi=ilkHarfiBuyut(txtTaskName.value);
               isEditMode=false;
               btnAdd.innerText='Ekle';
               taskBox.style.display='block';
               break;
             }
           }
        }      
    }else{
       alert('boş bırakma');    
    }
    txtTaskName.value='';
    displayTasks(document.querySelector('span.active').id);
    txtTaskName.focus();
    //localStorage.setItem('gorevListesi',JSON.stringify(gorevListesi))//görevlistesine şunu yaz
    saveLocal();
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
        gorevListesi.splice(deletedId,1);
        displayTasks(document.querySelector('span.active').id); 
        saveLocal();
       
    }

 function editTask(id,gorevAdi){
        editedId=id;
        isEditMode=true;
        txtTaskName.value=gorevAdi;
        txtTaskName.focus();
        btnAdd.innerText='Kaydet'
        taskBox.style.display='none'
    }

 function clearAll(){
       let cevap = confirm('Tüm görevler silinecek');
       if (cevap) { 
        gorevListesi.splice(0)   
       }
       saveLocal();
       displayTasks('all');
       
 }

 function updateStatus(selectedTask){
  
    let label =selectedTask.nextElementSibling;
    let durum;
    if (selectedTask.checked) { 

        label.classList.add('checked')
        durum = 'completed';
       
    }else{

        label.classList.remove('checked')
        durum = 'pending';

    };
    for (const gorev of gorevListesi) {
        if (gorev.id==selectedTask.id) {
            gorev.durum=durum;
        }
    }
    displayTasks(document.querySelector('span.active').id); 
    saveLocal();
 }

function saveLocal(){ //
    localStorage.setItem('gorevListesi',JSON.stringify(gorevListesi))
}

displayTasks('all');

