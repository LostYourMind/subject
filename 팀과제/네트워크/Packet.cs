using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 팀과제.네트워크
{
    internal class Packet
    {
        const string PACK_MEMBERJOIN = "memberjoin";
        const string PACK_LOGIN = "login";
        const string PACK_BURGER = "burger";
        const string PACK_ALLDATA = "alldata";

        public static string AllData()
        {
            string packet = string.Empty;

            packet += PACK_ALLDATA;

            return packet;
        }


        public static string MemberJoin(string id, string pw, string name)
        {
            string packet = string.Empty;

            packet += PACK_MEMBERJOIN + "\a";
            packet += id + "#";
            packet += pw + "#";
            packet += name;

            return packet;
        }

        public static string Login(string id, string pw)
        {
            string packet = string.Empty;

            packet += PACK_LOGIN + "\a";
            packet += id + "#";
            packet += pw + "";

            return packet;
        }

        public static string Burger(string name, int price)
        {
            string packet = string.Empty;

            packet += PACK_BURGER + "\a";
            packet += name + "#";
            packet += price ;

            return packet;
        }
    }
}
