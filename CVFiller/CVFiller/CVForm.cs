using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CVFiller
{
    public partial class CVForm : Form
    {

        private LowLevelKeyboardListener _listener;

        public CVForm()
        {
            InitializeComponent();
            _listener = new LowLevelKeyboardListener();
            _listener.OnKeyPressed += _listener_OnKeyPressed;
            _listener.HookKeyboard();
        }

        void _listener_OnKeyPressed(object sender, KeyPressedArgs e)
        {
            this.textBox.Text += e.KeyPressed.ToString();
        }
        
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            _listener.UnHookKeyboard();
        }
    }
}
