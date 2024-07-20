using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter_41_Interfaces_Section_41_7_Hiding_members_with_Explicit_Implementation
{
    public interface IMessageService
    {
        void OnMessageRecieve();
        void SendMessage();
        string Result { get; set; }
        int Endcoding { get; set; }
    }

    public class MyObjectWithMessages : IMessageService
    {
         void IMessageService.OnMessageRecieve() { }
         void IMessageService.SendMessage() { }
         string IMessageService.Result { get; set; }
         int IMessageService.Endcoding { get; set; }

    }

    




}
