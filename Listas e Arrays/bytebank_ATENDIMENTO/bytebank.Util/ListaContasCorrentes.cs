using bytebank.Modelos.Conta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Util
{
    public class ListaContasCorrentes
    {
        private ContaCorrente[] itens = null;
        private int proximaPosicao = 0;

        public ListaContasCorrentes(int tamanhoInicial = 5)
        {
            itens = new ContaCorrente[tamanhoInicial];
        }

        public void Adicionar(ContaCorrente item)
        {
            Console.WriteLine($"Adicionando item na posição {proximaPosicao}");
            VerificarCapacidade(proximaPosicao+1);
            itens[proximaPosicao] = item;
            proximaPosicao++;
        }

        private void VerificarCapacidade(int tamanhoNecessario)
        {
            if (itens.Length >= tamanhoNecessario)
            {
                return;
            }
            Console.WriteLine("Aumentando a capacidade da lista!");
            ContaCorrente[] novoArray = new ContaCorrente[tamanhoNecessario];

            for (int i = 0; i < itens.Length; i++)
            {
                novoArray[i] = itens[i];
            }

            itens = novoArray;
        }
        public ContaCorrente MaiorSaldo()
        {
            ContaCorrente conta = null;
            double maiorValor = 0;

            for (int i = 0; i < itens.Length; i++)
            {
                if (itens[i] != null)
                {
                    if(maiorValor < itens[i].Saldo)
                    {
                        maiorValor = itens[i].Saldo;
                        conta = itens[i];
                    }
                }
            }
            return conta;
        }

        public void Remover (ContaCorrente conta)
        {
            int IndiceItem = -1;
            for (int i = 0; i < proximaPosicao; i++)
            {
                ContaCorrente contaAtual = itens[i];
                if(contaAtual == conta)
                {
                    IndiceItem = i;
                    break;
                }
            }
            for (int i = IndiceItem; i < proximaPosicao-1; i++)
            {
                itens[i] = itens[i + 1];
            }
            proximaPosicao--;
            itens[proximaPosicao] = null;
        }

        public void ExibeLista()
        {
            for (int i = 0; i < itens.Length; i++)
            {
                if (itens[i] != null)
                {
                    var conta = itens[i];
                    Console.WriteLine($"indice[{i}] = conta:{conta.Conta} - Nª Agencia: {conta.Numero_agencia}");
                }
            }
        }
    }
}
