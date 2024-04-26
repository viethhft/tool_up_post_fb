using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Login
{
    public partial class Form1 : Form
    {
        ChromeDriver _driver;
        ChromeOptions _options;
        ChromeDriverService _service;
        string _user;
        string _pass;
        public Form1(string user, string pass)
        {
            InitializeComponent();
            _user = user;
            _pass = pass;
        }

        private void btn_Done_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Tool_Click(object sender, EventArgs e)
        {


            _service = ChromeDriverService.CreateDefaultService();
            _service.HideCommandPromptWindow = true;

            _options = new ChromeOptions();
            _options.AddArgument("--disable-notifications");

            _driver = new ChromeDriver(_service, _options);
            _driver.Navigate().GoToUrl("https://www.facebook.com/?locale=vi_VN");

            var user = _driver.FindElement(By.Id("email"));
            var pass = _driver.FindElement(By.Id("pass"));
            var login = _driver.FindElement(By.Name("login"));
            user.SendKeys(_user);
            pass.SendKeys(_pass);
            login.Click();
            Thread.Sleep(10000);

            var story = _driver.FindElement(By.ClassName("x1l7q5kx"));
            story.Click();
            Thread.Sleep(5000);

            var setting = _driver.FindElement(By.CssSelector("div.x1i10hfl.x1ejq31n.xd10rxx.x1sy0etr.x17r0tee.x1ypdohk.xe8uvvx.xdj266r.x11i5rnm.xat24cr.x1mh8g0r.x16tdsg8.x1hl2dhg.xggy1nq.x87ps6o.x1lku1pv.x1a2a7pz.x6s0dn4.xzolkzo.x12go9s9.x1rnf11y.xprq8jg.x972fbf.xcfux6l.x1qhh985.xm0m39n.x9f619.x78zum5.xl56j7k.xexx8yu.x4uap5.x18d9i69.xkhd6sd.x1n2onr6.xc9qbxq.x14qfxbe.x1qhmfi1"));
            setting.Click();
            Thread.Sleep(2000);
            var option = _driver.FindElement(By.CssSelector("div.x1o9yfan > div:nth-child(6) > div:nth-child(1)"));
            option.Click();
            Thread.Sleep(3000);
            int index = 1;
            List<int> listIndex = new List<int>();
        backindex:
            try
            {
                for (int i = index; i < 1000; i++)
                {
                    index = i;
                    var friend = _driver.FindElement(By.CssSelector($".x78zum5.xdt5ytf.x1iyjqo2.x6ikm8r.x10wlt62.xzk7aed.xyamay9 > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child({i}) > div:nth-child(1)"));
                    friend.Click();
                    friend.Click();

                }

            }
            catch (Exception)
            {
                listIndex.Add(index);
                if (listIndex.Count < 500) goto backindex;
                else
                {
                    try
                    {
                        for (int i = 1; i < listIndex[listIndex.Count - 1]; i++)
                        {
                            var friend = _driver.FindElement(By.CssSelector($".x78zum5.xdt5ytf.x1iyjqo2.x6ikm8r.x10wlt62.xzk7aed.xyamay9 > div:nth-child(2) > div:nth-child(1) > div:nth-child(1) > div:nth-child({i}) > div:nth-child(1)"));
                            friend.Click();
                        }
                    }
                    catch (Exception)
                    {
                        var btnsave = _driver.FindElement(By.CssSelector(".x78zum5.xdt5ytf.x1iyjqo2.x6ikm8r.x10wlt62.xzk7aed.xyamay9 > div:nth-child(3) > div:nth-child(1) > div:nth-child(2) >  div:nth-child(1)"));
                        btnsave.Click();
                        Thread.Sleep(2000);
                        btnsave = _driver.FindElement(By.CssSelector("div.x1o9yfan > div:nth-child(7) > div:nth-child(2) >div:nth-child(1) > div:nth-child(2) > div:nth-child(1)"));
                        btnsave.Click();
                        Thread.Sleep(1000);
                        _driver.Close();
                        MessageBox.Show("Xong!!!");
                    }
                }
            }
        }
    }
}
