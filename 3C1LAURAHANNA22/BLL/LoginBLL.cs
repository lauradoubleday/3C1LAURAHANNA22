using _3C1LAURAHANNA22.DAL;
using _3C1LAURAHANNA22.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1LAURAHANNA22.BLL
{
    class LoginBLL
    {
        AcessoBancoDados conexao = new AcessoBancoDados();
        string tabela = "tblLogin";

        public bool RealizarLogin(LoginDTO login);
    }
}
