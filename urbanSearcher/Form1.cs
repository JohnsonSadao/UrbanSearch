using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace urbanSearcher
{
    public partial class Form1 : Form
    {
        private static readonly HttpClient client = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void SearchAPI()
        {
            string localName = tbLocalName.Text;
            var longUri = "https://maps.googleapis.com/maps/api/place/findplacefromtext/json?";
            var uriBuilder = new UriBuilder(longUri);
            var query = HttpUtility.ParseQueryString(uriBuilder.Query);
            query["input"] = localName;
            query["inputtype"] = "textquery";
            query["fields"] = "name,formatted_address";
            query["key"] = "AIzaSyCqZlrIeGPEbmtw-l2ZVLNegbBuCaqlsg8";
            uriBuilder.Query = query.ToString();
            longUri = uriBuilder.ToString();

            WebRequest request = WebRequest.Create(longUri);

            WebResponse response = request.GetResponse();

            Stream data = response.GetResponseStream();

            StreamReader reader = new StreamReader(data);

            string responseFromServer = reader.ReadToEnd();

            response.Close();

            rtbResultado.Text = responseFromServer;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            SearchAPI();
        }
    }
}
