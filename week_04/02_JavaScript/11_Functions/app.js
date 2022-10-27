//bir metod oluşturmuş olduk
// function selamVer()
// {
//     console.log('Merhaba javascript');
// }
// selamVer();//fonsiyonu çagırdık

// function selamVer(isim='Dünya'){//dünya artık varsayılan bir deger oluyor.
//     console.log('Merhaba' + isim);
// }
// selamVer(' Sümeyye');
// selamVer();

// function yasHesapla(dogumYılı){
//   console.log(new Date().getFullYear() - dogumYılı);
// }
// yasHesapla(2000)


// function yasHesapla(dogumYılı){
//     return new Date().getFullYear() - dogumYılı;
//   }
//  console.log(yasHesapla(2000));

//  let yas = yasHesapla(1975);
//  if (yas<30) {
//     console.log('yaşınız uygun değil');
//  }else{
//     console.log('kabul edildiiniz');
//  }


//bir tutar bilgisi alıp bu tutarın kdvsini hesaplayıp geriye döndüren funciyon

// function kdvHesapla(tutar){
//     //alttaki de yapılabilir
//     //let sonuc = (tutar*0.18).toFixed(2)

    
//     let sonuc = tutar*0.18
//     sonuc=sonuc.toFixed(2);
//     return sonuc;
// }
// console.log(kdvHesapla(117));
// console.log(kdvHesapla(4875));

//console.log(arguments);bununla birden fazla deger çagırabiliyrz
// function kdvHesapla(){
//     for (let i = 0; i <arguments.length; i++) {
//         console.log(arguments[i]*0.18);
//     }
// console.log(arguments);
// }
// kdvHesapla(100,200,1000);

//kendisinie gönderilecek tutar bilgilerini kullanarak kdv'leri hesaplayıp geriye
//hesaplanmış kdv'leri içinde barındıran bir dizi döndüren funciton

function kdvHesapla(){
    let sonuc=[];
    let kdv=0;
    for (let i = 0; i <arguments.length; i++) {
       kdv = arguments[i] * 0.18;
       kdv = kdv.toFixed(2);//iki basamak al
       sonuc.push(kdv);//yazdırdık
    //    sonuc[i]=kdv;
        
    }
    return sonuc;
}
console.log(kdvHesapla(100,450,7800));