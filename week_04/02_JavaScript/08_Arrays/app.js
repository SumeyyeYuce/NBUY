//dizi tanımlama
// let urunler = [];
// urunler[0] ='Samsung';
// urunler[1] ='İphone 13';
// urunler[123]='Bilgisayar'

//farklı bir tanımlama
// let urunler = ['iphone 13', 'iphone 11', 'Dell X5']

// let fiyatlar = [15000,20000,40000]
// let renkler = ['Gri', 'Lacivert', 'Sarı']

// //foreach sadece dizileri için kullanılır burada
// urunler.forEach((urun, i)=>{ 
//     console.log(urun,fiyatlar[i],renkler[i]);
// });

// console.log(urunler);
// console.log(fiyatlar);
// console.log(renkler);


//bunları object olarak tanımlıyor
// let urun1 = [];
// urun1[0] = 'İPHONE 13';
// urun1[1] = 25000;
// urun1[2] = 'Gold';
// urun1[3] = true;

// let urun2 = ['Dell X5',2000,'Sarı',false];
// let urun3 = ['Samsung X2',3000,'Mavi',true];

// let urunler = [urun1,urun2,urun3];

// console.log(urun1,typeof urun1);
// console.log(urun2,typeof urun2);
// console.log(urun3,typeof urun3);
// console.log(urunler,typeof urunler);


// let urun1 = 'İphone 13, 25000, Yeşil, true';
// let urun1Dizi = urun1.split(',');
// console.log(urun1,typeof urun1);
// console.log(urun1Dizi,typeof urun1Dizi);


// let ogrenciler = ['Cemre','Melahat', 'Sema', 'HasanCAN'];
// let sonuc;
// sonuc = ogrenciler.length;
// sonuc=ogrenciler;
// sonuc = ogrenciler.toString();//tek parçada yazdı
// sonuc  = ogrenciler.join('-')//aralarına - koyarak birleştir

// console.log(sonuc);


let ogrenciler = ['Cemre','Melahat', 'Sema', 'HasanCAN'];
let sonuc;
ogrenciler[4]='Serhat';
ogrenciler.push('Aylin');//bir dizinin en sonuna eleman ekler push
ogrenciler.pop();//dizinin içindeki son elamanı siler.


sonuc=ogrenciler.push('Aylin');//dizinin son eleman sayısı
sonuc = ogrenciler.pop();//sondaki hangi elamnı sildiğini gösterir.
sonuc =ogrenciler.unshift('Aylin');//Dizinin en başına elaman ekler.


console.log(ogrenciler);
console.log(sonuc);