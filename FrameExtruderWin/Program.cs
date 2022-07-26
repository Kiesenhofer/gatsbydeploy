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
            float sheetOpPercentage = 100f / sheets.Length; // percentage of operation that completed once this sheet is extruded
            for (var i = 0; i < sheets.Length; i++) {
                Bitmap shin = sheets[i]; // sheet input
                if ((shin.Width - 2 * margin + spacing) % (width + spacing) != 0) {
                    shin.Dispose();
                    throw new ArgumentException("Non-integer number of frame columns, double check margin, spacing, frame dimensions and sheet dimensions.");
                }
                if ((shin.Height - 2 * margin + spacing) % (height + spacing) != 0) {
                    shin.Dispose();
                    throw new ArgumentException("Non-integer number of frame rows, double check margin, spacing, frame dimensions and sheet dimension