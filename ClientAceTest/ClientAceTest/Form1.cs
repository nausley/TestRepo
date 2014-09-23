using System;
using System.Windows.Forms;
using Kepware.ClientAce.OpcDaClient;


namespace ClientAceTest
{
    public partial class Form1 : Form
    {
        private readonly DaServerMgt _daServerMgt;
        private string _url;
        private int _clientHandle;

        public Form1()
        {
            _daServerMgt = new DaServerMgt();
            InitializeComponent();
            tbStatus.Text = "Not Connected";
        }

        private void cmdLocal_Click(object sender, EventArgs e)
        {
            tbConnectUrl.Text = "opcda://localhost/Kepware.KEPServerEX.V5";
        }

        private void cmdRemote_Click(object sender, EventArgs e)
        {
            tbConnectUrl.Text = "opcda://172.24.1.31/Kepware.KEPServerEX.V5";
//            tbConnectUrl.Text = "opc.tcp://127.0.0.1:49320";
        }

        private void cmdConnect_Click(object sender, EventArgs e)
        {
            bool connectFailed;
            _url = tbConnectUrl.Text;
            _clientHandle = Convert.ToInt32(tbClientHandle.Text);
            var userId = new UserIdentityTokenUserPassword { UserName = "172.24.1.31/envisionService", Password = "WwdRk6DVtQoD8y6" };
            var connectInfo = new ConnectInfo
            {
                LocalId = "en",
                ClientName = tbClientName.Text,
                KeepAliveTime = 500,
                RetryAfterConnectionError = true,
                RetryInitialConnection = false,
                UserIdentity = userId
            };

            try
            {
                _daServerMgt.Connect(_url, _clientHandle, ref connectInfo, out connectFailed);
                tbStatus.Text = !connectFailed ? "Successful" : "Error Connecting!!";
            }
            catch (Exception ex)
            {
                connectFailed = true;
                tbStatus.Text = !connectFailed ? "Successful" : "Error Connecting!!";
                var msg = "Connection Error\n" + ex.Message + "\nInner Exception:\n" + ex.InnerException;
                MessageBox.Show(msg,"Connection Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                if (_daServerMgt.IsConnected) _daServerMgt.Disconnect();
            }

        }

        private void cmdDisconnect_Click(object sender, EventArgs e)
        {
            if (_daServerMgt.IsConnected)
            {
                _daServerMgt.Disconnect();
                tbStatus.Text = "Not Connected";
            }
            

        }

        private void cmdExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formClosing(object sender, FormClosingEventArgs e)
        {
            //TODO Close Kepware ClientAce connections
            if (_daServerMgt.IsConnected) _daServerMgt.Disconnect();
            _daServerMgt.Dispose();
        }
    }
}
