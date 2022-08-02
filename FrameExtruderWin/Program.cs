﻿using System;
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
                    throw new ArgumentException("Non-integer number of frame rows, double check margin, spacing, frame dimensions and sheet dimensions.");
                }
                int frameColCount = (shin.Width - 2 * margin + spacing) / (width + spacing);
                int frameRowCount = (shin.Height - 2 * margin + spacing) / (height + spacing);
                float frameOpPercentage = sheetOpPercentage / (frameColCount * frameRowCount); // percentage of operation completed once a single frame is extruded

                int extWidth = 2 * margin + (frameColCount - 1) * spacing + frameColCount * (width + 2); // extruded sheet width
                int extHeight = 2 * margin + (frameRowCount - 1) * spacing + frameRowCount * (height + 2); // extruded sheet height
                Bitmap shou = new Bitmap(extWidth, extHeight); // sheet output
                Graphics extrudedSheet = Graphics.FromImage(shou);
                extrudedSheet.FillRectangle(new SolidBrush(background), 0, 0, extWidth, extHeight);
                for (int row = 0; row < frameRowCount; row++) {
                    for (int col = 0; col < frameColCount; col++) {
                        int srcX = margin + col * (width + spacing); // x of tile top lef