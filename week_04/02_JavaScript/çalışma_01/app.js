//çalışma_01

let saniye = parseInt(prompt('Bir saniye degeri girin.'));
console.log('Girilen Saniye Degeri:'+saniye);

let dakika = parseInt(saniye/60) ;
console.log(dakika);
saniye=saniye % 60;
console.log(saniye);
console.log(dakika + ' dakika:' + saniye + ' saniye' );
 

// let minute = girilenDeger/60;//dakika
// let second = minute/1000;//saniye

// console.log('Sonuç:' + minute + ' Dakika:' + second+' saniye' );


//ÖNERİ
/**
 * GİRİLEN SANİYE DEGERİNİ 1 saat 45 dakika 40 sn olarak yazsın gibi göster.
 */