using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Newtonsoft.Json;
using OpenQA.Selenium.Support.UI;
using Keys = OpenQA.Selenium.Keys;
using OpenQA.Selenium.Support;
using System.Collections.Concurrent;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Check_Live_Zalo
{
    public partial class Dashboah : Form
    {
        private DataTable profileTable = new DataTable();
        public Dashboah()
        {
            InitializeComponent();
        }

        private void LoadDataGridViewValues(string fileName, DataGridView dgv)
        {
            try
            {
                if (File.Exists(fileName))
                {
                    var json = File.ReadAllText(fileName);
                    var data = JsonConvert.DeserializeObject<List<Dictionary<string, string>>>(json);

                    for (int i = 0; i < data.Count; i++)
                    {
                        var row = data[i];
                        dgv.Rows.Add();
                        for (int j = 0; j < dgv.Columns.Count; j++)
                        {
                            var columnName = dgv.Columns[j].Name;
                            if (row.ContainsKey(columnName))
                            {
                                dgv.Rows[i].Cells[j].Value = row[columnName];
                            }
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void SaveDataGridViewValues(string fileName, DataGridView dgv)
        {
            var data = new List<Dictionary<string, string>>();
            for (int i = 0; i < dgv.Rows.Count - 1; i++)
            {
                var row = new Dictionary<string, string>();
                for (int j = 0; j < dgv.Columns.Count; j++)
                {
                    var columnName = dgv.Columns[j].Name;
                    var cellValue = dgv.Rows[i].Cells[j].Value?.ToString() ?? "";
                    row.Add(columnName, cellValue);
                }
                data.Add(row);
            }
            var json = JsonConvert.SerializeObject(data);
            File.WriteAllText(fileName, json);
        }
        private List<profile> profiles;
        private void Dashboah_Load(object sender, EventArgs e)
        {
            LoadDataGridViewValues("profile.json", dgv_Profile);
            string directoryPath = @"C:\path\to";
            LoadProfilesFromDirectory(directoryPath);

        }
        private void LoadProfilesFromDirectory(string directoryPath)
        {
            cbx_listProfile.Items.Clear();
            try
            {
                // Kiểm tra xem đường dẫn thư mục có tồn tại hay không
                if (Directory.Exists(directoryPath))
                {
                    // Lấy tên của các thư mục con trong đường dẫn
                    string[] profileDirectories = Directory.GetDirectories(directoryPath);

                    // Thêm từng tên thư mục làm một mục mới trong ComboBox
                    foreach (string profileDirectory in profileDirectories)
                    {
                        // Lấy tên thư mục cuối cùng từ đường dẫn
                        string profileName = Path.GetFileName(profileDirectory);
                        cbx_listProfile.Items.Add(profileName);
                    }
                }
                else
                {
                    // Tạo mới thư mục nếu không tồn tại
                    Directory.CreateDirectory(directoryPath);

                    // Hiển thị thông báo
                    MessageBox.Show("Directory created!");

                    // Không thêm gì vào ComboBox vì thư mục mới chỉ được tạo ra
                }
            }
            catch (Exception ex)
            {
                // Xử lý lỗi nếu có
                MessageBox.Show("Error loading profiles: " + ex.Message);
            }
            cbx_listProfile.StartIndex = 0;
        }
        private void Dashboah_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveDataGridViewValues("profile.json", dgv_Profile);
            ClosedDriver();
        }
        void ClosedDriver()
        {
            // Đóng tất cả các ChromeDriver trước khi thoát ứng dụng
            foreach (var driver in chromeDrivers)
            {
                try
                {
                    driver.Quit();
                    driver.Dispose();
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu cần thiết
                    // ...
                }
            }
            chromeDrivers.Clear();
        }
        private void btnCheckStatus_Click(object sender, EventArgs e)
        {
            ClosedDriver();
            Thread.Sleep(1000);
            Check_MultiThread();
        }
        //private volatile bool processingPhoneNumbers = true;
        // Trong class chính của ứng dụng (MainForm hoặc tên lớp tương tự), thêm một danh sách để lưu trữ các ChromeDriver.
        private List<IWebDriver> chromeDrivers = new List<IWebDriver>();
        void Check_MultiThread()
        {
            dgv_Profile.DataSource = null;
            List<string> profiles = new List<string>();
            foreach (var item in cbx_listProfile.Items)
            {
                profiles.Add(item.ToString());
            }

            BlockingCollection<string> phoneNumbersCollection = new BlockingCollection<string>();

            string[] phoneNumbers = null;
            this.Invoke(new Action(() =>
            {
                phoneNumbers = PhoneNumberTextBox.Text.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            }));

            foreach (string phoneNumber in phoneNumbers)
            {
                phoneNumbersCollection.Add(phoneNumber);
            }

            foreach (string PROFILE in profiles)
            {
                Thread thread = new Thread(() =>
                {
                    string localProfile = PROFILE;
                    int Qua = 0;

                    // Khai báo các biến cục bộ
                    IWebDriver driver = null;

                    try
                    {
                        // Xử lý trình duyệt trong luồng
                        this.Invoke(new Action(() =>
                        {
                            // Xóa DataGridView
                            ClearDataGridView(dgv_Profile);
                        }));

                        ChromeOptions options = new ChromeOptions();
                        options.AddArgument($@"--user-data-dir=C:\path\to\{localProfile}\directory");
                        // Set the window size
                        options.AddArgument("--window-size=600,500");
                        options.AddArgument("--force-device-scale-factor=0.8");
                        options.AddArgument("--headless"); // Chạy ẩn danh
                        options.AddArgument("--disable-logging"); // Ẩn cửa sổ CMD
                        ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                        service.HideCommandPromptWindow = true;

                        driver = new ChromeDriver(service, options);
                        driver.Navigate().GoToUrl(@"https://chat.zalo.me/");
                        chromeDrivers.Add(driver);
                        Thread.Sleep(3000);

                        // Tìm nút có class là "fa fa-outline-add-new-contact-2 pre" và click vào nút
                        IWebElement addButton = driver.FindElement(By.CssSelector(".fa.fa-outline-add-new-contact-2.pre"));
                        addButton.Click();

                        // Điền số điện thoại vào ô TextBox và xử lý kết quả
                        string phoneNumber;
                        while (phoneNumbersCollection.TryTake(out phoneNumber, 3000))
                        {
                            // Điền số điện thoại vào ô TextBox
                            IWebElement textBox = driver.FindElement(By.CssSelector("input.phone-i-input.flx-1"));
                            textBox.Clear();
                            textBox.SendKeys(phoneNumber);
                            // Nhấn phím Enter
                            textBox.SendKeys(Keys.Enter);
                            Thread.Sleep(1500); // Waiter load

                            // Kiểm tra xem có tên người dùng hay không
                            string name = "";
                            try
                            {
                                // Trích xuất tên từ phần tử trên trang
                                IWebElement nameElement = driver.FindElement(By.CssSelector("div.truncate.friend-profile__display-name"));
                                name = nameElement.Text;
                                Thread.Sleep(500);
                                // Thêm thông tin vào DataGridView
                                this.Invoke(new Action(() =>
                                {
                                    AddInfoToDataGridView(phoneNumber, null, name);
                                }));
                                Thread.Sleep(500);
                                // Tìm và click vào phần tử
                                IWebElement closeButton = driver.FindElement(By.CssSelector("i.fa.fa-close_24.flx-al-c"));
                                closeButton.Click();
                                Thread.Sleep(500);
                                continue; // Nếu tìm thấy tên, bỏ qua các trường hợp lỗi và xử lý số điện thoại tiếp theo
                            }
                            catch (NoSuchElementException)
                            {
                                try
                                {
                                    Thread.Sleep(500);
                                    // Tìm phần tử chứa toast message
                                    IWebElement toastContainer = driver.FindElement(By.ClassName("toast-container"));
                                    IWebElement toastMessage = toastContainer.FindElement(By.ClassName("toast"));

                                    // Lấy nội dung của toast message
                                    string toastText = toastMessage.Text;
                                    // Kiểm tra kí tự đầu tiên của toastText
                                    if (toastText.StartsWith("S"))
                                    {
                                        // Đoạn văn bản bắt đầu bằng 'S' - TH1: Số điện thoại chưa đăng ký tài khoản hoặc không cho phép tìm kiếm.
                                        this.Invoke(new Action(() =>
                                        {
                                            UpdateResultToTextBox(phoneNumber);
                                            AddInfoToDataGridView(phoneNumber, "VHH", null);
                                        }));
                                    }
                                    else if (toastText.StartsWith("B"))
                                    {
                                        // Đoạn văn bản bắt đầu bằng 'B' - TH2: Bạn đã tìm kiếm quá số lần cho phép. Vui lòng thử lại sau.
                                        //MessageBox.Show(" Bạn đã tìm kiếm quá số lần cho phép. Vui lòng thử lại sau.");
                                        this.Invoke(new Action(() =>
                                        {
                                            UpdateResultToTextBox(phoneNumber);
                                            AddInfoToDataGridView(phoneNumber, "QUA", null);
                                            driver.Quit();
                                        }));
                                        Thread.Sleep(5000);
                                    }
                                }
                                catch (Exception)
                                {
                                    throw;
                                }

                            }
                            Thread.Sleep(1000);
                        }
                        this.Invoke(new Action(() =>
                        {
                            driver.Quit();
                        }));
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }

                });
                thread.Start();
            }
        }

        private delegate void UpdateDataGridViewCallback(string phoneNumber, string status, string name);
        private delegate void UpdateTextBoxCallback(string phoneNumber);
        private delegate void ClearDataGridViewCallback(DataGridView dgv);

        private void UpdateResultToTextBox(string phoneNumber)
        {
            if (txt_fail.InvokeRequired)
            {
                UpdateTextBoxCallback callback = new UpdateTextBoxCallback(UpdateResultToTextBox);
                Invoke(callback, new object[] { phoneNumber });
            }
            else
            {
                txt_fail.AppendText(phoneNumber + Environment.NewLine);
            }
        }

        private void UpdateResultToDataGridView(string phoneNumber, string status, string name)
        {
            if (dgv_Profile.InvokeRequired)
            {
                UpdateDataGridViewCallback callback = new UpdateDataGridViewCallback(UpdateResultToDataGridView);
                Invoke(callback, new object[] { phoneNumber, status, name });
            }
            else
            {
                dgv_Profile.Rows.Add(dgv_Profile.Rows.Count + 1, phoneNumber, name);
            }
        }

        private void AddInfoToDataGridView(string sdt, string status, string name)
        {
            if (dgv_Profile.InvokeRequired)
            {
                UpdateDataGridViewCallback callback = new UpdateDataGridViewCallback(AddInfoToDataGridView);
                Invoke(callback, new object[] { sdt, status, name });
            }
            else
            {
                // Kiểm tra xem cặp sdt và tên đã tồn tại trong DataGridView chưa (trừ dòng cuối cùng)
                bool existed = false;
                int rowCount = dgv_Profile.Rows.Count;
                for (int i = 0; i < rowCount - 1; i++)
                {
                    DataGridViewRow row = dgv_Profile.Rows[i];
                    if (row.Cells["SDT"].Value.ToString() == sdt && row.Cells["name"].Value.ToString() == name)
                    {
                        existed = true;
                        break; // Exit the loop if the entry is found
                    }
                }

                // Nếu chưa tồn tại, thêm thông tin vào DataGridView
                if (!existed)
                {
                    // Add the new row to the DataGridView
                    int newRowIdx = dgv_Profile.Rows.Add(dgv_Profile.Rows.Count + 1, sdt, status, name);

                    // Get the newly added row and check if the "status" is "VHH"
                    DataGridViewRow newAddedRow = dgv_Profile.Rows[newRowIdx];
                    if (status == "QUA")
                    {
                        newAddedRow.DefaultCellStyle.BackColor = Color.PaleVioletRed;
                    }
                }
            }

        }

        private void ClearDataGridView(DataGridView dgv)
        {
            if (dgv.InvokeRequired)
            {
                ClearDataGridViewCallback callback = new ClearDataGridViewCallback(ClearDataGridView);
                Invoke(callback, new object[] { dgv });
            }
            else
            {
                dgv.Rows.Clear();
            }
        }

        private void btn_AddProfile_Click(object sender, EventArgs e)
        {
            string profileText = txt_profile.Text.Trim();

            if (!string.IsNullOrEmpty(profileText))
            {
                // Kiểm tra xem giá trị đã tồn tại trong ComboBox hay chưa
                if (cbx_listProfile.Items.Contains(profileText))
                {
                    MessageBox.Show("Profile already exists.");
                    return;
                }

                try
                {
                    // Tạo đường dẫn đầy đủ cho thư mục mới
                    string newProfileDirectory = Path.Combine("C:\\path\\to", profileText);

                    // Kiểm tra xem thư mục đã tồn tại hay chưa
                    if (!Directory.Exists(newProfileDirectory))
                    {
                        // Tạo thư mục mới
                        Directory.CreateDirectory(newProfileDirectory);

                        // Thêm tên thư mục mới vào ComboBox
                        cbx_listProfile.Items.Add(profileText);

                        // Xóa văn bản trong TextBox
                        txt_profile.Text = string.Empty;

                        // Hiển thị thông báo thành công
                        MessageBox.Show("New profile directory created.");
                    }
                    else
                    {
                        // Hiển thị thông báo nếu thư mục đã tồn tại
                        MessageBox.Show("Profile directory already exists.");
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý lỗi nếu có
                    MessageBox.Show("Error creating profile directory: " + ex.Message);
                }
            }
            else
            {
                // Hiển thị thông báo nếu không có văn bản được nhập vào
                MessageBox.Show("Please enter a profile name.");
            }

        }

        private void xAOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cbx_listProfile.SelectedItem != null)
            {
                try
                {
                    // Lấy mục đang được chọn
                    string selectedProfile = cbx_listProfile.SelectedItem.ToString();

                    // Xóa mục được chọn khỏi ComboBox
                    cbx_listProfile.Items.Remove(selectedProfile);

                    // Cập nhật lại tập tin "profile.txt" từ các mục còn lại trong ComboBox
                    File.WriteAllLines("profile.txt", cbx_listProfile.Items.Cast<string>());

                    cbx_listProfile.StartIndex = 0;
                }
                catch (Exception ex)
                {

                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một mục để loại bỏ..");
            }
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            string PROFILE = cbx_listProfile.SelectedItem.ToString();

            Thread thread = new Thread(() =>
            {
                ClearDataGridView(dgv_Profile);
                ChromeOptions options = new ChromeOptions();
                options.AddArgument($@"--user-data-dir=C:\path\to\{PROFILE}\directory");

                //// Add proxy settings
                //options.AddArgument($@"--proxy-server=https://{txt_profile.Text}");
                // Set the window size
                options.AddArgument("--window-size=600,500"); // Replace with your desired width and height

                // Set the zoom level
                options.AddArgument("--force-device-scale-factor=0.8"); // Adjust this value to set the zoom level (80% in this case)

                /*Enable kiosk mode
                //options.AddArgument("--kiosk");
                //options.AddArgument("--headless"); // Chạy ẩn danh
                //options.AddArgument("--disable-logging"); // Ẩn cửa sổ CMD
                */
                ChromeDriverService service = ChromeDriverService.CreateDefaultService();
                service.HideCommandPromptWindow = true;

                IWebDriver driver = new ChromeDriver(service, options);
                driver.Navigate().GoToUrl(@"https://chat.zalo.me/");
                //driver.Navigate().GoToUrl(@"https://checkip.com.vn/");
                string js = "var style = document.createElement('style');";
                js += "style.innerHTML = '::-webkit-scrollbar { display: none; }';"; // Hide scrollbars
                js += "style.innerHTML += '::-ms-overflow-style { display: none; }';"; // Hide scrollbars (for IE/Edge)
                js += "style.innerHTML += '::-webkit-scrollbar-thumb { display: none; }';"; // Hide scrollbar thumbs (for older Chrome versions)
                js += "style.innerHTML += 'body { overflow: hidden; }';"; // Hide scrollbars for the body
                js += "document.head.appendChild(style);";
                ((IJavaScriptExecutor)driver).ExecuteScript(js);

                /*// Inject CSS to set content zoom to 80%
                 //string js = "var style = document.createElement('style');";
                 //js += "style.innerHTML = 'body { zoom: 0.8; }';"; // Set zoom level to 80%
                 //js += "document.head.appendChild(style);";
                 //((IJavaScriptExecutor)driver).ExecuteScript(js);
                 //Thread.Sleep(5000);
                 //// Chờ đến khi element được tìm thấy
                 //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                 //By elementSelector = By.CssSelector(".fa.fa-outline-add-new-contact-2.pre");
                 //wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(elementSelector));

                 //// Tiếp tục xử lý sau khi element được tìm thấy
                 //// Đóng driver hoặc thực hiện hành động khác tùy thuộc vào yêu cầu của bạn
                 //driver.Quit();
                */
            });
            thread.Start();
        }

        private void PhoneNumberTextBox_TextChanged(object sender, EventArgs e)
        {
            string[] phoneNumbers = PhoneNumberTextBox.Text.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            int SL = phoneNumbers.Length;

            // Xóa phần sau của số điện thoại không cố định (ví dụ: " Ngoc.55")
            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string phoneNumber = phoneNumbers[i];
                int index = phoneNumber.IndexOf(" ");
                if (index != -1)
                {
                    phoneNumbers[i] = phoneNumber.Substring(0, index);
                }
            }

            // Cập nhật lại giá trị trong TextBox và thêm dòng mới
            PhoneNumberTextBox.Text = string.Join(Environment.NewLine, phoneNumbers) + Environment.NewLine;

            lb_SL.Text = SL.ToString();

            // Đặt vị trí con trỏ tại cuối dòng mới
            PhoneNumberTextBox.SelectionStart = PhoneNumberTextBox.Text.Length;
            PhoneNumberTextBox.SelectionLength = 0;
            PhoneNumberTextBox.ScrollToCaret();
        }

        private void txt_fail_TextChanged(object sender, EventArgs e)
        {
            string[] phoneNumbers = txt_fail.Text.Split(new[] { "\r\n", "\n", "\r" }, StringSplitOptions.RemoveEmptyEntries);
            int SL = phoneNumbers.Count();
            lb_VHH.Text = SL.ToString();
        }

    }



}

