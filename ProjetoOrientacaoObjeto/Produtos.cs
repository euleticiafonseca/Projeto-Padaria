using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrientacaoObjeto
{
    public class Produtos
    {
        private string Descricao;
        private int Codigo;
        private int Valor;
        private int Quantidade;
        private double Total;
        private string DataEntrada;
        private string DataSaida;

        public void setDescricao(string Descricao)
        {
            this.Descricao = Descricao;
        }
        public string getDescricao()
        {
            return this.Descricao;
        }

        public void setCodigo(int Codigo)
        {
            this.Codigo = Codigo;
        }
        public int getCodigo()
        {
            return this.Codigo;
        }

        public void setValor(int Valor)
        {
            this.Valor = Valor;
        }
        public int getValor()
        {
            return this.Valor;
        }

        public void setQuantidade(int Quantidade)
        {
            this.Quantidade = Quantidade;
        }
        public int getQuantidade()
        {
            return this.Quantidade;
        }

        public void setTotal(double Total)
        {
            this.Total = Total;
        }
        public double getTotal()
        {
            return this.Total;
        }

        public void setDataentrada(string DataEntrada)
        {
            this.DataEntrada = DataEntrada;
        }
        public string getDataEntrada()
        {
            return this.DataEntrada;
        }

        public void setDataSaida(string DataSaida)
        {
            this.DataSaida = DataSaida;
        }
        public string getDataSaida()
        {
            return this.DataSaida;
        }

        internal void setCodigo(string text)
        {
            throw new NotImplementedException();
        }

        internal void setTotal(string text)
        {
            throw new NotImplementedException();
        }

        internal void setDataentrada(object text)
        {
            throw new NotImplementedException();
        }

        internal void setDataSaida(object txtDataSaida)
        {
            throw new NotImplementedException();
        }
    }
}
