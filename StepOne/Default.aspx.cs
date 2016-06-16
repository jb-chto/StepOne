using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

namespace StepOne
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                var getIp = ClassLibrary.ComputerIp.GetIp();
                var getPublicIp = ClassLibrary.ComputerIp.GetPublicIp();
             
                var iplist = RetrieveIPv4AndIPv6();

                Label1.Text = string.Format("Local Ip: " + getIp + "Public Ip: " + getPublicIp);
                

                ListBox2.DataSource = iplist;
                ListBox2.DataBind();



            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        public static List<string> RetrieveIPv4AndIPv6()
        {
            var address = new List<string>();

            foreach (IPAddress ipaddr in Dns.GetHostAddresses(Environment.MachineName))
            {
                switch (ipaddr.AddressFamily)
                {
                    case System.Net.Sockets.AddressFamily.InterNetwork:
                         address = new List<string> {string.Format("IP V4 Address : {0}", ipaddr.ToString())};
                        break;
                    case System.Net.Sockets.AddressFamily.InterNetworkV6:
                        address = new List<string> {string.Format("IP V6 Address : {0}", ipaddr.ToString())};
                        break;
                }
            }

            return address;
        }

       
    }
}