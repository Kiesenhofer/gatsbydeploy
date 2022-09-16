using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FrameExtruderWin {
    public partial class ProgressForm : Form {
        public delegate bool DoWorkCallback(BackgroundWorker work);

        public ProgressForm(string title, DoWorkCallback 