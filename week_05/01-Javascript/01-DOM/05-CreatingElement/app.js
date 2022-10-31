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
     ul.insertAdjacentHTML('beforeend',li)
   
}


