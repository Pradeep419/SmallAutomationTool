using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Net;
using System.Windows.Forms;

namespace AutomationTool
{
    public partial class Form1 : Form
    {
        HttpWebRequest req = null;
        public String url = " ";
        public IWebDriver driver = null;
        public IList<IWebElement> imagesInaPage = new List<IWebElement>();
        public IList<IWebElement> textBox = new List<IWebElement>();
        public IList<IWebElement> hyperlinks = new List<IWebElement>();
        public IList<IWebElement> dropDowns = new List<IWebElement>();
        public IList<String> URLNames = new List<String>();
        public IList<String> statusCodes = new List<String>();
        public Form1()
        {
            InitializeComponent();
        }

        private void URLBox_TextChanged(object sender, EventArgs e)
        {
            url = URLBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string localURL = url;
            driver = new FirefoxDriver();
            driver.Navigate().GoToUrl(localURL);
            imagesInaPage = driver.FindElements(By.TagName("img"));
            Images.Text = imagesInaPage.Count.ToString();
            textBox = driver.FindElements(By.XPath("//input[@type = 'text']"));
            ImgaeswithLinks.Text = textBox.Count.ToString();
            hyperlinks = driver.FindElements(By.TagName("a"));
            Links.Text = hyperlinks.Count.ToString();
            dropDowns = driver.FindElements(By.TagName("select"));
            Select.Text = dropDowns.Count.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            responseCodeValidator(sender, e);



            //richTextBox1_TextChanged_1(sender, e);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Images_TextChanged(object sender, EventArgs e)
        {
            Images.Text = imagesInaPage.Count.ToString();

        }

        private void ImgaeswithLinks_TextChanged(object sender, EventArgs e)
        {
            ImgaeswithLinks.Text = textBox.Count.ToString();
        }

        private void Links_TextChanged(object sender, EventArgs e)
        {
            Links.Text = hyperlinks.Count.ToString();
        }

        private void Select_TextChanged(object sender, EventArgs e)
        {
            Select.Text = dropDowns.Count.ToString();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged_1(object sender, EventArgs e)
        {

            for (int i = 0; i < URLNames.Count; i++)
            {

                richTextBox1.Text = ($"URL : {URLNames[i]} and Status Code : {statusCodes[i]}");
                richTextBox1.AppendText(Environment.NewLine);


            }
        }
        public void responseCodeValidator(object sender, EventArgs e)
        {

            foreach (var link in hyperlinks)
            {

                string attribute = link.GetAttribute("href");
                if (attribute == null || attribute.Contains("mailto:") || attribute.Contains("javascript:") || attribute == "" || attribute.Contains("file:") || attribute.Contains("webex"))
                    continue;
                else
                {
                    req = (HttpWebRequest)WebRequest.Create(attribute);
                    try
                    {
                        //Console.WriteLine($"Link Text on Page : {l.Text}");
                        req.Proxy.Credentials = CredentialCache.DefaultCredentials;
                        req.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/66.0.3359.181 Safari/537.36";
                        var response = (HttpWebResponse)req.GetResponse();
                        //Console.WriteLine($"URL: {linktoTest.GetAttribute("href")} && Status is :{response.StatusCode}");
                        if (response.StatusCode.Equals("Not Found"))
                            continue;
                        richTextBox1.AppendText(Environment.NewLine);
                        richTextBox1.Text = attribute + response.StatusCode;
                        //URLNames.Add(link.Text);
                        //statusCodes.Add(response.StatusCode.ToString());

                    }
                    catch (WebException err)
                    {
                        //Console.WriteLine($"Link Text on Page : {linktoTest.Text}");
                        var errorResponse = (HttpWebResponse)err.Response;
                        //Console.WriteLine($"URL: {linktoTest.GetAttribute("href")} && Status is :{errorResponse.StatusCode}");
                        if (errorResponse.StatusCode.Equals("Not Found"))
                            continue;
                        richTextBox1.AppendText(Environment.NewLine);
                        richTextBox1.Text = ($"URL : {link.Text} ## Status Code is : {errorResponse.StatusCode}");
                        
                        //URLNames.Add(link.Text);
                        //statusCodes.Add(errorResponse.StatusCode.ToString());
                    }


                }

            }
        }
    }
}
