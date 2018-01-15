namespace Americas.Api
{
    using Americas.Api.Models;
    using Americas.Api.Repositories;
    using Americas.Api.Repository.Contracts;
    using System.Data.Entity;

    public partial class AmericasDbContext : DbContext
    {
        public AmericasDbContext()
            : base("name=AmericasDbContext")
        {
        }

        public virtual DbSet<Fapaccad> Fapaccads { get; set; }

        public IFapaccadRepository GetFapaccadRepository()
        {
            return new FapaccadRepository(this);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_PAC)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_PRT)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.LEITO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.TIPO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.TIP_ATEND)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_ALA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.TIPO_PAC)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NOME_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.END_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.BAI_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CID_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.EST_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CEP_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.PROF_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.FONE_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.IDENT_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CPF_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NOME_SEGU)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.FONE_SEGU)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.MOTI_ALTA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.TERMO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_CON)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_PLA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.SENHA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NUM_GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.MATRICULA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_PRO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_PRO_SA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.F_CAUDEP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.F_CAURET)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.F_PARCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.F_GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.F_VAL_GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.F_COB_PARCIAL)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.F_TETO_INAMPS)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.VAL_CAUCAO)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.VAL_PARCIAL)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.OBS1)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.DUM)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.MEDICAMENTO_USO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.OBSERVACAO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.SUSPENSO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_MAE)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.LOCAL_ENTREGA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.POSTO_COLETA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_SUB)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.DIREITO_ACO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.DIREITO_ALI_ACO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.DIREITO_TEL)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.ACIDENTE_TRAB)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CASO_POLICIAL)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CONTA_FECHADA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.INIBE_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.VALOR_CH)
                .HasPrecision(16, 4);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.VALOR_FILME)
                .HasPrecision(16, 4);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.VALOR_MAT_TAX)
                .HasPrecision(16, 4);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.OCORRENCIA_ATEND)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_UNI)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.VAL_CAU_PART_SGUIA)
                .HasPrecision(16, 2);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_SISTEMA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CPF_SEGURADO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_IDENT_SEGURADO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_LOTE)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_ESP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CONTROLE_CONSULTA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.MEDICO_ALTA_MEDICA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CONDICOES_RN)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.OBITO_MATERNO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.ASSINATURA_GUIA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.ABORTO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.DURA_GESTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.TIPO_GRAVIDEZ)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.TIPO_PARTO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.N_CONS_PRE_NATA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NUM_FILHOS_VIVOS)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NUM_FILHOS_MORTOS)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.ATEND_NEO_NATAL)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.ALTA_MED_MEDVIEW)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_CID)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_RSV)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.TIPO_RSV)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_MOT_ALTA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.IND_DAY_CLINIC)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.OBS_ALTA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.SN_DOC_EST_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NU_DOC_EST_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NO_DOC_EST_PS_RSP)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.IN_METODO_EST)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.IN_INI_PRENATAL)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.SN_PARTO_INDUZIDO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.IN_APRESENTACAO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.SN_CSR_ANT_TRBPART)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.IN_ASSIST_NASC)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_SET)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.CODIGO_EMPRESA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NUM_ATESTADO_OBITO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.NUM_ATESTADO_NASC)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.SN_ELETIVO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.DS_NUM_PEDIDO)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.SN_ALTAPREVISTA)
                .IsUnicode(false);

            modelBuilder.Entity<Fapaccad>()
                .Property(e => e.COD_PAC_ANT)
                .IsUnicode(false);
        }
    }
}
