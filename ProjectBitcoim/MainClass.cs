using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectBitcoin
{
    internal class MainClass
    {
        /*
        1- criando a referencia de dados para classe usuario e criando uma
        nova construção diretamente no código para não coloca-la no program.cs
        private: visto somente no documento em questão
        public: visto em qualquer parte do projeto e em qualquer documento
        */
        public UserClass _usuario = new UserClass();
        //2- mesmo conceito da posição 1 apontando apenas para outra classe criada
        public AdressClass _endereço = new AdressClass();
        //3- mesmo conceito aplicado na 2
        public KeyClass key;
        /*
        4- esta não está sendo apontada para nenhum local, é um valor indipendente
        não necessita de mais dados para serem completados, apenas manipulada
        */
        private double _saldo = 100;

        /*
        Verificação booleana, ou seja retorna apenas verdadeiro ou falso
        para executar a operação, a mesma é publica para ser chamada no projeto
        e executar a ação definida pelo programador e passar para a classe privada
        */
        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
        }

        /*
         Realizando um deposito, somente adicionando o valor(por que nao tem verificação?)
        em um exemplo real o cliente so deposita o valor e o mesmo é confirmado por uma
        pessoa física para não garantir ser fraude
        */
        public void Depositar(double valor)
        {
            _saldo += valor;
        }

        /*
        Mostrar saldo
        */
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (_saldo < 0)
                {
                    return;
                }
                else
                {
                    _saldo = value;
                }
            }
        }
    }
}
