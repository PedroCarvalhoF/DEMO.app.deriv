using DEMO.app.deriv.Controles;
using DEMO.app.deriv.services.Services;
using DEMO.app.deriv.services.Services.DeriviApi.ProposalContract;
using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Net.NetworkInformation;
using System.Windows.Forms;

namespace DEMO.app.deriv
{
    public partial class FrmRiseFail : Form
    {
        private readonly IProposalContractServices _proposalContractServices;

        private Timer _timer;
        private ChartValues<double> _values; // Substituído ObservableCollection por ChartValues
        private int _tickCounter;

        public FrmRiseFail()
        {
            InitializeComponent();

            _proposalContractServices = ServicosApp.IProposalContractServices;
            _values = new ChartValues<double>();

            formatarChart();
        }

        private void formatarChart()
        {
            // Configura o gráfico
            cartesianChart1.Series = new SeriesCollection
                {
                    new LineSeries
                    {
                        Title = "Preço",
                        Values = _values,
                        PointGeometry = null,
                        LineSmoothness = 0.5
                    }
                };

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Tempo",
                MinValue = -1, // Desloca o gráfico para começar antes do primeiro ponto
                Separator = new Separator
                {
                    Step = 1, // Define o intervalo entre os valores do eixo X
                    IsEnabled = false // Oculta as linhas verticais do grid, se desejar
                }
            });
            cartesianChart1.AxisY.Add(new Axis
            {
                Title = "Valor",
                LabelFormatter = value => value.ToString("C2")
            });

            // Inicializa o timer
            //StartRealTimeData();

        }
        private void StartRealTimeData()
        {
            _tickCounter = 0;
            _timer = new Timer { Interval = 1000 };
            _timer.Tick += (sender, args) =>
            {
                // Gera valores dinâmicos (simulação)
                double newValue = Math.Sin(_tickCounter * 0.1) * 10 + 50;
                _tickCounter++;

                // Atualiza o gráfico
                _values.Add(newValue);

                if (_values.Count > 50)
                {
                    _values.RemoveAt(0);
                }

                // Força a atualização do gráfico (opcional)
                //cartesianChart1.Update(true, true);
            };
            _timer.Start();
        }
        private void FrmRiseFail_Load(object sender, System.EventArgs e)
        {
            timer1.Start();
        }


        double ultimo_preco = 0;
        //double preco_atual = 0;
        double diferenca = 0;
        private SetasDirecao CalcularDiferencaRetornaSeta(double precoUpdate)
        {
            //0 = 0 - 100;
            //0 = 100-100;
            //0 = 100-200;
            diferenca = precoUpdate - ultimo_preco;
            ultimo_preco = precoUpdate;

            if (diferenca == 0)
            {
                //manteve

                return SetasDirecao.DireitaComPonto;
            }
            else
            {
                if (diferenca > 0)
                {
                    return SetasDirecao.Cima;
                }
                else
                {
                    //menor que zero
                    return SetasDirecao.Baixo;
                }
            }
        }

        private void AddSetaStatusContrato(double precoUpdate)
        {
            try
            {
                flStatusPrecoContrato.Controls.Add(CtrlUpDown.CriarControle(CalcularDiferencaRetornaSeta(precoUpdate)));
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        int tick = 0;
        DateTime time_incial = DateTime.Now;
        private async void timer1_Tick(object sender, System.EventArgs e)
        {
            try
            {
                //var resultContract = await _proposalContractServices.GetProposalResponseAsync();
                //txtPrecoContrato.Text = resultContract.proposal.spot.ToString();
                //_values.Add(Convert.ToDouble(resultContract.proposal.spot));


                var resultContract = await _proposalContractServices.GetProposalResponseAsync();
                tick += 1;
                lblPreco.Text = resultContract.proposal.spot.ToString();
                var preco = Convert.ToDouble(resultContract.proposal.spot.ToString());

                _values.Add(preco);
                AddSetaStatusContrato(preco);

                lblTick.Text = $"Tick: {tick}";
                lblTempoExecucao.Text = $"Tempo de Execução: {DateTime.Now - time_incial}";

            }
            catch (System.Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);

            }

        }
    }
}
