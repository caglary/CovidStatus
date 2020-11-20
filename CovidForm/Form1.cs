using Newtonsoft.Json;
using System;
using Entities;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Linq;

namespace CovidForm
{
    public partial class Form1 : Form
    {
        Item _liste;
        string url ="https://api.covid19api.com/summary";
        public Form1()
        {
            InitializeComponent();
            _liste = GetListCountry();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Loading();

        }

        private void Loading()
        {
            if (_liste != null)
            {
                var liste = _liste.Countries.OrderByDescending(I => I.TotalConfirmed).ToList();
                dgwCountries.DataSource = liste;
                dgwCountries.Columns["CountryCode"].Visible = false;
                dgwCountries.Columns["Slug"].Visible = false;
                dgwCountries.Columns["date"].Visible = false;
                var year= liste[1].date.Substring(0,4);
                var month = liste[1].date.Substring(5,2);
                var day = liste[1].date.Substring(8,2);
                DateTime tarih = Convert.ToDateTime(string.Format("{0}/{1}/{2}", day, month, year));
                labelTarih.Text = tarih.ToLongDateString();
                VeriYaz();
            }
            else
            {
                lblCountryName.Text = "";
                txtNewConfirmed.Text = "";
                txtNewDeaths.Text = "";
                txtNewRecovered.Text = "";
                txtTotalConfirmed.Text = "";
                txtTotalDeaths.Text = "";
                txtTotalRecovered.Text = "";


            }
        }

        private void VeriYaz(string countryName)
        {
            foreach (var item in _liste.Countries)
            {
                if (item.Country == countryName)
                {
                    txtNewConfirmed.Text = item.NewConfirmed;
                    txtNewDeaths.Text = item.NewDeaths;
                    txtNewRecovered.Text = item.NewRecovered;
                    txtTotalConfirmed.Text = Convert.ToInt32(item.TotalConfirmed).ToString();
                    txtTotalDeaths.Text = item.TotalDeaths;
                    txtTotalRecovered.Text = item.TotalRecovered;
                }
            }
            lblCountryName.Text = countryName;
        }
        private void VeriYaz()
        {

            txtNewConfirmed.Text = _liste.Global.NewConfirmed;
            txtNewDeaths.Text = _liste.Global.NewDeaths;
            txtNewRecovered.Text = _liste.Global.NewRecovered;
            txtTotalConfirmed.Text = _liste.Global.TotalConfirmed.ToString();
            txtTotalDeaths.Text = _liste.Global.TotalDeaths;
            txtTotalRecovered.Text = _liste.Global.TotalRecovered;
            lblCountryName.Text = "Dünyada Covid-19";
        }

        private Item GetListCountry()
        {
            
            string jsonString = string.Empty;
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(url);
                httpWebRequest.Method = "GET";
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                Console.WriteLine(httpWebResponse.StatusCode);
                Console.WriteLine(httpWebResponse.Server);

                using (Stream stream = httpWebResponse.GetResponseStream())   //modified from your code since the using statement disposes the stream automatically when done
                {
                    StreamReader reader = new StreamReader(stream, System.Text.Encoding.UTF8);
                    jsonString = reader.ReadToEnd();
                }
            }
            catch (Exception)
            {

                MessageBox.Show($"İnternet bağlantınızı kontrol ediniz.\n{url} adresinden veriler çekilemedi.","Dikkat",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }


            return JsonConvert.DeserializeObject<Item>(jsonString);
        }

        private void dgwCountries_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (_liste != null)
            {
                int rowIndex = dgwCountries.CurrentRow.Index;
                string country = dgwCountries.Rows[rowIndex].Cells["country"].Value.ToString();
                VeriYaz(country);
            }



        }

        void Refresh()
        {
            _liste = GetListCountry();
            Loading();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
