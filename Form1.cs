using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Globalization;
using Shared;
using System.IO;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

namespace Design
{
    public partial class Form1 : Form
    {
        KeyboardHook _keyboardHotKeyF1;
        KeyboardHook _keyboardHotKeyF2;
        KeyboardHook _keyboardHotKeyF3;

        public Form1()
        {
            InitializeComponent();
        }

        public static string ConvertRGBStringToHex(string value)
        {

            var matches = Regex.Matches(value, "[0-9]{1,3}(?![0-9a-fA-F])");

            var r = "";
            var ls = new List<string>();

            var count = 0;

            foreach (Match item in matches)

            {

                r += int.Parse(item.Value).ToString("X2");
                count++;
                if (count % 3 == 0)
                {
                    ls.Add(r);
                    r = "";
                    count = 0;
                }
            }
            return string.Join("\r\n", ls);
        }
        public static string ConvertHexStringToRGB(string hexColor)
        {

            if (hexColor.IndexOf('#') != -1)
                hexColor = hexColor.Replace("#", "");

            int red = 0;
            int green = 0;
            int blue = 0;

            if (hexColor.Length == 6)
            {
                //#RRGGBB
                red = int.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);
            }
            else if (hexColor.Length == 3)
            {
                //#RGB
                red = int.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
                green = int.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
                blue = int.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
            }
            return $"R={red}, G={green}, B={blue}";
        }

        private void RGB_Click(object sender, EventArgs e)
        {

        }

        private void HEX_Click(object sender, EventArgs e)
        {
            try
            {
                var v = Clipboard.GetText().Trim();

                Clipboard.SetText(ConvertHexStringToRGB(v));
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void 生成字母表和数字大写ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                var s = Enumerable.Range('A', 'Z' - 'A' + 1).Select(i => (char)i);
                var ss = Enumerable.Range(0, 10).Select(i => i.ToString());

                Clipboard.SetText(string.Join("", s) + string.Join("", ss));
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void switchCaseButton_ButtonClick(object sender, EventArgs e)
        {
            try
            {
                var v = Clipboard.GetText().Trim();

                var iu = v.Any(i => char.IsUpper(i));
                if (iu)
                {
                    v = v.ToLower();
                }
                else
                {
                    v = v.ToUpper();
                }

                Clipboard.SetText(v);
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void 获取屏幕颜色F1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_keyboardHotKeyF1 == null)
                _keyboardHotKeyF1 = new KeyboardHook();

            _keyboardHotKeyF1.RegisterHotKey(Shared.ModifierKeys.None, Keys.F1);
            _keyboardHotKeyF1.KeyPressed += (o, k) =>
            {
                try
                {
                    var (r, g, b) = Colors.GetColorAt();

                    Clipboard.SetText($"{r.ToString("X2")}{g.ToString("X2")}{b.ToString("X2")}");
                }
                catch (
                Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            };
        }



        private void 中_Click(object sender, EventArgs e)
        {
            Bing.Instance().ChineseToEnglishFromClipboard();
        }

        private void 排序空白分割后最后一个ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            try
            {
                var v = Clipboard.GetText().Trim();

                var ls = v.Split('\n').Where(i => !string.IsNullOrWhiteSpace(i) && i.Contains("\t")).Select(i => i.Trim()).Distinct().OrderBy(i =>
                  {
                      if (i.Contains("\t"))
                      {
                          return i.Split('\t').Last();
                      }
                      else
                      {
                          return "";
                      }
                  }).ToArray();

                Clipboard.SetText(string.Join(Environment.NewLine, ls));
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void rGBHEXF2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_keyboardHotKeyF2 == null)
            {
                _keyboardHotKeyF2 = new KeyboardHook();
            }
            _keyboardHotKeyF2.RegisterHotKey(Shared.ModifierKeys.None, Keys.F2);
            _keyboardHotKeyF2.KeyPressed += (o, k) =>
            {
                try
                {
                    var v = Clipboard.GetText().Trim();

                    Clipboard.SetText(ConvertRGBStringToHex(v));
                }
                catch (
                Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            };
        }

        private void RGB_ButtonClick(object sender, EventArgs e)
        {

            try
            {
                var v = Clipboard.GetText().Trim();

                Clipboard.SetText(Colors.ExtractRGB(v));
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void rGBHEXF3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_keyboardHotKeyF3 == null)
            {
                _keyboardHotKeyF3 = new KeyboardHook();
            }
            _keyboardHotKeyF3.RegisterHotKey(Shared.ModifierKeys.None, Keys.F3);
            _keyboardHotKeyF3.KeyPressed += (o, k) =>
            {
                try
                {
                    var v = Clipboard.GetText().Trim();

                    Clipboard.SetText(Colors.ConvertRGBStringToHex2(v));
                }
                catch (
                Exception exception)
                {

                    MessageBox.Show(exception.Message);
                }
            };
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            try
            {
                var v = Clipboard.GetText().Trim();
                if (!Directory.Exists(v)) return;
                var files = Directory.GetFiles(v, "*").Where(i => Regex.IsMatch(i, "\\.(?:ttf|otf)$", RegexOptions.IgnoreCase));

                foreach (var item in files)
                {
                    Fonts.ReNameFont(item);
                }
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void 生成二维码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var v = Clipboard.GetText().Trim();
                // instantiate a writer object
                var barcodeWriter = new BarcodeWriter();
                var options = new  QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 250,
                    Height = 250,
                };
                // set the barcode format
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                barcodeWriter.Options = options;
                // write text and generate a 2-D barcode as a bitmap
                barcodeWriter
                    .Write(v)
                    .Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetRandomFileName() + ".png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }

        private void qrButton_Click(object sender, EventArgs e)
        {
            try
            {
                var v = Clipboard.GetText().Trim();
                // instantiate a writer object
                var barcodeWriter = new BarcodeWriter();
                var options = new QrCodeEncodingOptions
                {
                    DisableECI = true,
                    CharacterSet = "UTF-8",
                    Width = 250,
                    Height = 250,
                };
                // set the barcode format
                barcodeWriter.Format = BarcodeFormat.QR_CODE;
                barcodeWriter.Options = options;
                // write text and generate a 2-D barcode as a bitmap

                // Path.GetRandomFileName()
                // Regex.Match(v,"(?<=/)[a-zA-Z\\.\\-0-9]+(?!:)").Value
                barcodeWriter
                    .Write(v)
                    .Save(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), Path.GetRandomFileName() + ".png"), System.Drawing.Imaging.ImageFormat.Png);
            }
            catch (
            Exception exception)
            {

                MessageBox.Show(exception.Message);
            }
        }
    }
}
