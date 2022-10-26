let ders = 'Bahçeşehir Üniversitesi Wissen Akademie Igdır';
let sonuc;

sonuc = ders.toLowerCase();
sonuc= ders.toLocaleLowerCase();//buyük I yı oldugu gibi yazsın
sonuc = ders.toUpperCase();
sonuc = ders.toLocaleUpperCase();

sonuc = ders.length;//toplam karakter uzunluğu  length bir property o yüzden paranetez aç kapayya gerek yok.
sonuc = ders[0];
sonuc = ders[29];
sonuc = ders[44];
sonuc = ders[45];//0 dan başladıgı için 44 de biter undeifend

sonuc = ders.slice(0,10);//0. ile 10. arsındakini al
sonuc = ders.slice(20,25);
sonuc = ders.slice(10);//10 dan sonrasını aldı (10 start oldu)


sonuc = ders.substring(0,10);//
sonuc = ders.substring(20,5);//

sonuc = ders.substring(10,0);//
sonuc = ders.substring(0,10);//

sonuc = ders.substring(20,25);//
sonuc = ders.substring(25,20);//ne yazarsak yazalım ilk küçük olanı başlatır

sonuc = ders.replace('Igdır','İstanbul')//neyle neyin yer degiştirmeisni istediğimizi söylüyoruz.
sonuc = ders.replace(' ', '-');//soldan sağa ararken ilk karşılaştıgını bulur

sonuc = ders.trim();//trim boşlugu ortadan kaldırır
sonuc = ders.trimStart();//baştaki boşlugu kaldırı
sonuc = ders.trimEnd();//sondaki boşlugu kaldırı


sonuc = ders.indexOf('A');//HARF ARAR
sonuc = ders.toLocaleLowerCase().indexOf('a');
sonuc = ders.toLocaleUpperCase().indexOf('A');

sonuc = ders.split(' ');//bir dizi yarattı. her bir sözcüğü ayrı ayrı diziye attı
// console.log(sonuc[3]);

//Kullanıcının girdiği bir cümlenin kaç sözcükten oluştugunu bulunz
// let metin=prompt('Metin giriiniz');
// let sozcukDızısı = metin.split(' ');
// console.log(sozcukDızısı.length);

sonuc = ders.includes('Akademie');//içinde bu sözcük geçiyor mmu diye aratır
sonuc = ders.startsWith('B');//neyle başladıgını doğruluyır
sonuc = ders.endsWith('Igdır')//son sözü bununla bitiyor mu demiş olduk

console.log(ders);
console.log(sonuc);