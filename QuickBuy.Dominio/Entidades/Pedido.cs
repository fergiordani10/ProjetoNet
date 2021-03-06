﻿using QuickBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public class Pedido:Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }
        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string CEP { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public string NumeroEndereco { get; set; }
        public int FormaPagamentoId { get; set; }
        public virtual FormaPagamento FormaPagamento{ get; set; }
     
        //Pedido deve ter pelo menus um item de pedido ou varios itens pedidos
        //
        public virtual ICollection<ItemPedido> ItensPedido { get; set; }
    

        public override void Validate()
        {
            LimparMensagensValidacao();
            if (!ItensPedido.Any())                       AdicionarErro("Pedido deve ter um item");
            if (string.IsNullOrEmpty(CEP))                AdicionarErro("CEP nao pode ser vazio");
            if (FormaPagamentoId == 0)                    AdicionarErro("Nao foi informada a forma de pagamento");
        }
    }
}
