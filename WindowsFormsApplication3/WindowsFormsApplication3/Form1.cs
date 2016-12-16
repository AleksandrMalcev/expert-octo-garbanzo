using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        private static bool started = false;
        private static System.Timers.Timer timer;
        int timeLeft = 0;

        public Form1()
        {
            InitializeComponent();
            this.KeyPress += new KeyPressEventHandler(onKeyPressed);
        }

        delegate void changeTextDelegate(string s);
        delegate string getTextDelegate();

        private void changeText(string s)
        {
            textViewTextBox.Invoke(new changeTextDelegate(str => textViewTextBox.Text = str), s);
        }
        private string getText()
        {
            return Convert.ToString(textViewTextBox.Invoke(new getTextDelegate(() => textViewTextBox.Text)));
        }


        delegate void incrementMistakesCountDelegate();

        private void incrementMistakesCount() 
        {
            mistakesCountLabel.Invoke(new incrementMistakesCountDelegate(
                () => {
                    int mistakesCount = Convert.ToInt32(mistakesCountLabel.Text);
                    mistakesCount++;
                    mistakesCountLabel.Text = Convert.ToString(mistakesCount);
                }               
                ));
        }

        delegate void setTimeLeftLabelVisibleDelegate(bool visible);
        private void setTimeLeftLabelVisible(bool visible)
        {
            timeLeftLabel.Invoke(new setTimeLeftLabelVisibleDelegate((v) => timeLeftLabel.Visible = v), visible);
        }

        delegate void setTimeLabelContentDelegate(int content);
        private void setTimeLabelContent(int content)
        {
            timeLabel.Invoke(new setTimeLabelContentDelegate((c) => timeLabel.Text = Convert.ToString(c)), content);
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            setTimeLeftLabelVisible(false);

            started = true;
            setTimerUp();
            loadText();
        }

        private void setTimerUp()
        {
            timeLeft = 0;
            try
            {
                timeLeft = Convert.ToInt32(timeTextBox.Text);
            }
            catch (Exception)
            {
            }

            if(timeLeft <= 0)
            {
                timeTextBox.Text = Convert.ToString(10);
                timeLeft = 10 * 1000;
                // 10 seconds by default
            }

            timer = new System.Timers.Timer();
            timer.Elapsed += timerEvent;
            timer.AutoReset = true;
            timer.Interval = 1000;
            timer.Enabled = true;
        }

        private void timerEvent(Object source, ElapsedEventArgs e)
        {
            timeLeft--;
            setTimeLabelContent(timeLeft);

            if (timeLeft <= 0)
            {
                started = false;
                setTimeLeftLabelVisible(true);
                timer.Enabled = false;
                timer.Stop();
            }
            //changeText("qqq");
        }

        private void textViewTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void onKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (startButton.Focused)
            {
                mistakesCountLabel.Focus();
            }
            if (!started)
            {
                return;
            }

            if (!getText().StartsWith("" + e.KeyChar))
            {
                incrementMistakesCount();
            }
            else
            {
                string textBoxText = getText();
                textBoxText = textBoxText.Substring(1);
                changeText(textBoxText);
            }

            if (getText().Length == 0)
            {
                started = false;
                timer.Stop();
            }
        }

        void loadText()
        {
            using(StreamReader sr = new StreamReader("resourses/text.txt", Encoding.UTF8))
            {
                changeText("Ы");
                string text = sr.ReadToEnd();
                
                text = text.Substring(text.IndexOf(' ', new Random().Next()%600)+1);
                changeText(text);
            }
        }
    }
}
