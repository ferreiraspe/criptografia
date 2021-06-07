using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Criptografia
{
    class Program
    {
        static void Main(string[] args)
        {
            //var teste1 = CriptografiaNovo.Seguranca.Criptografar("Teste Criptografia", "@@teste44");

            var valor = "UUVCMFpYTjBaVFEwS2lvcUtpcFdSMVo2WkVkVloxRXpTbkJqU0ZKMldqTkthRnB0YkdnPQ==";

            var respostaTeste = 
                CriptografiaNovo.Seguranca.Descriptografar("UUVCMFpYTjBaVFEwS2lvcUtpcFdSMVo2WkVkVloxRXpTbkJqU0ZKMldqTkthRnB0YkdnPQ==", "@@teste44");
        }
    }
}
