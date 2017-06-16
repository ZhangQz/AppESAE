using System;
namespace ESAE_CROSSPLATFORM
{
    public class Propina
    {
		//propriedades
		string mes;
		int ano, valor;
        bool pago;

		//construtor da classe
		public Propina()
		{
			this.mes = null;
			this.ano = 0;
			this.valor = 0;
            this.pago = false;
		}

		//construtor alternativo
		public Propina(string _mes, int _ano, int _valor, bool _pago)
		{
			this.mes = _mes;
			this.ano = _ano;
			this.valor = _valor;
			this.pago = _pago;
		}

		//getters
		public string GetMes() { return this.mes; }
		public int GetAno() { return this.ano; }
		public int GetValor() { return this.valor; }
		public bool GetPago() { return this.pago; }

		//setters
		public void SetMes(string _mes) { this.mes = _mes; }
		public void SetAno(int _ano) { this.ano = _ano; }
		public void SetValor(int _valor) { this.valor = _valor; }
		public void SetPago(bool _pago) { this.pago = _pago; }
		

		//métodos úteis
		public int GetNumCaracteres(string _conteudo)
		{
			return _conteudo.Length;
		}

		public string ToUpper(string _conteudo)
		{
			return _conteudo.ToUpper();
		}
    }
}
