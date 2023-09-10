using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiscordRpcDemo;

namespace DRPC
{
    
    public partial class DiscordRPC : Form
    {
        private DiscordRpc.EventHandlers handlers;
        private DiscordRpc.RichPresence presence;
        public DiscordRPC()
        {
            InitializeComponent();
            this.But_Edit.Enabled = false; //При старте отключаем кнопку Edit.
            this.groupBox2.Enabled = false; //А также и группу кастомизации.
            this.groupBox3.Enabled = false;
            this.groupBox4.Enabled = false;
            this.But_Disconnect.Enabled = false;
        }
        public string aid; //Переменная, которая принимает Application ID от пользователя.
        public void But_Send_Click(object sender, EventArgs e)
        {
            //Делаем логику, если ввели ID, то блокируем TextBox и кнопку Send, но открываем Edit.
            this.tAID.Enabled = false;
            this.But_Send.Enabled = false;
            this.But_Edit.Enabled = true;
            //Пока пользователь не ввел ID кастомизация недоступна.
            this.groupBox2.Enabled = true;
            this.groupBox3.Enabled = true;
            this.groupBox4.Enabled = true;
            this.But_Disconnect.Enabled = true;
            aid = tAID.Text; //Вносим в переменную Application ID.
        }

        private void But_Edit_Click(object sender, EventArgs e)
        {
            //Аналогичная логика как выше.
            this.tAID.Enabled = true;
            this.But_Send.Enabled = true;
            this.But_Edit.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox4.Enabled = false;
            this.But_Disconnect.Enabled = false;
        }
        
        private void But_Check_Click(object sender, EventArgs e)
        {
            
            //Создаем переменные для принятия значений
            string details = this.Details.Text;
            string state = this.State.Text;
            string image1 = this.ImageURL1.Text;
            string image2 = this.ImageURL2.Text;
            string text1 = this.ImageText1.Text;
            string text2 = this.ImageText2.Text;

            //Основная информация о статусе.
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(aid, ref this.handlers, true, null);
            this.handlers = default(DiscordRpc.EventHandlers);
            DiscordRpc.Initialize(aid, ref this.handlers, true, null);
            this.presence.details = details;
            this.presence.state = state;
            this.presence.largeImageKey = image1;
            this.presence.smallImageKey = image2;
            this.presence.largeImageText = text1;
            this.presence.smallImageText = text2;

            DiscordRpc.UpdatePresence(ref this.presence);
        }
        
        private void value_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Делаем ввод только цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void But_Enable_timer_Click(object sender, EventArgs e)
        {
            //Добавляем переменные для таймера.
            //Который тикает вперед.
            long startTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
            this.presence.startTimestamp = startTimestamp;
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void But_Countdown_Click(object sender, EventArgs e)
        {
            try
            {
                //Добавляем переменные для таймера.
                //Который тикает обратно.
                int inval = int.Parse(value.Text);
                long startTimestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds();
                long timerDuration;
                timerDuration = inval;
                long endTimestamp = startTimestamp + timerDuration;
                this.presence.startTimestamp = startTimestamp;
                this.presence.endTimestamp = endTimestamp;
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            catch (Exception)
            {
                //В случае если пользователь не ввел значение, вылетает ошибка.
                MessageBox.Show("Enter time in seconds.", "Error");
            }
            
        }

        private void But_Reset_Click(object sender, EventArgs e)
        {
            //Очищает таймер.
            this.presence.startTimestamp = 0;
            this.presence.endTimestamp = 0;
            DiscordRpc.UpdatePresence(ref this.presence);
        }

        private void But_Disconnect_Click(object sender, EventArgs e)
        {
            //Как и варианте выше очищаем таймер.
            this.presence.startTimestamp = 0;
            this.presence.endTimestamp = 0;
            DiscordRpc.UpdatePresence(ref this.presence);
            //Отсоединяем наш DiscordRPC.
            DiscordRpc.Shutdown();
            this.tAID.Enabled = true;
            //И производим очистку интерфейса.
            this.But_Send.Enabled = true;
            this.But_Edit.Enabled = false;
            this.groupBox2.Enabled = false;
            this.groupBox3.Enabled = false;
            this.groupBox4.Enabled = false;
            this.But_Disconnect.Enabled = false;
            this.tAID.Text = null;
            this.Details.Text = null;
            this.State.Text = null;
            this.ImageURL1.Text = null;
            this.ImageURL2.Text = null;
            this.ImageText1.Text = null;
            this.ImageText2.Text = null;
            this.value.Text = null;
            this.Partyid.Text = null;
            this.JoinSecret.Text = null;
            this.PartySize.Text = null;
            this.PartyMax.Text = null;
        }

        private void But_Invite_Click(object sender, EventArgs e)
        {
            try
            {
                //Создаем игровое пати (по фану)
                //Добавляем переменные для приема данных
                string partyid = this.Partyid.Text;
                string joinsecret = this.JoinSecret.Text;
                int partysize = Convert.ToInt32(this.PartySize.Text);
                int partymax = Convert.ToInt32(this.PartyMax.Text);
                this.presence.partyId = partyid;
                this.presence.joinSecret = joinsecret;
                this.presence.partySize = partysize;
                this.presence.partyMax = partymax;
                DiscordRpc.UpdatePresence(ref this.presence);
            }
            catch (Exception)
            {
                //В случае не заполнения какого-либо поля, вылезает ошибка.
                MessageBox.Show("Check that the parameters are entered correctly.", "Error");
            }
        }

        private void PartySize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Делаем ввод только цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void PartyMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Делаем ввод только цифр
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
