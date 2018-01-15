using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;

namespace Americas.Api.Models
{

    [Table("SISHOSP.FAPACCAD")]
    public partial class Fapaccad
    {
        [Key]
        [StringLength(7)]
        public string COD_PAC { get; set; }

        [Required]
        [StringLength(9)]
        public string COD_PRT { get; set; }

        [StringLength(5)]
        public string LEITO { get; set; }

        [StringLength(2)]
        public string TIPO { get; set; }

        [StringLength(1)]
        public string TIP_ATEND { get; set; }

        [Required]
        [StringLength(4)]
        public string COD_ALA { get; set; }

        [StringLength(1)]
        public string TIPO_PAC { get; set; }

        public DateTime? DATA_ENT { get; set; }

        public DateTime? HORA_ENT { get; set; }

        public DateTime? DATA_PRSAI { get; set; }

        public DateTime? HORA_PRSAI { get; set; }

        [StringLength(40)]
        public string NOME_RSP { get; set; }

        [StringLength(60)]
        public string END_RSP { get; set; }

        [StringLength(16)]
        public string BAI_RSP { get; set; }

        [StringLength(16)]
        public string CID_RSP { get; set; }

        [StringLength(2)]
        public string EST_RSP { get; set; }

        [StringLength(10)]
        public string CEP_RSP { get; set; }

        [StringLength(20)]
        public string PROF_RSP { get; set; }

        [StringLength(20)]
        public string FONE_RSP { get; set; }

        [StringLength(20)]
        public string IDENT_RSP { get; set; }

        [StringLength(14)]
        public string CPF_RSP { get; set; }

        [StringLength(40)]
        public string NOME_SEGU { get; set; }

        [StringLength(20)]
        public string FONE_SEGU { get; set; }

        public DateTime? DATA_ALTA { get; set; }

        public DateTime? HORA_ALTA { get; set; }

        [StringLength(1)]
        public string MOTI_ALTA { get; set; }

        [StringLength(1)]
        public string TERMO { get; set; }

        [Required]
        [StringLength(3)]
        public string COD_CON { get; set; }

        [Required]
        [StringLength(3)]
        public string COD_PLA { get; set; }

        [StringLength(30)]
        public string SENHA { get; set; }

        [StringLength(20)]
        public string NUM_GUIA { get; set; }

        public DateTime? VAL_GUIA { get; set; }

        [StringLength(30)]
        public string MATRICULA { get; set; }

        [Required]
        [StringLength(6)]
        public string COD_PRO { get; set; }

        [StringLength(6)]
        public string COD_PRO_SA { get; set; }

        [StringLength(1)]
        public string F_CAUDEP { get; set; }

        [StringLength(1)]
        public string F_CAURET { get; set; }

        [StringLength(1)]
        public string F_PARCIAL { get; set; }

        [StringLength(1)]
        public string F_GUIA { get; set; }

        [StringLength(1)]
        public string F_VAL_GUIA { get; set; }

        [StringLength(1)]
        public string F_COB_PARCIAL { get; set; }

        [StringLength(1)]
        public string F_TETO_INAMPS { get; set; }

        public decimal? VAL_CAUCAO { get; set; }

        public decimal? VAL_PARCIAL { get; set; }

        [StringLength(250)]
        public string OBS1 { get; set; }

        [StringLength(15)]
        public string DUM { get; set; }

        [StringLength(60)]
        public string MEDICAMENTO_USO { get; set; }

        [StringLength(120)]
        public string OBSERVACAO { get; set; }

        [StringLength(1)]
        public string SUSPENSO { get; set; }

        [StringLength(7)]
        public string COD_MAE { get; set; }

        [StringLength(1)]
        public string LOCAL_ENTREGA { get; set; }

        [StringLength(4)]
        public string POSTO_COLETA { get; set; }

        public DateTime? ULT_DTXAUT { get; set; }

        [StringLength(4)]
        public string COD_SUB { get; set; }

        [StringLength(1)]
        public string DIREITO_ACO { get; set; }

        [StringLength(1)]
        public string DIREITO_ALI_ACO { get; set; }

        [StringLength(1)]
        public string DIREITO_TEL { get; set; }

        [StringLength(1)]
        public string ACIDENTE_TRAB { get; set; }

        [StringLength(1)]
        public string CASO_POLICIAL { get; set; }

        [StringLength(1)]
        public string CONTA_FECHADA { get; set; }

        [StringLength(1)]
        public string INIBE_PEDIDO { get; set; }

        public decimal? VALOR_CH { get; set; }

        public decimal? VALOR_FILME { get; set; }

        public decimal? VALOR_MAT_TAX { get; set; }

        [StringLength(1)]
        public string OCORRENCIA_ATEND { get; set; }

        [StringLength(6)]
        public string COD_UNI { get; set; }

        public DateTime? DATA_LIM_PED { get; set; }

        public DateTime? HORA_LIM_PED { get; set; }

        public decimal? VAL_CAU_PART_SGUIA { get; set; }

        public long? COD_MATRICULA { get; set; }

        [StringLength(3)]
        public string COD_SISTEMA { get; set; }

        [StringLength(14)]
        public string CPF_SEGURADO { get; set; }

        [StringLength(20)]
        public string COD_IDENT_SEGURADO { get; set; }

        [StringLength(7)]
        public string COD_LOTE { get; set; }

        [StringLength(5)]
        public string COD_ESP { get; set; }

        [StringLength(1)]
        public string CONTROLE_CONSULTA { get; set; }

        public DateTime? DATA_ALTA_MEDICA { get; set; }

        [StringLength(6)]
        public string MEDICO_ALTA_MEDICA { get; set; }

        [StringLength(1)]
        public string CONDICOES_RN { get; set; }

        [StringLength(1)]
        public string OBITO_MATERNO { get; set; }

        public DateTime? DT_AUTORIZACAO { get; set; }

        [StringLength(1)]
        public string ASSINATURA_GUIA { get; set; }

        [StringLength(1)]
        public string ABORTO { get; set; }

        [StringLength(1)]
        public string DURA_GESTACAO { get; set; }

        [StringLength(1)]
        public string TIPO_GRAVIDEZ { get; set; }

        [StringLength(1)]
        public string TIPO_PARTO { get; set; }

        [StringLength(1)]
        public string N_CONS_PRE_NATA { get; set; }

        [StringLength(1)]
        public string NUM_FILHOS_VIVOS { get; set; }

        [StringLength(1)]
        public string NUM_FILHOS_MORTOS { get; set; }

        public long? APGAR_1_MIN { get; set; }

        public long? APGAR_5_MIN { get; set; }

        [StringLength(1)]
        public string ATEND_NEO_NATAL { get; set; }

        public double? PESO { get; set; }

        public long? GEMELAR { get; set; }

        public long? ID_REG { get; set; }

        [StringLength(1)]
        public string ALTA_MED_MEDVIEW { get; set; }

        [StringLength(6)]
        public string COD_CID { get; set; }

        [StringLength(6)]
        public string COD_RSV { get; set; }

        [StringLength(1)]
        public string TIPO_RSV { get; set; }

        [StringLength(2)]
        public string COD_MOT_ALTA { get; set; }

        [Required]
        [StringLength(1)]
        public string IND_DAY_CLINIC { get; set; }

        public long? TIP_ATEND_TISS { get; set; }

        [StringLength(4000)]
        public string OBS_ALTA { get; set; }

        public long? QTD_SESSAO_PAC { get; set; }

        public long? REF_ARQ { get; set; }

        [StringLength(1)]
        public string SN_DOC_EST_RSP { get; set; }

        [StringLength(8)]
        public string NU_DOC_EST_RSP { get; set; }

        [StringLength(30)]
        public string NO_DOC_EST_PS_RSP { get; set; }

        public DateTime? DH_DOC_EST_VAL_RSP { get; set; }

        public long? FK_PARENT { get; set; }

        public DateTime? DH_DUM { get; set; }

        [StringLength(1)]
        public string IN_METODO_EST { get; set; }

        [StringLength(2)]
        public string IN_INI_PRENATAL { get; set; }

        public long? NU_GESTACAO_ANT { get; set; }

        public long? NU_PARTO_VAGINAL { get; set; }

        public long? NU_PARTO_CESARIA { get; set; }

        [StringLength(1)]
        public string SN_PARTO_INDUZIDO { get; set; }

        [StringLength(1)]
        public string IN_APRESENTACAO { get; set; }

        public long? NU_FILHOS_NVIVO { get; set; }

        public long? NU_FILHOS_NMORTO { get; set; }

        [StringLength(1)]
        public string SN_CSR_ANT_TRBPART { get; set; }

        [StringLength(1)]
        public string IN_ASSIST_NASC { get; set; }

        public DateTime? DAT_ULT_ATUALIZ { get; set; }

        public DateTime? DT_HR_ALTA_MEDICA { get; set; }

        [StringLength(4)]
        public string COD_SET { get; set; }

        public DateTime? DT_HR_REALALTAMED { get; set; }

        [StringLength(6)]
        public string CODIGO_EMPRESA { get; set; }

        [StringLength(15)]
        public string NUM_ATESTADO_OBITO { get; set; }

        [StringLength(11)]
        public string NUM_ATESTADO_NASC { get; set; }

        public long? FK_UR_CID { get; set; }

        public DateTime? DH_AUTO_INTERNA { get; set; }

        [Required]
        [StringLength(1)]
        public string SN_ELETIVO { get; set; }

        [StringLength(20)]
        public string DS_NUM_PEDIDO { get; set; }

        [StringLength(1)]
        public string SN_ALTAPREVISTA { get; set; }

        [StringLength(7)]
        public string COD_PAC_ANT { get; set; }

        [Column(TypeName = "LONG RAW")]
        [MaxLength(2147483647)]
        public byte[] IM_DATAMATRIX { get; set; }

        public DateTime? ASM_DATA_ALTA { get; set; }

        protected string getTokenValue(JObject json, string key)
        {
            return json.ToString().Contains("\"" + key + "\":") && ((JValue)json.SelectToken(key)).Value != null
                ? ((JValue)json.SelectToken(key)).Value.ToString()
                : "";
        }

        protected DateTime? TokenToDateTime(JObject json, string key, string format)
        {
            string strDate = getTokenValue(json, key);
            if (!string.IsNullOrEmpty(strDate))
            {
                if (format.Length == 10)
                    strDate = strDate.Substring(0, 10);

                if (strDate.Contains("/"))
                    strDate = strDate.Replace('/', '-');

                return DateTime.ParseExact(strDate, format, CultureInfo.InvariantCulture);
            }
            else
            {
                return null;
            }
        }

        public void DeserializeJson(JObject json)
        {
            /*COD_PAC = getTokenValue(json, "codpac");
            Sistema = getTokenValue(json, "sistema");
            BancoDados = getTokenValue(json, "bancoDados");
            NomeServidor = getTokenValue(json, "nomeServidor");
            Ip = getTokenValue(json, "ip");
            Porta = int.Parse(getTokenValue(json, "porta"));
            Usuario = getTokenValue(json, "usuario");
            Senha = getTokenValue(json, "senha");
            Status = getTokenValue(json, "status");
            DataStatus = TokenToDateTime(json, "dataStatus", "dd-MM-yyyy");
            */
            /*Exemplo de campo boolean
             * if (!string.IsNullOrEmpty(getTokenValue(json, "ativo")))
                Ativo = Convert.ToBoolean(getTokenValue(json, "ativo"));
            */

        }
    }
}