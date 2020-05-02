using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
   public class Produto:Entidade
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Descricao)) AdicionarErro("Descricao nao pode ser vazio");
            if (string.IsNullOrEmpty(Nome)) AdicionarErro("Nome nao pode ser vazio");
            if (Preco == 0) AdicionarErro("Preco deve ser informado");
        }
    }
}
