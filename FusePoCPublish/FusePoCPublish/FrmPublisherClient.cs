using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FusePoCPublish
{
    using FusePoCPublish.EsbProxyPerson;

    public partial class FrmPublisherClient : Form
    {
        private int messageNum = 0;

        public FrmPublisherClient()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            try
            {
                string message = txtBxName.Text;
                SayHiEndpointClient client = new SayHiEndpointClient();
                //bool result = client.SayHi(message);
                Person person = new Person()
                                    {
                                        Name = txtBxName.Text,
                                        Surname = txtBxSurname.Text
                                    };

                bool result = client.SayHi(person);

                lblMessageNum.Text = messageNum.ToString();

                rtbxLog.AppendText(messageNum++ + " " + txtBxName.Text + " " + txtBxSurname.Text + " : Service operation invocation result: " + result+ "\n");
            }
            catch (Exception e)
            {
                rtbxLog.AppendText(e.Message);
            }
        }
    }
}
