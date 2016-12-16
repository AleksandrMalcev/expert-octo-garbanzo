using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {

        
        private static System.Timers.Timer timer;

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



        private void startButton_Click(object sender, EventArgs e)
        {
            setTimerUp();
        }

        private void setTimerUp()
        {
            int time = 0;
            try
            {
                time = Convert.ToInt32(timeTextBox.Text) * 1000;
            }
            catch (Exception)
            {
            }

            if(time <= 0)
            {
                timeTextBox.Text = Convert.ToString(10);
                time = 10 * 1000;
                // 10 seconds by default
            }

            timer = new System.Timers.Timer(time);
            timer.Elapsed += timerEvent;
            timer.Enabled = true;
        }

        private void timerEvent(Object source, ElapsedEventArgs e)
        {
            changeText("qqq");
        }

        private void textViewTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void onKeyPressed(object sender, KeyPressEventArgs e)
        {
            if (!getText().StartsWith("" + e.KeyChar))
            {
                incrementMistakesCount();
            }else
            {
                string textBoxText = getText();
                textBoxText = textBoxText.Substring(1);
                changeText(textBoxText);
            }
        }
    }
}
