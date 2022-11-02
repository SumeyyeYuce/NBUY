const btnAdd=document.getElementById('btnPlus');
const txtName=document.getElementById('txtName');
const txtName1=document.getElementById('txtName1');


btnAdd.addEventListener('click',newAdd);
txtName.addEventListener('keypress',function(event){
    if (event.key=='Enter') {
        event.preventDefault();
        btnAdd.click();
    }
});

    let notListesi =[
        { 'id': 1, 'notlar': '' },
        { 'id': 2, 'notlar': '' },
        { 'id': 3, 'notlar': '' },

    ]

function newAdd(event){
    event.preventDefault();
    if (txtName.value) {
        txtName.push=txtName1
    }

    let div =document.getElementById('notlar');
      for (const not of notListesi) {
        
        let li =`

        <div class="input2-text1">
              <button class="tras-icon1" id="btnTras"><i class="fa-solid fa-trash"></i></button> 
              <button class="check-icon2" id="btnCheck"><i class="fa-regular fa-square-check"></i></button> 
                <input type="text"  class="sepet2" id="txtName1">
            </div>
        
            <div class="input2-text1">
                <button class="tras-icon1"><i class="fa-solid fa-trash"></i></button> 
                <button class="check-icon2"><i class="fa-regular fa-square-check"></i></button> 
                  <input type="text" class="sepet2" id="txtName2">
              </div>

              
            <div class="input2-text1">
                <button class="tras-icon1"><i class="fa-solid fa-trash"></i></button> 
                <button class="check-icon2"><i class="fa-regular fa-square-check"></i></button> 
                  <input type="text" class="sepet2" id="txtName3">
            </div>
    
        `;
      }

}

function btnClear(){

}

function btnCheck(){

}