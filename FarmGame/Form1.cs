using Autofac.Features.AttributeFilters;
using FarmGame.Service;
using FarmGame.Service.Msg;
using FarmGame.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmGame
{
    public partial class Form1 : Form
    {
        private readonly IMsgService _msgService;
        private readonly IMsgService _msgService2;
        private readonly RandomHelper _randomHelper;

        public Form1([KeyFilter("msgService")] IMsgService msgService, RandomHelper randomHelper)
        {
            _msgService = msgService;
            _randomHelper = randomHelper;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ResetProgressBar();
        }

        private void ResetProgressBar()
        {
            Task.Run(() => UpdateProgressBar(CucumbersBar, _randomHelper.GetRandomProgressbarNumber()));
            Task.Run(() => UpdateProgressBar(PotatoesBar, _randomHelper.GetRandomProgressbarNumber()));
            Task.Run(() => UpdateProgressBar(TomatoesBar, _randomHelper.GetRandomProgressbarNumber()));
        }

        private void UpdateProgressBar<T>(T progressBar, Func<int> valueProvider) where T : ProgressBar
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action(() => { UpdateProgressBar(progressBar, valueProvider); }));
                return;
            }

            int value = valueProvider(); // 调用委托获取随机数
            progressBar.Value = value;
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            ResetProgressBar();
        }
    }
}
