let simdi = new Date();
sonuc = simdi;
sonuc = simdi.getDate();//ilgili tarihin günü
sonuc = simdi.getDay();//kaçıncı gün
sonuc = simdi.getFullYear();//yıl
sonuc = simdi.getHours();
sonuc = simdi.getTime();

simdi.setFullYear(2015);//yıl bilgisini değiltiridk
simdi.setMonth(0)//ay'ı değiştridik
sonuc=simdi;


let suan=new Date();
sonuc=suan;
let kacYılSonra=1;
sonuc = sonuc.getFullYear()+1;//bir sonraki yılı veir
sonuc = new Date (suan.setFullYear(suan.getFullYear()+kacYılSonra));


simdi = new Date();
sonuc = simdi;

let dogumTarihi=new Date(2000,6,16);
 sonuc = simdi.getFullYear()-dogumTarihi.getFullYear();//şimdiki yıldan doğdugumuz yılı çıkardık

 let millisecond = simdi-dogumTarihi;
 let second = millisecond/1000;//ne kadar saniyedir yaşıyoruz
 let minute  = second/60;//ne kadar saattie yaşıyroz
 let hour  = minute/60;
 let day  =hour/24;//kaç gündür yaşyoruz

 sonuc = parseInt(day);
console.log(dogumTarihi);
console.log(sonuc);
// console.log(millisecond);