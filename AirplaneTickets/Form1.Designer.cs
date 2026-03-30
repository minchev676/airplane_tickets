namespace AirplaneTickets
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAddCustomer = new Button();
            dgvCustomers = new DataGridView();
            txtFirstName = new TextBox();
            txtEmail = new TextBox();
            txtLastName = new TextBox();
            txtPhone = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            labelEmail = new Label();
            tabControl1 = new TabControl();
            tabCustomers = new TabPage();
            pictureBox11 = new PictureBox();
            pictureBox10 = new PictureBox();
            tabFlights = new TabPage();
            pictureBox6 = new PictureBox();
            btnAddFlight = new Button();
            labelSeats = new Label();
            labelPrice = new Label();
            txtSeasts = new TextBox();
            txtPrice = new TextBox();
            labelArrival = new Label();
            labelDeparture = new Label();
            txtArrival = new TextBox();
            txtDeparture = new TextBox();
            labelDestination = new Label();
            txtDestination = new TextBox();
            labelOrigin = new Label();
            txtOrigin = new TextBox();
            dgvFlights = new DataGridView();
            pictureBox4 = new PictureBox();
            tabBookings = new TabPage();
            pictureBox1 = new PictureBox();
            labelSeatBooking = new Label();
            txtSeatNumber = new TextBox();
            labelFlightBooking = new Label();
            labelBookingName = new Label();
            cmbFlights = new ComboBox();
            cmbCustomers = new ComboBox();
            btnBookTicket = new Button();
            dgvBookings = new DataGridView();
            pictureBox3 = new PictureBox();
            tabAdmin = new TabPage();
            dgvFlightsAdmin = new DataGridView();
            panel3 = new Panel();
            dgvBookingsAdmin = new DataGridView();
            btnUpdateBookingStatus = new Button();
            cmbBookingStatus = new ComboBox();
            deleteBookingAdmin = new Button();
            dgvCustomersAdmin = new DataGridView();
            panel1 = new Panel();
            DeleteCustomerAdmin = new Button();
            panel2 = new Panel();
            deleteFlightAdmin = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            tabControl1.SuspendLayout();
            tabCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            tabFlights.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            tabBookings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            tabAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvFlightsAdmin).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAdmin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersAdmin).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // btnAddCustomer
            // 
            btnAddCustomer.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnAddCustomer.Location = new Point(408, 855);
            btnAddCustomer.Margin = new Padding(3, 4, 3, 4);
            btnAddCustomer.Name = "btnAddCustomer";
            btnAddCustomer.Size = new Size(387, 132);
            btnAddCustomer.TabIndex = 1;
            btnAddCustomer.Text = "Добави пътник";
            btnAddCustomer.UseVisualStyleBackColor = true;
            btnAddCustomer.Click += btnAddCustomer_Click;
            // 
            // dgvCustomers
            // 
            dgvCustomers.BackgroundColor = Color.White;
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(42, 52);
            dgvCustomers.Margin = new Padding(3, 4, 3, 4);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(1177, 635);
            dgvCustomers.TabIndex = 8;
            // 
            // txtFirstName
            // 
            txtFirstName.Font = new Font("Segoe UI", 15F);
            txtFirstName.Location = new Point(1654, 728);
            txtFirstName.Margin = new Padding(3, 4, 3, 4);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(209, 41);
            txtFirstName.TabIndex = 12;
            // 
            // txtEmail
            // 
            txtEmail.Font = new Font("Segoe UI", 15F);
            txtEmail.Location = new Point(1654, 892);
            txtEmail.Margin = new Padding(3, 4, 3, 4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(209, 41);
            txtEmail.TabIndex = 13;
            // 
            // txtLastName
            // 
            txtLastName.Font = new Font("Segoe UI", 15F);
            txtLastName.Location = new Point(1654, 812);
            txtLastName.Margin = new Padding(3, 4, 3, 4);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(209, 41);
            txtLastName.TabIndex = 14;
            // 
            // txtPhone
            // 
            txtPhone.Font = new Font("Segoe UI", 15F);
            txtPhone.Location = new Point(1654, 983);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(209, 41);
            txtPhone.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label1.Location = new Point(1551, 728);
            label1.Name = "label1";
            label1.Size = new Size(87, 40);
            label1.TabIndex = 22;
            label1.Text = "Име:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label2.Location = new Point(1487, 813);
            label2.Name = "label2";
            label2.Size = new Size(157, 40);
            label2.TabIndex = 23;
            label2.Text = "Фамилия:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            label3.Location = new Point(1497, 983);
            label3.Name = "label3";
            label3.Size = new Size(148, 40);
            label3.TabIndex = 24;
            label3.Text = "Телефон:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelEmail.Location = new Point(1519, 893);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(122, 40);
            labelEmail.TabIndex = 25;
            labelEmail.Text = "Имейл:";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabCustomers);
            tabControl1.Controls.Add(tabFlights);
            tabControl1.Controls.Add(tabBookings);
            tabControl1.Controls.Add(tabAdmin);
            tabControl1.Location = new Point(-1, 1);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2293, 1148);
            tabControl1.TabIndex = 33;
            // 
            // tabCustomers
            // 
            tabCustomers.BackColor = SystemColors.ControlDark;
            tabCustomers.Controls.Add(pictureBox11);
            tabCustomers.Controls.Add(btnAddCustomer);
            tabCustomers.Controls.Add(dgvCustomers);
            tabCustomers.Controls.Add(labelEmail);
            tabCustomers.Controls.Add(label3);
            tabCustomers.Controls.Add(label2);
            tabCustomers.Controls.Add(txtFirstName);
            tabCustomers.Controls.Add(label1);
            tabCustomers.Controls.Add(txtEmail);
            tabCustomers.Controls.Add(txtLastName);
            tabCustomers.Controls.Add(txtPhone);
            tabCustomers.Controls.Add(pictureBox10);
            tabCustomers.Location = new Point(4, 29);
            tabCustomers.Margin = new Padding(3, 4, 3, 4);
            tabCustomers.Name = "tabCustomers";
            tabCustomers.Padding = new Padding(3, 4, 3, 4);
            tabCustomers.Size = new Size(2285, 1115);
            tabCustomers.TabIndex = 0;
            tabCustomers.Text = "Клиенти";
            // 
            // pictureBox11
            // 
            pictureBox11.Image = Properties.Resources.new_logo;
            pictureBox11.Location = new Point(1449, 165);
            pictureBox11.Margin = new Padding(3, 4, 3, 4);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(729, 371);
            pictureBox11.TabIndex = 27;
            pictureBox11.TabStop = false;
            // 
            // pictureBox10
            // 
            pictureBox10.Image = Properties.Resources.mg_air_down_logo;
            pictureBox10.Location = new Point(-18, 959);
            pictureBox10.Margin = new Padding(3, 4, 3, 4);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(321, 149);
            pictureBox10.TabIndex = 26;
            pictureBox10.TabStop = false;
            // 
            // tabFlights
            // 
            tabFlights.BackColor = SystemColors.ControlDark;
            tabFlights.Controls.Add(pictureBox6);
            tabFlights.Controls.Add(btnAddFlight);
            tabFlights.Controls.Add(labelSeats);
            tabFlights.Controls.Add(labelPrice);
            tabFlights.Controls.Add(txtSeasts);
            tabFlights.Controls.Add(txtPrice);
            tabFlights.Controls.Add(labelArrival);
            tabFlights.Controls.Add(labelDeparture);
            tabFlights.Controls.Add(txtArrival);
            tabFlights.Controls.Add(txtDeparture);
            tabFlights.Controls.Add(labelDestination);
            tabFlights.Controls.Add(txtDestination);
            tabFlights.Controls.Add(labelOrigin);
            tabFlights.Controls.Add(txtOrigin);
            tabFlights.Controls.Add(dgvFlights);
            tabFlights.Controls.Add(pictureBox4);
            tabFlights.Location = new Point(4, 29);
            tabFlights.Margin = new Padding(3, 4, 3, 4);
            tabFlights.Name = "tabFlights";
            tabFlights.Padding = new Padding(3, 4, 3, 4);
            tabFlights.Size = new Size(2285, 1115);
            tabFlights.TabIndex = 1;
            tabFlights.Text = "Полети";
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources.rayancho;
            pictureBox6.Location = new Point(1914, 155);
            pictureBox6.Margin = new Padding(3, 4, 3, 4);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(243, 97);
            pictureBox6.TabIndex = 16;
            pictureBox6.TabStop = false;
            // 
            // btnAddFlight
            // 
            btnAddFlight.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnAddFlight.Location = new Point(413, 859);
            btnAddFlight.Margin = new Padding(3, 4, 3, 4);
            btnAddFlight.Name = "btnAddFlight";
            btnAddFlight.Size = new Size(383, 124);
            btnAddFlight.TabIndex = 13;
            btnAddFlight.Text = "Добави полет";
            btnAddFlight.UseVisualStyleBackColor = true;
            btnAddFlight.Click += btnAddFlight_Click;
            // 
            // labelSeats
            // 
            labelSeats.AutoSize = true;
            labelSeats.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelSeats.Location = new Point(1624, 856);
            labelSeats.Name = "labelSeats";
            labelSeats.Size = new Size(258, 40);
            labelSeats.TabIndex = 12;
            labelSeats.Text = "Свободни места:";
            // 
            // labelPrice
            // 
            labelPrice.AutoSize = true;
            labelPrice.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelPrice.Location = new Point(1765, 775);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(99, 40);
            labelPrice.TabIndex = 11;
            labelPrice.Text = "Цена:";
            // 
            // txtSeasts
            // 
            txtSeasts.Font = new Font("Segoe UI", 15F);
            txtSeasts.Location = new Point(1880, 856);
            txtSeasts.Margin = new Padding(3, 4, 3, 4);
            txtSeasts.Name = "txtSeasts";
            txtSeasts.Size = new Size(191, 41);
            txtSeasts.TabIndex = 10;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 15F);
            txtPrice.Location = new Point(1880, 771);
            txtPrice.Margin = new Padding(3, 4, 3, 4);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(191, 41);
            txtPrice.TabIndex = 9;
            // 
            // labelArrival
            // 
            labelArrival.AutoSize = true;
            labelArrival.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelArrival.Location = new Point(1101, 1012);
            labelArrival.Name = "labelArrival";
            labelArrival.Size = new Size(286, 40);
            labelArrival.TabIndex = 8;
            labelArrival.Text = "Час на пристигане:";
            // 
            // labelDeparture
            // 
            labelDeparture.AutoSize = true;
            labelDeparture.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelDeparture.Location = new Point(1128, 935);
            labelDeparture.Name = "labelDeparture";
            labelDeparture.Size = new Size(256, 40);
            labelDeparture.TabIndex = 7;
            labelDeparture.Text = "Час на излитане:";
            // 
            // txtArrival
            // 
            txtArrival.Font = new Font("Segoe UI", 15F);
            txtArrival.Location = new Point(1375, 1011);
            txtArrival.Margin = new Padding(3, 4, 3, 4);
            txtArrival.Name = "txtArrival";
            txtArrival.Size = new Size(191, 41);
            txtArrival.TabIndex = 6;
            // 
            // txtDeparture
            // 
            txtDeparture.Font = new Font("Segoe UI", 15F);
            txtDeparture.Location = new Point(1375, 933);
            txtDeparture.Margin = new Padding(3, 4, 3, 4);
            txtDeparture.Name = "txtDeparture";
            txtDeparture.Size = new Size(191, 41);
            txtDeparture.TabIndex = 5;
            // 
            // labelDestination
            // 
            labelDestination.AutoSize = true;
            labelDestination.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelDestination.Location = new Point(1190, 856);
            labelDestination.Name = "labelDestination";
            labelDestination.Size = new Size(180, 40);
            labelDestination.TabIndex = 4;
            labelDestination.Text = "Пристига в:";
            // 
            // txtDestination
            // 
            txtDestination.Font = new Font("Segoe UI", 15F);
            txtDestination.Location = new Point(1375, 855);
            txtDestination.Margin = new Padding(3, 4, 3, 4);
            txtDestination.Name = "txtDestination";
            txtDestination.Size = new Size(191, 41);
            txtDestination.TabIndex = 3;
            // 
            // labelOrigin
            // 
            labelOrigin.AutoSize = true;
            labelOrigin.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelOrigin.Location = new Point(1206, 771);
            labelOrigin.Name = "labelOrigin";
            labelOrigin.Size = new Size(165, 40);
            labelOrigin.TabIndex = 2;
            labelOrigin.Text = "Излита от:";
            // 
            // txtOrigin
            // 
            txtOrigin.Font = new Font("Segoe UI", 15F);
            txtOrigin.Location = new Point(1375, 769);
            txtOrigin.Margin = new Padding(3, 4, 3, 4);
            txtOrigin.Name = "txtOrigin";
            txtOrigin.Size = new Size(191, 41);
            txtOrigin.TabIndex = 1;
            // 
            // dgvFlights
            // 
            dgvFlights.BackgroundColor = Color.White;
            dgvFlights.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlights.Location = new Point(38, 51);
            dgvFlights.Margin = new Padding(3, 4, 3, 4);
            dgvFlights.Name = "dgvFlights";
            dgvFlights.RowHeadersWidth = 51;
            dgvFlights.Size = new Size(1182, 648);
            dgvFlights.TabIndex = 0;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.image_1_;
            pictureBox4.Location = new Point(-18, 959);
            pictureBox4.Margin = new Padding(3, 4, 3, 4);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(345, 161);
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // tabBookings
            // 
            tabBookings.BackColor = SystemColors.ControlDark;
            tabBookings.Controls.Add(pictureBox1);
            tabBookings.Controls.Add(labelSeatBooking);
            tabBookings.Controls.Add(txtSeatNumber);
            tabBookings.Controls.Add(labelFlightBooking);
            tabBookings.Controls.Add(labelBookingName);
            tabBookings.Controls.Add(cmbFlights);
            tabBookings.Controls.Add(cmbCustomers);
            tabBookings.Controls.Add(btnBookTicket);
            tabBookings.Controls.Add(dgvBookings);
            tabBookings.Controls.Add(pictureBox3);
            tabBookings.Location = new Point(4, 29);
            tabBookings.Margin = new Padding(3, 4, 3, 4);
            tabBookings.Name = "tabBookings";
            tabBookings.Padding = new Padding(3, 4, 3, 4);
            tabBookings.Size = new Size(2285, 1115);
            tabBookings.TabIndex = 2;
            tabBookings.Text = "Резервация";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.bulgaria_air_Airbus_320_1024x439_removebg_preview__2_;
            pictureBox1.Location = new Point(1336, 115);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(874, 387);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // labelSeatBooking
            // 
            labelSeatBooking.AutoSize = true;
            labelSeatBooking.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelSeatBooking.Location = new Point(1608, 891);
            labelSeatBooking.Name = "labelSeatBooking";
            labelSeatBooking.Size = new Size(114, 40);
            labelSeatBooking.TabIndex = 7;
            labelSeatBooking.Text = "Място:";
            // 
            // txtSeatNumber
            // 
            txtSeatNumber.Font = new Font("Segoe UI", 15F);
            txtSeatNumber.Location = new Point(1736, 891);
            txtSeatNumber.Margin = new Padding(3, 4, 3, 4);
            txtSeatNumber.Name = "txtSeatNumber";
            txtSeatNumber.Size = new Size(315, 41);
            txtSeatNumber.TabIndex = 6;
            // 
            // labelFlightBooking
            // 
            labelFlightBooking.AutoSize = true;
            labelFlightBooking.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelFlightBooking.Location = new Point(1610, 771);
            labelFlightBooking.Name = "labelFlightBooking";
            labelFlightBooking.Size = new Size(111, 40);
            labelFlightBooking.TabIndex = 5;
            labelFlightBooking.Text = "Полет:";
            // 
            // labelBookingName
            // 
            labelBookingName.AutoSize = true;
            labelBookingName.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            labelBookingName.Location = new Point(1498, 637);
            labelBookingName.Name = "labelBookingName";
            labelBookingName.Size = new Size(239, 40);
            labelBookingName.TabIndex = 4;
            labelBookingName.Text = "Име на пътник:";
            // 
            // cmbFlights
            // 
            cmbFlights.Font = new Font("Segoe UI", 15F);
            cmbFlights.FormattingEnabled = true;
            cmbFlights.Location = new Point(1736, 769);
            cmbFlights.Margin = new Padding(3, 4, 3, 4);
            cmbFlights.Name = "cmbFlights";
            cmbFlights.Size = new Size(315, 43);
            cmbFlights.TabIndex = 3;
            // 
            // cmbCustomers
            // 
            cmbCustomers.Font = new Font("Segoe UI", 15F);
            cmbCustomers.FormattingEnabled = true;
            cmbCustomers.Location = new Point(1736, 636);
            cmbCustomers.Margin = new Padding(3, 4, 3, 4);
            cmbCustomers.Name = "cmbCustomers";
            cmbCustomers.Size = new Size(315, 43);
            cmbCustomers.TabIndex = 2;
            // 
            // btnBookTicket
            // 
            btnBookTicket.Font = new Font("Segoe UI", 17F, FontStyle.Bold);
            btnBookTicket.Location = new Point(414, 859);
            btnBookTicket.Margin = new Padding(3, 4, 3, 4);
            btnBookTicket.Name = "btnBookTicket";
            btnBookTicket.Size = new Size(379, 124);
            btnBookTicket.TabIndex = 1;
            btnBookTicket.Text = "Направи резервация";
            btnBookTicket.UseVisualStyleBackColor = true;
            btnBookTicket.Click += btnBookTicket_Click;
            // 
            // dgvBookings
            // 
            dgvBookings.BackgroundColor = Color.White;
            dgvBookings.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookings.Location = new Point(42, 52);
            dgvBookings.Margin = new Padding(3, 4, 3, 4);
            dgvBookings.Name = "dgvBookings";
            dgvBookings.RowHeadersWidth = 51;
            dgvBookings.Size = new Size(1168, 644);
            dgvBookings.TabIndex = 0;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.mg_air_down_logo;
            pictureBox3.Location = new Point(-18, 959);
            pictureBox3.Margin = new Padding(3, 4, 3, 4);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(401, 171);
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // tabAdmin
            // 
            tabAdmin.BackColor = SystemColors.ControlDark;
            tabAdmin.Controls.Add(dgvFlightsAdmin);
            tabAdmin.Controls.Add(panel3);
            tabAdmin.Controls.Add(dgvCustomersAdmin);
            tabAdmin.Controls.Add(panel1);
            tabAdmin.Controls.Add(panel2);
            tabAdmin.Controls.Add(pictureBox2);
            tabAdmin.Location = new Point(4, 29);
            tabAdmin.Margin = new Padding(3, 4, 3, 4);
            tabAdmin.Name = "tabAdmin";
            tabAdmin.Padding = new Padding(3, 4, 3, 4);
            tabAdmin.Size = new Size(2285, 1115);
            tabAdmin.TabIndex = 3;
            tabAdmin.Text = "Администратор";
            // 
            // dgvFlightsAdmin
            // 
            dgvFlightsAdmin.BackgroundColor = Color.White;
            dgvFlightsAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFlightsAdmin.Location = new Point(769, 53);
            dgvFlightsAdmin.Margin = new Padding(3, 4, 3, 4);
            dgvFlightsAdmin.Name = "dgvFlightsAdmin";
            dgvFlightsAdmin.RowHeadersWidth = 51;
            dgvFlightsAdmin.Size = new Size(704, 405);
            dgvFlightsAdmin.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.RosyBrown;
            panel3.Controls.Add(dgvBookingsAdmin);
            panel3.Controls.Add(btnUpdateBookingStatus);
            panel3.Controls.Add(cmbBookingStatus);
            panel3.Controls.Add(deleteBookingAdmin);
            panel3.Location = new Point(1493, 33);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(695, 844);
            panel3.TabIndex = 13;
            // 
            // dgvBookingsAdmin
            // 
            dgvBookingsAdmin.BackgroundColor = Color.White;
            dgvBookingsAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBookingsAdmin.Location = new Point(16, 20);
            dgvBookingsAdmin.Margin = new Padding(3, 4, 3, 4);
            dgvBookingsAdmin.Name = "dgvBookingsAdmin";
            dgvBookingsAdmin.RowHeadersWidth = 51;
            dgvBookingsAdmin.Size = new Size(657, 405);
            dgvBookingsAdmin.TabIndex = 10;
            // 
            // btnUpdateBookingStatus
            // 
            btnUpdateBookingStatus.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            btnUpdateBookingStatus.Location = new Point(446, 721);
            btnUpdateBookingStatus.Name = "btnUpdateBookingStatus";
            btnUpdateBookingStatus.Size = new Size(206, 67);
            btnUpdateBookingStatus.TabIndex = 7;
            btnUpdateBookingStatus.Text = "Запази";
            btnUpdateBookingStatus.UseVisualStyleBackColor = true;
            btnUpdateBookingStatus.Click += btnUpdateBookingStatus_Click;
            // 
            // cmbBookingStatus
            // 
            cmbBookingStatus.Font = new Font("Segoe UI", 15F);
            cmbBookingStatus.FormattingEnabled = true;
            cmbBookingStatus.Location = new Point(166, 721);
            cmbBookingStatus.Margin = new Padding(3, 4, 3, 4);
            cmbBookingStatus.Name = "cmbBookingStatus";
            cmbBookingStatus.Size = new Size(209, 43);
            cmbBookingStatus.TabIndex = 6;
            // 
            // deleteBookingAdmin
            // 
            deleteBookingAdmin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            deleteBookingAdmin.Location = new Point(227, 545);
            deleteBookingAdmin.Name = "deleteBookingAdmin";
            deleteBookingAdmin.Size = new Size(334, 133);
            deleteBookingAdmin.TabIndex = 5;
            deleteBookingAdmin.Text = "Изтрий резервация";
            deleteBookingAdmin.UseVisualStyleBackColor = true;
            deleteBookingAdmin.Click += deleteBookingAdmin_Click;
            // 
            // dgvCustomersAdmin
            // 
            dgvCustomersAdmin.BackgroundColor = Color.White;
            dgvCustomersAdmin.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomersAdmin.Location = new Point(30, 53);
            dgvCustomersAdmin.Margin = new Padding(3, 4, 3, 4);
            dgvCustomersAdmin.Name = "dgvCustomersAdmin";
            dgvCustomersAdmin.RowHeadersWidth = 51;
            dgvCustomersAdmin.Size = new Size(688, 405);
            dgvCustomersAdmin.TabIndex = 8;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(DeleteCustomerAdmin);
            panel1.Location = new Point(-5, 33);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(745, 844);
            panel1.TabIndex = 11;
            // 
            // DeleteCustomerAdmin
            // 
            DeleteCustomerAdmin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            DeleteCustomerAdmin.Location = new Point(138, 545);
            DeleteCustomerAdmin.Name = "DeleteCustomerAdmin";
            DeleteCustomerAdmin.Size = new Size(333, 133);
            DeleteCustomerAdmin.TabIndex = 3;
            DeleteCustomerAdmin.Text = "Изтрий пътник";
            DeleteCustomerAdmin.UseVisualStyleBackColor = true;
            DeleteCustomerAdmin.Click += DeleteCustomerAdmin_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.RosyBrown;
            panel2.Controls.Add(deleteFlightAdmin);
            panel2.Location = new Point(758, 33);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(728, 844);
            panel2.TabIndex = 12;
            // 
            // deleteFlightAdmin
            // 
            deleteFlightAdmin.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            deleteFlightAdmin.Location = new Point(211, 545);
            deleteFlightAdmin.Name = "deleteFlightAdmin";
            deleteFlightAdmin.Size = new Size(334, 133);
            deleteFlightAdmin.TabIndex = 4;
            deleteFlightAdmin.Text = "Изтрий полет";
            deleteFlightAdmin.UseVisualStyleBackColor = true;
            deleteFlightAdmin.Click += deleteFlightAdmin_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.mg_air_down_logo;
            pictureBox2.Location = new Point(-18, 959);
            pictureBox2.Margin = new Padding(3, 4, 3, 4);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(394, 168);
            pictureBox2.TabIndex = 14;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1055);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "ОМГ Еър";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            tabControl1.ResumeLayout(false);
            tabCustomers.ResumeLayout(false);
            tabCustomers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            tabFlights.ResumeLayout(false);
            tabFlights.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvFlights).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            tabBookings.ResumeLayout(false);
            tabBookings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBookings).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            tabAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvFlightsAdmin).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvBookingsAdmin).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCustomersAdmin).EndInit();
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnAddCustomer;
        private DataGridView dgvCustomers;
        private Button btnAddFlight;
        private Button btnBookTicket;
        private TextBox txtFirstName;
        private TextBox txtEmail;
        private TextBox txtLastName;
        private TextBox txtPhone;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label labelEmail;
        private TabControl tabControl1;
        private TabPage tabCustomers;
        private TabPage tabFlights;
        private TabPage tabBookings;
        private TabPage tabAdmin;
        private Button deleteBookingAdmin;
        private Button deleteFlightAdmin;
        private Button DeleteCustomerAdmin;
        private DataGridView dgvCustomersAdmin;
        private DataGridView dgvBookingsAdmin;
        private DataGridView dgvFlightsAdmin;
        private DataGridView dgvFlights;
        private DataGridView dgvBookings;
        private Label labelOrigin;
        private TextBox txtOrigin;
        private TextBox txtDestination;
        private TextBox txtDeparture;
        private Label labelDestination;
        private TextBox txtPrice;
        private Label labelArrival;
        private Label labelDeparture;
        private TextBox txtArrival;
        private Label labelSeats;
        private Label labelPrice;
        private TextBox txtSeasts;
        private Label labelBookingName;
        private ComboBox cmbFlights;
        private ComboBox cmbCustomers;
        private Label labelSeatBooking;
        private TextBox txtSeatNumber;
        private Label labelFlightBooking;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button btnUpdateBookingStatus;
        private ComboBox cmbBookingStatus;
        private PictureBox pictureBox4;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox6;
        private PictureBox pictureBox11;
        private PictureBox pictureBox10;
    }
}
