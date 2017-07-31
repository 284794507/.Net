using ServiceStack.Redis;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace testRedis
{
    public partial class FrmMain : Form
    {
        RedisClient redisClient;
        public FrmMain()
        {
            InitializeComponent();

            Init();
            HandlerList();
        }

        public void Init()
        {
            redisClient = new RedisClient("127.0.0.1", 6379);
        }

        public void HandlerString()
        {
            redisClient.Set<string>("key", "hello,redis!");
            string key = redisClient.Get<string>("key");
            Console.WriteLine("key=" + key);
        }

        public void HandlerList()
        {
            redisClient.Remove("myList");
            redisClient.PushItemToList("myList", "a");
            redisClient.PushItemToList("myList", "b");
            redisClient.PushItemToList("myList", "c");

            List<string> myList = redisClient.GetRangeFromList("myList", 0, -1);
            foreach(string item in myList)
            {
                Console.WriteLine("item from myList:" + item);
            }

            redisClient.PopItemFromList("myList");
            myList = redisClient.GetRangeFromList("myList", 0, -1);
            Console.WriteLine("after pop...");
            foreach (string item in myList)
            {
                Console.WriteLine("item from myList:" + item);
            }
        }

        public void handlerHash()
        {
            redisClient.Remove("car:100");
            redisClient.SetEntryInHash("car:100", "Name", "Benz S600");
            redisClient.SetEntryInHash("car:100", "Price", "600");
            redisClient.SetEntryInHash("car:100", "Color", "black");
            Dictionary<string, string> car = redisClient.GetAllEntriesFromHash("car:100");
            foreach(string key in car.Keys)
            {
                Console.WriteLine("{0}={1}", key, car[key]);
            }
        }
    }
}
