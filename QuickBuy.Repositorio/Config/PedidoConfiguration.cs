using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickBuy.Repositorio.Config
{

    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        

        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(ped=> ped.Id);
            //builder utiliza o padrao Fluent
            builder
                .Property(ped => ped.DataPedido)
                .IsRequired();

            builder
               .Property(ped => ped.DataPrevisaoEntrega)
               .IsRequired();
              
            builder
               .Property(ped => ped.CEP)
               .IsRequired()
               .HasMaxLength(9);
            builder
               .Property(ped=> ped.Cidade)
               .IsRequired()
               .HasMaxLength(50);
            builder
               .Property(ped => ped.Estado)
               .IsRequired()
               .HasMaxLength(2);
            builder
              .Property(ped => ped.EnderecoCompleto)
              .IsRequired()
              .HasMaxLength(100);
            builder
              .Property(ped => ped.NumeroEndereco)
              .IsRequired()
              .HasMaxLength(4);
            builder
              .Property(ped => ped.Cidade)
              .IsRequired()
              .HasMaxLength(50);
            builder
              .Property(ped => ped.UsuarioId)
              .IsRequired();

            builder.HasOne(ped => ped.FormaPagamento);


            builder.HasOne(p => p.Usuario);
                
        }
    }
}
