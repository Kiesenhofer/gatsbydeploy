using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace FrameExtruderWin {
    static class Program {

        [STAThread]
        static void Main(string[] args) {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        public static bool ExtrudeSheets(Bitmap[] sheets, string[] dests, int width, int height, int margin, int spacing, Color background, bool saveUnextrudedCopies, BackgroundWorker worker) {
            float progress = 0; // progress percentage;
 