namespace Atividade
{
    class Clientes
    {
        public string nome {get; set;}
        public string endereco {get; set;}
        private float valor {get; protected set;}
        private float valor_imposto {get; protected set;}
        private float total {get; protected set;}

        public virtual void Pagar_Imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 10 / 100
            this.valor = this.valor + this.valor_imposto;
}
    }
}