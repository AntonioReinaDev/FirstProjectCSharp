using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBitcoin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            
            MainClass contaManipulacao = new MainClass();
            contaManipulacao.Sacar(11);

            //Definindo dados UserClass
            contaManipulacao._usuario.Nome = "Antonio Marcos Reina Junior";
            contaManipulacao._usuario.Idade = 21;
            contaManipulacao._usuario.CPF = "111.222.333-44";
            contaManipulacao._usuario.Profissao = "Desenvolvedor C#";

            //Definindo dados AdressClass
            contaManipulacao._endereço.Rua = "Rua Construção Iludida";
            contaManipulacao._endereço.Bairro = "Bairro da Ilusão";
            contaManipulacao._endereço.Numero = 10;
            contaManipulacao._endereço.Referencia = "Casa da Ilusão";

            //Definindo dados KeyClass
            KeyClass kc = new KeyClass(6475, "ASH776BAD%%7");
           
            //Mostrando dados usuarios
            Console.WriteLine("Dados do usuário \nNome: " + contaManipulacao._usuario.Nome +
                "\nIdade: " + contaManipulacao._usuario.Idade + 
                "\nCPF: " + contaManipulacao._usuario.CPF +
                "\nProfissão: " + contaManipulacao._usuario.Profissao);

            //Mostrando dados Endereço
            Console.WriteLine("\n\nEndereço \nRua: " + contaManipulacao._endereço.Rua  + 
                "\nBairro: " + contaManipulacao._endereço.Bairro  + 
                "\nNúmero: " + contaManipulacao._endereço.Numero  + 
                "\nReferência " + contaManipulacao._endereço.Referencia);

            //Mostrando dados Chaves
            Console.WriteLine("\n\nChaves do cadastro \nID: " + kc.ID + "\nKey: " + kc.Key);
            Console.WriteLine("\nQuantidade de cadastros: " + kc.numerosContas);

            Console.ReadLine();
        }
    }
}
