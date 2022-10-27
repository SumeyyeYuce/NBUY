//While
// let i=0;
// while(i<10) //eger büyüktür koyarsak 0 10 dan büyükmü diye bakar olmadı için bişey yazmaz
// {
//     i++;
//     console.log(i + '.Javascript');
   
// }

//do While
// let i=0;
// //do da en az bir kere çalışmış olucak
// do {
//     i++;
//     console.log(i +'.Js');
// } while (i>10);


//for döngüsü
// for (let i = 0; i < 10; i++) {

//    console.log(i+1 + '.Javascript');
    
// }

//1 ile 10 arsındaki sayıları toplayıp ekrana yazn program


// let toplam=0;
// let i=1;
// while (i<=10) {
//     toplam+=i;
//     i++;
// }
// console.log('While ile:'+toplam);

// let toplam2=0;
// for (let i = 1; i <=10; i++) {
//    toplam2+=i;
   
    
// }
// console.log('for ile:'+toplam2);

//kullanıcını girecegi 3 sayıyı toplatan  for kullanarak yazınız

// let sayı;
// let toplam=0;
//  sayı=prompt('Lütfen bir sayı Giriniz:')
//  document.write(sayı);
// // let toplambul=Number(sayı);

// let girilenSayılar;
// for (let i = 0; i <=3; i++) {
 
//     toplam=toplam+i;
// //     girilenSayılar=sayı;
// //    toplambul+=girilenSayılar;
    
// }
// console.log(toplam);

//kullanıcını girecegi 3 sayıyı toplatan  for kullanarak yazınız
// let toplam=0;
// let girilenSayılar;
// for (let i = 1; i <=3; i++) {
//     girilenSayılar=Number(prompt(i+'.sayı'));
//     toplam+=girilenSayılar;
    
// }
// console.log('Toplam:' +toplam);

//0 giirlene kadar girilen sayıları toplayan program


//son örnekteki girilen sayıları da sonuçta yazdıralım
//girilen sayıları diziye aktaraak yaz
// let toplam=0;
// let girilenSayılar=[];
// let i=0;
// do {
//     girilenSayılar[i]=Number(prompt(i+1 +'.sayı'));
//     toplam+=girilenSayılar[i];
//     i++;    
    
// } while (girilenSayılar[i-1]!=0);
// girilenSayılar.pop();
// for (let i = 0; i < girilenSayılar.length; i++) {
//    console.log(i+1 +'.sayı\t' + girilenSayılar[i]);
    
// }
// console.log('Toplam:'+toplam);
// console.log('1.sayı'+i, '2.Sayı'+i,'3.Sayı'+i);




//Kullanıcının isyediği kadra sayı girmesini saglayan
//Sayı girişi bitişiş için 0 a basılması gereksin
//0  a basılıp sayı girişi bittiğinde kullanıcıya şu soruyu sorun
//Tek mi çift mi*
//tek derse tek sayıları topla
//çift derse çift sayıları topla



let sayılar = [];
let i=0;
//sıfır girene kadar dönen bir döngü
do {
    sayılar[i]=Number(prompt(i+1 +'.Sayı'));
    i++;
} while (sayılar[i-1]!=0);
sayılar.pop();

let sonucDizi = [];
let toplam=0;
let tur;
let cevap = prompt('Tek mi, Çift mi')
console.log(' cevap:'+cevap);
if (cevap.toLocaleLowerCase()=='tek') {
    tur='Tek';
    for (let i = 0; i <sayılar.length; i++) {
        if (sayılar[i]%2===1) {
            sonucDizi.push(sayılar[i]);
            toplam+=sayılar[i];
        }
        
    }
}
else if(cevap.toLocaleLowerCase()=='çift'){
    tur='Çift';
    for (let i = 0; i <sayılar.length; i++) {
        if (sayılar[i]%2===0) {
            sonucDizi.push(sayılar[i]);
            toplam+=sayılar[i];
        }
        
    }
}else{
    // alert('Lütfen tek ya da çift yaz')
    console.log('Lütfen tek ya da çift yaz');
}

console.log(sayılar);
console.log(tur+ 'Sayılar:'+ sonucDizi);
console.log(tur + 'Sayılar Toplamı:' +toplam);