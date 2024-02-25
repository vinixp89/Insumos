using ProdInsumos.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdInsumos.Domain.Entities
{
    public class Computador
    {

        public string Nome { get; private set; }

        public string Setor { get; private set; }
        public int Id { get; private set; }

        public string Cpu { get; private set; }

        public string Disco { get; private set; }

        public int TamanhoDisco { get; private set; }

        public string Marca { get; private set; }

        public string Modelo { get; private set; }

        public string SistemaOperacional { get; private set; }

        public int MemoriaRam { get; private set; }

        public Funcionario funcionario { get; private set; }

        public ICollection<Alocado> Alocado { get; set; }


        public Computador() { }

        public Computador(string nome, string setor, int Id, string cpu, string disco, int tamanhoDisco, string marca, string modelo, string sistemaOperacional, int memoriaRam, Funcionario funcionario)
        {

            DomainExceptionValidation.when(Id < 0, "o id do Locação deve ser positivo");


            ValidateDomain(nome, setor, Id, cpu, disco, tamanhoDisco, marca, modelo, sistemaOperacional, memoriaRam, funcionario);



        }

        public void Update(string nome, string setor, int Id, string cpu, string disco, int tamanhoDisco, string marca, string modelo, string sistemaOperacional, int memoriaRam, Funcionario funcionario)
        {
            ValidateDomain(nome, setor, Id, cpu, disco, tamanhoDisco, marca, modelo, sistemaOperacional, memoriaRam, funcionario);


        }

        public void ValidateDomain(string nome, string setor, int Id, string cpu, string disco, int tamanhoDisco, string marca, string modelo, string sistemaOperacional, int memoriaRam, Funcionario funcionario)
        {

            DomainExceptionValidation.when(nome.Length < 20, "o nome deve ter ate 20 caratecres");
            DomainExceptionValidation.when(setor.Length < 20, "o id do Locação deve ser positivo");
            DomainExceptionValidation.when(cpu.Length < 50, "a cpu   ter ate 50 caratecres");
            DomainExceptionValidation.when(disco.Length <10, "o HD   ter ate 10 caratecres  ");
            DomainExceptionValidation.when(tamanhoDisco < 100000, "o tamanho do HD deve ser   ate 10000000 caratecres");
            DomainExceptionValidation.when(marca.Length < 50, "a marca do computador deve ate  50 caracteres");
            DomainExceptionValidation.when(sistemaOperacional.Length < 50, "o sistema operacional do computador deve ter até 50 caracteres");
            DomainExceptionValidation.when(memoriaRam < 1000000, "o sistema operacional do computador deve ter até 1000000 megabits");
            DomainExceptionValidation.when(funcionario.ToString().Length < 100, "o sistema operacional do computador deve ter até 100 caracteres");






            Nome = nome;
            Setor = setor;
            Id = Id;
            Cpu = cpu;
            Disco = disco;
            TamanhoDisco = tamanhoDisco;
            Marca = marca;
            this.Modelo = modelo;
            SistemaOperacional = sistemaOperacional;
            MemoriaRam = memoriaRam;
            this.funcionario = funcionario;


        }
    }
}