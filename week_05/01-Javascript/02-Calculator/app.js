const display = document.querySelector('.calculator-input');
const keys = document.querySelector('.calculator-keys');

let displayValue='0';//siyah input
let firstValue=null;//başlangıçta null ol
let operator=null;
let waitingForSecondValue=false;

updateDisplay();

function updateDisplay(){
     display.value=displayValue.replace('.' , ',')//updatedisplayı her çagırdıgımzada burası güncllenicek.nokta yerine virgül yazsın dedik
     
}


keys.addEventListener('click',function(event){
    const element = event.target;
    const value=element.value;//elemembtin içinden value al
    if (!element.matches('button')) return; //element buton değilmi
    switch (value) {
        case '+':
        case '-':
        case'*':
        case'/':
        case '=':
            handleOperator(value);
            break;

         case '.':
            inputDecimal();
            break;

        case 'clear':
            clearDisplay();
            break;

        default://yukarıdakilerden hiçbiri değilse
            inputNumber(value);
            
    }
   



    //if ile yapımı
    // if (element.classList.contains('operator')) {

    //     handleOperator(element.value);//elementin value sunu bu fonksiyona yolla
    //     //updateDisplay();
    //     return;
    // }

    // if (element.classList.contains('decimal')) {
    //    inputDecimal();//metot
      
    //    return;
    // }
    // if (element.classList.contains('clear')) {
    //     clearDisplay();
       
    //     return;
    // }
    
    // inputNumber(element.value);//rakam griildiğinde ekranda bişey çıksım
   

    //console.log(element.value);//hangi rakama bastı onu yakalıyor
});

function inputNumber(num){
    //displayValue=num;//hangi sayıya basarsa o olsun
    //displayValue+=num;//displayvalue nun içindekini silmeden yanına ekle
    if (waitingForSecondValue) {
        displayValue=num;
        waitingForSecondValue=false;
    }
    else{
        displayValue=displayValue=='0' ? num : displayValue + num//eger daha önceden sıfır varsa benim numaramı yaz yok yazmıyorsa benim yazdığım sayıları diger sayıların arsına ekle

    }
    
    updateDisplay();
}

function inputDecimal(){
    if (!displayValue.includes('.')) {//displayın içinde nokta yoksa
        displayValue+='.';
        updateDisplay();
    }  
}

function clearDisplay(){ //ac ye bastıgımızda temizleme işlemi yapıyor
    displayValue='0'
    firstValue=null;//başlangıçta null ol
    operator=null;
    waitingForSecondValue=false;
    updateDisplay();
}

function handleOperator(nextOperator)
{
    let value=parseFloat(displayValue);
    if(operator && waitingForSecondValue)
    {
        operator=nextOperator;
        return;
    }


    if (firstValue==null) {
        firstValue=value;//eger firstvalue ilk etapda boşta displayvaluyu alsın
    }
    else if(operator){//operator doluysa
      const result=calculater(firstValue, operator,value)
      displayValue=`${parseFloat(result.toFixed(7))}`;
      firstValue=result;
    }

    waitingForSecondValue=true;
    operator=nextOperator;//operatoruun içinde sıradaki operatorü yazsın
    updateDisplay();

    console.log(firstValue,nextOperator,operator,value);

}
function calculater(num1,op,num2){
    if (op=='+') return num1 +num2;  
    if (op=='-') return num1 - num2;   
    if (op=='*') return num1 * num2;
    if (op=='/') return num1 / num2;
    return num2;
    
   
}






    // if (displayValue=='+') {
    //     displayValue+='+';
    // }
    // console.log(nextOperator,tutulanSayı);


    // else{
    //     //hesaplama işemleri yapılabilir
    //     let result= Number(firstValue) + Number(displayValue);
    // }
