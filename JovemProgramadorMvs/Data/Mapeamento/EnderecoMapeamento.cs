using JovemProgramadorMvs.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JovemProgramadorMvs.Data.Mapeamento
{
    public class EnderecoMapeamento: IEntityTypeConfiguration<EnderecoModel>
    {
        public void Configure(EntityTypeBuilder<AlunoModel> builder)
        {
            builder.ToTable("EnderecoAluno");

            builder.HasKey(t => t.Id);
            builder.HasKey(t => t.IdAluno);

            builder.Property(t => t.Nome).HasColumnType("varchar(50)");
            builder.Property(t => t.Idade).HasColumnType("int");
            builder.Property(t => t.Contato).HasColumnType("varchar(15)");
            builder.Property(t => t.Email).HasColumnType("varchar(50)");
            builder.Property(t => t.Cep).HasColumnType("varchar(10)");
        }

    }
}
