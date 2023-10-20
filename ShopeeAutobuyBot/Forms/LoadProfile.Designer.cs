﻿using System.Drawing;
using System.Windows.Forms;

namespace Shopee_Autobuy_Bot
{
    partial class Profile
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            btnLoadProfile=new Button();
            btnDeleteProfile=new Button();
            darkLabel1=new Label();
            darkComboBoxProfile=new ComboBox();
            darkSectionPanel1=new GroupBox();
            darkCheckBoxRedeemShopeeVoucher=new CheckBox();
            darkCheckBoxClaimShopVoucher=new CheckBox();
            darkCheckBoxRedeemCoin=new CheckBox();
            darkSectionPanelPaymentDetails=new GroupBox();
            darkComboBoxPaymentMethod=new ComboBox();
            darkComboBoxBankType=new ComboBox();
            darkLabel14=new Label();
            tbLast4Digit=new TextBox();
            darkLabel6=new Label();
            darkLabel8=new Label();
            darkTextBoxShopeePayPin=new TextBox();
            darkLabel7=new Label();
            darkSectionPanelBuyingMode=new GroupBox();
            tbBelowSpecificPriceCARTCHECKOUTPrice=new TextBox();
            tbPriceSpecific=new TextBox();
            radioButtonPriceSpecific_CartCheckout=new RadioButton();
            radioButtonCheckOutCart=new RadioButton();
            radioButtonShockingSale=new RadioButton();
            radioButtonBuyNormal=new RadioButton();
            radioButtonPriceSpecific=new RadioButton();
            darkSectionPanelBotSettings=new GroupBox();
            numericUpDownTimeOut=new NumericUpDown();
            numericUpDownRefreshInterval=new NumericUpDown();
            darkCheckBoxNotifyTelegram=new CheckBox();
            checkBoxDesktopNotification=new CheckBox();
            darkCheckBoxTestMode=new CheckBox();
            darkCheckBoxLogging=new CheckBox();
            darkCheckBoxRefresh=new CheckBox();
            darkLabel5=new Label();
            darkLabel4=new Label();
            darkLabel13=new Label();
            darkSectionPanelProductDetails=new GroupBox();
            numericUpDownQuantity=new NumericUpDown();
            cbVariantPreSelected=new CheckBox();
            cbRandom=new CheckBox();
            darkLabel11=new Label();
            darkTextBoxProductLink=new TextBox();
            darkLabel10=new Label();
            darkTextBoxVariationString=new TextBox();
            darkLabel9=new Label();
            darkSectionPanelTimerMode=new GroupBox();
            label2=new Label();
            label1=new Label();
            numericUpDownSecond=new NumericUpDown();
            numericUpDownMinute=new NumericUpDown();
            numericUpDownHour=new NumericUpDown();
            darkCheckBoxTomorrow=new CheckBox();
            darkCheckBoxScheduleBot=new CheckBox();
            darkLabel12=new Label();
            btnUpdateProfile=new Button();
            groupBox1=new GroupBox();
            label4=new Label();
            tbTelegramChatId=new TextBox();
            label3=new Label();
            tbTelegramApiToken=new TextBox();
            groupBox5=new GroupBox();
            groupBox6=new GroupBox();
            label5=new Label();
            tbNewProfileName=new TextBox();
            btnCreateNewProfile=new Button();
            tabControl1=new TabControl();
            tabPage1=new TabPage();
            tabPage2=new TabPage();
            darkSectionPanel1.SuspendLayout();
            darkSectionPanelPaymentDetails.SuspendLayout();
            darkSectionPanelBuyingMode.SuspendLayout();
            darkSectionPanelBotSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeOut).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRefreshInterval).BeginInit();
            darkSectionPanelProductDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).BeginInit();
            darkSectionPanelTimerMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).BeginInit();
            groupBox1.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox6.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // btnLoadProfile
            // 
            btnLoadProfile.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnLoadProfile.Location=new Point(28, 81);
            btnLoadProfile.Margin=new Padding(2);
            btnLoadProfile.Name="btnLoadProfile";
            btnLoadProfile.Size=new Size(123, 24);
            btnLoadProfile.TabIndex=103;
            btnLoadProfile.Text="Load profile";
            btnLoadProfile.Click+=btnLoadProfile_Click;
            // 
            // btnDeleteProfile
            // 
            btnDeleteProfile.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDeleteProfile.Location=new Point(28, 139);
            btnDeleteProfile.Margin=new Padding(2);
            btnDeleteProfile.Name="btnDeleteProfile";
            btnDeleteProfile.Size=new Size(123, 24);
            btnDeleteProfile.TabIndex=104;
            btnDeleteProfile.Text="Delete profile";
            btnDeleteProfile.Click+=btnDeleteProfile_Click;
            // 
            // darkLabel1
            // 
            darkLabel1.AutoSize=true;
            darkLabel1.ForeColor=SystemColors.ControlText;
            darkLabel1.Location=new Point(28, 32);
            darkLabel1.Margin=new Padding(2, 0, 2, 0);
            darkLabel1.Name="darkLabel1";
            darkLabel1.Size=new Size(78, 15);
            darkLabel1.TabIndex=108;
            darkLabel1.Text="Select profile:";
            // 
            // darkComboBoxProfile
            // 
            darkComboBoxProfile.DropDownStyle=ComboBoxStyle.DropDownList;
            darkComboBoxProfile.FormattingEnabled=true;
            darkComboBoxProfile.Location=new Point(28, 50);
            darkComboBoxProfile.Margin=new Padding(2, 3, 2, 3);
            darkComboBoxProfile.Name="darkComboBoxProfile";
            darkComboBoxProfile.Size=new Size(197, 23);
            darkComboBoxProfile.TabIndex=107;
            darkComboBoxProfile.SelectedIndexChanged+=darkComboBoxProfile_SelectedIndexChanged;
            // 
            // darkSectionPanel1
            // 
            darkSectionPanel1.Controls.Add(darkCheckBoxRedeemShopeeVoucher);
            darkSectionPanel1.Controls.Add(darkCheckBoxClaimShopVoucher);
            darkSectionPanel1.Controls.Add(darkCheckBoxRedeemCoin);
            darkSectionPanel1.Location=new Point(357, 15);
            darkSectionPanel1.Name="darkSectionPanel1";
            darkSectionPanel1.Size=new Size(342, 111);
            darkSectionPanel1.TabIndex=114;
            darkSectionPanel1.TabStop=false;
            darkSectionPanel1.Text="Voucher && coin";
            // 
            // darkCheckBoxRedeemShopeeVoucher
            // 
            darkCheckBoxRedeemShopeeVoucher.AutoSize=true;
            darkCheckBoxRedeemShopeeVoucher.Location=new Point(82, 53);
            darkCheckBoxRedeemShopeeVoucher.Margin=new Padding(2, 3, 2, 3);
            darkCheckBoxRedeemShopeeVoucher.Name="darkCheckBoxRedeemShopeeVoucher";
            darkCheckBoxRedeemShopeeVoucher.Size=new Size(179, 19);
            darkCheckBoxRedeemShopeeVoucher.TabIndex=52;
            darkCheckBoxRedeemShopeeVoucher.Text="Redeem any Shopee voucher";
            // 
            // darkCheckBoxClaimShopVoucher
            // 
            darkCheckBoxClaimShopVoucher.AutoSize=true;
            darkCheckBoxClaimShopVoucher.Location=new Point(82, 28);
            darkCheckBoxClaimShopVoucher.Margin=new Padding(2);
            darkCheckBoxClaimShopVoucher.Name="darkCheckBoxClaimShopVoucher";
            darkCheckBoxClaimShopVoucher.Size=new Size(154, 19);
            darkCheckBoxClaimShopVoucher.TabIndex=50;
            darkCheckBoxClaimShopVoucher.Text="Claim any shop voucher";
            // 
            // darkCheckBoxRedeemCoin
            // 
            darkCheckBoxRedeemCoin.AutoSize=true;
            darkCheckBoxRedeemCoin.Location=new Point(82, 78);
            darkCheckBoxRedeemCoin.Margin=new Padding(2, 3, 2, 3);
            darkCheckBoxRedeemCoin.Name="darkCheckBoxRedeemCoin";
            darkCheckBoxRedeemCoin.Size=new Size(95, 19);
            darkCheckBoxRedeemCoin.TabIndex=42;
            darkCheckBoxRedeemCoin.Text="Redeem coin";
            // 
            // darkSectionPanelPaymentDetails
            // 
            darkSectionPanelPaymentDetails.Controls.Add(darkComboBoxPaymentMethod);
            darkSectionPanelPaymentDetails.Controls.Add(darkComboBoxBankType);
            darkSectionPanelPaymentDetails.Controls.Add(darkLabel14);
            darkSectionPanelPaymentDetails.Controls.Add(tbLast4Digit);
            darkSectionPanelPaymentDetails.Controls.Add(darkLabel6);
            darkSectionPanelPaymentDetails.Controls.Add(darkLabel8);
            darkSectionPanelPaymentDetails.Controls.Add(darkTextBoxShopeePayPin);
            darkSectionPanelPaymentDetails.Controls.Add(darkLabel7);
            darkSectionPanelPaymentDetails.Location=new Point(11, 131);
            darkSectionPanelPaymentDetails.Margin=new Padding(2, 3, 2, 3);
            darkSectionPanelPaymentDetails.Name="darkSectionPanelPaymentDetails";
            darkSectionPanelPaymentDetails.Size=new Size(342, 138);
            darkSectionPanelPaymentDetails.TabIndex=113;
            darkSectionPanelPaymentDetails.TabStop=false;
            darkSectionPanelPaymentDetails.Text="Payment Details";
            // 
            // darkComboBoxPaymentMethod
            // 
            darkComboBoxPaymentMethod.DropDownStyle=ComboBoxStyle.DropDownList;
            darkComboBoxPaymentMethod.FormattingEnabled=true;
            darkComboBoxPaymentMethod.Items.AddRange(new object[] { "Default", "Credit / Debit Card", "ATM / Cash Deposit", "Online Banking", "ShopeePay", "Cash on Delivery", "7-Eleven", "KK Mart" });
            darkComboBoxPaymentMethod.Location=new Point(142, 25);
            darkComboBoxPaymentMethod.Margin=new Padding(2, 3, 2, 3);
            darkComboBoxPaymentMethod.Name="darkComboBoxPaymentMethod";
            darkComboBoxPaymentMethod.Size=new Size(191, 23);
            darkComboBoxPaymentMethod.TabIndex=116;
            // 
            // darkComboBoxBankType
            // 
            darkComboBoxBankType.DropDownStyle=ComboBoxStyle.DropDownList;
            darkComboBoxBankType.FormattingEnabled=true;
            darkComboBoxBankType.Items.AddRange(new object[] { "Maybank2u", "CIMB Clicks", "Public Bank", "RHB Now", "Ambank", "MyBSN", "Bank Rakyat", "UOB", "Affin Bank", "Bank Islam", "HSBC Online", "Standard Chartered Bank", "Kuwait Finance House", "Bank Muamalat", "OCBC Online", "Alliance Bank (Personal)", "Hong Leong Connect" });
            darkComboBoxBankType.Location=new Point(142, 50);
            darkComboBoxBankType.Margin=new Padding(2, 3, 2, 3);
            darkComboBoxBankType.Name="darkComboBoxBankType";
            darkComboBoxBankType.Size=new Size(191, 23);
            darkComboBoxBankType.TabIndex=117;
            // 
            // darkLabel14
            // 
            darkLabel14.AutoSize=true;
            darkLabel14.ForeColor=SystemColors.ControlText;
            darkLabel14.Location=new Point(9, 79);
            darkLabel14.Margin=new Padding(2, 0, 2, 0);
            darkLabel14.Name="darkLabel14";
            darkLabel14.Size=new Size(175, 15);
            darkLabel14.TabIndex=51;
            darkLabel14.Text="Last 4 digit of debit/credit card :";
            // 
            // tbLast4Digit
            // 
            tbLast4Digit.Location=new Point(212, 75);
            tbLast4Digit.Margin=new Padding(2, 3, 2, 3);
            tbLast4Digit.MaxLength=4;
            tbLast4Digit.Name="tbLast4Digit";
            tbLast4Digit.Size=new Size(121, 23);
            tbLast4Digit.TabIndex=50;
            tbLast4Digit.TextAlign=HorizontalAlignment.Center;
            // 
            // darkLabel6
            // 
            darkLabel6.AutoSize=true;
            darkLabel6.ForeColor=SystemColors.ControlText;
            darkLabel6.Location=new Point(9, 29);
            darkLabel6.Margin=new Padding(2, 0, 2, 0);
            darkLabel6.Name="darkLabel6";
            darkLabel6.Size=new Size(105, 15);
            darkLabel6.TabIndex=14;
            darkLabel6.Text="Payment method :";
            // 
            // darkLabel8
            // 
            darkLabel8.AutoSize=true;
            darkLabel8.ForeColor=SystemColors.ControlText;
            darkLabel8.Location=new Point(9, 54);
            darkLabel8.Margin=new Padding(2, 0, 2, 0);
            darkLabel8.Name="darkLabel8";
            darkLabel8.Size=new Size(65, 15);
            darkLabel8.TabIndex=31;
            darkLabel8.Text="Bank type :";
            // 
            // darkTextBoxShopeePayPin
            // 
            darkTextBoxShopeePayPin.Location=new Point(212, 100);
            darkTextBoxShopeePayPin.Margin=new Padding(2, 3, 2, 3);
            darkTextBoxShopeePayPin.MaxLength=6;
            darkTextBoxShopeePayPin.Name="darkTextBoxShopeePayPin";
            darkTextBoxShopeePayPin.Size=new Size(121, 23);
            darkTextBoxShopeePayPin.TabIndex=13;
            darkTextBoxShopeePayPin.TextAlign=HorizontalAlignment.Center;
            // 
            // darkLabel7
            // 
            darkLabel7.AutoSize=true;
            darkLabel7.ForeColor=SystemColors.ControlText;
            darkLabel7.Location=new Point(9, 104);
            darkLabel7.Margin=new Padding(2, 0, 2, 0);
            darkLabel7.Name="darkLabel7";
            darkLabel7.Size=new Size(93, 15);
            darkLabel7.TabIndex=15;
            darkLabel7.Text="ShopeePay PIN :";
            // 
            // darkSectionPanelBuyingMode
            // 
            darkSectionPanelBuyingMode.Controls.Add(tbBelowSpecificPriceCARTCHECKOUTPrice);
            darkSectionPanelBuyingMode.Controls.Add(tbPriceSpecific);
            darkSectionPanelBuyingMode.Controls.Add(radioButtonPriceSpecific_CartCheckout);
            darkSectionPanelBuyingMode.Controls.Add(radioButtonCheckOutCart);
            darkSectionPanelBuyingMode.Controls.Add(radioButtonShockingSale);
            darkSectionPanelBuyingMode.Controls.Add(radioButtonBuyNormal);
            darkSectionPanelBuyingMode.Controls.Add(radioButtonPriceSpecific);
            darkSectionPanelBuyingMode.Location=new Point(11, 15);
            darkSectionPanelBuyingMode.Margin=new Padding(2, 3, 2, 3);
            darkSectionPanelBuyingMode.Name="darkSectionPanelBuyingMode";
            darkSectionPanelBuyingMode.Size=new Size(342, 111);
            darkSectionPanelBuyingMode.TabIndex=112;
            darkSectionPanelBuyingMode.TabStop=false;
            darkSectionPanelBuyingMode.Text="Buy Mode";
            // 
            // tbBelowSpecificPriceCARTCHECKOUTPrice
            // 
            tbBelowSpecificPriceCARTCHECKOUTPrice.Location=new Point(265, 73);
            tbBelowSpecificPriceCARTCHECKOUTPrice.Margin=new Padding(2, 3, 2, 3);
            tbBelowSpecificPriceCARTCHECKOUTPrice.Name="tbBelowSpecificPriceCARTCHECKOUTPrice";
            tbBelowSpecificPriceCARTCHECKOUTPrice.Size=new Size(67, 23);
            tbBelowSpecificPriceCARTCHECKOUTPrice.TabIndex=54;
            tbBelowSpecificPriceCARTCHECKOUTPrice.TextAlign=HorizontalAlignment.Center;
            // 
            // tbPriceSpecific
            // 
            tbPriceSpecific.Location=new Point(265, 48);
            tbPriceSpecific.Margin=new Padding(2, 3, 2, 3);
            tbPriceSpecific.Name="tbPriceSpecific";
            tbPriceSpecific.Size=new Size(67, 23);
            tbPriceSpecific.TabIndex=50;
            tbPriceSpecific.TextAlign=HorizontalAlignment.Center;
            // 
            // radioButtonPriceSpecific_CartCheckout
            // 
            radioButtonPriceSpecific_CartCheckout.AutoSize=true;
            radioButtonPriceSpecific_CartCheckout.ForeColor=SystemColors.ControlText;
            radioButtonPriceSpecific_CartCheckout.Location=new Point(11, 75);
            radioButtonPriceSpecific_CartCheckout.Margin=new Padding(2, 3, 2, 3);
            radioButtonPriceSpecific_CartCheckout.Name="radioButtonPriceSpecific_CartCheckout";
            radioButtonPriceSpecific_CartCheckout.Size=new Size(220, 19);
            radioButtonPriceSpecific_CartCheckout.TabIndex=53;
            radioButtonPriceSpecific_CartCheckout.Text="Below specific price (Cart checkout) :";
            // 
            // radioButtonCheckOutCart
            // 
            radioButtonCheckOutCart.AutoSize=true;
            radioButtonCheckOutCart.ForeColor=SystemColors.ControlText;
            radioButtonCheckOutCart.Location=new Point(11, 50);
            radioButtonCheckOutCart.Margin=new Padding(2, 3, 2, 3);
            radioButtonCheckOutCart.Name="radioButtonCheckOutCart";
            radioButtonCheckOutCart.Size=new Size(99, 19);
            radioButtonCheckOutCart.TabIndex=52;
            radioButtonCheckOutCart.Text="Cart checkout";
            // 
            // radioButtonShockingSale
            // 
            radioButtonShockingSale.AutoSize=true;
            radioButtonShockingSale.ForeColor=SystemColors.ControlText;
            radioButtonShockingSale.Location=new Point(130, 24);
            radioButtonShockingSale.Margin=new Padding(2, 3, 2, 3);
            radioButtonShockingSale.Name="radioButtonShockingSale";
            radioButtonShockingSale.Size=new Size(163, 19);
            radioButtonShockingSale.TabIndex=51;
            radioButtonShockingSale.Text="Flash/Shocking sale mode";
            // 
            // radioButtonBuyNormal
            // 
            radioButtonBuyNormal.AutoSize=true;
            radioButtonBuyNormal.Checked=true;
            radioButtonBuyNormal.ForeColor=SystemColors.ControlText;
            radioButtonBuyNormal.Location=new Point(11, 24);
            radioButtonBuyNormal.Margin=new Padding(2, 3, 2, 3);
            radioButtonBuyNormal.Name="radioButtonBuyNormal";
            radioButtonBuyNormal.Size=new Size(99, 19);
            radioButtonBuyNormal.TabIndex=50;
            radioButtonBuyNormal.TabStop=true;
            radioButtonBuyNormal.Text="Normal mode";
            // 
            // radioButtonPriceSpecific
            // 
            radioButtonPriceSpecific.AutoSize=true;
            radioButtonPriceSpecific.ForeColor=SystemColors.ControlText;
            radioButtonPriceSpecific.Location=new Point(130, 50);
            radioButtonPriceSpecific.Margin=new Padding(2, 3, 2, 3);
            radioButtonPriceSpecific.Name="radioButtonPriceSpecific";
            radioButtonPriceSpecific.Size=new Size(135, 19);
            radioButtonPriceSpecific.TabIndex=15;
            radioButtonPriceSpecific.Text="Below specific price :";
            // 
            // darkSectionPanelBotSettings
            // 
            darkSectionPanelBotSettings.Controls.Add(numericUpDownTimeOut);
            darkSectionPanelBotSettings.Controls.Add(numericUpDownRefreshInterval);
            darkSectionPanelBotSettings.Controls.Add(darkCheckBoxNotifyTelegram);
            darkSectionPanelBotSettings.Controls.Add(checkBoxDesktopNotification);
            darkSectionPanelBotSettings.Controls.Add(darkCheckBoxTestMode);
            darkSectionPanelBotSettings.Controls.Add(darkCheckBoxLogging);
            darkSectionPanelBotSettings.Controls.Add(darkCheckBoxRefresh);
            darkSectionPanelBotSettings.Controls.Add(darkLabel5);
            darkSectionPanelBotSettings.Controls.Add(darkLabel4);
            darkSectionPanelBotSettings.Controls.Add(darkLabel13);
            darkSectionPanelBotSettings.Location=new Point(184, 15);
            darkSectionPanelBotSettings.Margin=new Padding(2, 3, 2, 3);
            darkSectionPanelBotSettings.Name="darkSectionPanelBotSettings";
            darkSectionPanelBotSettings.Size=new Size(343, 254);
            darkSectionPanelBotSettings.TabIndex=111;
            darkSectionPanelBotSettings.TabStop=false;
            darkSectionPanelBotSettings.Text="Bot Settings";
            // 
            // numericUpDownTimeOut
            // 
            numericUpDownTimeOut.BackColor=SystemColors.Window;
            numericUpDownTimeOut.ForeColor=SystemColors.ControlText;
            numericUpDownTimeOut.Location=new Point(122, 209);
            numericUpDownTimeOut.Margin=new Padding(2, 3, 2, 3);
            numericUpDownTimeOut.Maximum=new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownTimeOut.Name="numericUpDownTimeOut";
            numericUpDownTimeOut.Size=new Size(38, 23);
            numericUpDownTimeOut.TabIndex=56;
            numericUpDownTimeOut.Value=new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // numericUpDownRefreshInterval
            // 
            numericUpDownRefreshInterval.BackColor=SystemColors.Window;
            numericUpDownRefreshInterval.ForeColor=SystemColors.ControlText;
            numericUpDownRefreshInterval.Location=new Point(244, 106);
            numericUpDownRefreshInterval.Margin=new Padding(2, 3, 2, 3);
            numericUpDownRefreshInterval.Maximum=new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownRefreshInterval.Name="numericUpDownRefreshInterval";
            numericUpDownRefreshInterval.Size=new Size(38, 23);
            numericUpDownRefreshInterval.TabIndex=55;
            numericUpDownRefreshInterval.Value=new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // darkCheckBoxNotifyTelegram
            // 
            darkCheckBoxNotifyTelegram.AutoSize=true;
            darkCheckBoxNotifyTelegram.Location=new Point(15, 38);
            darkCheckBoxNotifyTelegram.Margin=new Padding(2);
            darkCheckBoxNotifyTelegram.Name="darkCheckBoxNotifyTelegram";
            darkCheckBoxNotifyTelegram.Size=new Size(307, 19);
            darkCheckBoxNotifyTelegram.TabIndex=54;
            darkCheckBoxNotifyTelegram.Text="Send notification to Telegram on successful checkout";
            // 
            // checkBoxDesktopNotification
            // 
            checkBoxDesktopNotification.AutoSize=true;
            checkBoxDesktopNotification.Location=new Point(15, 73);
            checkBoxDesktopNotification.Margin=new Padding(2);
            checkBoxDesktopNotification.Name="checkBoxDesktopNotification";
            checkBoxDesktopNotification.Size=new Size(290, 19);
            checkBoxDesktopNotification.TabIndex=53;
            checkBoxDesktopNotification.Text="Show desktop notification on successful checkout";
            // 
            // darkCheckBoxTestMode
            // 
            darkCheckBoxTestMode.AutoSize=true;
            darkCheckBoxTestMode.Location=new Point(15, 178);
            darkCheckBoxTestMode.Margin=new Padding(2);
            darkCheckBoxTestMode.Name="darkCheckBoxTestMode";
            darkCheckBoxTestMode.Size=new Size(80, 19);
            darkCheckBoxTestMode.TabIndex=49;
            darkCheckBoxTestMode.Text="Test mode";
            // 
            // darkCheckBoxLogging
            // 
            darkCheckBoxLogging.AutoSize=true;
            darkCheckBoxLogging.Location=new Point(15, 143);
            darkCheckBoxLogging.Margin=new Padding(2);
            darkCheckBoxLogging.Name="darkCheckBoxLogging";
            darkCheckBoxLogging.Size=new Size(108, 19);
            darkCheckBoxLogging.TabIndex=50;
            darkCheckBoxLogging.Text="Disable logging";
            // 
            // darkCheckBoxRefresh
            // 
            darkCheckBoxRefresh.AutoSize=true;
            darkCheckBoxRefresh.Location=new Point(15, 108);
            darkCheckBoxRefresh.Margin=new Padding(2);
            darkCheckBoxRefresh.Name="darkCheckBoxRefresh";
            darkCheckBoxRefresh.Size=new Size(142, 19);
            darkCheckBoxRefresh.TabIndex=48;
            darkCheckBoxRefresh.Text="Auto refresh webpage";
            // 
            // darkLabel5
            // 
            darkLabel5.AutoSize=true;
            darkLabel5.ForeColor=SystemColors.ControlText;
            darkLabel5.Location=new Point(282, 110);
            darkLabel5.Margin=new Padding(2, 0, 2, 0);
            darkLabel5.Name="darkLabel5";
            darkLabel5.Size=new Size(50, 15);
            darkLabel5.TabIndex=11;
            darkLabel5.Text="seconds";
            // 
            // darkLabel4
            // 
            darkLabel4.AutoSize=true;
            darkLabel4.ForeColor=SystemColors.ControlText;
            darkLabel4.Location=new Point(167, 110);
            darkLabel4.Margin=new Padding(2, 0, 2, 0);
            darkLabel4.Name="darkLabel4";
            darkLabel4.Size=new Size(77, 15);
            darkLabel4.TabIndex=10;
            darkLabel4.Text="Refresh every";
            // 
            // darkLabel13
            // 
            darkLabel13.AutoSize=true;
            darkLabel13.ForeColor=SystemColors.ControlText;
            darkLabel13.Location=new Point(11, 213);
            darkLabel13.Margin=new Padding(2, 0, 2, 0);
            darkLabel13.Name="darkLabel13";
            darkLabel13.Size=new Size(109, 15);
            darkLabel13.TabIndex=45;
            darkLabel13.Text="Time out (second) :";
            // 
            // darkSectionPanelProductDetails
            // 
            darkSectionPanelProductDetails.Controls.Add(numericUpDownQuantity);
            darkSectionPanelProductDetails.Controls.Add(cbVariantPreSelected);
            darkSectionPanelProductDetails.Controls.Add(cbRandom);
            darkSectionPanelProductDetails.Controls.Add(darkLabel11);
            darkSectionPanelProductDetails.Controls.Add(darkTextBoxProductLink);
            darkSectionPanelProductDetails.Controls.Add(darkLabel10);
            darkSectionPanelProductDetails.Controls.Add(darkTextBoxVariationString);
            darkSectionPanelProductDetails.Controls.Add(darkLabel9);
            darkSectionPanelProductDetails.Location=new Point(357, 131);
            darkSectionPanelProductDetails.Margin=new Padding(2);
            darkSectionPanelProductDetails.Name="darkSectionPanelProductDetails";
            darkSectionPanelProductDetails.Size=new Size(342, 138);
            darkSectionPanelProductDetails.TabIndex=110;
            darkSectionPanelProductDetails.TabStop=false;
            darkSectionPanelProductDetails.Text="Product Details";
            // 
            // numericUpDownQuantity
            // 
            numericUpDownQuantity.BackColor=SystemColors.Window;
            numericUpDownQuantity.ForeColor=SystemColors.ControlText;
            numericUpDownQuantity.Location=new Point(90, 52);
            numericUpDownQuantity.Margin=new Padding(2, 3, 2, 3);
            numericUpDownQuantity.Maximum=new decimal(new int[] { 10, 0, 0, 0 });
            numericUpDownQuantity.Name="numericUpDownQuantity";
            numericUpDownQuantity.Size=new Size(38, 23);
            numericUpDownQuantity.TabIndex=117;
            numericUpDownQuantity.Value=new decimal(new int[] { 5, 0, 0, 0 });
            // 
            // cbVariantPreSelected
            // 
            cbVariantPreSelected.AutoSize=true;
            cbVariantPreSelected.Location=new Point(206, 104);
            cbVariantPreSelected.Margin=new Padding(2);
            cbVariantPreSelected.Name="cbVariantPreSelected";
            cbVariantPreSelected.Size=new Size(128, 19);
            cbVariantPreSelected.TabIndex=116;
            cbVariantPreSelected.Text="Variant pre selected";
            // 
            // cbRandom
            // 
            cbRandom.AutoSize=true;
            cbRandom.Location=new Point(90, 104);
            cbRandom.Margin=new Padding(2);
            cbRandom.Name="cbRandom";
            cbRandom.Size=new Size(110, 19);
            cbRandom.TabIndex=55;
            cbRandom.Text="Random variant";
            // 
            // darkLabel11
            // 
            darkLabel11.AutoSize=true;
            darkLabel11.ForeColor=SystemColors.ControlText;
            darkLabel11.Location=new Point(9, 32);
            darkLabel11.Margin=new Padding(2, 0, 2, 0);
            darkLabel11.Name="darkLabel11";
            darkLabel11.Size=new Size(77, 15);
            darkLabel11.TabIndex=24;
            darkLabel11.Text="Product link :";
            // 
            // darkTextBoxProductLink
            // 
            darkTextBoxProductLink.Location=new Point(90, 28);
            darkTextBoxProductLink.Margin=new Padding(2, 3, 2, 3);
            darkTextBoxProductLink.Name="darkTextBoxProductLink";
            darkTextBoxProductLink.ScrollBars=ScrollBars.Vertical;
            darkTextBoxProductLink.Size=new Size(244, 23);
            darkTextBoxProductLink.TabIndex=23;
            // 
            // darkLabel10
            // 
            darkLabel10.AutoSize=true;
            darkLabel10.ForeColor=SystemColors.ControlText;
            darkLabel10.Location=new Point(9, 56);
            darkLabel10.Margin=new Padding(2, 0, 2, 0);
            darkLabel10.Name="darkLabel10";
            darkLabel10.Size=new Size(59, 15);
            darkLabel10.TabIndex=21;
            darkLabel10.Text="Quantity :";
            // 
            // darkTextBoxVariationString
            // 
            darkTextBoxVariationString.Location=new Point(90, 77);
            darkTextBoxVariationString.Margin=new Padding(2, 3, 2, 3);
            darkTextBoxVariationString.Name="darkTextBoxVariationString";
            darkTextBoxVariationString.Size=new Size(244, 23);
            darkTextBoxVariationString.TabIndex=18;
            darkTextBoxVariationString.TextAlign=HorizontalAlignment.Center;
            // 
            // darkLabel9
            // 
            darkLabel9.AutoSize=true;
            darkLabel9.ForeColor=SystemColors.ControlText;
            darkLabel9.Location=new Point(9, 81);
            darkLabel9.Margin=new Padding(2, 0, 2, 0);
            darkLabel9.Name="darkLabel9";
            darkLabel9.Size=new Size(59, 15);
            darkLabel9.TabIndex=19;
            darkLabel9.Text="Variation :";
            // 
            // darkSectionPanelTimerMode
            // 
            darkSectionPanelTimerMode.Controls.Add(label2);
            darkSectionPanelTimerMode.Controls.Add(label1);
            darkSectionPanelTimerMode.Controls.Add(numericUpDownSecond);
            darkSectionPanelTimerMode.Controls.Add(numericUpDownMinute);
            darkSectionPanelTimerMode.Controls.Add(numericUpDownHour);
            darkSectionPanelTimerMode.Controls.Add(darkCheckBoxTomorrow);
            darkSectionPanelTimerMode.Controls.Add(darkCheckBoxScheduleBot);
            darkSectionPanelTimerMode.Controls.Add(darkLabel12);
            darkSectionPanelTimerMode.Location=new Point(11, 274);
            darkSectionPanelTimerMode.Margin=new Padding(2, 3, 2, 3);
            darkSectionPanelTimerMode.Name="darkSectionPanelTimerMode";
            darkSectionPanelTimerMode.Size=new Size(342, 110);
            darkSectionPanelTimerMode.TabIndex=109;
            darkSectionPanelTimerMode.TabStop=false;
            darkSectionPanelTimerMode.Text="Schedule Bot";
            // 
            // label2
            // 
            label2.AutoSize=true;
            label2.ForeColor=SystemColors.ControlText;
            label2.Location=new Point(123, 54);
            label2.Margin=new Padding(2, 0, 2, 0);
            label2.Name="label2";
            label2.Size=new Size(10, 15);
            label2.TabIndex=21;
            label2.Text=":";
            // 
            // label1
            // 
            label1.AutoSize=true;
            label1.ForeColor=SystemColors.ControlText;
            label1.Location=new Point(61, 54);
            label1.Margin=new Padding(2, 0, 2, 0);
            label1.Name="label1";
            label1.Size=new Size(10, 15);
            label1.TabIndex=20;
            label1.Text=":";
            // 
            // numericUpDownSecond
            // 
            numericUpDownSecond.BackColor=SystemColors.Window;
            numericUpDownSecond.ForeColor=SystemColors.ControlText;
            numericUpDownSecond.Location=new Point(140, 50);
            numericUpDownSecond.Margin=new Padding(2, 3, 2, 3);
            numericUpDownSecond.Maximum=new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownSecond.Name="numericUpDownSecond";
            numericUpDownSecond.Size=new Size(38, 23);
            numericUpDownSecond.TabIndex=19;
            // 
            // numericUpDownMinute
            // 
            numericUpDownMinute.BackColor=SystemColors.Window;
            numericUpDownMinute.ForeColor=SystemColors.ControlText;
            numericUpDownMinute.Location=new Point(78, 50);
            numericUpDownMinute.Margin=new Padding(2, 3, 2, 3);
            numericUpDownMinute.Maximum=new decimal(new int[] { 59, 0, 0, 0 });
            numericUpDownMinute.Name="numericUpDownMinute";
            numericUpDownMinute.Size=new Size(38, 23);
            numericUpDownMinute.TabIndex=18;
            // 
            // numericUpDownHour
            // 
            numericUpDownHour.BackColor=SystemColors.Window;
            numericUpDownHour.ForeColor=SystemColors.ControlText;
            numericUpDownHour.Location=new Point(16, 50);
            numericUpDownHour.Margin=new Padding(2, 3, 2, 3);
            numericUpDownHour.Maximum=new decimal(new int[] { 23, 0, 0, 0 });
            numericUpDownHour.Name="numericUpDownHour";
            numericUpDownHour.Size=new Size(38, 23);
            numericUpDownHour.TabIndex=17;
            numericUpDownHour.Value=new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // darkCheckBoxTomorrow
            // 
            darkCheckBoxTomorrow.AutoSize=true;
            darkCheckBoxTomorrow.Location=new Point(16, 80);
            darkCheckBoxTomorrow.Margin=new Padding(2, 3, 2, 3);
            darkCheckBoxTomorrow.Name="darkCheckBoxTomorrow";
            darkCheckBoxTomorrow.Size=new Size(80, 19);
            darkCheckBoxTomorrow.TabIndex=16;
            darkCheckBoxTomorrow.Text="Tomorrow";
            // 
            // darkCheckBoxScheduleBot
            // 
            darkCheckBoxScheduleBot.AutoSize=true;
            darkCheckBoxScheduleBot.Location=new Point(16, 27);
            darkCheckBoxScheduleBot.Margin=new Padding(2, 3, 2, 3);
            darkCheckBoxScheduleBot.Name="darkCheckBoxScheduleBot";
            darkCheckBoxScheduleBot.Size=new Size(310, 19);
            darkCheckBoxScheduleBot.TabIndex=15;
            darkCheckBoxScheduleBot.Text="Schedule bot to run at specific time (24-hours format)";
            // 
            // darkLabel12
            // 
            darkLabel12.AutoSize=true;
            darkLabel12.ForeColor=SystemColors.ControlText;
            darkLabel12.Location=new Point(182, 54);
            darkLabel12.Margin=new Padding(2, 0, 2, 0);
            darkLabel12.Name="darkLabel12";
            darkLabel12.Size=new Size(137, 15);
            darkLabel12.TabIndex=4;
            darkLabel12.Text="(Hour : Minute : Second)";
            // 
            // btnUpdateProfile
            // 
            btnUpdateProfile.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnUpdateProfile.Location=new Point(28, 110);
            btnUpdateProfile.Margin=new Padding(2);
            btnUpdateProfile.Name="btnUpdateProfile";
            btnUpdateProfile.Size=new Size(123, 24);
            btnUpdateProfile.TabIndex=115;
            btnUpdateProfile.Text="Update profile";
            btnUpdateProfile.Click+=btnSaveProfile_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tbTelegramChatId);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tbTelegramApiToken);
            groupBox1.Location=new Point(184, 275);
            groupBox1.Name="groupBox1";
            groupBox1.Size=new Size(343, 109);
            groupBox1.TabIndex=116;
            groupBox1.TabStop=false;
            groupBox1.Text="Telegram Settings";
            // 
            // label4
            // 
            label4.AutoSize=true;
            label4.ForeColor=SystemColors.ControlText;
            label4.Location=new Point(14, 67);
            label4.Margin=new Padding(2, 0, 2, 0);
            label4.Name="label4";
            label4.Size=new Size(51, 15);
            label4.TabIndex=28;
            label4.Text="Chat Id :";
            // 
            // tbTelegramChatId
            // 
            tbTelegramChatId.Location=new Point(95, 63);
            tbTelegramChatId.Margin=new Padding(2, 3, 2, 3);
            tbTelegramChatId.Name="tbTelegramChatId";
            tbTelegramChatId.ScrollBars=ScrollBars.Vertical;
            tbTelegramChatId.Size=new Size(233, 23);
            tbTelegramChatId.TabIndex=27;
            // 
            // label3
            // 
            label3.AutoSize=true;
            label3.ForeColor=SystemColors.ControlText;
            label3.Location=new Point(14, 38);
            label3.Margin=new Padding(2, 0, 2, 0);
            label3.Name="label3";
            label3.Size=new Size(65, 15);
            label3.TabIndex=26;
            label3.Text="Api Token :";
            // 
            // tbTelegramApiToken
            // 
            tbTelegramApiToken.Location=new Point(95, 34);
            tbTelegramApiToken.Margin=new Padding(2, 3, 2, 3);
            tbTelegramApiToken.Name="tbTelegramApiToken";
            tbTelegramApiToken.ScrollBars=ScrollBars.Vertical;
            tbTelegramApiToken.Size=new Size(233, 23);
            tbTelegramApiToken.TabIndex=25;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(darkComboBoxProfile);
            groupBox5.Controls.Add(darkLabel1);
            groupBox5.Controls.Add(btnLoadProfile);
            groupBox5.Controls.Add(btnUpdateProfile);
            groupBox5.Controls.Add(btnDeleteProfile);
            groupBox5.Location=new Point(18, 68);
            groupBox5.Margin=new Padding(2, 3, 2, 3);
            groupBox5.Name="groupBox5";
            groupBox5.Size=new Size(252, 182);
            groupBox5.TabIndex=120;
            groupBox5.TabStop=false;
            groupBox5.Text="Load Profile";
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(label5);
            groupBox6.Controls.Add(tbNewProfileName);
            groupBox6.Controls.Add(btnCreateNewProfile);
            groupBox6.Location=new Point(18, 268);
            groupBox6.Margin=new Padding(2, 3, 2, 3);
            groupBox6.Name="groupBox6";
            groupBox6.Size=new Size(252, 129);
            groupBox6.TabIndex=121;
            groupBox6.TabStop=false;
            groupBox6.Text="Create Profile";
            // 
            // label5
            // 
            label5.AutoSize=true;
            label5.ForeColor=SystemColors.ControlText;
            label5.Location=new Point(28, 31);
            label5.Margin=new Padding(2, 0, 2, 0);
            label5.Name="label5";
            label5.Size=new Size(107, 15);
            label5.TabIndex=109;
            label5.Text="New profile name :";
            // 
            // tbNewProfileName
            // 
            tbNewProfileName.Location=new Point(28, 52);
            tbNewProfileName.Margin=new Padding(2, 3, 2, 3);
            tbNewProfileName.Name="tbNewProfileName";
            tbNewProfileName.ScrollBars=ScrollBars.Vertical;
            tbNewProfileName.Size=new Size(197, 23);
            tbNewProfileName.TabIndex=105;
            // 
            // btnCreateNewProfile
            // 
            btnCreateNewProfile.Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCreateNewProfile.Location=new Point(28, 81);
            btnCreateNewProfile.Margin=new Padding(2);
            btnCreateNewProfile.Name="btnCreateNewProfile";
            btnCreateNewProfile.Size=new Size(123, 24);
            btnCreateNewProfile.TabIndex=104;
            btnCreateNewProfile.Text="Create profile";
            btnCreateNewProfile.Click+=btnCreateNewProfile_Click;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Location=new Point(286, 19);
            tabControl1.Name="tabControl1";
            tabControl1.SelectedIndex=0;
            tabControl1.Size=new Size(718, 426);
            tabControl1.TabIndex=122;
            // 
            // tabPage1
            // 
            tabPage1.BackColor=SystemColors.ActiveCaption;
            tabPage1.Controls.Add(darkSectionPanelBotSettings);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Location=new Point(4, 24);
            tabPage1.Name="tabPage1";
            tabPage1.Padding=new Padding(3);
            tabPage1.Size=new Size(710, 398);
            tabPage1.TabIndex=0;
            tabPage1.Text="Bot Settings";
            // 
            // tabPage2
            // 
            tabPage2.BackColor=SystemColors.ActiveCaption;
            tabPage2.Controls.Add(darkSectionPanelBuyingMode);
            tabPage2.Controls.Add(darkSectionPanelTimerMode);
            tabPage2.Controls.Add(darkSectionPanelPaymentDetails);
            tabPage2.Controls.Add(darkSectionPanelProductDetails);
            tabPage2.Controls.Add(darkSectionPanel1);
            tabPage2.Location=new Point(4, 24);
            tabPage2.Name="tabPage2";
            tabPage2.Padding=new Padding(3);
            tabPage2.Size=new Size(710, 398);
            tabPage2.TabIndex=1;
            tabPage2.Text="Buying Settings";
            // 
            // LoadProfile
            // 
            AutoScaleDimensions=new SizeF(7F, 15F);
            AutoScaleMode=AutoScaleMode.Font;
            BackColor=SystemColors.ActiveCaption;
            ClientSize=new Size(1022, 465);
            Controls.Add(tabControl1);
            Controls.Add(groupBox6);
            Controls.Add(groupBox5);
            Font=new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle=FormBorderStyle.FixedDialog;
            Icon=(Icon)resources.GetObject("$this.Icon");
            MaximizeBox=false;
            Name="LoadProfile";
            StartPosition=FormStartPosition.CenterScreen;
            Text="Load Profile";
            Load+=Profile_Load_1;
            darkSectionPanel1.ResumeLayout(false);
            darkSectionPanel1.PerformLayout();
            darkSectionPanelPaymentDetails.ResumeLayout(false);
            darkSectionPanelPaymentDetails.PerformLayout();
            darkSectionPanelBuyingMode.ResumeLayout(false);
            darkSectionPanelBuyingMode.PerformLayout();
            darkSectionPanelBotSettings.ResumeLayout(false);
            darkSectionPanelBotSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTimeOut).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownRefreshInterval).EndInit();
            darkSectionPanelProductDetails.ResumeLayout(false);
            darkSectionPanelProductDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantity).EndInit();
            darkSectionPanelTimerMode.ResumeLayout(false);
            darkSectionPanelTimerMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownSecond).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownMinute).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownHour).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox5.ResumeLayout(false);
            groupBox5.PerformLayout();
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Button btnLoadProfile;
        private Button btnDeleteProfile;
        private Label darkLabel1;
        private ComboBox darkComboBoxProfile;
        private GroupBox darkSectionPanel1;
        private CheckBox darkCheckBoxRedeemShopeeVoucher;
        private CheckBox darkCheckBoxClaimShopVoucher;
        private CheckBox darkCheckBoxRedeemCoin;
        private GroupBox darkSectionPanelPaymentDetails;
        private Label darkLabel14;
        private TextBox tbLast4Digit;
        private Label darkLabel6;
        private Label darkLabel8;
        private TextBox darkTextBoxShopeePayPin;
        private Label darkLabel7;
        private GroupBox darkSectionPanelBuyingMode;
        private TextBox tbBelowSpecificPriceCARTCHECKOUTPrice;
        private TextBox tbPriceSpecific;
        private RadioButton radioButtonPriceSpecific_CartCheckout;
        private RadioButton radioButtonCheckOutCart;
        private RadioButton radioButtonShockingSale;
        private RadioButton radioButtonBuyNormal;
        private RadioButton radioButtonPriceSpecific;
        private GroupBox darkSectionPanelBotSettings;
        private CheckBox darkCheckBoxTestMode;
        private CheckBox darkCheckBoxLogging;
        private CheckBox darkCheckBoxRefresh;
        private CheckBox darkCheckBoxHeadless;
        private Label darkLabel5;
        private Label darkLabel4;
        private Label darkLabel13;
        private CheckBox darkCheckBoxDisableImageExtension;
        private GroupBox darkSectionPanelProductDetails;
        private Label darkLabel11;
        private TextBox darkTextBoxProductLink;
        private Label darkLabel10;
        private TextBox darkTextBoxVariationString;
        private Label darkLabel9;
        private GroupBox darkSectionPanelTimerMode;
        private CheckBox darkCheckBoxTomorrow;
        private CheckBox darkCheckBoxScheduleBot;
        private Label darkLabel12;
        private Button btnUpdateProfile;
        private Button btnSaveProfile;
        private CheckBox cbRandom;
        private CheckBox cbVariantPreSelected;
        private CheckBox checkBoxDesktopNotification;
        private CheckBox darkCheckBoxNotifyTelegram;
        private NumericUpDown numericUpDownRefreshInterval;
        private NumericUpDown numericUpDownSecond;
        private NumericUpDown numericUpDownMinute;
        private NumericUpDown numericUpDownHour;
        private Label label2;
        private Label label1;
        private NumericUpDown numericUpDownTimeOut;
        private NumericUpDown numericUpDownQuantity;
        private ComboBox darkComboBoxPaymentMethod;
        private ComboBox darkComboBoxBankType;
        private GroupBox groupBox1;
        private Label label4;
        private TextBox tbTelegramChatId;
        private Label label3;
        private TextBox tbTelegramApiToken;
        private GroupBox groupBox4;
        private GroupBox groupBox6;
        private ComboBox comboBox1;
        private Button button1;
        private Button button2;
        private Button btnCreateNewProfile;
        private GroupBox groupBox5;
        private Label label5;
        private TextBox tbNewProfileName;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
    }
}