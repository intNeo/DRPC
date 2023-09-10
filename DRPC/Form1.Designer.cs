namespace DRPC
{
    partial class DiscordRPC
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.tAID = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.But_Edit = new System.Windows.Forms.Button();
            this.But_Send = new System.Windows.Forms.Button();
            this.But_Check = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ImageURL2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ImageURL1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.State = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Details = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.But_Enable_timer = new System.Windows.Forms.Button();
            this.But_Countdown = new System.Windows.Forms.Button();
            this.But_Reset = new System.Windows.Forms.Button();
            this.But_Disconnect = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Partyid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.JoinSecret = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.PartySize = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PartyMax = new System.Windows.Forms.TextBox();
            this.But_Invite = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ImageText1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ImageText2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Application ID:";
            // 
            // tAID
            // 
            this.tAID.Location = new System.Drawing.Point(85, 27);
            this.tAID.Name = "tAID";
            this.tAID.PasswordChar = '•';
            this.tAID.Size = new System.Drawing.Size(214, 20);
            this.tAID.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.But_Disconnect);
            this.groupBox1.Controls.Add(this.But_Edit);
            this.groupBox1.Controls.Add(this.But_Send);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tAID);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(318, 112);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Authorize";
            // 
            // But_Edit
            // 
            this.But_Edit.Location = new System.Drawing.Point(143, 66);
            this.But_Edit.Name = "But_Edit";
            this.But_Edit.Size = new System.Drawing.Size(75, 23);
            this.But_Edit.TabIndex = 3;
            this.But_Edit.Text = "Edit";
            this.But_Edit.UseVisualStyleBackColor = true;
            this.But_Edit.Click += new System.EventHandler(this.But_Edit_Click);
            // 
            // But_Send
            // 
            this.But_Send.Location = new System.Drawing.Point(224, 66);
            this.But_Send.Name = "But_Send";
            this.But_Send.Size = new System.Drawing.Size(75, 23);
            this.But_Send.TabIndex = 2;
            this.But_Send.Text = "Send";
            this.But_Send.UseVisualStyleBackColor = true;
            this.But_Send.Click += new System.EventHandler(this.But_Send_Click);
            // 
            // But_Check
            // 
            this.But_Check.Location = new System.Drawing.Point(224, 181);
            this.But_Check.Name = "But_Check";
            this.But_Check.Size = new System.Drawing.Size(75, 23);
            this.But_Check.TabIndex = 3;
            this.But_Check.Text = "Check";
            this.But_Check.UseVisualStyleBackColor = true;
            this.But_Check.Click += new System.EventHandler(this.But_Check_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ImageText2);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.ImageURL2);
            this.groupBox2.Controls.Add(this.ImageText1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ImageURL1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.State);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.Details);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.But_Check);
            this.groupBox2.Location = new System.Drawing.Point(12, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(318, 217);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Customizer";
            // 
            // ImageURL2
            // 
            this.ImageURL2.Location = new System.Drawing.Point(100, 103);
            this.ImageURL2.Name = "ImageURL2";
            this.ImageURL2.Size = new System.Drawing.Size(199, 20);
            this.ImageURL2.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Small Image Key:";
            // 
            // ImageURL1
            // 
            this.ImageURL1.Location = new System.Drawing.Point(100, 77);
            this.ImageURL1.Name = "ImageURL1";
            this.ImageURL1.Size = new System.Drawing.Size(199, 20);
            this.ImageURL1.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(90, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Large Image Key:";
            // 
            // State
            // 
            this.State.Location = new System.Drawing.Point(54, 51);
            this.State.Name = "State";
            this.State.Size = new System.Drawing.Size(245, 20);
            this.State.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "State:";
            // 
            // Details
            // 
            this.Details.Location = new System.Drawing.Point(54, 25);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(245, 20);
            this.Details.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Details:";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(224, 21);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(75, 20);
            this.value.TabIndex = 2;
            this.value.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.value_KeyPress);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.value);
            this.groupBox3.Controls.Add(this.But_Reset);
            this.groupBox3.Controls.Add(this.But_Countdown);
            this.groupBox3.Controls.Add(this.But_Enable_timer);
            this.groupBox3.Location = new System.Drawing.Point(336, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 81);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Timer";
            // 
            // But_Enable_timer
            // 
            this.But_Enable_timer.Location = new System.Drawing.Point(6, 19);
            this.But_Enable_timer.Name = "But_Enable_timer";
            this.But_Enable_timer.Size = new System.Drawing.Size(75, 23);
            this.But_Enable_timer.TabIndex = 2;
            this.But_Enable_timer.Text = "Enable timer";
            this.But_Enable_timer.UseVisualStyleBackColor = true;
            this.But_Enable_timer.Click += new System.EventHandler(this.But_Enable_timer_Click);
            // 
            // But_Countdown
            // 
            this.But_Countdown.Location = new System.Drawing.Point(85, 19);
            this.But_Countdown.Name = "But_Countdown";
            this.But_Countdown.Size = new System.Drawing.Size(75, 23);
            this.But_Countdown.TabIndex = 2;
            this.But_Countdown.Text = "Countdown";
            this.But_Countdown.UseVisualStyleBackColor = true;
            this.But_Countdown.Click += new System.EventHandler(this.But_Countdown_Click);
            // 
            // But_Reset
            // 
            this.But_Reset.Location = new System.Drawing.Point(224, 47);
            this.But_Reset.Name = "But_Reset";
            this.But_Reset.Size = new System.Drawing.Size(75, 23);
            this.But_Reset.TabIndex = 2;
            this.But_Reset.Text = "Reset";
            this.But_Reset.UseVisualStyleBackColor = true;
            this.But_Reset.Click += new System.EventHandler(this.But_Reset_Click);
            // 
            // But_Disconnect
            // 
            this.But_Disconnect.Location = new System.Drawing.Point(62, 66);
            this.But_Disconnect.Name = "But_Disconnect";
            this.But_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.But_Disconnect.TabIndex = 3;
            this.But_Disconnect.Text = "Disconnect";
            this.But_Disconnect.UseVisualStyleBackColor = true;
            this.But_Disconnect.Click += new System.EventHandler(this.But_Disconnect_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.PartyMax);
            this.groupBox4.Controls.Add(this.PartySize);
            this.groupBox4.Controls.Add(this.JoinSecret);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.Partyid);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.But_Invite);
            this.groupBox4.Location = new System.Drawing.Point(336, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(318, 128);
            this.groupBox4.TabIndex = 14;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Invite";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Party Id:";
            // 
            // Partyid
            // 
            this.Partyid.Location = new System.Drawing.Point(75, 19);
            this.Partyid.Name = "Partyid";
            this.Partyid.PasswordChar = '•';
            this.Partyid.Size = new System.Drawing.Size(224, 20);
            this.Partyid.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Join Secret:";
            // 
            // JoinSecret
            // 
            this.JoinSecret.Location = new System.Drawing.Point(75, 45);
            this.JoinSecret.Name = "JoinSecret";
            this.JoinSecret.PasswordChar = '•';
            this.JoinSecret.Size = new System.Drawing.Size(224, 20);
            this.JoinSecret.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Party Size:";
            // 
            // PartySize
            // 
            this.PartySize.Location = new System.Drawing.Point(75, 71);
            this.PartySize.Name = "PartySize";
            this.PartySize.Size = new System.Drawing.Size(66, 20);
            this.PartySize.TabIndex = 5;
            this.PartySize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartySize_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(164, 74);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Party Max:";
            // 
            // PartyMax
            // 
            this.PartyMax.Location = new System.Drawing.Point(233, 71);
            this.PartyMax.Name = "PartyMax";
            this.PartyMax.Size = new System.Drawing.Size(66, 20);
            this.PartyMax.TabIndex = 5;
            this.PartyMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartyMax_KeyPress);
            // 
            // But_Invite
            // 
            this.But_Invite.Location = new System.Drawing.Point(224, 97);
            this.But_Invite.Name = "But_Invite";
            this.But_Invite.Size = new System.Drawing.Size(75, 23);
            this.But_Invite.TabIndex = 3;
            this.But_Invite.Text = "Invite";
            this.But_Invite.UseVisualStyleBackColor = true;
            this.But_Invite.Click += new System.EventHandler(this.But_Invite_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "Large Image Text:";
            // 
            // ImageText1
            // 
            this.ImageText1.Location = new System.Drawing.Point(100, 129);
            this.ImageText1.Name = "ImageText1";
            this.ImageText1.Size = new System.Drawing.Size(199, 20);
            this.ImageText1.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 13);
            this.label11.TabIndex = 10;
            this.label11.Text = "Small Image Text:";
            // 
            // ImageText2
            // 
            this.ImageText2.Location = new System.Drawing.Point(100, 155);
            this.ImageText2.Name = "ImageText2";
            this.ImageText2.Size = new System.Drawing.Size(199, 20);
            this.ImageText2.TabIndex = 9;
            // 
            // DiscordRPC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 355);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "DiscordRPC";
            this.Text = "DiscordRPC by intNeo";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tAID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button But_Send;
        private System.Windows.Forms.Button But_Edit;
        private System.Windows.Forms.Button But_Check;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox State;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Details;
        private System.Windows.Forms.TextBox ImageURL2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ImageURL1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button But_Countdown;
        private System.Windows.Forms.Button But_Enable_timer;
        private System.Windows.Forms.Button But_Reset;
        private System.Windows.Forms.Button But_Disconnect;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox PartySize;
        private System.Windows.Forms.TextBox JoinSecret;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Partyid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PartyMax;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button But_Invite;
        private System.Windows.Forms.TextBox ImageText2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ImageText1;
        private System.Windows.Forms.Label label10;
    }
}

