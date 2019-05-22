using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SuperSocket.ClientEngine;
using WebSocket4Net;
using System.Windows.Forms;
using DevExpress.Entity.Model;

namespace PegasusMetal_Pro
{
   public class WebSocketService : ISocketService
    {
        const string LOG_TYPE = "WebSocket";
        WebSocket websocket;
        public bool isLogin = false;
        static WebSocketService service;
        private WebSocketService()
        {
            websocket = new WebSocket("ws://" + Constants.IP_ADDRESS + ":" + Constants.PORT.ToString() + "/");
            websocket.Opened += new EventHandler(websocket_Opened);
            websocket.Error += new EventHandler<ErrorEventArgs>(websocket_Error);
            websocket.Closed += new EventHandler(websocket_Closed);
            websocket.MessageReceived += new EventHandler<MessageReceivedEventArgs>(websocket_MessageReceived);
            websocket.Open();
        }

        public static WebSocketService getInstance()
        {
            if (service == null)
            {
                service = new WebSocketService();
            }
            return service;
        }

        private T GetForm<T>() where T : Form
        {
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                if (Application.OpenForms[i] is T)
                {
                    return (T)Application.OpenForms[i];
                }
            }
            return null;
        }

        public void Send(List<string> packetData)
        {
            string message = "";
            for (int i = 0; i < packetData.Count; i++)
            {
                if (i == packetData.Count - 1)
                {
                    message = message + packetData[i];
                    break;
                }
                message = message + packetData[i] + Constants.SPLITTER;
            }
            websocket.Send(message);
            Utilities.WriteLog(LOG_TYPE, message + " sent to server.", ConsoleColor.Yellow);
        }

        private void websocket_MessageReceived(object sender, MessageReceivedEventArgs e)
        {
            Utilities.WriteLog(LOG_TYPE, e.Message + " received from server.", ConsoleColor.Gray);
            string[] packets = e.Message.Split(new string[] { Constants.SPLITTER }, StringSplitOptions.None);
            string opCode = packets[0];
            string body = packets[1];
            switch (opCode)
            {
                case OPCodes.LOGIN_SUCCESS:
                    Info.GetInstance().staff = JsonConvert.DeserializeObject<Staff>(body);
                    GetForm<frmLogin>().LoginSuccess(Info.GetInstance().staff.Name, Info.GetInstance().staff.Surname);
                    break;
                case OPCodes.LOGIN_FAIL:
                    Reason temp = JsonConvert.DeserializeObject<Reason>(body);
                    GetForm<frmLogin>().LoginFail(temp.Explanation);
                    break;
                case OPCodes.STAFF:
                    var staff = JsonConvert.DeserializeObject<Staff>(body);
                    Lists.staffs.Add(staff);
                    break;
                case OPCodes.ROLES:
                    var role = JsonConvert.DeserializeObject<Roles>(body);
                    Lists.roles.Add(role);
                    break;
                case OPCodes.USER_ROLE:
                    var userRole = JsonConvert.DeserializeObject<UserRole>(body);
                    Lists.userRoles.Add(userRole);
                    break;
                case OPCodes.USER:
                    var user = JsonConvert.DeserializeObject<User>(body);
                    Lists.users.Add(user);
                    break;
                case OPCodes.COMPANY:
                    var company = JsonConvert.DeserializeObject<Company>(body);
                    Lists.companies.Add(company);
                    break;
            }
        }

        private void websocket_Opened(object sender, EventArgs e)
        {
            Utilities.WriteLog(LOG_TYPE, "Connection opened.", ConsoleColor.Green);
            Utilities.WriteLog(LOG_TYPE, "IP Address : " + Constants.IP_ADDRESS.ToString(), ConsoleColor.Yellow);
            Utilities.WriteLog(LOG_TYPE, "Port : " + Constants.PORT.ToString(), ConsoleColor.Yellow);
        }

        private void websocket_Error(object sender, ErrorEventArgs e)
        {
            Utilities.WriteErrorMessages(e.Exception);
        }

        private void websocket_Closed(object sender, EventArgs e)
        {
            Utilities.WriteLog(LOG_TYPE, "Connection closed.", ConsoleColor.Magenta);
            MessageBox.Show("Lütfen internetinizi veya sunucuyu kontrol edin.", "Bağlantı Hatası!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Application.Exit();
        }
    }
}
