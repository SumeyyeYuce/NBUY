/*
    EcmaScript'in gerçek adıolan (let) (ES6-Kısaltması)
    Değişkenler tanımlanırken 3 farklı keyword kullanılabilir
    1)var
    2)let (yeni çıkan bu-aslıda (var) la aynı)
    3)const(sabit)

    - ES6 ile birlikte artık modern javascript tabiri kullanımaya başlanıldı
    bu süreçte let ve conts kullanın var kullanmaktan kaçının

    -js 'te değişken tanımlanırken tip belirtilmez
    bu değişkenlerin tipi olmadıgı anlamına gelmez
    -Js motoru bir değişkene deger atanması esnasında o degere göre tipi belirller
    -eger henüz bir değişkene deger atanmamışsa undefined olarak kabul belirlenir

*/

/* değişken tanımlama*/ 
// let yas=20;
// console.log(yas);

// let ad='Sümeyye';
// let soyad='Yüce';
// console.log(ad, ' ',soyad);
// console.log(ad);
// console.log(soyad);

// let firstName='Serhat';
// let lastName='Kaya';
// console.log(firstName+ ' ' + lastName);

/**farklı tanımlama  en çok kullanılan bu*/
// let sayi1=15;
// let sayi2=25;
// let sayi3=35;

// let s1=15, s2=45, s3=55; /**farklı tanımlama */

/**farklı tanımlama */
//  let sayı1=25,
//      sayı2=55,
//      sayı3=48;


// let durum=true;    

// sayi1=125;
// console.log(sayi1);

/**const sabit demek içine bişey atıyamassın demek */
// conts toplam=0;
// toplam=toplam + sayi1;

// let toplam=0;
// toplam=toplam + sayi1;

// const benimDogumYilim = 2000;
// console.log('benim dogum yılım:'+ benimDogumYilim);

/**
  Bilidğigiz değişken tanımlama yöntemlerini burda da kullanilirz değişkenler camalcase ile isimlendirriiz
değişken ismindde harf,rakam,$ ve _ olabilir
değişken isimleri rakamla başlayabmaz
reserved keyword ları değişken adı olarak kullanılamaz

const sabit degerleri tumak için kullanılır genelde tamamne büyük harf ile isimlendirilir

 */

// const PI_SAYISI=3.14;
// const _PI_SAYISI=3.14;

// const RENK_1='SARI';
// const RENK_2='LACİVERT';
// let renk_3='yeşil';

// console.log(RENK_1, renk_3, RENK_2);


//DATA TYPES

//1-Number
// let sayi1=100;
// console.log(sayi1);
// console.log(typeof sayi1);  //tipini ögrenmek istedik tipi number
// console.log(typeof (sayi1));

// let sayi2=17.5;
// console.log(sayi2, typeof sayi2);

// if (typeof(sayi2)==number) {
//     alert('evet doğru')
// }

// let sayi3=25/0;
// console.log(sayi3, typeof(sayi3)); //Infinity (böyle birşey yok) bir number tipidir.


// let sayi4='okul'/25;
// console.log(sayi4, typeof(sayi4)); //NaN  (not a number) demek

// let sayi5=23434555555555555555555555453453535353535334n; //sayının sonuna n koyduğumuzda sayının tamamını okuyabilirz
// console.log(sayi5, typeof(sayi5));

// let sayi6=sayi5*9999999999999999999999999999999999n;
// console.log(sayi6, typeof(sayi6));

//STRING

/*string ifaedler 3 farklı şekilde iafe edeilir
1) tek tırnak ('')
2) çift tırnak("")
3)Backticks(``)

*/

// let ad='"Sümeyye"';
// let soyad='\'Yüce\'';
// let adSoyad=ad + " " + soyad;
// console.log(adSoyad);

// let adres='halitaga  mahallesi \n\tsütlü nuriye sokak. Candaş apt no:21 \n\tBeşiktaş'; //\n ile tek satırda yazsın dedik. \t ile bi satır içerden başlasın dedik tab gibi
// console.log(adres);

// let adSoyad='Sümeyye Yüce';
// let yas=22;
// let kanGrubu='0RH-';
// let kilo=48;
// let cinsiyet='Kadın';

// console.log('Sayın:'+ adSoyad + ','+ yas +'yasındasınız.\n Kilo:' + kilo + '\nYaş' + yas + '\nCinsiyet' +cinsiyet +'\n\n\n');


// console.log(`Sayın ${adSoyad},${yas} yasındasınız.
//     kilo:${kilo}
//     kan grubu:${kanGrubu}
//     Cinsiyet:${cinsiyet}
// `);



//BOOLEAN
// let durum=true;
// console.log(durum,typeof(durum));

// let ad='Süm';
// console.log(ad,typeof(ad));

//NULL,undefined
// let yas;
// yas=null;
// yas=12/0;
// console.log(yas,typeof(yas));

//javascript te CHAR diye bir tip yok.

//CONVERT DATA TYPES
// let durum=true;
// console.log(durum,typeof(durum));

// let metin='Durumunuz ' + durum + ' Şeklindedir';
// console.log(metin,typeof(metin));

// let durumMetin=String(durum); //bu şekilde durum degerini stringe çevirdik
// console.log(durumMetin,typeof(durumMetin));

// let sayi=25;
// let metin2=sayi + ' yaşındasınız';
// console.log(metin2,typeof(metin2));

// let sayiMetin=String(sayi);
// console.log(sayiMetin,typeof sayiMetin);

// let metinSayı='455';
// console.log(metinSayı,typeof(metinSayı));
// let metinSayiNumber=Number(metinSayı); //numbera dönüştürür
// console.log(metinSayiNumber,typeof(metinSayiNumber));

// let sayıMetin='          145         ';
// console.log(sayıMetin,typeof(sayıMetin));
// let sayi=Number(sayıMetin);
// console.log(sayi,typeof(sayi));

// let sayi=1245n; //n koyuldugunda bunun tipi artık bigint olur
// console.log(sayi,typeof(sayi));


// console.log(Number(true));//1
// console.log(Number(false));//0

// console.log(Boolean(0));
// console.log(Boolean(1));
// console.log(Boolean('0'));

let a;
a='' + 1 + 0; console.log(a,typeof a); //'' bir etki etmedi string bir şeyle + işlemi yapılırsa birleştirme yapar ve string yapar
a='' - 1 + 0; console.log(a,typeof a);//'' birişde yaramdı çıkarma işlemi yaptı
a= true + false; console.log(a,typeof a);
a=6 / '3'; console.log(a,typeof a);//'3' ü number a çevirip işlem yaptı
a= 4 + 5 + 'px'; console.log(a,typeof a);//öncelik aritmetik işlem olmuş sonra string birleştirme yapmış
a='$' + 4 + 5; console.log(a,typeof a);//soldan saga bakıyor ilk birleştirme oldugu içim birleştiriyor
a='4px' - 2; console.log(a,typeof a);//çıkarma işlemi oldugunu içim nan oldu
a='      -9   ' + 5; console.log(a,typeof a);
a=null + 1; console.log(a,typeof a);
a=undefined + 1; console.log(a,typeof a);//undifend ile bişeyi toplayamassın


// a='$' + (4 + 5); console.log(a,typeof a);
// a='      -9   ' - 5; console.log(a,typeof a);//çıkarma işlemi yapmaya çalışır












