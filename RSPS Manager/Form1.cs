using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSPS_Manager
{
    public class RSPSBasicInfo
    {
        public String dataUrl;
        public String shortDesc;
        public String serverName;
        public RSPSBasicInfo()
        {

        }

        public override string ToString()
        {
            return serverName;
        }

    }
    public partial class Form1 : Form
    {

        public static String clientFolder = "clients";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            String url = "http://rsps.gs2012.xyz/list";
            using (WebClient client = new WebClient())
            {
                string[] clientList = client.DownloadString(url).Split('\n');

                foreach (String clientInfo in clientList)
                {

                    RSPSBasicInfo r = new RSPSBasicInfo();
                    string[] basicInfo = clientInfo.Split(new[] { " | " }, StringSplitOptions.None);
                    if (String.IsNullOrWhiteSpace(basicInfo[0]))
                        break;

                    r.serverName = basicInfo[0];
                    r.shortDesc = basicInfo[1];
                    r.dataUrl = basicInfo[2];
                    serverListBox.Items.Add(r);
                }
                //client.DownloadFile("http://www.example.com/somefile.txt", @"c:\temp\somefile.txt");


            }
        }
    }
}
