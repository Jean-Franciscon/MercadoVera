using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace Mercado_Vera
{


    class BemaFI32

    {
     public BemaFI32()

     {

     }

     



            #region DECLARAÇÃO DAS FUNÇÕES DA BEMAFI32.DLL



            #region Funções de Inicialização

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AlteraSimboloMoeda(string SimboloMoeda);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaAliquota(string Aliquota, int ICMS_ISS);

            [DllImport("BemaFi32.dll")] public static extern int Dados_Vera(string loja, double cnpj, string end, int num, double numero, string email);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NomeiaTotalizadorNaoSujeitoIcms(int Indice, string Totalizador);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LinhasEntreCupons(int Linhas);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_EspacoEntreLinhas(int Dots);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ForcaImpactoAgulhas(int ForcaImpacto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaHorarioVerao();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaArredondamento();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaTruncamento();

            #endregion



            #region Funções do Cupom Fiscal

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreCupom(string CGC_CPF);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VendeItem(string Codigo, string Descricao, string Aliquota, string TipoQuantidade, string Quantidade, int CasasDecimais, string ValorUnitario, string TipoDesconto, string Desconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VendeItemDepartamento(string Codigo, string Descricao, string Aliquota, string ValorUnitario, string Quantidade, string Acrescimo, string Desconto, string IndiceDepartamento, string UnidadeMedida);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaItemAnterior();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaItemGenerico(string NumeroItem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaCupom();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FechaCupomResumido(string FormaPagamento, string Mensagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FechaCupom(string FormaPagamento, string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto, string ValorPago, string Mensagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_IniciaFechamentoCupom(string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_EfetuaFormaPagamento(string FormaPagamento, string ValorFormaPagamento);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_EfetuaFormaPagamentoDescricaoForma(string FormaPagamento, string ValorFormaPagamento, string Descricao);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_TerminaFechamentoCupom(string Mensagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_EstornoFormasPagamento(string FormaOrigem, string FormaDestino, string Valor);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AumentaDescricaoItem(string Descricao);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_UsaUnidadeMedida(string UnidadeMedida);

            #endregion



            #region Funções dos Relatórios Fiscais

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraX();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraXSerial();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ReducaoZ(string Data, string Hora);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RelatorioGerencial(string Texto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FechaRelatorioGerencial();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalData(string DataInicial, string DataFinal);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalReducao(string ReducaoInicial, string ReducaoFinal);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalSerialData(string DataInicial, string DataFinal);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalSerialReducao(string ReducaoInicial, string ReducaoFinal);

            #endregion



            #region Funções das Operações Não Fiscais

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RecebimentoNaoFiscal(string IndiceTotalizador, string Valor, string FormaPagamento);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreComprovanteNaoFiscalVinculado(string FormaPagamento, string Valor, string NumeroCupom);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_UsaComprovanteNaoFiscalVinculado(string Texto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FechaComprovanteNaoFiscalVinculado();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_Sangria(string Valor);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_Suprimento(string Valor, string FormaPagamento);

            #endregion



            #region Funções de Informações da Impressora

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_Acrescimos([MarshalAs(UnmanagedType.VBByRefStr)] ref string ValorAcrescimos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_Cancelamentos([MarshalAs(UnmanagedType.VBByRefStr)] ref string ValorCancelamentos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CGC_IE([MarshalAs(UnmanagedType.VBByRefStr)] ref string CGC, [MarshalAs(UnmanagedType.VBByRefStr)] ref string IE);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ClicheProprietario([MarshalAs(UnmanagedType.VBByRefStr)] ref string Cliche);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadorBilhetePassagem(string ContadorPassagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadoresTotalizadoresNaoFiscais([MarshalAs(UnmanagedType.VBByRefStr)] ref string Contadores);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_DadosUltimaReducao([MarshalAs(UnmanagedType.VBByRefStr)] ref string DadosReducao);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_DataHoraImpressora([MarshalAs(UnmanagedType.VBByRefStr)] ref string Data, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Hora);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_DataHoraReducao([MarshalAs(UnmanagedType.VBByRefStr)] ref string Data, [MarshalAs(UnmanagedType.VBByRefStr)] ref string Hora);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_DataMovimento([MarshalAs(UnmanagedType.VBByRefStr)] ref string Data);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_Descontos([MarshalAs(UnmanagedType.VBByRefStr)] ref string ValorDescontos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FlagsFiscais(ref int Flag);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_GrandeTotal([MarshalAs(UnmanagedType.VBByRefStr)] ref string GrandeTotal);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_MinutosLigada([MarshalAs(UnmanagedType.VBByRefStr)] ref string Minutos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_MinutosImprimindo([MarshalAs(UnmanagedType.VBByRefStr)] ref string Minutos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_MonitoramentoPapel(ref int Linhas);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroCaixa([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroCaixa);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroCupom([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroCupom);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroCuponsCancelados([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroCancelamentos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroIntervencoes([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroIntervencoes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroLoja([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroLoja);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroOperacoesNaoFiscais([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroOperacoes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroReducoes([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroReducoes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroSerie([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroSerie);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroSubstituicoesProprietario([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroSubstituicoes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RetornoAliquotas([MarshalAs(UnmanagedType.VBByRefStr)] ref string Aliquotas);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_SimboloMoeda([MarshalAs(UnmanagedType.VBByRefStr)] ref string SimboloMoeda);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_SubTotal([MarshalAs(UnmanagedType.VBByRefStr)] ref string SubTotal);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_UltimoItemVendido([MarshalAs(UnmanagedType.VBByRefStr)] ref string NumeroItem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ValorFormaPagamento(string Forma, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ValorForma);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ValorPagoUltimoCupom([MarshalAs(UnmanagedType.VBByRefStr)] ref string ValorCupom);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ValorTotalizadorNaoFiscal(string Totalizador, [MarshalAs(UnmanagedType.VBByRefStr)] ref string ValorTotalizador);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaAliquotasIss([MarshalAs(UnmanagedType.VBByRefStr)] ref string Flag);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaEpromConectada([MarshalAs(UnmanagedType.VBByRefStr)] ref string Flag);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaDepartamentos([MarshalAs(UnmanagedType.VBByRefStr)] ref string Departamentos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaEstadoImpressora(ref int ACK, ref int ST1, ref int ST2);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaFormasPagamento([MarshalAs(UnmanagedType.VBByRefStr)] ref string Formas);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaIndiceAliquotasIss([MarshalAs(UnmanagedType.VBByRefStr)] ref string Flag);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaModoOperacao([MarshalAs(UnmanagedType.VBByRefStr)] ref string Modo);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaRecebimentoNaoFiscal([MarshalAs(UnmanagedType.VBByRefStr)] ref string Recebimentos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaTipoImpressora(ref int TipoImpressora);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaTotalizadoresNaoFiscais([MarshalAs(UnmanagedType.VBByRefStr)] ref string Totalizadores);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaTotalizadoresParciais([MarshalAs(UnmanagedType.VBByRefStr)] ref string Totalizadores);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaTruncamento([MarshalAs(UnmanagedType.VBByRefStr)] ref string Flag);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VersaoFirmware([MarshalAs(UnmanagedType.VBByRefStr)] ref string VersaoFirmware);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_TotalIcmsCupom([MarshalAs(UnmanagedType.VBByRefStr)] ref string ValorIcms);

            #endregion



            #region Funções de Autenticação e Gaveta de Dinheiro

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AcionaGaveta();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_Autenticacao();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaCaracterAutenticacao(string Parametros);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaEstadoGaveta(out int EstadoGaveta);

            #endregion



            #region Funções de Impressão de Cheques

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaImpressaoCheque();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ImprimeCheque(string Banco, string Valor, string Favorecido, string Cidade, string Data, string Mensagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ImprimeCopiaCheque();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_IncluiCidadeFavorecido(string Cidade, string Favorecido);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaMoedaPlural(string MoedaPlural);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaMoedaSingular(string MoedaSingular);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaStatusCheque(ref int StatusCheque);

            #endregion



            #region Outras Funções

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AberturaDoDia(string Valor, string FormaPagto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbrePortaSerial();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FechamentoDoDia();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FechaPortaSerial();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ImprimeConfiguracoesImpressora();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ImprimeDepartamentos();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_MapaResumo();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RelatorioTipo60Analitico();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RelatorioTipo60Mestre();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RetornoImpressora(ref int ACK, ref int ST1, ref int ST2);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaImpressoraLigada();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ResetaImpressora();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreBilhetePassagem(string ImprimeValorFinal, string ImprimeEnfatizado, string Embarque, string Destino, string Linha, string Prefixo, string Agente, string Agencia, string Data, string Hora, string Poltrona, string Plataforma);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ImpressaoCarne(string Titulo, string Parcelas, string Datas, int Quantidade, string Texto, string Cliente, string RG_CPF, string Cupom, int Vias, int Assina);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeArquivoRetorno([MarshalAs(UnmanagedType.VBByRefStr)] ref string Retorno);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_GeraRegistrosCAT52MFD(string cArquivo, string cData);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_GeraRegistrosCAT52MFDEx(string cArquivo, string cData, ref string cArqDestino);

            #endregion



            #region Funções para a Impressora Restaurante

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_AbreConferenciaMesa(string Mesa);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_AbreCupomRestaurante(string Mesa, string CGC_CPF);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_CancelaVenda(string Mesa, string Codigo, string Descricao, string Aliquota, string Quantidade, string ValorUnitario, string FlagAcrescimoDesconto, string ValorAcrescimoDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_ConferenciaMesa(string Mesa, string FlagAcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_ContaDividida(string NumeroCupons, string ValorPago, string CGC_CPF);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_CardapioPelaSerial();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_FechaConferenciaMesa(string FlagAcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_FechaCupomContaDividida(string NumeroCupons, string FlagAcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto, string FormasPagamento, string ValorFormasPagamento, string ValorPagoCliente, string CGC_CPF);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_FechaCupomRestaurante(string FormaPagamento, string FlagAcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto, string ValorFormaPagto, string Mensagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_ImprimeCardapio();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_RegistraVenda(string Mesa, string Codigo, string Descricao, string Aliquota, string Quantidade, string ValorUnitario, string FlagAcrescimoDesconto, string ValorAcrescimoDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_RegistroVendaSerial(string Mesa);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_RelatorioMesasAbertas(int TipoRelatorio);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_RelatorioMesasAbertasSerial();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_TransferenciaItem(string MesaOrigem, string Codigo, string Descricao, string Aliquota, string Quantidade, string ValorUnitario, string FlagAcrescimoDesconto, string ValorAcrescimoDesconto, string MesaDestino);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_TransferenciaMesa(string MesaOrigem, string MesaDestino);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_VerificaMemoriaLivre(string Bytes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FIR_FechaCupomResumidoRestaurante(string FormaPagamento, string Mensagem);

            #endregion



            #region Funções da Impressora Fiscal MFD

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreBilhetePassagemMFD(string Embarque, string Destino, string Linha, string Agencia, string Data, string Hora, string Poltrona, string Plataforma, string TipoPassagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreComprovanteNaoFiscalVinculadoMFD(string FormaPagamento, string Valor, string NumeroCupom, string CGC, string nome, string Endereco);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreCupomMFD(string CGC, string Nome, string Endereco);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreRecebimentoNaoFiscalMFD(string CGC, string Nome, string Endereco);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AbreRelatorioGerencialMFD(string Indice);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AcrescimoDescontoItemMFD(string Item, string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimoDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AcrescimoDescontoSubtotalRecebimentoMFD(string cFlag, string cTipo, string cValor);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AcrescimoDescontoSubtotalMFD(string cFlag, string cTipo, string cValor);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_AutenticacaoMFD(string Linhas, string Texto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaAcrescimoDescontoItemMFD(string cFlag, string cItem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaAcrescimoDescontoSubtotalMFD(string cFlag);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaAcrescimoDescontoSubtotalRecebimentoMFD(string cFlag);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaCupomMFD(string CGC, string Nome, string Endereco);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CancelaRecebimentoNaoFiscalMFD(string CGC, string Nome, string Endereco);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ComprovantesNaoFiscaisNaoEmitidosMFD(string Comprovantes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CNPJMFD(string CNPJ);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadorComprovantesCreditoMFD(string Comprovantes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadorCupomFiscalMFD(string CuponsEmitidos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadorFitaDetalheMFD(string ContadorFita);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadorOperacoesNaoFiscaisCanceladasMFD(string OperacoesCanceladas);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadorRelatoriosGerenciaisMFD(string Relatorios);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ContadoresTotalizadoresNaoFiscaisMFD(string Contadores);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_CupomAdicionalMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_DadosUltimaReducaoMFD(string DadosReducao);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_DataHoraUltimoDocumentoMFD(string cDataHora);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_EfetuaFormaPagamentoMFD(string FormaPagamento, string ValorFormaPagamento, string Parcelas, string DescricaoFormaPagto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_EfetuaRecebimentoNaoFiscalMFD(string IndiceTotalizador, string ValorRecebimento);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_EstornoNaoFiscalVinculadoMFD(string CGC, string Nome, string Endereco);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_FechaRecebimentoNaoFiscalMFD(string Mensagem);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_HabilitaDesabilitaRetornoEstendidoMFD(string FlagRetorno);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ImprimeChequeMFD(string NumeroBanco, string Valor, string Favorecido, string Cidade, string Data, string Mensagem, string ImpressaoVerso, string Linhas);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_IniciaFechamentoCupomMFD(string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimo, string ValorDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_IniciaFechamentoRecebimentoNaoFiscalMFD(string AcrescimoDesconto, string TipoAcrescimoDesconto, string ValorAcrescimo, string ValorDesconto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_InscricaoEstadualMFD(string InscricaoEstadual);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_InscricaoMunicipalMFD(string InscricaoMunicipal);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraChequeMFD(string CodigoCMC7);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalDataMFD(string DataInicial, string DataFinal, string FlagLeitura);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalReducaoMFD(string ReducaoInicial, string ReducaoFinal, string FlagLeitura);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalSerialDataMFD(string DataInicial, string DataFinal, string FlagLeitura);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_LeituraMemoriaFiscalSerialReducaoMFD(string ReducaoInicial, string ReducaoFinal, string FlagLeitura);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_MapaResumoMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_MarcaModeloTipoImpressoraMFD(string Marca, string Modelo, string Tipo);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_MinutosEmitindoDocumentosFiscaisMFD(string Minutos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NomeiaRelatorioGerencialMFD(string Indice, string Descricao);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroSerieMFD(string NumeroSerie);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_NumeroSerieMemoriaMFD(string NumeroSerieMFD);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_PercentualLivreMFD(string cMemoriaLivre);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ProgramaFormaPagamentoMFD(string FormaPagto, string OperacaoTef);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ReducoesRestantesMFD(string Reducoes);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ReimpressaoNaoFiscalVinculadoMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RelatorioTipo60AnaliticoMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_RetornoImpressoraMFD(ref int ACK, ref int ST1, ref int ST2, ref int ST3);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_SegundaViaNaoFiscalVinculadoMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_SubTotalizaCupomMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_SubTotalizaRecebimentoMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_TotalLivreMFD(string cMemoriaLivre);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_TamanhoTotalMFD(string cTamanhoMFD);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_TempoOperacionalMFD(string TempoOperacional);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_TotalizaCupomMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_TotalizaRecebimentoMFD();

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_UsaRelatorioGerencialMFD(string Texto);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ValorFormaPagamentoMFD(string Forma, string ValorForma);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_ValorTotalizadorNaoFiscalMFD(string Totalizador, string ValorTotalizador);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaEstadoImpressoraMFD(ref int ACK, ref int ST1, ref int ST2, ref int ST3);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaFormasPagamentoMFD(string FormasPagamento);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaRecebimentoNaoFiscalMFD(string Recebimentos);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaRelatorioGerencialMFD(string Relatorios);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaTotalizadoresNaoFiscaisMFD(string Totalizadores);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VerificaTotalizadoresParciaisMFD(string Totalizadores);

            [DllImport("BemaFi32.dll")] public static extern int Bematech_FI_VersaoFirmwareMFD(string VersaoFirmware);

            #endregion



            #endregion



        }

}



