using ProdInsumos.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdInsumos.Domain.Interfaces
{
    public interface IFuncionarioRepository
    {

        Task<Funcionario> Incluir (Funcionario funcionario);
        Task<Funcionario> Alterar(Funcionario funcionario);

        Task<Funcionario> Excluir(Funcionario funcionario);

        Task<Funcionario> SelecionarAsync(Funcionario funcionario);

        Task<IEnumerable<Funcionario>> SelecionarTodosAsync();




    }

}
