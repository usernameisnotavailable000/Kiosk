using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        int sum = 0;
        int page = 0;

        

        public Form1()
        {
            InitializeComponent();

            this.Burger.Click += BtnBurger;
            this.SideMenu.Click += BtnSide;
            this.Drink.Click += BtnDrink;
            this.Dessert.Click += BtnDessert;

            this.btn1.Click += ClickButton1;
            this.btn2.Click += ClickButton2;
            this.btn3.Click += ClickButton3;
            this.btn4.Click += ClickButton4;
            this.btn5.Click += ClickButton5;
            this.btn6.Click += ClickButton6;
            this.btn7.Click += ClickButton7;
            this.btn8.Click += ClickButton8;
            this.btn9.Click += ClickButton9;

            this.buy.Click += BuyMenu;
            this.buyCancel.Click += CancelMenu;
        }

        private void BtnBurger(object sender, EventArgs e)
        {
            page = 1;

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = true;
            btn7.Visible = true;
            btn8.Visible = true;
            btn9.Visible = false;

            R1_1.Visible = true;
            R1_2.Visible = true;
            R2_1.Visible = true;
            R2_2.Visible = true;
            R3_1.Visible = true;
            R3_2.Visible = true;
            R4_1.Visible = true;
            R4_2.Visible = true;
            R5_1.Visible = true;
            R5_2.Visible = true;
            R6_1.Visible = true;
            R6_2.Visible = true;
            R7_1.Visible = true;
            R7_2.Visible = true;
            R8_1.Visible = true;
            R8_2.Visible = true;
            R9_1.Visible = false;
            R9_2.Visible = false;

            btn1.Text = "햄버거";
            btn2.Text = "치즈버거";
            btn3.Text = "불고기버거";
            btn4.Text = "치킨버거";
            btn5.Text = "새우버거";
            btn6.Text = "빅버거";
            btn7.Text = "빅불";
            btn8.Text = "빅치킨";

            R1_1.Text = "단품";
            R1_2.Text = "세트";
            R2_1.Text = "단품";
            R2_2.Text = "세트";
            R3_1.Text = "단품";
            R3_2.Text = "세트";
            R4_1.Text = "단품";
            R4_2.Text = "세트";
            R5_1.Text = "단품";
            R5_2.Text = "세트";
            R6_1.Text = "단품";
            R6_2.Text = "세트";
            R7_1.Text = "단품";
            R7_2.Text = "세트";
            R8_1.Text = "단품";
            R8_2.Text = "세트";

            R1_1.Checked = false;
            R1_2.Checked = false;
            R2_1.Checked = false;
            R2_2.Checked = false;
            R3_1.Checked = false;
            R3_2.Checked = false;
            R4_1.Checked = false;
            R4_2.Checked = false;
            R5_1.Checked = false;
            R5_2.Checked = false;
            R6_1.Checked = false;
            R6_2.Checked = false;
            R7_1.Checked = false;
            R7_2.Checked = false;
            R8_1.Checked = false;
            R8_2.Checked = false;
            R9_1.Checked = false;
            R9_2.Checked = false;
        }

        private void BtnSide(object sender, EventArgs e)
        {
            page = 2;

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;

            R1_1.Visible = true;
            R1_2.Visible = true;
            R2_1.Visible = true;
            R2_2.Visible = true;
            R3_1.Visible = true;
            R3_2.Visible = true;
            R4_1.Visible = true;
            R4_2.Visible = true;
            R5_1.Visible = false;
            R5_2.Visible = false;
            R6_1.Visible = false;
            R6_2.Visible = false;
            R7_1.Visible = false;
            R7_2.Visible = false;
            R8_1.Visible = false;
            R8_2.Visible = false;
            R9_1.Visible = false;
            R9_2.Visible = false;

            btn1.Text = "감자튀김";
            btn2.Text = "치킨너겟";
            btn3.Text = "치즈스틱";
            btn4.Text = "치즈볼";

            R1_1.Text = "M";
            R1_2.Text = "L";
            R2_1.Text = "3p";
            R2_2.Text = "6p";
            R3_1.Text = "2p";
            R3_2.Text = "4p";
            R4_1.Text = "3p";
            R4_2.Text = "6p";

            R1_1.Checked = false;
            R1_2.Checked = false;
            R2_1.Checked = false;
            R2_2.Checked = false;
            R3_1.Checked = false;
            R3_2.Checked = false;
            R4_1.Checked = false;
            R4_2.Checked = false;
            R5_1.Checked = false;
            R5_2.Checked = false;
            R6_1.Checked = false;
            R6_2.Checked = false;
            R7_1.Checked = false;
            R7_2.Checked = false;
            R8_1.Checked = false;
            R8_2.Checked = false;
            R9_1.Checked = false;
            R9_2.Checked = false;
        }

        private void BtnDrink(object sender, EventArgs e)
        {
            page = 3;

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = true;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;

            R1_1.Visible = true;
            R1_2.Visible = true;
            R2_1.Visible = true;
            R2_2.Visible = true;
            R3_1.Visible = true;
            R3_2.Visible = true;
            R4_1.Visible = true;
            R4_2.Visible = true;
            R5_1.Visible = true;
            R5_2.Visible = true;
            R6_1.Visible = false;
            R6_2.Visible = false;
            R7_1.Visible = false;
            R7_2.Visible = false;
            R8_1.Visible = false;
            R8_2.Visible = false;
            R9_1.Visible = false;
            R9_2.Visible = false;

            btn1.Text = "콜라";
            btn2.Text = "사이다";
            btn3.Text = "환타";
            btn4.Text = "아메리카노";
            btn5.Text = "레모네이드";

            R1_1.Text = "M";
            R1_2.Text = "L";
            R2_1.Text = "M";
            R2_2.Text = "L";
            R3_1.Text = "M";
            R3_2.Text = "L";
            R4_1.Text = "M";
            R4_2.Text = "L";
            R5_1.Text = "M";
            R5_2.Text = "L";

            R1_1.Checked = false;
            R1_2.Checked = false;
            R2_1.Checked = false;
            R2_2.Checked = false;
            R3_1.Checked = false;
            R3_2.Checked = false;
            R4_1.Checked = false;
            R4_2.Checked = false;
            R5_1.Checked = false;
            R5_2.Checked = false;
            R6_1.Checked = false;
            R6_2.Checked = false;
            R7_1.Checked = false;
            R7_2.Checked = false;
            R8_1.Checked = false;
            R8_2.Checked = false;
            R9_1.Checked = false;
            R9_2.Checked = false;
        }

        private void BtnDessert(object sender, EventArgs e)
        {
            page = 4;

            btn1.Visible = true;
            btn2.Visible = true;
            btn3.Visible = true;
            btn4.Visible = true;
            btn5.Visible = false;
            btn6.Visible = false;
            btn7.Visible = false;
            btn8.Visible = false;
            btn9.Visible = false;

            R1_1.Visible = false;
            R1_2.Visible = false;
            R2_1.Visible = false;
            R2_2.Visible = false;
            R3_1.Visible = false;
            R3_2.Visible = false;
            R4_1.Visible = false;
            R4_2.Visible = false;
            R5_1.Visible = false;
            R5_2.Visible = false;
            R6_1.Visible = false;
            R6_2.Visible = false;
            R7_1.Visible = false;
            R7_2.Visible = false;
            R8_1.Visible = false;
            R8_2.Visible = false;
            R9_1.Visible = false;
            R9_2.Visible = false;

            btn1.Text = "바닐라콘";
            btn2.Text = "초콜렛콘";
            btn3.Text = "오렌지슬러시";
            btn4.Text = "레몬슬러시";
        }

        private void ClickButton1(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R1_1.Checked == false && R1_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R1_1.Checked == true)
                {
                    string[] row = { "햄버거", "3500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 3500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R1_2.Checked == true)
                {
                    string[] row = { "햄버거(세트)", "6000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 6000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {
                if (R1_1.Checked == false && R1_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R1_1.Checked == true)
                {
                    string[] row = { "감자튀김 M", "2500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R1_2.Checked == true)
                {
                    string[] row = { "감자튀김 L", "3000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 3000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 3)
            {
                if (R1_1.Checked == false && R1_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R1_1.Checked == true)
                {
                    string[] row = { "콜라 M", "2000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R1_2.Checked == true)
                {
                    string[] row = { "콜라 L", "2500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 4)
            {
                string[] row = { "바닐라콘", "1000" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                sum += 1000;
                buy.Enabled = true;
                buyCancel.Enabled = true;
            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton2(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R2_1.Checked == false && R2_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R2_1.Checked == true)
                {
                    string[] row = { "치즈버거", "4000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 4000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R2_2.Checked == true)
                {
                    string[] row = { "치즈버거(세트)", "6500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 6500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {
                if (R2_1.Checked == false && R2_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R2_1.Checked == true)
                {
                    string[] row = { "치킨너겟 3p", "2000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R2_2.Checked == true)
                {
                    string[] row = { "치킨너겟 6p", "4000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 4000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 3)
            {
                if (R2_1.Checked == false && R2_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R2_1.Checked == true)
                {
                    string[] row = { "사이다 M", "2000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R2_2.Checked == true)
                {
                    string[] row = { "사이다 L", "2500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 4)
            {
                string[] row = { "초콜렛콘", "1000" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                sum += 1000;
                buy.Enabled = true;
                buyCancel.Enabled = true;
            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton3(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R3_1.Checked == false && R3_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R3_1.Checked == true)
                {
                    string[] row = { "불고기버거", "4500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 4500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R3_2.Checked == true)
                {
                    string[] row = { "치즈버거(세트)", "7000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 7000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {
                if (R3_1.Checked == false && R3_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R3_1.Checked == true)
                {
                    string[] row = { "치즈스틱 2p", "2000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R3_2.Checked == true)
                {
                    string[] row = { "치즈스틱 4p", "4000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 4000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 3)
            {
                if (R3_1.Checked == false && R3_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R3_1.Checked == true)
                {
                    string[] row = { "환타 M", "2000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R3_2.Checked == true)
                {
                    string[] row = { "환타 L", "2500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 4)
            {
                string[] row = { "오렌지슬러시", "2000" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                sum += 2000;
                buy.Enabled = true;
                buyCancel.Enabled = true;
            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton4(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R4_1.Checked == false && R4_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R4_1.Checked == true)
                {
                    string[] row = { "치킨버거", "4500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 4500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R4_2.Checked == true)
                {
                    string[] row = { "치킨버거(세트)", "7000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 7000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {
                if (R4_1.Checked == false && R4_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R4_1.Checked == true)
                {
                    string[] row = { "치즈볼 3p", "2000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R4_2.Checked == true)
                {
                    string[] row = { "치즈볼 6p", "4000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 4000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 3)
            {
                if (R4_1.Checked == false && R4_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R4_1.Checked == true)
                {
                    string[] row = { "아메리카노 M", "2500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 2500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R4_2.Checked == true)
                {
                    string[] row = { "아메리카노 L", "3000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 3000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 4)
            {
                string[] row = { "레몬슬러시", "2000" };
                var listViewItem = new ListViewItem(row);
                listView1.Items.Add(listViewItem);
                sum += 2000;
                buy.Enabled = true;
                buyCancel.Enabled = true;
            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton5(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R5_1.Checked == false && R5_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R5_1.Checked == true)
                {
                    string[] row = { "새우버거", "5000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 5000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R5_2.Checked == true)
                {
                    string[] row = { "새우버거(세트)", "7500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 7500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {

            }
            else if (page == 3)
            {
                if (R5_1.Checked == false && R5_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R5_1.Checked == true)
                {
                    string[] row = { "레모네이드 M", "3000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 3000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R5_2.Checked == true)
                {
                    string[] row = { "레모네이드 L", "3500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 3500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 4)
            {

            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton6(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R6_1.Checked == false && R6_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R6_1.Checked == true)
                {
                    string[] row = { "빅버거", "7000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 7000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R6_2.Checked == true)
                {
                    string[] row = { "빅버거(세트)", "9500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 9500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {

            }
            else if (page == 3)
            {
                
            }
            else if (page == 4)
            {

            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton7(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R7_1.Checked == false && R7_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R7_1.Checked == true)
                {
                    string[] row = { "빅불", "8500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 8500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R7_2.Checked == true)
                {
                    string[] row = { "빅불(세트)", "11000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 11000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {

            }
            else if (page == 3)
            {

            }
            else if (page == 4)
            {

            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton8(object sender, EventArgs e)
        {
            if (page == 1)
            {
                if (R8_1.Checked == false && R8_2.Checked == false)
                {
                    MessageBox.Show("제품의 사이즈를 결정해 주세요.");
                }
                else if (R8_1.Checked == true)
                {
                    string[] row = { "빅치킨", "8500" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 8500;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
                else if (R8_2.Checked == true)
                {
                    string[] row = { "빅치킨(세트)", "11000" };
                    var listViewItem = new ListViewItem(row);
                    listView1.Items.Add(listViewItem);
                    sum += 11000;
                    buy.Enabled = true;
                    buyCancel.Enabled = true;
                }
            }
            else if (page == 2)
            {

            }
            else if (page == 3)
            {

            }
            else if (page == 4)
            {

            }

            txtSum.Text = sum + " 원";
        }

        private void ClickButton9(object sender, EventArgs e)
        {
            if (page == 1)
            {
                
            }
            else if (page == 2)
            {

            }
            else if (page == 3)
            {

            }
            else if (page == 4)
            {

            }

            txtSum.Text = sum + " 원";
        }

        private void BuyMenu(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("결제하시겠습니까?", "결제하기", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("결제가 완료되었습니다.", "결제하기");
                listView1.Items.Clear();
                sum = 0;
                buy.Enabled = false;
                buyCancel.Enabled = false;
                txtSum.Text = sum + " 원";
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
        }

        private void CancelMenu(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("결제를 취소하시겠습니까?", "결제취소", MessageBoxButtons.OKCancel);

            if (dialogResult == DialogResult.OK)
            {
                MessageBox.Show("결제가 취소되었습니다.", "결제취소");
                listView1.Items.Clear();
                sum = 0;
                buy.Enabled = false;
                buyCancel.Enabled = false;
                txtSum.Text = sum + " 원";
            }
            else if (dialogResult == DialogResult.Cancel)
            {

            }
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_ColumnReordered(object sender, ColumnReorderedEventArgs e)
        {
            
        }
    }
}
