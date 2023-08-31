using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace DelegatorOperatorPrac32
{
    public partial class Form1 : Form
    {
        public delegate void SendString(string message);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Button button = new Button();
            button.Text = "나만의 델리게이터 버튼";
            button.Click += button_click1;
            button.Click += (s, e2) => MessageBox.Show("잘가!");

            Controls.Add(button);

            SendString sayHello, sayGoodbye, multiDelegate;
            sayHello = Hello;
            sayGoodbye = Goodbye;

            multiDelegate = sayHello + sayGoodbye;
            multiDelegate("아이유");

            multiDelegate -= sayGoodbye;
            multiDelegate("아이유");

        }

        private void Goodbye(string message)
        {
            Console.WriteLine("안녕히가세요, " + message + "양~");
        }

        private void Hello(string message)
        {
            Console.WriteLine("안녕하세요, " + message + "양!");
        }

        private void button_click1(object sender, EventArgs e)
        {
            MessageBox.Show("안녕!");
        }
    }
}