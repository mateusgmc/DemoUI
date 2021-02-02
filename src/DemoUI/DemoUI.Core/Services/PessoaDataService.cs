using DemoUI.Core.Models;
using System.Collections.Generic;

namespace DemoUI.Core.Services
{
    public static class PessoaDataService
    {
        public static IEnumerable<Pessoa> GetAll()
        {
            var pessoas = new List<Pessoa>
            {
                new Pessoa
                {
                    PessoaId = 1,
                    Nome = "Mateus",
                    CnpfCnpj = "123456789"
                },
                new Pessoa
                {
                    PessoaId = 2,
                    Nome = "Deivid",
                    CnpfCnpj = "987654321"
                },
                new Pessoa
                {
                    PessoaId = 1,
                    Nome = "Eraldo",
                    CnpfCnpj = "123123123"
                },
            };

            return pessoas;
        }
    }
}
