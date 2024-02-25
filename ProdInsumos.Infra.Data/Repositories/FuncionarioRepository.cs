using Microsoft.EntityFrameworkCore;
using ProdInsumos.Domain.Entities;
using ProdInsumos.Domain.Interfaces;
using ProdInsumos.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdInsumos.Infra.Data.Repositories
{
    public class FuncionarioRepository : IFuncionarioRepository
    {

        public readonly ApplicationDbContext _context;

        public FuncionarioRepository(ApplicationDbContext context)
        {

            _context = context;


        }

        public async Task<Funcionario> Alterar(Funcionario funcionario)
        {
            _context.Funcionario.Update(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;
            //_context.Entry(funcionario).State = EntityState.Modified;
            /// await _context.SaveChangesAsync();
            //return funcionario;
        }

        public async Task<Funcionario> Excluir(Funcionario funcionario)
        {
            _context.Funcionario.Remove(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;


        }

        public async Task<Funcionario> Incluir(Funcionario funcionario)
        {
            _context.Funcionario.Add(funcionario);
            await _context.SaveChangesAsync();
            return funcionario;


        }

        public async Task<Funcionario> SelecionarAsync(Funcionario funcionario)
        {

            //return await _context.SaveChangesAsync(funcionario);
            throw new NotImplementedException();

        }

        public async Task<Funcionario> SelecionarByPk(int id)
        {
        
            var funcionario = await _context.Funcionario.Where(x => x.Id == id).FirstOrDefaultAsync();
            return funcionario;
        }

        public async Task<IEnumerable<Funcionario>> SelecionarTodosAsync()
        {
            return await _context.Funcionario.ToListAsync();
        }
    }
}
