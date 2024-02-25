using ProdInsumos.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdInsumos.Domain.Entities
{
    public class Funcionario
    {


        public int Id { get; private set; }


        public string Nome { get; private set; }

        public string Cpf { get; private set; }

        public string Setor { get; private set; }

        public bool Entrega { get; private set; }

        //public Computador computador { get; set;}

        public ICollection<Alocado> Alocado { get; set; }

        public Funcionario() { }


        public Funcionario(int Id, string Nome, string Cpf, string Setor, Computador computadores, bool Entrega)
        {
            DomainExceptionValidation.when(Id < 0, "o Id do cliente deve ser positivo");
            Id = Id;
            ValidateDomain(Nome, Cpf, Setor, computadores, Entrega);

        }
        public Funcionario(string Nome, string Cpf, string Setor, Computador computadores, bool Entrega)
        {

            //this.Id = id;

            ValidateDomain(Nome, Cpf, Setor, computadores, Entrega);



        }

        public void Update(string Nome, string Cpf, string Setor, Computador computadores, bool Entrega)

        {

            ValidateDomain(Nome, Cpf, Setor, computadores, Entrega);

        }
        public void ValidateDomain(string Nome, string Cpf, string Setor, Computador Computadores, bool entrega)
        {

            DomainExceptionValidation.when(Nome.Length != 200, "o nome  deve ter  no maximo 200 caracteres");
            DomainExceptionValidation.when(Cpf.Length != 11, "o cpf deve ter  11 caracteres");
            DomainExceptionValidation.when(Setor.Length != 20, "o cpf deve ter  20 caracteres");





            this.Nome = Nome;
            this.Entrega = Entrega;
            this.Cpf = Cpf;
            this.Setor = Setor;
            //this.Computadores = computadores;
            this.Entrega = entrega;

        }
    }
}