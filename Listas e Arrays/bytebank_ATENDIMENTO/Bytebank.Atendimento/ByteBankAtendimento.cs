using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.Bytebank.Atendimento
{
    public class ByteBankAtendimento
    {
         private List<ContaCorrente> listaDeContas = new List<ContaCorrente>()

{
    new ContaCorrente(95, "12151511-a"){Saldo=500,Titular = new Cliente {Cpf = " 111210 ",Nome=" Luisinho " } },
    new ContaCorrente(95, "12151511-b"){Saldo=200,Titular = new Cliente {Cpf = " 220330 ",Nome=" felipinho " } },
    new ContaCorrente(95, "12151511-c"){Saldo=100,Titular = new Cliente {Cpf = " 440044 ",Nome=" Joaozinho " }}
};
        

        public void AtendimentoCliente()
        {
            char opcao = '0';
            while (opcao != '6')
            {
                Console.Clear();
                Console.WriteLine("==========================");
                Console.WriteLine("===     Atendimento    ===");
                Console.WriteLine("===1 - Cadastrar Conta ===");
                Console.WriteLine("===2 - Listar Contas   ===");
                Console.WriteLine("===3 - Remover Conta   ===");
                Console.WriteLine("===4 - Ordenar Contas  ===");
                Console.WriteLine("===5 - Pesquisar Conta ===");
                Console.WriteLine("===6 - Sair do Sistema ===");
                Console.WriteLine("\n\n");
                Console.WriteLine("Digite a opção desejada; ");
                opcao = Console.ReadLine()[0];
                switch (opcao)
                {
                    case '1':
                        CadastrarConta();
                        break;
                    case '2':
                        ListarConta();
                        break;
                    case '3':
                        RemoverConta();
                        break;
                    case '4':
                        OrdenarContas();
                        break;
                    case '5':
                        PesquisarContas();
                        break;
                    case '6':
                        SairDoSistema();
                        break;
                    default:
                        Console.WriteLine("opcao não implementada.");
                        break;
                }
            }

        }

        private void SairDoSistema()
        {
            Console.WriteLine("Encerrando atendimento.");
            Console.ReadKey();
        }

        private void PesquisarContas()
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine("===   Pesquisar Contas  ===");
            Console.WriteLine("==========================");
            Console.WriteLine("\n");
            Console.WriteLine("Pesquisar por número de conta(1) ou por cpf do titular(2) ou por número da agencia (3)");
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    {
                        Console.WriteLine("Informe o número da conta: ");
                        string numeroConta = Console.ReadLine();
                        ContaCorrente consultaConta = ConsultaPorNumeroConta(numeroConta);
                        Console.WriteLine(consultaConta.ToString());
                        Console.ReadKey();
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Informe o CPF do titular: ");
                        string cpf = Console.ReadLine();
                        ContaCorrente consultaCpf = ConsultaPorCpf(cpf);
                        Console.WriteLine(consultaCpf.ToString());
                        Console.ReadKey();
                        break;
                    }
                case 3:
                    {
                        Console.WriteLine("Informe no número da agencia: ");
                        int agencia = int.Parse(Console.ReadLine());
                        var contasPorAgencia = ConsultaPorAgencia(agencia);

                        ExibirListaDeContas(contasPorAgencia);

                        Console.ReadKey();
                        break;
                    }
            }


        }

        private void ExibirListaDeContas(List<ContaCorrente> contasPorAgencia)
        {
            if (contasPorAgencia == null)
            {
                Console.WriteLine("A consulta não retornou dados.");
            }
            else
            {
                foreach (var item in contasPorAgencia)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        private List<ContaCorrente> ConsultaPorAgencia(int agencia)
        {
            var consulta = (
                    from conta in listaDeContas
                    where conta.Numero_agencia == agencia
                    select conta).ToList();

            return consulta;
        }

        private ContaCorrente ConsultaPorCpf(string? cpf)
        {
            //ContaCorrente conta = null;
            //for (int i = 0; i < listaDeContas.Count; i++)
            //{
            //    if (listaDeContas[i].Titular.Cpf.Equals(cpf))
            //    {
            //        conta = listaDeContas[i];
            //    }
            //}

            //return conta;

            return listaDeContas.Where(conta => conta.Titular.Cpf == cpf).FirstOrDefault();

        }

        private ContaCorrente ConsultaPorNumeroConta(string? numeroConta)
        {
            //ContaCorrente conta = null;
            //for(int i = 0; i < listaDeContas.Count; i++)
            //{
            //    if (listaDeContas[i].Conta.Equals(numeroConta))
            //    {
            //        conta = listaDeContas[i];
            //    }

            //}

            //return conta;

            return listaDeContas.Where(conta => conta.Conta == numeroConta).FirstOrDefault();
        }

        private void OrdenarContas()
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine("===   Ordenar Contas  ===");
            Console.WriteLine("==========================");
            Console.WriteLine("\n");

            listaDeContas.Sort();
            Console.WriteLine("Lista de contas ordenada");
            Console.ReadKey();
        }

        private void RemoverConta()
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine("===   Remover Conta  ===");
            Console.WriteLine("==========================");
            Console.WriteLine("\n");
            Console.WriteLine("Informe no número da conta a ser removida: ");
            string numeroConta = Console.ReadLine();
            ContaCorrente conta = null;

            foreach (var item in listaDeContas)
            {
                if (item.Conta.Equals(numeroConta))
                {
                    conta = item;
                }

            }
            if (conta != null)
            {
                listaDeContas.Remove(conta);
                Console.WriteLine("Conta removida com sucesso");
            }
            else
            {
                Console.WriteLine("Conta não encontrada");
            }
            Console.ReadKey();
        }

        private void ListarConta()
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine("===   Lista de Contas  ===");
            Console.WriteLine("==========================");
            Console.WriteLine("\n");

            if (listaDeContas.Count <= 0)
            {
                Console.WriteLine("Não há contas cadastradas");
                Console.ReadKey();
                return;
            }
            foreach (ContaCorrente item in listaDeContas)
            {
                //Console.WriteLine("=== Dados da Conta ===");
                //Console.WriteLine("Número da conta  " + item.Conta);
                //Console.WriteLine("o saldo da conta é: " + item.Saldo);
                //Console.WriteLine("Titular da conta : " + item.Titular.Nome);
                //Console.WriteLine("Cpf do titular : " + item.Titular.Cpf);
                //Console.WriteLine("Profissão do titular : " + item.Titular.Profissao);
                Console.WriteLine(item.ToString());
                Console.WriteLine(">>>>>>>>>>>>>>>>>>>>>>>");
                Console.ReadKey();
            }
        }

        private void CadastrarConta()
        {
            Console.Clear();
            Console.WriteLine("=================================");
            Console.WriteLine("===     Cadastro de Contas    ===");
            Console.WriteLine("=================================");
            Console.WriteLine("\n");
            Console.WriteLine("Informe os dados da Conta: ");
            

            Console.WriteLine("Numero da Agencia: ");
            int numeroAgencia = int.Parse(Console.ReadLine());

            ContaCorrente conta = new ContaCorrente(numeroAgencia);

            Console.WriteLine($"Número de conta criada: {conta.Conta}");
            Console.WriteLine("Informe o saldo inicial: ");
            conta.Saldo = double.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do titular: ");
            conta.Titular.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do titular: ");
            conta.Titular.Cpf = Console.ReadLine();

            Console.WriteLine("Informe a profissão do titular: ");
            conta.Titular.Profissao = Console.ReadLine();

            listaDeContas.Add(conta);
            Console.WriteLine("Conta cadastrada com sucesso! ...");
            Console.ReadKey();




        }

        /*List<ContaCorrente> listaDeContas2 = new List<ContaCorrente>()
        {
            new ContaCorrente(95, "12151511-a"){Saldo=500},
            new ContaCorrente(95, "12151511-b"){Saldo=200},
            new ContaCorrente(95, "12151511-c"){Saldo=100}
        };

        List<ContaCorrente> listaDeContas3 = new List<ContaCorrente>()
        {
            new ContaCorrente(95, "12151511-d"){Saldo=500},
            new ContaCorrente(95, "12151511-e"){Saldo=200},
            new ContaCorrente(95, "12151511-f"){Saldo=100}

        };

        listaDeContas2.AddRange(listaDeContas3);

        for(int i = 0; i < listaDeContas2.Count; i++)
        {
            Console.WriteLine($"Indice [{i}] = conta [{listaDeContas2[i].Conta}]");
        }*/
    }
}
