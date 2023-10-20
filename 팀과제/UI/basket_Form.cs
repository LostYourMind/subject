using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using 팀과제.컨트롤;

namespace 팀과제.UI
{
    public partial class Dlg_basket : MetroFramework.Forms.MetroForm
    {

        private 컨트롤.Control _control = 컨트롤.Control.Instance;
        public Dlg_basket()
        {
            InitializeComponent();
        }

        private void basket_Form_Load(object sender, EventArgs e)
        {
            List<Basket> baskets = _control.GetBaskets();

            // 받아온 데이터를 사용
            foreach (Basket basket in baskets)
            {
                
                label1.Text += basket.Name + basket.Price + basket.Counter;
                // 이제 'item'에는 'ListViewItem' 객체가 할당되며, 이름은 'item0', 'item1', 'item2', ... 와 같이 바뀝니다.
                // 버거 데이터를 활용
            }
        }
    }
}
