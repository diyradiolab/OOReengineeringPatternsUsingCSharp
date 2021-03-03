using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10._4_After
{
    class Program
    {
        static void Main(string[] args)
        {
            Message myMessage = new Action_Message(4);
            //Message myMessage = new Text_Message("Some Text");  <--invoke if you want to send a textmessage

            var myChannel = new Channel();
            myMessage.Send(myChannel);
            Console.ReadLine();
        }

        public abstract class Message
        {
            public abstract void Send(Channel channel);
        }

        public class Text_Message : Message
        {
            public string Text;
            public Text_Message(string text)
            {
                Text = text;
            }
            public override void Send(Channel c) { Console.WriteLine("Sending text to a machine..."); }

        }

        public class Action_Message : Message
        {
            public int Action;
            public Action_Message(int action)
            {
                Action = action;
            }
            public override void Send(Channel c) { Console.WriteLine("Sending an action to a machine..."); }
        }

        public class Channel
        {
        }

    }
}
