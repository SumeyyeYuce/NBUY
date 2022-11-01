'use strict';
const btnAdd = document.getElementById('btnAddNewTask');
const txtTaskName = document.getElementById('txtTaskName');
const btnClear = document.getElementById('btnClear');
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
    if (gorevListesi.length==0) { //görevlistsinin uzunlugu 0 ise aşşagıdaki kodu göstersin dedik
        ul.innerHTML='<span class="alert alert-danger mb-0">Görev Listeniz Boş</span>';
    }

    for (const gorev of gorevListesi) {
        let li = `
        <li class="task list-group-item">
            <div class="form-check">
                <input onclick="updateStatus(this)" type="checkbox" id="${gorev.id}" class="form-check-input">
                <label for="${gorev.id}" class="form-check-label">${gorev.gorevAdi}</label>
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
        </li>
    `;
        ul.insertAdjacentHTML('beforeend', li);
    }
}


function newTask(event){
    event.preventDefault();
    

    if (isFull(txtTaskName.value)==true) {
        if (!isEditMode) {
            //yeni kayıt işlemleri
            gorevListesi.push(
                {
                    'id': gorevListesi.length + 1,
                    'gorevAdi': ilkHarfiBuyut(txtTaskName.value)//her kelimenin ilk harfini büyütücek function u yazınız
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
               break;
             }
           }
        }

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
        gorevListesi.splice(deletedId,1);
        displayTasks(); 
    }

 function editTask(id,gorevAdi){
        editedId=id;
        isEditMode=true;
        txtTaskName.value=gorevAdi;
        txtTaskName.focus();
        btnAdd.innerText='Kaydet'
    }

 function clearAll(){
       let cevap = confirm('Tüm görevler silinecek');
       if (cevap) { //eger ture ise içindekkileri çalıştır değilse bişe yapma aynı kalsın
        gorevListesi.splice(0)//sıfırdan başla hepsini sil. ikinci parametreyi veermessek 0 la hepsini siler
        displayTasks();
       }
       
 }

 function updateStatus(selectedTask){
    // console.log(selectedTask.parentElement.lastElementChild);//bir üstndeki getir.sonrada lastElementChild son elamnı getir
    // console.log(selectedTask.nextElementSibling);// nextElementSibling ile üstünü çizdiricegimiz elamnı seçtirdik
    let label =selectedTask.nextElementSibling;
    if (selectedTask.checked) { //EGER Selectedtask seçiliyse demek
        label.classList.add('checked')//tıkladıgımda üstünğ çiz
        //label.style.color='red';
        //console.log('seçili');
    }else{
        label.classList.remove('checked')//bidaha tıkladıgımda sil
        //label.style.color='black';
        //console.log('SeÇİLİ DEĞİL');
    }
 }

displayTasks();

