using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using 팀과제.컨트롤;
using Control = 팀과제.컨트롤.Control;
using System.Xml.Linq;
using 팀과제.네트워크;
using _1018_Wb_Client;
using 팀과제.데이터;
using System.Security.Policy;

/*
 
 *********** 장바구니는 모달리스로!!!!**************
 ************ 지금은 모달 사용 중 **************
 
 */



namespace 팀과제.UI
{
    public partial class Menu_Form : MetroFramework.Forms.MetroForm
    {

        private Control _control = Control.Instance;

        private Dlg_basket dlg_basket = null; // -> basket 모달리스

        #region 나가봐

        public Menu_Form()
        {
            InitializeComponent();

        }

        private void basket_Click(object sender, EventArgs e)
        {
            if (dlg_basket == null || dlg_basket.IsDisposed)
            {
                dlg_basket = new Dlg_basket();
                dlg_basket.Owner = this;
                dlg_basket.Show();
            }

            else
            {
                dlg_basket.Focus();
            }
            return;
        }


        private void label1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("햄버거만 보여주세요잉~ ");
            Menu_list.Show();
            drink_view.Hide();
            Side_view.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("음료만 보여주세요잉~");
            drink_view.Show();
            Menu_list.Hide();
            Side_view.Hide();

        }

        private void label5_Click(object sender, EventArgs e)
        {
            drink_view.Hide();
            Menu_list.Hide();
            Side_view.Show();

        }

        private void Menu_Form_Load(object sender, EventArgs e)
        {




            List<Burger> burgers = _control.GetBurgers();

            for (int i = 0; i < burgers.Count; i++)
            {
                ListViewItem item = new ListViewItem(burgers[i].Name, i);
                item.SubItems.Add(Convert.ToString(burgers[i].Price));
                Menu_list.Items.Add(item);
            }

            #endregion

            #region 음료


            List<Drink> drinks = _control.GetDrinks();
            for (int i = 0; i < drinks.Count; i++)
            {
                ListViewItem item1 = new ListViewItem(drinks[i].Name, i);
                item1.SubItems.Add(Convert.ToString(drinks[i].Price));
                drink_view.Items.Add(item1);
            }
            #endregion


            #region 사이드


            List<Side> sides = _control.GetSide();
            for (int i = 0; i < sides.Count; i++)
            {
                ListViewItem item = new ListViewItem(sides[i].Name, i);
                item.SubItems.Add(Convert.ToString(sides[i].Price));
                Side_view.Items.Add(item);
            }



            #endregion
        }
        private void Menu_list_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection test = Menu_list.SelectedItems;

            foreach (ListViewItem item in test)
            {
                for (int i = 0; i < item.SubItems.Count - 1; i++)
                {
                    //label3.Text = "가격 : " + item.SubItems[i].Text + "원 \t";
                    string name = item.SubItems[i].Text;
                    int price = int.Parse(item.SubItems[i + 1].Text);
                    _control.basketinsert(name, price);
                    label3.Text = name + price;

                    //label3.Text = item.SubItems[i].ToString();
                }
            }
        }

        private void drink_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection test = drink_view.SelectedItems;

            foreach (ListViewItem item in test)
            {
                for (int i = 0; i < item.SubItems.Count - 1; i++)
                {
                    //label3.Text = "가격 : " + item.SubItems[i].Text + "원 \t";
                    string name = item.SubItems[i].Text;
                    int price = int.Parse(item.SubItems[i + 1].Text);
                    _control.basketinsert(name, price);
                    label3.Text = name + price;
                }
            }
        }

        private void Side_view_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Windows.Forms.ListView.SelectedListViewItemCollection test = Side_view.SelectedItems;

            foreach (ListViewItem item in test)
            {
                for (int i = 0; i < item.SubItems.Count - 1; i++)
                {
                    //label3.Text = "가격 : " + item.SubItems[i].Text + "원 \t";
                    string name = item.SubItems[i].Text;
                    int price = int.Parse(item.SubItems[i + 1].Text);
                    _control.basketinsert(name, price);
                    label3.Text = name + price;

                    //label3.Text = item.SubItems[i].ToString();
                }
            }
        }


    }
}
