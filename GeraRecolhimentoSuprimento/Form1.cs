using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace GeraRecolhimentoSuprimento
{
    public partial class Form1 : Form
    {
        ModeloSaidaVerificarTarefas _tarefas;
        byte _operacao = 0;

        public Form1()
        {
            InitializeComponent();
        }

        public string JsonPrettify(string json)
        {
            using (var stringReader = new StringReader(json))
            using (var stringWriter = new StringWriter())
            {
                var jsonReader = new JsonTextReader(stringReader);
                var jsonWriter = new JsonTextWriter(stringWriter) { Formatting = Newtonsoft.Json.Formatting.Indented };
                jsonWriter.WriteToken(jsonReader);
                return stringWriter.ToString();
            }
        }

        private void btnRecolhimento_Click(object sender, EventArgs e)
        {
            try
            {

                ModeloEntradaVerificarTarefas entradaSaldo = new ModeloEntradaVerificarTarefas();

                entradaSaldo.nu_terminal = int.Parse(txbTerminal.Text);

                string conteudoData = JsonConvert.SerializeObject(entradaSaldo);

                string responsebody = ChamaApi(txb_URLServivos.Text, conteudoData, "saldoCedulas", "POST");

                txbEntradaSaldoCedula.Text = JsonPrettify(responsebody);

                ModeloSaidaSaldoCedulas saida = JsonConvert.DeserializeObject<ModeloSaidaSaldoCedulas>(txbEntradaSaldoCedula.Text);

                Tarefa tarefa = _tarefas.tarefa.Find(x => x.cd_tarefa == 10);

                if (tarefa != null)
                {
                    RecolhimentoSuprimento saidaA = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "A");
                    RecolhimentoSuprimento saidaB = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "B");
                    RecolhimentoSuprimento saidaC = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "C");
                    RecolhimentoSuprimento saidaD = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "D");
                    RecolhimentoSuprimento saidaReject = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "REJECT");

                    ModeloEntradaRecolhimento entrada = new ModeloEntradaRecolhimento();

                    entrada.nu_terminal = Convert.ToInt32(txbTerminal.Text); 
                    entrada.nu_os = Convert.ToInt32(cbbTarefas_nu_os.SelectedItem);
                    entrada.dt_atendimento = DateTime.Now.ToString("ddMMyyyyHHmmss");
                    entrada.dt_envio = DateTime.Now.ToString("ddMMyyyyHHmmss");

                    entrada.qtd_cedulas_cassete_A = saidaA == null ? 0 : saidaA.qt_k7;
                    entrada.qtd_cedulas_cassete_B = saidaB == null ? 0 : saidaB.qt_k7;
                    entrada.qtd_cedulas_cassete_C = saidaC == null ? 0 : saidaC.qt_k7;
                    entrada.qtd_cedulas_cassete_D = saidaD == null ? 0 : saidaD.qt_k7;

                    entrada.valor_cedulas_cassete_A = entrada.qtd_cedulas_cassete_A * (saidaA == null ? 0 : saidaA.vl_k7);
                    entrada.valor_cedulas_cassete_B = entrada.qtd_cedulas_cassete_B * (saidaB == null ? 0 : saidaB.vl_k7);
                    entrada.valor_cedulas_cassete_C = entrada.qtd_cedulas_cassete_C * (saidaC == null ? 0 : saidaC.vl_k7);
                    entrada.valor_cedulas_cassete_D = entrada.qtd_cedulas_cassete_D * (saidaD == null ? 0 : saidaD.vl_k7);

                    entrada.valor_total_rejeicao = (saida.qtd_cedulas_rejeitadas_A + saida.valor_cedulas_cassete_A
                        + saida.qtd_cedulas_rejeitadas_B * saida.valor_cedulas_cassete_B
                        + saida.qtd_cedulas_rejeitadas_C * saida.valor_cedulas_cassete_C
                        + saida.qtd_cedulas_rejeitadas_D * saida.valor_cedulas_cassete_D);

                    txbSaida.Text = JsonPrettify(JsonConvert.SerializeObject(entrada));

                    _operacao = 1;
                }
            }
            catch(Exception ex)
            {
                txbEntradaSaldoCedula.Text = ex.Message;
            }
        }

        private void btnConcluirTarefa_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloEntradaConcluirTarefas entrada = new ModeloEntradaConcluirTarefas();

                entrada.id_tarefa = Convert.ToInt32(cbbConcluirTarefas_id_tarefa.SelectedItem);
                entrada.tp_atendimento = cbbConcluirTarefas_tp_atendimento.SelectedItem.ToString();
                entrada.dt_atendimento = DateTime.Now.ToString("ddMMyyyyhhmmss");

                txbSaida.Text = JsonPrettify(JsonConvert.SerializeObject(entrada));

                _operacao = 3;
            }
            catch(Exception ex)
            {
                txbSaida.Text = ex.Message;
            }
        }

        private void btnVerificaTarefas_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloEntradaVerificarTarefas entrada = new ModeloEntradaVerificarTarefas();

                entrada.nu_terminal = int.Parse(txbTerminal.Text);

                string conteudoData = JsonConvert.SerializeObject(entrada);

                string responsebody = ChamaApi(txb_URLServivos.Text, conteudoData, "verificarTarefas", "POST");

                txbEntradaTarefas.Text = JsonPrettify(responsebody);

                ModeloSaidaVerificarTarefas saida = JsonConvert.DeserializeObject<ModeloSaidaVerificarTarefas>(txbEntradaTarefas.Text);

                if (saida.nrRetorno == 0)
                {
                    _tarefas = saida;

                    cbbConcluirTarefas_id_tarefa.Items.Clear();

                    foreach (Tarefa t in saida.tarefa)
                    {
                        cbbConcluirTarefas_id_tarefa.Items.Add(t.id_tarefa);

                        if (t.nu_os != null)
                        {
                            cbbTarefas_nu_os.Items.Add(t.nu_os);
                        }
                    }

                    if (cbbConcluirTarefas_id_tarefa.Items.Count > 0)
                        cbbConcluirTarefas_id_tarefa.SelectedIndex = 0;

                    if (cbbTarefas_nu_os.Items.Count > 0)
                        cbbTarefas_nu_os.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                txbSaida.Text = ex.Message;
            }
        }

        private void btnSuprimento_Click(object sender, EventArgs e)
        {
            try
            {
                Tarefa tarefa = _tarefas.tarefa.Find(x => x.cd_tarefa == 20);

                if (tarefa != null)
                {
                    RecolhimentoSuprimento saidaA = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "A");
                    RecolhimentoSuprimento saidaB = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "B");
                    RecolhimentoSuprimento saidaC = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "C");
                    RecolhimentoSuprimento saidaD = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "D");
                    RecolhimentoSuprimento saidaReject = tarefa.listaEstruturaRecolhimentoSuprimento.Find(x => x.cd_k7 == "REJECT");

                    ModeloEntradaSuprimento entrada = new ModeloEntradaSuprimento();

                    entrada.nu_terminal = Convert.ToInt32(txbTerminal.Text);
                    entrada.nu_os = Convert.ToInt32(cbbTarefas_nu_os.SelectedItem);
                    entrada.dt_atendimento = DateTime.Now.ToString("ddMMyyyyHHmmss");
                    entrada.dt_envio = DateTime.Now.ToString("ddMMyyyyHHmmss");

                    entrada.qtd_cedulas_cassete_A = saidaA == null ? 0 : saidaA.qt_k7;
                    entrada.qtd_cedulas_cassete_B = saidaB == null ? 0 : saidaB.qt_k7;
                    entrada.qtd_cedulas_cassete_C = saidaC == null ? 0 : saidaC.qt_k7;
                    entrada.qtd_cedulas_cassete_D = saidaD == null ? 0 : saidaD.qt_k7;

                    entrada.valor_cedulas_cassete_A = entrada.qtd_cedulas_cassete_A * (saidaA == null ? 0 : saidaA.vl_k7);
                    entrada.valor_cedulas_cassete_B = entrada.qtd_cedulas_cassete_B * (saidaB == null ? 0 : saidaB.vl_k7);
                    entrada.valor_cedulas_cassete_C = entrada.qtd_cedulas_cassete_C * (saidaC == null ? 0 : saidaC.vl_k7);
                    entrada.valor_cedulas_cassete_D = entrada.qtd_cedulas_cassete_D * (saidaD == null ? 0 : saidaD.vl_k7);

                    txbSaida.Text = JsonPrettify(JsonConvert.SerializeObject(entrada));

                    _operacao = 2;
                }
            }
            catch (Exception ex)
            {
                txbSaida.Text = ex.Message;
            }
        }

        private string ChamaApi(string ip, string conteudoData, string metodo, string tipo)
        {
            WebClient wc = new WebClient();
            wc.UseDefaultCredentials = true;
            wc.Dispose();

            wc.Headers[HttpRequestHeader.Authorization] = "Bearer Token_Content";
            wc.Headers[HttpRequestHeader.ContentType] = "application/json";

            byte[] result = wc.UploadData(ip + metodo, tipo, System.Text.Encoding.UTF8.GetBytes(conteudoData));
            string responsebody = System.Text.Encoding.UTF8.GetString(result);

            return responsebody;
        }

        private void btnExecuta_Click(object sender, EventArgs e)
        {
            string responsebody = "";
            string conteudoData = txbSaida.Text;

            switch (_operacao)
            {
                case 1:
                     responsebody = ChamaApi(txb_URLServivos.Text, conteudoData, "recolhimento", "POST");
                    break;
                case 2:
                     responsebody = ChamaApi(txb_URLServivos.Text, conteudoData, "suprimento", "POST");
                    break;
                case 3:
                     responsebody = ChamaApi(txb_URLServivos.Text, conteudoData, "concluirTarefas", "POST");
                    break;
            }

            txbSaida.Text = JsonPrettify(responsebody);
        }
    }
}
