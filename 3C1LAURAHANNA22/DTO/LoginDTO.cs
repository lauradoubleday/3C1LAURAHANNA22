using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1LAURAHANNA22.DTO
{
    class LoginDTO
    {
        private int _id;
        private string _email;
        private string _senha;

        public int Id { get => _id; set => _id = value; }
        public int Email { get => _email; set => _email = value; }
        public int Senha { get => _senha; set => _senha = value; }
    }
}
