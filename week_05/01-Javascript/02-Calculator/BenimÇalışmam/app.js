const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');

let displayValue='0';

updateDisplay();

function updateDisplay(){
     display.value=displayValue;//updatedisplayı her çagırdıgımzada burası güncllenicek
}

keys.addEventListener('click',function(event){
    const element = event.target;
    if (!element.matches('button')) return //element buton değilmi
    if (element.classList.contains('operator')) {
        console.log('Bir operatore Tılkandı');
    }
    else if (element.classList.contains('decimal')) {
        console.log('ondalık sayıya tıklandı');
    }else if (element.classList.contains('clear')) {
        console.log('temizleme butonuna tıklanıldı');
    }
    else{
        console.log('bir rakama tıklandı');
    }

    //console.log(element.value);//hangi rakama bastı onu yakalıyor
});
