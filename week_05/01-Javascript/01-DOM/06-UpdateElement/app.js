'use strict'; //deger ataması yapmassam beni uyar
let sonuc;

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

//document.querySelector('#task-list').remove();//task-list in içindekileri siler
//document.querySelector('#task-list').parentElement.remove();
//document.querySelector('#task-list').children[0].remove();//birinciyi sil dedik
//document.querySelector('#task-list').children[2].remove();

//document.querySelector('#task-list').removeAttribute('class');//clasını sil
//document.querySelector('#task-list').children[1].removeAttribute('class');
//sonuc=document.querySelector('#task-list').children[1].getAttribute('class');
//sonuc=document.querySelector('#task-list').children[1].setAttribute('class','bg-danger');//eskiyi atıp yeni degeri koyar

sonuc= document.querySelector('#task-list').children[1].classList;
document.querySelector('#task-list').children[1].classList.add('bg-danger');//add ile bg-danger ekledik
sonuc=document.querySelector('#task-list').children[1].classList.contains('bg-danger');//containes ile içinde bg-danger varmı yokmu onu sorduk
sonuc=document.querySelector('#task-list').children[0].classList.contains('bg-danger');//false der





console.log(sonuc);

