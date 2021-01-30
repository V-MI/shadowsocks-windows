using Shadowsocks.Controller;
using Shadowsocks.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Shadowsocks.View
{
    public partial class AddProxyDomain : Form
    {
        private ShadowsocksController controller;

        public AddProxyDomain(ShadowsocksController controller)
        {
            InitializeComponent(); 
            UpdateTexts();
            this.Icon = Icon.FromHandle(Resources.ssw128.GetHicon());
            this.controller = controller;
        }

        private void UpdateTexts()
        {
            AddButton.Text = I18N.GetString("&Add");
            this.Text = I18N.GetString("Add Proxy Domain");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBox1.Text))
                return;
            this.controller.AddProxyDomain(this.textBox1.Text);
            this.Close();
        }
    }
}
