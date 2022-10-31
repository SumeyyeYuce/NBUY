let sonuc;
//getElementByClassName -->geeriye birden çok sonuç döndürebilir
//getElementsByTagName -->geeriye birden çok sonuç döndürebilir
//getElementById -->geriye tek bir deger döndürür yukarıdadn aşşagı ilk karşılaştıgını döndürü
//querySelectorAl -->geriye birden çok sonuç döndürür

// sonuc = document.getElementsByClassName('card-header');
// sonuc = document.getElementsByClassName('task');
// sonuc = document.getElementsByClassName('task')[0].innerText;
// sonuc = document.getElementsByClassName('task')[2].innerText;
// sonuc =document.getElementsByClassName('task');

// for (let i = 0; i <sonuc.length; i++) {
//    console.log(sonuc[i].innerText);
    
// }

let taskList= document.getElementsByClassName('task');

//herbiirne task dedik ve tasklist içinde dolaş dedik her defasında task dönücek
// for (const task of taskList) {
//     task.style.color='red';
//     task.style.fontSize='60px';
//     task.innerText='ITEM';

// }

let taskList2  = document.getElementById('task-list-2');
// sonuc = taskList2.getElementsByClassName('task');
sonuc = taskList2.getElementsByTagName('li');

sonuc = taskList2 = document.querySelectorAll('#task-list-2 li');
for (const task of sonuc) {
    task.style.backgroundColor='navy';
    task.style.color='white';
}



console.log(sonuc);