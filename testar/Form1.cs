using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EEUniverse.Library;
using EEUniverse.LoginExtensions;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
namespace testar
{
    public partial class Form1 : Form
    {
        public static Client client_;
        public static Connection con_;
        private string pathtoprotocol = $"{Directory.GetCurrentDirectory()}\\protocol.json";
        private Dictionary<string, Protocol> protocol = new Dictionary<string, Protocol>();
        public static Dictionary<string, List<Tuple<string, EEUniverse.Library.Message>>> messages = new Dictionary<string, List<Tuple<string, EEUniverse.Library.Message>>>();
        public Form1()
        {
            InitializeComponent();
            this.Text = "EEUProtocol Tool";
        }

        private void ConnectButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TokenTextBox.Text))
            {
                if (!string.IsNullOrEmpty(RoomIDTextBox.Text))
                {
                    connect2eeu(TokenTextBox.Text, RoomIDTextBox.Text);
                }
            }
        }
        private async void connect2eeu(string token, string rid)
        {
            Client client_ = new Client(token);
            await client_.ConnectAsync();
            Connection con_ = client_.CreateWorldConnection(rid);
            con_.OnMessage += (s, m) =>
            {
                if (messages.ContainsKey(m.Type.ToString()))
                {
                    messages[m.Type.ToString()].Add(new Tuple<string, EEUniverse.Library.Message>(string.Concat(new object[] { "[", messages[m.Type.ToString()].Count, "] ", DateTime.Now.ToString("hh:mm:ss") }), m));

                    base.Invoke(new MethodInvoker(delegate ()
                    {
                        if (listView1.SelectedIndices.Count != 0 && listView1.SelectedItems[0].Text != null && listView1.SelectedItems[0].Text == m.Type.ToString())
                        {

                            listBox2.Items.Add(messages[m.Type.ToString()].Last<Tuple<string, EEUniverse.Library.Message>>().Item1);
                        }
                    }));


                }
                else
                {
                    List<Tuple<string, EEUniverse.Library.Message>> list = new List<Tuple<string, EEUniverse.Library.Message>>();
                    list.Add(new Tuple<string, EEUniverse.Library.Message>("[0] " + DateTime.Now.ToString("hh:mm:ss"), m));
                    messages.Add(m.Type.ToString(), list);
                    if (listView1.InvokeRequired)
                    {
                        base.Invoke(new MethodInvoker(delegate ()
                        {
                            listView1.Items.Add(m.Type.ToString());
                        }));
                    }
                }
            };
            await con_.SendAsync(MessageType.Init, 0);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
            listBox2.Items.Clear();
            MCListView.Items.Clear();
            if (listView1.SelectedItems.Count == 1)
            {
                foreach (Tuple<string, EEUniverse.Library.Message> tuple in messages[listView1.SelectedItems[0].Text])
                {
                    listBox2.Items.Add(tuple.Item1);
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            MCListView.Items.Clear();
            textBox1.Clear();
            //listView1.Select();
            if (listBox2.SelectedIndex != -1)
            {
                EEUniverse.Library.Message item = messages[listView1.SelectedItems[0].Text][listBox2.SelectedIndex].Item2;
                for (int num = 0; num < item.Count; num += 1)
                {

                    MCListView.Items.Add("[" + num + "]").SubItems.Add(item[num].GetType().ToString());
                    if (protocol.Count > 0)
                    {
                        if (protocol.ContainsKey(listView1.SelectedItems[0].Text))
                        {
                            if (protocol[listView1.SelectedItems[0].Text].Data.ContainsKey(num))
                            {
                                JToken line = protocol[listView1.SelectedItems[0].Text].Data[num];
                                if (line.ToString() == item[num].GetType().ToString())
                                {
                                    MCListView.Items[num].ForeColor = Color.Green;
                                }
                                else
                                {
                                    MCListView.Items[num].ForeColor = Color.Red;
                                }

                            }
                            else
                            {
                                MCListView.Items[num].ForeColor = Color.DarkBlue;
                            }
                        }
                    }
                    else
                    {
                        MCListView.Items[num].ForeColor = Color.DarkBlue;
                    }
                }
            }
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathtoprotocol))
            {

                var output = JObject.Parse(File.ReadAllText(pathtoprotocol));
                foreach (var property in output)
                {
                    if (property.Value["Data"].Count() > 0)
                    {
                        Protocol prtc1 = new Protocol()
                        {
                            Data = property.Value["Data"].ToObject<Dictionary<int, JToken>>()
                        };

                        protocol.Add(property.Key, prtc1);
                    }
                }
                foreach (KeyValuePair<string, Protocol> prt in protocol)
                {
                    foreach (var value in prt.Value.Data)
                    {
                        Console.WriteLine(value.Key);
                    }
                }

            }
        }

        private void MCListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //listView1.Select();
            //listView1.SelectedItems[0].Selected = true;

            if (MCListView.SelectedIndices.Count == 0)
            {
                textBox1.Clear();

            }
            else
            {
                EEUniverse.Library.Message item = messages[listView1.SelectedItems[0].Text][listBox2.SelectedIndex].Item2;
                int index = MCListView.SelectedIndices[0];
                if (item[index].GetType().ToString() == "System.Byte[]")
                {
                    textBox1.Text = "Byte found, can't convert";
                    textBox1.ForeColor = Color.Red;
                }
                else
                {
                    textBox1.Text = item[index].ToString();
                    textBox1.ForeColor = SystemColors.WindowText;
                }
            }
        }
    }
    public class Protocol
    {
        public Dictionary<int, JToken> Data { get; set; }
    }
}
