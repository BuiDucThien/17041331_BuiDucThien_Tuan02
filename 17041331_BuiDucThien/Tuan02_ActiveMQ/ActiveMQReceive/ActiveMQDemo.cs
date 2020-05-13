using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Apache.NMS;
using Apache.NMS.ActiveMQ;
using Apache.NMS.ActiveMQ.Commands;

namespace ActiveMQReceive
{
    public class ActiveMQDemo
    {
        static void Main(string[] args)
        {
                Console.WriteLine("receiving message. Enter to exit.");
                //tạo connection factory
                IConnectionFactory factory = new ConnectionFactory("tcp://localhost:61616");
                //tạo connection
                IConnection con = factory.CreateConnection("admin", "admin");
                con.Start();//nối tới MOM
                            //tạo session
                ISession session = con.CreateSession(AcknowledgementMode.AutoAcknowledge);
                //tạo consumer
                ActiveMQQueue destination = new ActiveMQQueue("thanthidet");
                IMessageConsumer consumer = session.CreateConsumer(destination);
                //nhận mesage - lắng nghe
                consumer.Listener += Consumer_Listener;
                Console.ReadKey();
            }

          private static void Consumer_Listener(IMessage message)
        {
            if (message is ActiveMQTextMessage)
            {
                ActiveMQTextMessage msg = message as ActiveMQTextMessage;
                Console.WriteLine("receive:" + msg.Text);
            }
        }
    }
    }

