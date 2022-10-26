let sonuc;

sonuc = Number('10.6');
sonuc = parseInt('10.6')// parseint küsüratlı kısmı atar yuvarlamaz
sonuc = parseInt('10abc') //sayısal bi degeri yakalıana kadar bakar ve alır sonrası farklıysa almaz
sonuc = parseInt('Aw232');
sonuc =parseInt('10.6abc');
sonuc =parseFloat('10.6abc');//sayıyı ve noktayı alır.

//tofixed aynı zamanda yuvarlıyarak da laır
let sayi=15.468756;
sonuc = sayi.toFixed();//küsüratı attı tipini string yaptı
sonuc = sayi.toFixed(4)//noktadan sonra 4 küsürat alsın dedik

sonuc = sayi.toPrecision(4);//toplam kaç basamak gözüksün diye kullaırız

sonuc = Math.round(2.4);
sonuc = Math.round(2.5);//5 den sonrasını yukarı yuvarlar

sonuc = Math.ceil(2.2);//ne olursa olsun ondalık kısmı her zamna üste yuvarlar
sonuc = Math.floor(2.9)//her zaman aşşagı yani tabana yuvarlar
sonuc = Math.pow(2,3);//üst alma 
sonuc = Math.sqrt(25)//karekök
sonuc = Math.sqrt(27)//karekök
sonuc = Math.abs(-5);//mutlak deger
sonuc = Math.min(43,23,34,4);//en küçük degeri bulur
sonuc = Math.max(43,23,34,4);//en büyük degeri bulur
sonuc = Math.random();//0 ile 1 arasında rastgele ssayı üretir.
sonuc =parseInt(Math.random()*10)+1;//sıfırla 10 arsında sayı +1 ile 10 da dahil olsun dedik




console.log(sonuc,typeof(sonuc));