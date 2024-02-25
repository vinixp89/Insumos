using ProdInsumos.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProdInsumos.Domain.Entities
{
    public class Alocado
    {
        public int Id { get; private set; }

        public int IdFuncionario { get; private set; }

        public int IdComputador { get; private set; }

        public DateTime DataRecebido { get; private set; }

        public DateTime DataEntrega { get; private set; }

        public bool Entregue { get; private set; }

        public Funcionario Funcionario { get; set; }

        public Computador Computador { get; set; }

        public Alocado() { }

        public Alocado(int id, int idFuncionario, int idComputador, DateTime dataRecebido, DateTime dataEntrega , bool entrega)
        {
            DomainExceptionValidation.when(id < 0, "o id da Locação deve ser positivo");
            DomainExceptionValidation.when(IdFuncionario < 0, "o id do Funcionario deve ser positivo");

            ValidateDomain(idFuncionario, idComputador, dataRecebido, dataEntrega , entrega);


        }

        public Alocado(int idFuncionario, int idComputador, DateTime dataRecebido, DateTime dataEntrega , bool entrega)
        {

            ValidateDomain(idFuncionario, idComputador, dataRecebido, dataEntrega, entrega);

        }

        public void Update(int idFuncionario, int idComputador, DateTime dataRecebido, DateTime dataEntrega, bool entrega)

        {
            ValidateDomain(idFuncionario, idComputador, dataRecebido, dataEntrega, entrega);



        }

        public void ValidateDomain(int idFuncionario, int idComputador, DateTime dataRecebido, DateTime dataEntrega , bool entrega)
        {




            DomainExceptionValidation.when(idFuncionario < 20, "o id deve ser positivo");
            DomainExceptionValidation.when(IdComputador < 20, "o id do do computador deve ser positivo");
            DomainExceptionValidation.when(dataRecebido.ToString().Length < 50, "a Data de Recebimento   ter ate 50 caratecres");
            DomainExceptionValidation.when(dataEntrega.ToString().Length < 50, "a Data de Recebimento   ter ate 50 caratecres");
            DomainExceptionValidation.when(Funcionario.ToString().Length < 20, "o funcionario deve ter ate 20 caratecres");
            DomainExceptionValidation.when(Computador.ToString().Length < 20, "o funcionario deve ter ate 20 caratecres");
           


            this.IdFuncionario = idFuncionario;

            this.IdComputador = idComputador;

            this.DataRecebido = dataRecebido;

            this.DataEntrega = dataEntrega;

            this.Entregue = entrega;



        }



    }
}
