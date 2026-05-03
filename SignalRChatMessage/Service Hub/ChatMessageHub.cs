using Microsoft.AspNetCore.SignalR;
using SignalRChatMessage.Models;

namespace SignalRChatMessage.Service_Hub
{
    public class ChatMessageHub:Hub
    {
        private readonly ChatContext _chatContext;

        public ChatMessageHub(ChatContext chatContext)
        {
           _chatContext = chatContext;
        }
        public void SendMessage(string name,string message)
        {
            //    //save in DB
            //    chatmessage mess = new chatmessage()
            //    {
            //        username = name,
            //        messagetxt = message
            //    };
            //    db.chatmessages.Add(mess);
            //    db.SaveChanges();
            //Perform Actions 
            Clients.All.SendAsync("NewMessage",name,message);//Send Response For all Client اللى مهتمين وبيسالوا على الEvent دا فقط 
            //ممكن بعد كدة نتحكم فى clients اللى  عايزهم يستقبلوا ال Response دا فقط 
           
            //then Save Changes in Database 
        }


        #region Function With Object From Context
        //public void sendmessage(ChatContext mess)
        //{
        //    //save in DB

        //    _chatContext.chatmessages.Add(mess);
        //    _chatContext.SaveChanges();


        //    //broadcasting to all online clients
        //    Clients.All.SendAsync("newmessage", mess);
        //}

        #endregion



    }
}
