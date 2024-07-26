using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using uPLibrary.Networking.M2Mqtt;
using uPLibrary.Networking.M2Mqtt.Messages;

namespace IoT1CS
{
    public partial class Form1 : Form
    {
        MqttClient mqttClient;
        private bool connected=false;
        private bool ledState=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(connected) { mqttClient.Disconnect(); }
            Close();
        }

        private void WriteLog(string msg)
        {
            //lbLog.Items.Add(msg);
            lbLog.Invoke((MethodInvoker)(()=>lbLog.Items.Add(msg)));
        }
        private void MQTTReceived(object sender, uPLibrary.Networking.M2Mqtt.Messages.MqttMsgPublishEventArgs e)
        {
            var topic = e.Topic;
            var msg = Encoding.UTF8.GetString(e.Message);
            WriteLog("Received ("+topic+"): " + msg);
            if (topic == tbConnectedTopic.Text)
            {
                if (msg == "1")
                {
                    pbConnected.Image = IoT1CS.Properties.Resources.led_green;
                }
                else
                {
                    pbConnected.Image = IoT1CS.Properties.Resources.led_grey;
                }
            }
            if (topic == tbStateTopic.Text)
            {
                ledState = (msg == "1");
                if (ledState) { 
                    pbState.Image = IoT1CS.Properties.Resources.led_red; 
                } else {
                    pbState.Image = IoT1CS.Properties.Resources.led_grey; 
                }
            }
        }
        private void MQTTConnect()
        {
            mqttClient = new MqttClient(cbBroker.Text);
            mqttClient.MqttMsgPublishReceived += MQTTReceived;
            mqttClient.Subscribe(new string[] { tbConnectedTopic.Text, tbStateTopic.Text }, new byte[] { 1,1 });
            mqttClient.Connect(tbID.Text);
            connected = (mqttClient != null && mqttClient.IsConnected);
            if (mqttClient.IsConnected)
            {
                WriteLog("Successfully connected");
            } else
            {
                WriteLog("Not connected");
            }
            btnConnect.Enabled = !connected;
            btnDisConnect.Enabled = connected;
            cbBroker.Enabled = !connected;
            numUDPort.Enabled = !connected;
            tbID.Enabled = !connected;
            tbUser.Enabled = !connected;
            tbPassword.Enabled = !connected;
            chkSSL.Enabled = !connected;
            tbConnectedTopic.Enabled = !connected;
            tbStateTopic.Enabled = !connected;
            pbState.Enabled = connected;
            tbTopic.Enabled = connected;
            tbID1.Enabled = connected;
            btnSubscribe.Enabled = connected;
        }
        private void MQTTDisConnect()
        {
            if (mqttClient.IsConnected) { mqttClient.Disconnect(); Thread.Sleep(500);  }
            connected = mqttClient.IsConnected;
            btnConnect.Enabled = !connected;
            btnDisConnect.Enabled = connected;
            cbBroker.Enabled = !connected;
            numUDPort.Enabled = !connected;
            tbID.Enabled = !connected;
            tbUser.Enabled = !connected;
            tbPassword.Enabled = !connected;
            chkSSL.Enabled = !connected;
            tbConnectedTopic.Enabled = !connected;
            tbStateTopic.Enabled = !connected;
            pbState.Enabled = connected;
            tbTopic.Enabled = connected;
            tbID1.Enabled = connected;
            btnSubscribe.Enabled = connected;
            btnUnSubscribe.Enabled = connected;
            if (!connected)
            {
                pbState.Image = IoT1CS.Properties.Resources.led_grey;
                pbConnected.Image = IoT1CS.Properties.Resources.led_grey;

            }
        }
        private void MQTTSubscribe()
        {
            if (mqttClient.IsConnected)
            {
                mqttClient.Subscribe(new string[] { tbTopic.Text }, new byte[] { 1 });
                bool success = true;
                btnSubscribe.Enabled = !success;
                btnUnSubscribe.Enabled = success;
                tbPublishText.Enabled = success;
                btnPublish.Enabled = success;
            }
        }
        private void MQTTUnSubscribe()
        {
            if (mqttClient.IsConnected) { 
                mqttClient.Unsubscribe(new string[] { tbTopic.Text });
                bool success = false;
                btnSubscribe.Enabled = !success;
                btnUnSubscribe.Enabled = success;
                tbPublishText.Enabled = success;
                btnPublish.Enabled = success;
            }
        }
        private void MQTTPublish()
        {
            if (mqttClient.IsConnected)
            {
                mqttClient.Publish(tbTopic.Text, Encoding.UTF8.GetBytes(tbPublishText.Text), 1, true);
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MQTTConnect();
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            MQTTDisConnect();
        }

        private void btnSubscribe_Click(object sender, EventArgs e)
        {
            MQTTSubscribe();
        }

        private void btnUnSubscribe_Click(object sender, EventArgs e)
        {
            MQTTUnSubscribe();
        }

        private void btnPublish_Click(object sender, EventArgs e)
        {
            MQTTPublish();
        }

        private void pbState_Click(object sender, EventArgs e)
        {
            if (ledState)
            {
                mqttClient.Publish(tbStateTopic.Text, Encoding.UTF8.GetBytes("0"),1,true);
            } 
            else
            {
                mqttClient.Publish(tbStateTopic.Text, Encoding.UTF8.GetBytes("1"),1,true);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MQTTConnect();
        }
    }
}
