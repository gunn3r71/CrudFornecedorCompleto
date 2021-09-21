// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function back() {
    window.history.back();
}

function AjaxModal() {
    $(document).ready(function () {
        $(function() {
            $.ajaxSetup({ cache: false });

            $("a[data-modal]").on("click", function (e) {
                $("#modalContent").load(this.href, function () {
                    $("#modal-endereco-edit").modal({ keyboard: true }, "show");
                    bindForm(this);
                });
                return false;
            });
        });


        function bindForm(dialog) {
            $("form", dialog).submit(function() {
                $.ajax({
                    url: this.action,
                    type: this.method,
                    data: $(this).serialize(),
                    success: function(result) {
                        if (result.success) {
                            $("#modal-endereco-edit").modal("hide");
                            $("#EnderecoTarget").load(result.url);
                        } else {
                            $("#modalContent").html(result);
                            bindForm(dialog);
                        }
                    }
                });
                return false;
            });
        }
    });
}

function limpaFormCep() {
    $("#Endereco_Logradouro").val("");
    $("#Endereco_Bairro").val("");
    $("#Endereco_Cidade").val("");
    $("#Endereco_Estado").val("");
}

function buscaCep() {
    $(document).ready(() => {
        $("#Endereco_Logradouro").val("");
        $("#Endereco_Bairro").val("");
        $("#Endereco_Cidade").val("");  
        $("#Endereco_Estado").val("");  
    });

    $("#Endereco_Cep").blur(() => {
        var cep = $("#Endereco_Cep").val().replace(/\D/g, '');
        
        if (cep != "") {
            var validaCep = /^[0-9]{8}/;
            if (validaCep.test(cep)) {
                $("#Endereco_Logradouro").val("...");
                $("#Endereco_Bairro").val("...");
                $("#Endereco_Cidade").val("...");
                $("#Endereco_Estado").val("...");

                $.getJSON("https://viacep.com.br/ws/" + cep + "/json/?callback=?",
                    (data) => {
                        if (!("erro" in data)) {
                            $("#Endereco_Logradouro").val(data.logradouro);
                            $("#Endereco_Bairro").val(data.bairro);
                            $("#Endereco_Cidade").val(data.localidade);
                            $("#Endereco_Estado").val(data.uf);
                        } else {
                            limpaFormCep();
                            alert("CEP não encontrado.");
                        }
                    });
            } else {
                limpaFormCep();
                alert("Formato de CEP inválido.");
            }
        } else {
            limpaFormCep();
        }
    });
}