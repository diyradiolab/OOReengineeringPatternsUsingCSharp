using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter10._4_Before
{
    class Program
    {
      
        static void Main(string[] args)
        {



            var myMessage = new Message();
            myMessage.set_value("Text"); // here you can send a string or an int. Depending on the type, it will set the type_ property to 1 or 2, which will cause a different format of message to be sent by Message.Send
            var myChannel = new Channel();
            myMessage.Send(myChannel);
            Console.ReadLine();

        }

    }

    public class Message
    {

        public int type_;

        public Message()
        {
            //constructor
        }

        public void set_value(int action) { type_ = 2; } //text type message

        public void set_value(string text) { type_ = 1; } //action type message

        public void Send(Channel c)
        {

            switch (type_)
            {
                case 1:
                    Console.WriteLine("Sending text to a machine...");


                    break;
                case 2:
                    Console.WriteLine("Sending an action to a machine...");
                    break;
                default: break;
            }

        }
    }

    public class Channel
    {
    }
}
