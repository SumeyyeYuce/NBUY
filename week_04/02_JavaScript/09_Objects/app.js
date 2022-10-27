// //bu bir obje tanımlaması
// let obje1= {
//     'urunAd':'İphone 13',
//     'urunFiyat':30000,
//     'urunRenk':'Gri',
//     'onayli':true
// };


// let obje2= {
//     'urunAd':'İphone 13',
//     'urunFiyat':30000,
//     'urunRenk':'Gri',
    
// };
// console.log(obje2.onayli);
// obje2.onayli=false;
// if (obje2.onayli==undefined) {
//     console.log('Lüften admin ile iletişime geçin');
// }else{
//     if (obje2.onayli===true) {
//         console.log('Ürün satışta');
//     }
//     else{
//         console.log('Gelince haber ver');
//     }
    
// }


// console.log(obje1);
// console.log(obje1.urunFiyat);//bu şekilde fiyatını yazdırıyoruz
// obje1.urunFiyat = 45000;//bu şekilde fiyatı değiştirip yazdırdık
// console.log(obje1.urunFiyat);
// obje1.urunAdet =15;//ilk tanımlandığında vermesek bile burda bu şekilde yeni deger verebilirz

// console.log(obje1);


// let ogrenci1 ={
//     'ogrenciNo':144,
//     'ogrenciAd':'Ali',
//     'ogrenciSoyad':'Babahan',
//     'ogrenciYaş':18,
//     'ogrenciAktif':true
// };

// ogrenci1.cinsiyet ='Erkek';//bunu yazarsak cinsiyeti gösterir.
// //eger ögrenci1 in içinde cinsiyet diye bir alan varsa demek
// if ('cinsiyet' in ogrenci1) {
//     console.log(ogrenci1.cinsiyet);
// }else{
//     console.log('Böyle bir özellik yok');
// }

// let kisi1 = {
//     'Ad Soyad':'Sümeyye Yüce',
//     'Doğum Tarihi':'17.07.2000',
//     kidemYılı:27 //tırnaksız bu şekilde de kullanılabiliyor
// };
// console.log(kisi1["Ad Soyad"]);//eger boşluk kullanıcaksak yukarda burda tanımlarken köşeli parentez kullanıcaz
// console.log(kisi1.kidemYılı);

// let product1 = {
//     productId:12,
//     productName:'Samsung s21',
//     productPrice:2700
// }

// let product2 = {
//     productId:13,
//     productName:'İphone 14',
//     productPrice:2100
// }

// let product3 = {
//     productId:14,
//     productName:'Xaomi note',
//     productPrice:1700
// }

// let products = [product1,product2,product3]
// console.log(products);


//yukarıdakinin daha basit hali // let products = [product1,product2,product3] burdakileri aşşagıdaki gibi tek dizide yazıyoruz
// let products = [
//     {
//         Id:13,
//         Name:'iphone',
//         Price:1200
//     },
//     {
//         Id:14,
//         Name:'Samsung',
//         Price:1344
//     },
//     {
//         Id:15,
//         Name:'Xaomi',
//         Price:12500
//     }
// ];
// console.log(products);
// console.log(products[2].Price + ' ' + products[2].Name);


//yukarıdakinin içi boş hali

// let category1 ={};//bu içi boş bir obje
// category1.name ='Telefon';
// let category2 ={};
// category2.name='Bilgisayar';
// let categories =[category1,category2];
// console.log(categories);

