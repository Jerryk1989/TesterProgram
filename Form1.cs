using Gma.System.MouseKeyHook;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        StepRecording recording = new StepRecording();
        List<string> lines = new List<string> { "import pyautogui", "import time", "\n"};
        private IKeyboardMouseEvents m_GlobalHook;

        public Form1()
        {
            InitializeComponent();
            stopRecording.Enabled = false;
        }


        #region mouse hooks
        public void Subscribe()
        {
            m_GlobalHook = Hook.GlobalEvents();

            m_GlobalHook.MouseDownExt += GlobalHookMouseDownExt;
            m_GlobalHook.KeyPress += GlobalHookKeyPress;
        }

        private void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            if(LoopCheckBox.Checked == true)
            {
                lines.Add("    pyautogui.typewrite('" + e.KeyChar + "')");
            } else
            {
                lines.Add("pyautogui.typewrite('" + e.KeyChar + "')");
            }
        }

        private void GlobalHookMouseDownExt(object sender, MouseEventExtArgs e)
        {
            if(LoopCheckBox.Checked == true)
            {
                lines.Add("    pyautogui.moveTo(" + e.X.ToString() + ", " + e.Y.ToString() + ", 1)");
                lines.Add("    pyautogui.click()");
            } else
            {
                lines.Add("pyautogui.moveTo(" + e.X.ToString() + ", " + e.Y.ToString() + ", 1)");
                lines.Add("pyautogui.click()");
            }
            

        }

        public void Unsubscribe()
        {
            m_GlobalHook.MouseDownExt -= GlobalHookMouseDownExt;
            m_GlobalHook.KeyPress -= GlobalHookKeyPress;

            m_GlobalHook.Dispose();
        }
        #endregion

        private void StartRecordingButton_Click(object sender, EventArgs e)
        {
            DisableButtons();
            Subscribe();
        }

        private void DisableButtons()
        {
            LoopCheckBox.Enabled = false;
            StartRecordingButton.Enabled = false;


            stopRecording.Enabled = true;

        }

        private void RenableButtons()
        {
            LoopCheckBox.Enabled = true;
            StartRecordingButton.Enabled = true;

            stopRecording.Enabled = false;
        }

        private void testWritingButton_Click(object sender, EventArgs e)
        {
            lines.Add(testWritingBox.Text);
            foreach(String line in lines)
            {
                Console.WriteLine(line);
            }
        }

        private void stopRecording_Click(object sender, EventArgs e)
        {
            Unsubscribe();
            RenableButtons();
            Console.WriteLine(lines.Count - 1);

            //removes the last move an click to the stop recording button.
            lines.RemoveAt(lines.Count - 1);
            lines.RemoveAt(lines.Count - 1);
            foreach (String line in lines)
            {
                Console.WriteLine(line);
            }

            using(StreamWriter stream = new StreamWriter("test.py"))
            {
                foreach(String line in lines)
                {
                    stream.WriteLine(line);
                }
            }

        }

        private void LoopCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(LoopCheckBox.Checked == true)
            {
                lines.Add("def testLoop():");
            } else
            {
                
            }
        }
    }
}
