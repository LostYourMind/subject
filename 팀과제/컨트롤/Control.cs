using _1018_Wb_Client;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using 팀과제.UI;
using 팀과제.네트워크;
using 팀과제.데이터;

namespace 팀과제.컨트롤
{
    internal class Control
    {
        #region 레퍼런스 선언

        private Client client = null;


        private List<Burger> burgers = new List<Burger>(); //버거 List
        private List<Drink> drinks = new List<Drink>();    //음료 List
        private List<Side> sides = new List<Side>();       //사이드 List


        private List<Basket> baskets = new List<Basket>(); // 장바구니 List

        //const string SERVER_IP = "220.90.179.75"; // 220.90.179.75 // 10.101.198.4
        const string SERVER_IP = "127.0.0.1"; //LocalHost
        const int SERVER_PORT = 8000;

        #endregion

        #region 싱글톤(생성자에서 파일로드)
        public static Control Instance { get; private set; } = null;
        static Control()
        {
            Instance = new Control();
        }
        private Control()
        {
            client = new Client(SERVER_IP, SERVER_PORT, RecvDel, LogDel);
        }

        #endregion

        #region 시작과 끝 (네트워크 연결, 종료)
        public bool Load()
        {
            bool ret = client.Start();

            return ret;
        }
        public void Close()
        {
            client.Stop();
        }

        #endregion

        #region Callback
        public void RecvDel(Socket s, string msg)
        {
            string[] sp = msg.Split('\a');
            if (sp[0] == "memberjoin")
                MemberJoin_Ack(sp[1]);
            else if (sp[0] == "login")
                Login_Ack(sp[1]);
            else if (sp[0] == "Burger")
                Burger(sp[1]);
            else if (sp[0] == "Drink")
                Drink(sp[1]);
            else if (sp[0] == "Side")
                Side(sp[1]);

        }

        public void LogDel(Socket s, Log log, string msg)
        {
            //  string temp = string.Format(log.ToString() + "\t" + msg);
            //  Console.WriteLine(temp);
        }
        #endregion

        #region 기능 메서드
        public void MemberJoin(string id, string pw, string name)
        {
            string packet = Packet.MemberJoin(id, pw, name);
            client.SendData(packet);
        }//회원 가입

        public void MemberJoin_Ack(string msg)
        {
            string[] sp = msg.Split('#');

            if (bool.Parse(sp[0]) == true)
                MessageBox.Show("회원가입 성공");

            else
                MessageBox.Show("회원가입 실패");
        }//회원 가입 ACK

        public void Login(string id, string pw)
        {
            string packet = Packet.Login(id, pw);
            client.SendData(packet);
        }//로그인

        public void Login_Ack(string msg)
        {
            string[] sp = msg.Split('#');

            if (bool.Parse(sp[0]) == true)// true == Form_Run을 모달로 실행
            {
                MessageBox.Show("로그인 성공");

                Menu_Form dlg = new Menu_Form();
                dlg.ShowDialog();
            }

            else
            {
                MessageBox.Show("로그인 실패");
            }
        }
        public void alldata()
        {
            string packet = Packet.AllData();
            client.SendData(packet);
        }//로그인


        #region 햄버거
        public void Burger(string msg)
        {
            string[] sp = msg.Split('#');
            string name = sp[0];
            int price = int.Parse(sp[1]);
            burgers.Add(new Burger(name, price));
        }//버거 패킷 처리



        public List<Burger> GetBurgers()
        {
            return burgers;
        }

        /* 디버깅 코드
public void show()
{
    for (int i = 0; i < burgers.Count; i++)
    {
        MessageBox.Show(burgers[i].Name + burgers[i].Price);
    }
}*/

        #endregion//버거




        #region 음료수

        public List<Drink> GetDrinks()
        {
            return drinks;
        }

        public void Drink(string msg)
        {
            string[] sp = msg.Split('#');
            string name = sp[0];
            int price = int.Parse(sp[1]);
            drinks.Add(new Drink(name, price));
        }//음료 패킷 리턴 처리

        #endregion




        #region 사이드 메뉴
        public List<Side> GetSide()
        {
            return sides;
        }

        public void Side(string msg)
        {
            string[] sp = msg.Split('#');
            string name = sp[0];
            int price = int.Parse(sp[1]);
            sides.Add(new Side(name, price));
        }//사이드 패킷 리턴 처리

        #endregion




        #region 장바구니
        public List<Basket> GetBaskets()
        {
            return baskets;
        }

        public void basketinsert(string name, int price)
        {
            baskets.Add(new Basket(name, price));
        } // 버거를 장바구니에 추가하는 코드

        #endregion


        #endregion//전체
    }
}
