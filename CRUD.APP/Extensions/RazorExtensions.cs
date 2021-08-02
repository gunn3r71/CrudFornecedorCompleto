using Microsoft.AspNetCore.Mvc.Razor;

namespace CRUD.APP.Extensions
{
    public static class RazorExtensions
    {
        public static string DocumentHandler(this RazorPage page, int tipoPessoa, string documento)
        {
            return tipoPessoa == 1
                ? long.Parse(documento).ToString(@"000\.000\.000\-00")
                : long.Parse(documento).ToString(@"00\.000\.000\/0000\-00");
        }

        public static string ProviderTypeHandler(this RazorPage page, int tipoPessoa)
        {
            return tipoPessoa == 1 ? "Pessoa Fisica" : "Pessoa Juridica";
        }
    }
}