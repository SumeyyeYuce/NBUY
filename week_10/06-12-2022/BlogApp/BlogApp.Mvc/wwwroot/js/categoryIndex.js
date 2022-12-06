$(document).ready(function () {
    //datatable burda başlıyor
    $('#categoriesTable').DataTable({

        dom: "<'row'<'col-sm-3'l><'col-sm-6 text-center'B><'col-sm-3'f>>" +
            "<'row'<'col-sm-12'tr>>" +
            "<'row'<'col-sm-5'i><'col-sm-7'p>>",
        buttons: [
            {

                text: 'Ekle',
                attr: {
                    id: 'btnAdd'
                },
                action: function (e, dt, node, config) {

                },
                className: 'btn btn-success'
            },

            {
                text: 'Yenile',
                action: function (e, dt, node, config) {

                    $.ajax({

                        //veri çekicegimiz için type get olucak
                        type: 'GET',
                        url: '/Admin/Category/GetAllCategories/',
                        contentType: 'application/json',
                        beforeSend: function () {

                            $('#categoriesTable').fadeOut(1500);
                            $('.spinner-border').show();
                        },
                        success: function (data) {
                            const categoryListDto = jQuery.parseJSON(data);                     
                            if (categoryListDto.ResultStatus === 0) {//ResultStatus başarılıysa
                                //buranın içide sayfa yenilendiiğnde oluşucak olan yeni tabloyu oluşturuyoruz
                                let tableBody = ''; //önce tabloyu temzile
                                $.each(categoryListDto.Categories.$values, function (index, category) {//sonra göster

                                    //satırları tek tek yerleştir
                                    tableBody += `
                                             <tr name="${category.Id}">
                                                    <td>${category.Id}</td>
                                                    <td>${category.Name}</td>
                                                    <td>${category.Description}</td>
                                                    <td>${convertFirstLetterToUpperCase(category.IsActive)}</td>                           
                                                    <td>${convertToShortDate(category.CreatedDate)}</td>
                                                    <td>${category.CreatedByName}</td>
                                                      <td>
                                                <button class="btn btn-warning btn-sm btn-update" data-id="${category.Id}"><span class="fas fa-edit text-white"></span></button>
                                                <button class="btn btn-danger btn-sm btn-delete" data-id="${category.Id}"><span class="fas fa-minus-circle"></span></button>

                                               </td>

                                                </tr>       
                                       `;
                                });//döngü burda bitiyor
                                $('#categoriesTable > tbody').replaceWith(tableBody);//içi dolu bir tableBODY değişkeni var(içeriği tableBody ile değiştir)
                                $('.spinner-border').hide();//gizle
                                $('#categoriesTable').fadeIn(1000);//tekrar görünür yap

                            }
                            else {

                                toastr.error(`${categoryListDto.Message}`, 'İşlem başarısız');

                            }


                        },
                        error: function (err) {

                            toastr.error(err.statusText, 'Başarısız İşlem');
                        }



                    });
                },
                className: 'btn btn-warning'
            }
        ],
        language: {
            url: "https://cdn.datatables.net/plug-ins/1.13.1/i18n/tr.json"
        }
    });
    //datatable burada bitiyor

    //burası ekrana modal'ın gelmesini saglıyor
    $(function () {
        const url = '/Admin/Category/Add/';
        const placeHolderDiv = $('#modalPlaceHolder');

        $('#btnAdd').click(function () {//btnAdd'e click yapıldıgında func'ı çalıştır
            $.get(url).done(function (data) {//url bilgisini kullarak func hazırlasın html datayı yerleştirisn
                placeHolderDiv.html(data);
                placeHolderDiv.find(".modal").modal('show');//find kullanarak divin find özleliğini show yapsın
            });
        });
        //ajax'la(Get) partialView'i ekrana gelmesi bitti

        //Ajax'la POST işlemleri
        placeHolderDiv.on('click', '#btnSave', function (event) {//placholderdiv in içinde id si btnsave olan dive click olayı ekledi

            event.preventDefault();// preventDefault ile refresh yapma diyoruz
            const form = $('#form-category-add');
            const actionUrl = form.attr('action');//forum'un içinde bir attr yarat onu al
            const dataToSend = form.serialize();//forumun içindeki bütün inputları jsın formtında al

            $.post(actionUrl, dataToSend).done(function (data) {

                const categoryAddAjaxModel = jQuery.parseJSON(data);//jquery kullanarak datayı çeviridk
                const newFormBody = $('.modal-body', categoryAddAjaxModel.CategoryAddPartial);
                placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';//hata yoksa yani burası true ise alta geç
                if (isValid) {

                    //burada tablomuzu oluşturyoruz
                    const newTableRow = `
                            <tr name="${categoryAddAjaxModel.CategoryDto.Category.Id}">
                                <td>${categoryAddAjaxModel.CategoryDto.Category.Id}</td>
                                <td>${categoryAddAjaxModel.CategoryDto.Category.Name}</td>
                                <td>${categoryAddAjaxModel.CategoryDto.Category.Description}</td>
                                <td>${convertFirstLetterToUpperCase(categoryAddAjaxModel.CategoryDto.Category.IsActive)}</td>
                                
                                <td>${convertToShortDate(categoryAddAjaxModel.CategoryDto.Category.CreatedDate)}</td>
                                <td>${categoryAddAjaxModel.CategoryDto.Category.CreatedByName}</td> 
                                 <td>
                                   <button class="btn btn-warning btn-sm btn-update" data-id="${categoryAddAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-edit text-white"></span></button>
                                   <button class="btn btn-danger btn-sm btn-delete" data-id="${categoryAddAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-minus-circle"></span></button>

                                </td>
                               
                             </tr>                               
                            `;
                    const newTableRowObject = $(newTableRow);
                    newTableRowObject.hide();
                    $('#categoriesTable').append(newTableRowObject);
                    newTableRowObject.fadeIn(3000);
                    toastr.success(`${categoryAddAjaxModel.CategoryDto.Message}`, 'Başarılı!');
                    placeHolderDiv.find(".modal").modal('hide');
                }
                else {
                    let summaryText = '<br>';
                    $('#validation-summary > ul > li').each(function () {
                        let liText = $(this).text();
                        summaryText += `*${liText}<br><br>`;
                    });//valdıton-summary içindeki ul ve li leri seçiyor
                    toastr.warning(summaryText, 'Dikkat!');
                }

            });

        });
        //Ajax'la POST işlemleri bitti

        //Ajax'la delete işlemleri
        $(document).on('click', '.btn-delete', function (event) {//documanın ğzerindeki clası btn-delet olablara tıklanıldıgında burdaki func'ı çalıştır diyoruz
            event.preventDefault();//burada butonun tipi submit olmaıdgı için kullanmasak da olur aışkanlık olsun diey ayzdık
            const id = $(this).attr('data-id')//this nereye tıkladıysan ordan bahseyior demek(burada nereye tıklaıysak data-id ile onu getiircez)
            Swal.fire({
                title: 'Silmek İstediğinizden Emin misiniz?',
                text: "İlgili Kategori Silinecek!",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Evet',
                cancelButtonText: 'Hayır'
            }).then((result) => {
                if (result.isConfirmed) {
                    //burada kategorinin silinme işlemleri yapılıcak ardından silinmiştir yazısı gözükücek
                    $.ajax({
                        //ever demeden önce silme işlemini yapıoruz
                        type: 'POST',//OLMASININ NEDENİ BİR veri döndericez
                        dataType: 'json',
                        data: { categoryId: id },//categoryId:1 diye gözükücek catefgoryId yi yukarıda belirlediğimiz id(const yanındaki) ile değiştir

                        url: '/Admin/Category/Delete/',//categorya adlı controllerın delete action 'u
                        success: function (data) {
                            const result = jQuery.parseJSON(data);
                            if (result.ResultStatus === 0) {
                                Swal.fire({
                                    title: 'İşlem başarılı!',
                                    text: 'İlgili kategori silinmiştir.',
                                    icon: 'success',
                                    confirmButtonText: 'Tamam'
                                });
                                const tableRow = $(`[name="${id}"]`);
                                tableRow.fadeOut(3000);
                            }
                            else {
                                Swal.fire({
                                    title: 'Hata oluştu!',
                                    text: `${result.Message}`,
                                    icon: 'error',
                                    confirmButtonText: 'Tamam'
                                });

                            }
                        },
                        error: function (err) {
                            toastr.error(err.statusText, 'Hata');
                        }
                    })



                }
            })

        });

    });
        $(function () {
            const url = '/Admin/Category/Update/';
            const placeHolderDiv = $('#modalPlaceHolder');
            //category partial view getime
            $(document).on('click', '.btn-update', function (event) {//click yapıldıgında clasıı btn-update mş bak onan göe func çalıştır
                event.preventDefault();
                const id = $(this).attr('data-id');//ilgili ürünün id'sini vericek'            
                $.get(url, { categoryId: id })
                    .done(function (data) {
                        placeHolderDiv.html(data);
                        placeHolderDiv.find('.modal').modal('show');
                    })//başarılıysa funcı çalıştır
                    .fail(function () {
                        toastr.error('Bir hata oluştu');

                    });//başarızıs olma durumu
            });
            //category partial view getime bitti
            placeHolderDiv.on('click', '#btnUpdate', function (event) {
                event.preventDefault();
                const form = $('#form-category-update');
                const actionUrl = form.attr('action');
                const dataToSend = form.serialize();
                $.post(actionUrl, dataToSend)
                    .done(function (data) {
                        const categoryUpdateAjaxModel = jQuery.parseJSON(data);
                        console.log(categoryUpdateAjaxModel);

                        const newFormBody = $('.modal-body', categoryUpdateAjaxModel.CategoryUpdatePartial);
                        placeHolderDiv.find('.modal-body').replaceWith(newFormBody);
                        const isValid = newFormBody.find('[name="IsValid"]').val() === 'True';//ısvalid degeri true ise bunu al 
                        if (isValid) {//eger herşey doğru ise
                            placeHolderDiv.find('.modal').modal('hide');//kaydete bastıktan sonra kapat
                            const currentCategoryTableRow = $(` [name="${categoryUpdateAjaxModel.CategoryDto.Category.Id}"]`);//name'i neyse bana onu getir(yani kategorinin tr sini bulduk)
                            if (!categoryUpdateAjaxModel.CategoryDto.Category.IsDeleted) {
                                //forma giirlen tablo satırlarını yaratık
                                const newTableRow = ` 
                            <tr name="${categoryUpdateAjaxModel.CategoryDto.Category.Id}">
                                <td>${categoryUpdateAjaxModel.CategoryDto.Category.Id}</td>
                                <td>${categoryUpdateAjaxModel.CategoryDto.Category.Name}</td>
                                <td>${categoryUpdateAjaxModel.CategoryDto.Category.Description}</td>
                                <td>${convertFirstLetterToUpperCase(categoryUpdateAjaxModel.CategoryDto.Category.IsActive)}</td>
                                
                                <td>${convertToShortDate(categoryUpdateAjaxModel.CategoryDto.Category.CreatedDate)}</td>
                                <td>${categoryUpdateAjaxModel.CategoryDto.Category.CreatedByName}</td> 
                                 <td>
                                   <button class="btn btn-warning btn-sm btn-update" data-id="${categoryUpdateAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-edit text-white"></span></button>
                                   <button class="btn btn-danger btn-sm btn-delete" data-id="${categoryUpdateAjaxModel.CategoryDto.Category.Id}"><span class="fas fa-minus-circle"></span></button>

                                </td>
                               
                             </tr>               
                                  
                        `;

                                const newTableRowObject = $(newTableRow);//burdaki objeyi bir önceki satırla değiştiriez

                                newTableRowObject.hide();
                                currentCategoryTableRow.replaceWith(newTableRowObject);//currentCategoryTableRow bunu newTableRowObject bunuula değiştir
                                newTableRowObject.fadeIn(1000);
                                toastr.success(`${categoryUpdateAjaxModel.CategoryDto.Message}`, 'İşlem başarılı');//managerdan gelen bilgi
                            }

                            else {
                                currentCategoryTableRow.fadeOut(1000);
                                toastr.success(`${categoryUpdateAjaxModel.CategoryDto.Category.Name} adlı kategori silindi`, 'İşlem başarılı');

                            }

                        }
                        else
                        {
                            let summaryText = '<br>';
                            $('#validation-summary > ul >li').each(function () {
                                let text = $(this).text();                             
                                toastr.error(text);
                            });
                            
                        }
                    });
                   

            });
        });

});