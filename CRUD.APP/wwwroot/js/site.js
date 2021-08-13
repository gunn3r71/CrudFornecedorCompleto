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