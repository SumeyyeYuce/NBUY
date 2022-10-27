//ilk çözüm
// let n = prompt('Bir sayı giriniz.');
// let asalMi;

// for (let i = 2; i <=n; i++) {
//     asalMi=true;
//     for (let j = 2; j < i; j++) {
//         // console.log(i,j);
//         if (i % j===0) { //mesela i=8 j=2 tek tek böl
//             asalMi=false;
//         }
        
//     }
//     if (asalMi===true) {
//         console.log(i);
//     }   
// }


let n = prompt('Bir sayı giriniz')
nextPrime:
for (let i = 2; i <=n; i++) {
    for (let j = 2; j <n; j++) { 
        if (i % j===0) {
            continue nextPrime
        } 
    }
    console.log(i);  
}




































// let girilenDeger =prompt('Bir sayı Giriniz.');
// let sayı=[];

// if (girilenDeger) {
    
// }

// for (let i = 2; i <girilenDeger.length; i++) {
   
    
// }
// console.log(girilenDeger);