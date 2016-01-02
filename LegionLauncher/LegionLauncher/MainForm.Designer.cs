﻿using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;

namespace LegionLauncher
{
    partial class MainForm
    {

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mainTabControl = new System.Windows.Forms.TabControl();
            this.servers = new System.Windows.Forms.TabPage();
            this.serverOneLaunchButton = new System.Windows.Forms.Button();
            this.playersPlaceholder = new System.Windows.Forms.Label();
            this.serverNamePlaceholder = new System.Windows.Forms.Label();
            this.mods = new System.Windows.Forms.TabPage();
            this.exileDownloadButton = new System.Windows.Forms.Button();
            this.exileVerifyButton = new System.Windows.Forms.Button();
            this.exileModLabel = new System.Windows.Forms.Label();
            this.aiaDownloadButton = new System.Windows.Forms.Button();
            this.usafDownloadButton = new System.Windows.Forms.Button();
            this.afrfDownloadButton = new System.Windows.Forms.Button();
            this.taviDownloadButton = new System.Windows.Forms.Button();
            this.cupDownloadButton = new System.Windows.Forms.Button();
            this.asdgDownloadButton = new System.Windows.Forms.Button();
            this.aiaVerifyButton = new System.Windows.Forms.Button();
            this.usafVerifyButton = new System.Windows.Forms.Button();
            this.afrfVerifyButton = new System.Windows.Forms.Button();
            this.taviVerifyButton = new System.Windows.Forms.Button();
            this.cupVerifyButton = new System.Windows.Forms.Button();
            this.asdgVerifyButton = new System.Windows.Forms.Button();
            this.asdgModLabel = new System.Windows.Forms.Label();
            this.aiaModLabel = new System.Windows.Forms.Label();
            this.usafModLabel = new System.Windows.Forms.Label();
            this.afrfModLabel = new System.Windows.Forms.Label();
            this.taviModLabel = new System.Windows.Forms.Label();
            this.cupModLabel = new System.Windows.Forms.Label();
            this.armaPath = new System.Windows.Forms.Label();
            this.mainTabControl.SuspendLayout();
            this.servers.SuspendLayout();
            this.mods.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabControl
            // 
            this.mainTabControl.Controls.Add(this.servers);
            this.mainTabControl.Controls.Add(this.mods);
            this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabControl.Location = new System.Drawing.Point(0, 0);
            this.mainTabControl.Name = "mainTabControl";
            this.mainTabControl.SelectedIndex = 0;
            this.mainTabControl.Size = new System.Drawing.Size(521, 547);
            this.mainTabControl.TabIndex = 0;
            // 
            // servers
            // 
            this.servers.BackColor = System.Drawing.Color.Transparent;
            this.servers.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.servers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.servers.Controls.Add(this.serverOneLaunchButton);
            this.servers.Controls.Add(this.playersPlaceholder);
            this.servers.Controls.Add(this.serverNamePlaceholder);
            this.servers.Location = new System.Drawing.Point(4, 22);
            this.servers.Name = "servers";
            this.servers.Padding = new System.Windows.Forms.Padding(3);
            this.servers.Size = new System.Drawing.Size(513, 521);
            this.servers.TabIndex = 0;
            this.servers.Text = "Legion Servers";
            // 
            // serverOneLaunchButton
            // 
            this.serverOneLaunchButton.Location = new System.Drawing.Point(366, 42);
            this.serverOneLaunchButton.Name = "serverOneLaunchButton";
            this.serverOneLaunchButton.Size = new System.Drawing.Size(122, 56);
            this.serverOneLaunchButton.TabIndex = 3;
            this.serverOneLaunchButton.Text = "PLAY!";
            this.serverOneLaunchButton.UseVisualStyleBackColor = true;
            this.serverOneLaunchButton.Click += new System.EventHandler(this.serverOneLaunchButton_Click);
            // 
            // playersPlaceholder
            // 
            this.playersPlaceholder.AutoSize = true;
            this.playersPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playersPlaceholder.Location = new System.Drawing.Point(8, 73);
            this.playersPlaceholder.Name = "playersPlaceholder";
            this.playersPlaceholder.Size = new System.Drawing.Size(202, 25);
            this.playersPlaceholder.TabIndex = 2;
            this.playersPlaceholder.Text = "players Placeholder";
            // 
            // serverNamePlaceholder
            // 
            this.serverNamePlaceholder.AutoSize = true;
            this.serverNamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serverNamePlaceholder.Location = new System.Drawing.Point(3, 42);
            this.serverNamePlaceholder.Name = "serverNamePlaceholder";
            this.serverNamePlaceholder.Size = new System.Drawing.Size(323, 31);
            this.serverNamePlaceholder.TabIndex = 0;
            this.serverNamePlaceholder.Text = "Server Name Placeholder";
            // 
            // mods
            // 
            this.mods.BackColor = System.Drawing.Color.Black;
            this.mods.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mods.Controls.Add(this.exileDownloadButton);
            this.mods.Controls.Add(this.exileVerifyButton);
            this.mods.Controls.Add(this.exileModLabel);
            this.mods.Controls.Add(this.aiaDownloadButton);
            this.mods.Controls.Add(this.usafDownloadButton);
            this.mods.Controls.Add(this.afrfDownloadButton);
            this.mods.Controls.Add(this.taviDownloadButton);
            this.mods.Controls.Add(this.cupDownloadButton);
            this.mods.Controls.Add(this.asdgDownloadButton);
            this.mods.Controls.Add(this.aiaVerifyButton);
            this.mods.Controls.Add(this.usafVerifyButton);
            this.mods.Controls.Add(this.afrfVerifyButton);
            this.mods.Controls.Add(this.taviVerifyButton);
            this.mods.Controls.Add(this.cupVerifyButton);
            this.mods.Controls.Add(this.asdgVerifyButton);
            this.mods.Controls.Add(this.asdgModLabel);
            this.mods.Controls.Add(this.aiaModLabel);
            this.mods.Controls.Add(this.usafModLabel);
            this.mods.Controls.Add(this.afrfModLabel);
            this.mods.Controls.Add(this.taviModLabel);
            this.mods.Controls.Add(this.cupModLabel);
            this.mods.Controls.Add(this.armaPath);
            this.mods.Location = new System.Drawing.Point(4, 22);
            this.mods.Name = "mods";
            this.mods.Padding = new System.Windows.Forms.Padding(3);
            this.mods.Size = new System.Drawing.Size(513, 521);
            this.mods.TabIndex = 1;
            this.mods.Text = "Mods";
            // 
            // exileDownloadButton
            // 
            this.exileDownloadButton.Location = new System.Drawing.Point(343, 427);
            this.exileDownloadButton.Name = "exileDownloadButton";
            this.exileDownloadButton.Size = new System.Drawing.Size(94, 23);
            this.exileDownloadButton.TabIndex = 24;
            this.exileDownloadButton.Text = "DOWNLOAD";
            this.exileDownloadButton.UseVisualStyleBackColor = true;
            // 
            // exileVerifyButton
            // 
            this.exileVerifyButton.Location = new System.Drawing.Point(233, 427);
            this.exileVerifyButton.Name = "exileVerifyButton";
            this.exileVerifyButton.Size = new System.Drawing.Size(75, 23);
            this.exileVerifyButton.TabIndex = 23;
            this.exileVerifyButton.Text = "VERIFY";
            this.exileVerifyButton.UseVisualStyleBackColor = true;
            this.exileVerifyButton.Click += new System.EventHandler(this.exileVerifyButton_Click);
            // 
            // exileModLabel
            // 
            this.exileModLabel.AutoSize = true;
            this.exileModLabel.BackColor = System.Drawing.Color.White;
            this.exileModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.exileModLabel.Location = new System.Drawing.Point(29, 430);
            this.exileModLabel.Name = "exileModLabel";
            this.exileModLabel.Size = new System.Drawing.Size(45, 20);
            this.exileModLabel.TabIndex = 22;
            this.exileModLabel.Text = "Exile";
            // 
            // aiaDownloadButton
            // 
            this.aiaDownloadButton.Location = new System.Drawing.Point(343, 398);
            this.aiaDownloadButton.Name = "aiaDownloadButton";
            this.aiaDownloadButton.Size = new System.Drawing.Size(94, 23);
            this.aiaDownloadButton.TabIndex = 21;
            this.aiaDownloadButton.Text = "DOWNLOAD";
            this.aiaDownloadButton.UseVisualStyleBackColor = true;
            // 
            // usafDownloadButton
            // 
            this.usafDownloadButton.Location = new System.Drawing.Point(343, 370);
            this.usafDownloadButton.Name = "usafDownloadButton";
            this.usafDownloadButton.Size = new System.Drawing.Size(94, 23);
            this.usafDownloadButton.TabIndex = 20;
            this.usafDownloadButton.Text = "DOWNLOAD";
            this.usafDownloadButton.UseVisualStyleBackColor = true;
            // 
            // afrfDownloadButton
            // 
            this.afrfDownloadButton.Location = new System.Drawing.Point(343, 342);
            this.afrfDownloadButton.Name = "afrfDownloadButton";
            this.afrfDownloadButton.Size = new System.Drawing.Size(94, 23);
            this.afrfDownloadButton.TabIndex = 19;
            this.afrfDownloadButton.Text = "DOWNLOAD";
            this.afrfDownloadButton.UseVisualStyleBackColor = true;
            // 
            // taviDownloadButton
            // 
            this.taviDownloadButton.Location = new System.Drawing.Point(343, 314);
            this.taviDownloadButton.Name = "taviDownloadButton";
            this.taviDownloadButton.Size = new System.Drawing.Size(94, 23);
            this.taviDownloadButton.TabIndex = 18;
            this.taviDownloadButton.Text = "DOWNLOAD";
            this.taviDownloadButton.UseVisualStyleBackColor = true;
            // 
            // cupDownloadButton
            // 
            this.cupDownloadButton.Location = new System.Drawing.Point(343, 286);
            this.cupDownloadButton.Name = "cupDownloadButton";
            this.cupDownloadButton.Size = new System.Drawing.Size(94, 23);
            this.cupDownloadButton.TabIndex = 17;
            this.cupDownloadButton.Text = "DOWNLOAD";
            this.cupDownloadButton.UseVisualStyleBackColor = true;
            // 
            // asdgDownloadButton
            // 
            this.asdgDownloadButton.Location = new System.Drawing.Point(343, 258);
            this.asdgDownloadButton.Name = "asdgDownloadButton";
            this.asdgDownloadButton.Size = new System.Drawing.Size(94, 23);
            this.asdgDownloadButton.TabIndex = 16;
            this.asdgDownloadButton.Text = "DOWNLOAD";
            this.asdgDownloadButton.UseVisualStyleBackColor = true;
            // 
            // aiaVerifyButton
            // 
            this.aiaVerifyButton.Location = new System.Drawing.Point(233, 398);
            this.aiaVerifyButton.Name = "aiaVerifyButton";
            this.aiaVerifyButton.Size = new System.Drawing.Size(75, 23);
            this.aiaVerifyButton.TabIndex = 15;
            this.aiaVerifyButton.Text = "VERIFY";
            this.aiaVerifyButton.UseVisualStyleBackColor = true;
            this.aiaVerifyButton.Click += new System.EventHandler(this.aiaVerifyButton_Click);
            // 
            // usafVerifyButton
            // 
            this.usafVerifyButton.Location = new System.Drawing.Point(233, 370);
            this.usafVerifyButton.Name = "usafVerifyButton";
            this.usafVerifyButton.Size = new System.Drawing.Size(75, 23);
            this.usafVerifyButton.TabIndex = 14;
            this.usafVerifyButton.Text = "VERIFY";
            this.usafVerifyButton.UseVisualStyleBackColor = true;
            this.usafVerifyButton.Click += new System.EventHandler(this.usafVerifyButton_Click);
            // 
            // afrfVerifyButton
            // 
            this.afrfVerifyButton.Location = new System.Drawing.Point(233, 342);
            this.afrfVerifyButton.Name = "afrfVerifyButton";
            this.afrfVerifyButton.Size = new System.Drawing.Size(75, 23);
            this.afrfVerifyButton.TabIndex = 13;
            this.afrfVerifyButton.Text = "VERIFY";
            this.afrfVerifyButton.UseVisualStyleBackColor = true;
            this.afrfVerifyButton.Click += new System.EventHandler(this.afrfVerifyButton_Click);
            // 
            // taviVerifyButton
            // 
            this.taviVerifyButton.Location = new System.Drawing.Point(233, 314);
            this.taviVerifyButton.Name = "taviVerifyButton";
            this.taviVerifyButton.Size = new System.Drawing.Size(75, 23);
            this.taviVerifyButton.TabIndex = 12;
            this.taviVerifyButton.Text = "VERIFY";
            this.taviVerifyButton.UseVisualStyleBackColor = true;
            this.taviVerifyButton.Click += new System.EventHandler(this.taviVerifyButton_Click);
            // 
            // cupVerifyButton
            // 
            this.cupVerifyButton.Location = new System.Drawing.Point(233, 286);
            this.cupVerifyButton.Name = "cupVerifyButton";
            this.cupVerifyButton.Size = new System.Drawing.Size(75, 23);
            this.cupVerifyButton.TabIndex = 11;
            this.cupVerifyButton.Text = "VERIFY";
            this.cupVerifyButton.UseVisualStyleBackColor = true;
            this.cupVerifyButton.Click += new System.EventHandler(this.cupVerifyButton_Click);
            // 
            // asdgVerifyButton
            // 
            this.asdgVerifyButton.Location = new System.Drawing.Point(233, 258);
            this.asdgVerifyButton.Name = "asdgVerifyButton";
            this.asdgVerifyButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.asdgVerifyButton.Size = new System.Drawing.Size(75, 23);
            this.asdgVerifyButton.TabIndex = 10;
            this.asdgVerifyButton.Text = "VERIFY";
            this.asdgVerifyButton.UseVisualStyleBackColor = true;
            this.asdgVerifyButton.Click += new System.EventHandler(this.asdgVerifyButton_Click);
            // 
            // asdgModLabel
            // 
            this.asdgModLabel.AutoSize = true;
            this.asdgModLabel.BackColor = System.Drawing.Color.White;
            this.asdgModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.asdgModLabel.Location = new System.Drawing.Point(29, 261);
            this.asdgModLabel.Name = "asdgModLabel";
            this.asdgModLabel.Size = new System.Drawing.Size(141, 20);
            this.asdgModLabel.TabIndex = 9;
            this.asdgModLabel.Text = "ASDG Joint Rails";
            // 
            // aiaModLabel
            // 
            this.aiaModLabel.AutoSize = true;
            this.aiaModLabel.BackColor = System.Drawing.Color.White;
            this.aiaModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.aiaModLabel.Location = new System.Drawing.Point(29, 401);
            this.aiaModLabel.Name = "aiaModLabel";
            this.aiaModLabel.Size = new System.Drawing.Size(149, 20);
            this.aiaModLabel.TabIndex = 8;
            this.aiaModLabel.Text = "All in Arma Terrian";
            // 
            // usafModLabel
            // 
            this.usafModLabel.AutoSize = true;
            this.usafModLabel.BackColor = System.Drawing.Color.White;
            this.usafModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.usafModLabel.Location = new System.Drawing.Point(29, 373);
            this.usafModLabel.Name = "usafModLabel";
            this.usafModLabel.Size = new System.Drawing.Size(94, 20);
            this.usafModLabel.TabIndex = 7;
            this.usafModLabel.Text = "RHS USAF";
            // 
            // afrfModLabel
            // 
            this.afrfModLabel.AutoSize = true;
            this.afrfModLabel.BackColor = System.Drawing.Color.White;
            this.afrfModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.afrfModLabel.Location = new System.Drawing.Point(29, 345);
            this.afrfModLabel.Name = "afrfModLabel";
            this.afrfModLabel.Size = new System.Drawing.Size(93, 20);
            this.afrfModLabel.TabIndex = 6;
            this.afrfModLabel.Text = "RHS AFRF";
            // 
            // taviModLabel
            // 
            this.taviModLabel.AutoSize = true;
            this.taviModLabel.BackColor = System.Drawing.Color.White;
            this.taviModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.taviModLabel.Location = new System.Drawing.Point(29, 317);
            this.taviModLabel.Name = "taviModLabel";
            this.taviModLabel.Size = new System.Drawing.Size(129, 20);
            this.taviModLabel.TabIndex = 5;
            this.taviModLabel.Text = "Taviana A3 Map";
            // 
            // cupModLabel
            // 
            this.cupModLabel.AutoSize = true;
            this.cupModLabel.BackColor = System.Drawing.Color.White;
            this.cupModLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cupModLabel.Location = new System.Drawing.Point(29, 289);
            this.cupModLabel.Name = "cupModLabel";
            this.cupModLabel.Size = new System.Drawing.Size(119, 20);
            this.cupModLabel.TabIndex = 4;
            this.cupModLabel.Text = "CUP Weapons";
            // 
            // armaPath
            // 
            this.armaPath.AutoSize = true;
            this.armaPath.BackColor = System.Drawing.Color.Green;
            this.armaPath.ForeColor = System.Drawing.Color.White;
            this.armaPath.Location = new System.Drawing.Point(193, 37);
            this.armaPath.Name = "armaPath";
            this.armaPath.Size = new System.Drawing.Size(115, 13);
            this.armaPath.TabIndex = 0;
            this.armaPath.Text = "Arma Path Placeholder";
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(521, 547);
            this.Controls.Add(this.mainTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Legion ARMA Launcher";
            this.mainTabControl.ResumeLayout(false);
            this.servers.ResumeLayout(false);
            this.servers.PerformLayout();
            this.mods.ResumeLayout(false);
            this.mods.PerformLayout();
            this.ResumeLayout(false);

        }
        #endregion
        
        
        private System.Windows.Forms.TabPage servers;
        private System.Windows.Forms.TabControl mainTabControl;
        private System.Windows.Forms.TabPage mods;
        private System.Windows.Forms.Label armaPath;
        private System.Windows.Forms.Label serverNamePlaceholder;
        private System.Windows.Forms.Label playersPlaceholder;
        private System.Windows.Forms.Button serverOneLaunchButton;
        private System.Windows.Forms.Label aiaModLabel;
        private System.Windows.Forms.Label usafModLabel;
        private System.Windows.Forms.Label afrfModLabel;
        private System.Windows.Forms.Label taviModLabel;
        private System.Windows.Forms.Label cupModLabel;
        private System.Windows.Forms.Label asdgModLabel;
        private System.Windows.Forms.Button aiaDownloadButton;
        private System.Windows.Forms.Button usafDownloadButton;
        private System.Windows.Forms.Button afrfDownloadButton;
        private System.Windows.Forms.Button taviDownloadButton;
        private System.Windows.Forms.Button cupDownloadButton;
        private System.Windows.Forms.Button asdgDownloadButton;
        private System.Windows.Forms.Button aiaVerifyButton;
        private System.Windows.Forms.Button usafVerifyButton;
        private System.Windows.Forms.Button afrfVerifyButton;
        private System.Windows.Forms.Button taviVerifyButton;
        private System.Windows.Forms.Button cupVerifyButton;
        private System.Windows.Forms.Button asdgVerifyButton;
        private System.Windows.Forms.Button exileDownloadButton;
        private System.Windows.Forms.Button exileVerifyButton;
        private System.Windows.Forms.Label exileModLabel;
    }
}

