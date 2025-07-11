using System;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        private const string CurrentVersion = "1.0.0";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    string latestVersion = client.DownloadString("https://requerion.com/rdr-version").Trim();
                    if (latestVersion != CurrentVersion)
                    {
                        MessageBox.Show("Yeni bir güncelleme mevcut. Web sitesine yönlendiriliyorsunuz.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        System.Diagnostics.Process.Start("https://requerion.com");
                        Application.Exit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Güncelleme kontrolü başarısız: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string selectedFolder = textBox1.Text.Trim();

            if (!Directory.Exists(selectedFolder))
            {
                MessageBox.Show("Seçili klasör bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rdr2ExePath = Path.Combine(selectedFolder, "RDR2.exe");
            if (!File.Exists(rdr2ExePath))
            {
                MessageBox.Show("Seçilen klasörde RDR2.exe bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DeleteFile(Path.Combine(selectedFolder, "rdr2-translator.xml"));
                DeleteFile(Path.Combine(selectedFolder, "ScriptHookRDR2.dll"));
                DeleteFile(Path.Combine(selectedFolder, "dinput8.dll"));
                DeleteFile(Path.Combine(selectedFolder, "rdr2-translator.asi"));
                DeleteFile(Path.Combine(selectedFolder, "fontfix.asi"));
                DeleteDirectory(Path.Combine(selectedFolder, "commonx"));
                MessageBox.Show("Dosyalar başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void DownloadFile(string url, string destination)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(url, destination);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya indirme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteFile(string filePath)
        {
            try
            {
                if (File.Exists(filePath))
                {
                    File.Delete(filePath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteDirectory(string directoryPath)
        {
            try
            {
                if (Directory.Exists(directoryPath))
                {
                    Directory.Delete(directoryPath, true);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Klasör silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Close_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            using (FolderBrowserDialog folderPicker = new FolderBrowserDialog())
            {
                if (folderPicker.ShowDialog() == DialogResult.OK)
                {
                    textBox1.Text = folderPicker.SelectedPath;
                }
            }
        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            string selectedFolder = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(selectedFolder))
            {
                string rdr2ExePath = Path.Combine(selectedFolder, "RDR2.exe");

                if (File.Exists(rdr2ExePath))
                {
                    try
                    {
                        DownloadFile("https://requerion.com/rdr2/dinput8.dll", Path.Combine(selectedFolder, "dinput8.dll"));
                        DownloadFile("https://requerion.com/rdr2/fontfix.asi", Path.Combine(selectedFolder, "fontfix.asi"));
                        DownloadFile("https://requerion.com/rdr2/rdr2-translator.asi", Path.Combine(selectedFolder, "rdr2-translator.asi"));
                        DownloadFile("https://requerion.com/rdr2/rdr2-translator.xml", Path.Combine(selectedFolder, "rdr2-translator.xml"));
                        DownloadFile("https://requerion.com/rdr2/ScriptHookRDR2.dll", Path.Combine(selectedFolder, "ScriptHookRDR2.dll"));

                        string commonxFolder = Path.Combine(selectedFolder, "commonx");
                        string dataFolder = Path.Combine(commonxFolder, "data");
                        string uiFolder = Path.Combine(dataFolder, "ui");

                        Directory.CreateDirectory(uiFolder);

                        string fontmapPath = Path.Combine(uiFolder, "fontmap.xml");
                        DownloadFile("https://requerion.com/rdr2/fontmap.xml", fontmapPath);

                        MessageBox.Show("Dosyalar başarıyla indirildi ve kopyalandı.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Dosya indirme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Seçilen klasörde RDR2.exe bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir klasör seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Button3_Click_1(object sender, EventArgs e)
        {
            string selectedFolder = textBox1.Text.Trim();

            if (!Directory.Exists(selectedFolder))
            {
                MessageBox.Show("Seçili klasör bulunamadı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string rdr2ExePath = Path.Combine(selectedFolder, "RDR2.exe");
            if (!File.Exists(rdr2ExePath))
            {
                MessageBox.Show("Seçilen klasörde RDR2.exe bulunamadı!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                DeleteFile(Path.Combine(selectedFolder, "rdr2-translator.xml"));
                DeleteFile(Path.Combine(selectedFolder, "ScriptHookRDR2.dll"));
                DeleteFile(Path.Combine(selectedFolder, "dinput8.dll"));
                DeleteFile(Path.Combine(selectedFolder, "rdr2-translator.asi"));
                DeleteFile(Path.Combine(selectedFolder, "fontfix.asi"));
                DeleteDirectory(Path.Combine(selectedFolder, "commonx"));
                MessageBox.Show("Dosyalar başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Dosya silme hatası: " + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button4_Click_1(object sender, EventArgs e)
        {
            foreach (string drive in Directory.GetLogicalDrives())
            {
                try
                {
                    string[] rdr2Folders = Directory.GetDirectories(drive, "Red Dead Redemption 2", SearchOption.TopDirectoryOnly);
                    foreach (string folder in rdr2Folders)
                    {
                        if (File.Exists(Path.Combine(folder, "RDR2.exe")))
                        {
                            textBox1.Text = folder;
                            MessageBox.Show("Red Dead Redemption 2 klasörü bulundu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }
                }
                catch { }
            }

            MessageBox.Show("Red Dead Redemption 2 klasörü bulunamadı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
