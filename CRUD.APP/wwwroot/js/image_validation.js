﻿$('#ImagemUpload').change(
    function () {
        $('#img_nome').text(this.files[0].name);
        $('#img_nome')[0].style.display = 'block';
    }
);

function validateIMG() {
    $('#ImagemUpload').attr('data-val', 'true');
    $('#ImagemUpload').attr('data-val-required', 'Preencha o campo imagem!');
}