using AirplaneTickets.Data;
using AirplaneTickets.Services;
using AirplaneTickets.Data.Models;

namespace AirplaneTickets
{
    public partial class Form1 : Form
    {
        private CustomerService _customerService = new CustomerService();
        private FlightService _flightService = new FlightService();
        private BookingService _bookingService = new BookingService();

        private User _loggedUser;

        public Form1(User loggedUser)
        {
           // this.MaximizeBox = false;   // маха бутона за maximize
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // прави прозореца фиксиран размер
            InitializeComponent();

            _loggedUser = loggedUser;

            LoadCustomers();
            LoadFlights();
            LoadBookings();
            ApplyRolePermissions();
          


        }

        private void ApplyRolePermissions()
        {
            bool isAdmin = _loggedUser != null && _loggedUser.Role == "admin";

            if (!isAdmin)
            {
                tabControl1.TabPages.Remove(tabAdmin);
                btnAddFlight.Visible = false;
                labelArrival.Visible = false;
                labelDestination.Visible = false;
                labelDeparture.Visible = false;
                labelPrice.Visible = false;
                labelOrigin.Visible = false;
                labelSeats.Visible = false;
                txtOrigin.Visible = false;
                txtDestination.Visible = false;
                txtArrival.Visible = false;
                txtDeparture.Visible = false;
                txtPrice.Visible = false;
                txtSeasts.Visible = false;


            }
        }


        // Customers
        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
          

            // Проверка за празни полета
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) ||
                string.IsNullOrWhiteSpace(txtLastName.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                MessageBox.Show("Моля, попълнете всички полета!");
                return;
            }

            var customer = new Customer
            {
                FirstName = txtFirstName.Text.Trim(),
                LastName = txtLastName.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Phone = txtPhone.Text.Trim()
            };

            _customerService.Add(customer);
            MessageBox.Show("Пътникът бе добавен!");
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtEmail.Text = "";
            txtPhone.Text = "";

            RefreshAllData();
        }

        private void LoadCustomers()
        {
            dgvCustomers.AllowUserToAddRows = false;     // маха сивия ред
            dgvCustomers.ReadOnly = true;                // само за четене
            dgvCustomers.RowHeadersVisible = false;      // маха малкия сив хедър отляво
            dgvCustomers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // разпределя колоните равномерно
            dgvCustomers.AutoResizeColumns();
            dgvCustomers.DataSource = _customerService.GetAll();
            dgvCustomers.Columns["CustomerId"].HeaderText = "ИД на пътник";
            dgvCustomers.Columns["FirstName"].HeaderText = "Име";
            dgvCustomers.Columns["LastName"].HeaderText = "Фамилия";
            dgvCustomers.Columns["Email"].HeaderText = "Имейл";
            dgvCustomers.Columns["Phone"].HeaderText = "Телефон";

            cmbCustomers.DataSource = _customerService.GetAll();
            cmbCustomers.DisplayMember = "FirstName";
            cmbCustomers.ValueMember = "CustomerId";
        }

       

        private void LoadFlights()
        {
            dgvFlights.AllowUserToAddRows = false;     // маха сивия ред
            dgvFlights.ReadOnly = true;                // само за четене
            dgvFlights.RowHeadersVisible = false;      // маха малкия сив хедър отляво
            dgvFlights.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // разпределя колоните равномерно
            dgvFlights.AutoResizeColumns();
            dgvFlights.DataSource = _flightService.GetAll();
            dgvFlights.Columns["FlightID"].HeaderText = "ИД на полет";
            dgvFlights.Columns["Origin"].HeaderText = "От";
            dgvFlights.Columns["Destination"].HeaderText = "До";
            dgvFlights.Columns["DepartureTime"].HeaderText = "Час на тръгване";
            dgvFlights.Columns["ArrivalTime"].HeaderText = "Час на пристигане";
            dgvFlights.Columns["Price"].HeaderText = "Цена";
            dgvFlights.Columns["AvailableSeats"].HeaderText = "Свободни места";

            cmbFlights.DataSource = _flightService.GetAll()
      .Select(f => new
      {
          f.FlightId,
          Name = $"{f.Origin} → {f.Destination} ({f.AvailableSeats} места)"
      })
      .ToList();
            cmbFlights.ValueMember = "FlightId";
            cmbFlights.DisplayMember = "Name";
        }

        // Booking
        private void LoadBookings()
        {
            dgvBookings.AllowUserToAddRows = false;     // маха сивия ред
            dgvBookings.ReadOnly = true;                // само за четене
            dgvBookings.RowHeadersVisible = false;      // маха малкия сив хедър отляво
            dgvBookings.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // разпределя колоните равномерно
            dgvBookings.AutoResizeColumns();
            dgvBookings.DataSource = _bookingService.GetAll();
            dgvBookings.Columns["BookingId"].HeaderText = "ИД на билет";
            dgvBookings.Columns["Customer"].HeaderText = "Пътник";
            dgvBookings.Columns["Flight"].HeaderText = "Полет";
            dgvBookings.Columns["Seats"].HeaderText = "Места";
            dgvBookings.Columns["BookingDate"].HeaderText = "Дата";
            dgvBookings.Columns["Status"].HeaderText = "Статус";
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            if (_loggedUser.Role == "admin")
            {
                cmbBookingStatus.Items.Clear();
                cmbBookingStatus.Items.AddRange(new string[] { "активен", "отменен", "изчакващ" });
                LoadAdminData();
            }
        }

     

        private void LoadAdminData()
        {
            dgvCustomersAdmin.AllowUserToAddRows = false;     // маха сивия ред
            dgvCustomersAdmin.ReadOnly = true;                // само за четене
            dgvCustomersAdmin.RowHeadersVisible = false;      // маха малкия сив хедър отляво
            dgvCustomersAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // разпределя колоните равномерно
            dgvCustomers.AutoResizeColumns();
            dgvCustomersAdmin.DataSource = _customerService.GetAll();
            dgvCustomersAdmin.Columns["CustomerId"].HeaderText = "ИД на пътник";
            dgvCustomersAdmin.Columns["FirstName"].HeaderText = "Име";
            dgvCustomersAdmin.Columns["LastName"].HeaderText = "Фамилия";
            dgvCustomersAdmin.Columns["Email"].HeaderText = "Имейл";
            dgvCustomersAdmin.Columns["Phone"].HeaderText = "Телефон";


            dgvFlightsAdmin.AllowUserToAddRows = false;     // маха сивия ред
            dgvFlightsAdmin.ReadOnly = true;                // само за четене
            dgvFlightsAdmin.RowHeadersVisible = false;      // маха малкия сив хедър отляво
            dgvFlightsAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // разпределя колоните равномерно
            dgvCustomers.AutoResizeColumns();
            dgvFlightsAdmin.DataSource = _flightService.GetAll();
            dgvFlightsAdmin.Columns["FlightID"].HeaderText = "ИД на полет";
            dgvFlightsAdmin.Columns["Origin"].HeaderText = "От";
            dgvFlightsAdmin.Columns["Destination"].HeaderText = "До";
            dgvFlightsAdmin.Columns["DepartureTime"].HeaderText = "Час на тръгване";
            dgvFlightsAdmin.Columns["ArrivalTime"].HeaderText = "Час на пристигане";
            dgvFlightsAdmin.Columns["Price"].HeaderText = "Цена";
            dgvFlightsAdmin.Columns["AvailableSeats"].HeaderText = "Свободни места";

            dgvBookingsAdmin.AllowUserToAddRows = false;     // маха сивия ред
            dgvBookingsAdmin.ReadOnly = true;                // само за четене
            dgvBookingsAdmin.RowHeadersVisible = false;      // маха малкия сив хедър отляво
            dgvBookingsAdmin.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill; // разпределя колоните равномерно
            dgvBookingsAdmin.AutoResizeColumns();
            dgvBookingsAdmin.DataSource = _bookingService.GetAll();
            dgvBookingsAdmin.Columns["BookingId"].HeaderText = "ИД на резервация";
            dgvBookingsAdmin.Columns["Customer"].HeaderText = "Пътник";
            dgvBookingsAdmin.Columns["Flight"].HeaderText = "Полет";
            dgvBookingsAdmin.Columns["Seats"].HeaderText = "Седалки";
            dgvBookingsAdmin.Columns["BookingDate"].HeaderText = "Дата";
            dgvBookingsAdmin.Columns["Status"].HeaderText = "Статус";



        }

       
        private void RefreshAllData()
        {
            
            // Customers
            dgvCustomers.DataSource = null;
            dgvCustomers.DataSource = _customerService.GetAll();
            dgvCustomers.Columns["CustomerId"].HeaderText = "ИД на пътник";
            dgvCustomers.Columns["FirstName"].HeaderText = "Име";
            dgvCustomers.Columns["LastName"].HeaderText = "Фамилия";
            dgvCustomers.Columns["Email"].HeaderText = "Имейл";
            dgvCustomers.Columns["Phone"].HeaderText = "Телефон";

            if (_loggedUser.Role == "admin")
            {
                dgvCustomersAdmin.DataSource = null;
                dgvCustomersAdmin.DataSource = _customerService.GetAll();
                dgvCustomersAdmin.Columns["CustomerId"].HeaderText = "ИД на пътник";
                dgvCustomersAdmin.Columns["FirstName"].HeaderText = "Име";
                dgvCustomersAdmin.Columns["LastName"].HeaderText = "Фамилия";
                dgvCustomersAdmin.Columns["Email"].HeaderText = "Имейл";
                dgvCustomersAdmin.Columns["Phone"].HeaderText = "Телефон";
            }
            

            // Customer ComboBox
            cmbCustomers.DataSource = null;
            cmbCustomers.DataSource = _customerService.GetAll();
            cmbCustomers.DisplayMember = "FirstName";
            cmbCustomers.ValueMember = "CustomerId";

            // Bookings
            dgvBookings.DataSource = null;
            dgvBookings.DataSource = _bookingService.GetAll();
            dgvBookings.Columns["BookingId"].HeaderText = "ИД на билет";
            dgvBookings.Columns["Customer"].HeaderText = "Пътник";
            dgvBookings.Columns["Flight"].HeaderText = "Полет";
            dgvBookings.Columns["Seats"].HeaderText = "Седалки";
            dgvBookings.Columns["BookingDate"].HeaderText = "Дата";
            dgvBookings.Columns["Status"].HeaderText = "Статус";


            if (_loggedUser.Role == "admin")
            {
                dgvBookingsAdmin.DataSource = null;
                dgvBookingsAdmin.DataSource = _bookingService.GetAll();
                dgvBookingsAdmin.Columns["BookingId"].HeaderText = "ИД на резервация";
                dgvBookingsAdmin.Columns["Customer"].HeaderText = "Пътник";
                dgvBookingsAdmin.Columns["Flight"].HeaderText = "Полет";
                dgvBookingsAdmin.Columns["Seats"].HeaderText = "Седалки";
                dgvBookingsAdmin.Columns["BookingDate"].HeaderText = "Дата";
                dgvBookingsAdmin.Columns["Status"].HeaderText = "Статус";

            }
            dgvFlights.DataSource = null;
            dgvFlights.DataSource = _flightService.GetAll();
            dgvFlights.Columns["FlightID"].HeaderText = "ИД на полет";
            dgvFlights.Columns["Origin"].HeaderText = "От";
            dgvFlights.Columns["Destination"].HeaderText = "До";
            dgvFlights.Columns["DepartureTime"].HeaderText = "Час на тръгване";
            dgvFlights.Columns["ArrivalTime"].HeaderText = "Час на пристигане";
            dgvFlights.Columns["Price"].HeaderText = "Цена";
            dgvFlights.Columns["AvailableSeats"].HeaderText = "Свободни места";
            cmbFlights.DataSource = _flightService.GetAll()
    .Select(f => new
    {
        f.FlightId,
        Name = $"{f.Origin} → {f.Destination} ({f.AvailableSeats} места)"
    })
    .ToList();
            if (_loggedUser.Role == "admin")
            {
                dgvFlightsAdmin.DataSource = null;
                dgvFlightsAdmin.DataSource = _flightService.GetAll();
                dgvFlightsAdmin.Columns["FlightID"].HeaderText = "ИД на полет";
                dgvFlightsAdmin.Columns["Origin"].HeaderText = "От";
                dgvFlightsAdmin.Columns["Destination"].HeaderText = "До";
                dgvFlightsAdmin.Columns["DepartureTime"].HeaderText = "Час на тръгване";
                dgvFlightsAdmin.Columns["ArrivalTime"].HeaderText = "Час на пристигане";
                dgvFlightsAdmin.Columns["Price"].HeaderText = "Цена";
                dgvFlightsAdmin.Columns["AvailableSeats"].HeaderText = "Свободни места";
            }
        }


        private void DeleteCustomerAdmin_Click(object sender, EventArgs e)
        {
            if (dgvCustomersAdmin.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvCustomersAdmin.CurrentRow.Cells["CustomerId"].Value);

            try
            {
                _customerService.Delete(id);
                MessageBox.Show("Пътникът е изтрит!");
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при изтриване: " + ex.Message);
            }
        }

        private void deleteFlightAdmin_Click(object sender, EventArgs e)
        {
            if (dgvFlightsAdmin.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvFlightsAdmin.CurrentRow.Cells["FlightID"].Value);

            try
            {
                _flightService.Delete(id);
                MessageBox.Show("Полетът е изтрит!");
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при изтриване на полет: " + ex.Message + "\n\nINNER: " + ex.InnerException?.Message);
            }
        }

        private void deleteBookingAdmin_Click(object sender, EventArgs e)
        {
            if (dgvBookingsAdmin.CurrentRow == null) return;

            int id = Convert.ToInt32(dgvBookingsAdmin.CurrentRow.Cells["BookingId"].Value);

            try
            {
                _bookingService.Delete(id);
                MessageBox.Show("Резервацията е изтрита!");
                RefreshAllData(); // презареждаме всичко, за да се отрази навсякъде
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при изтриване на резервация: " + ex.Message + "\n\nINNER: " + ex.InnerException?.Message);
            }
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(txtOrigin.Text) ||
                string.IsNullOrWhiteSpace(txtDestination.Text) ||
                string.IsNullOrWhiteSpace(txtDeparture.Text) ||
                string.IsNullOrWhiteSpace(txtArrival.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtSeasts.Text))
            {
                MessageBox.Show("Моля, попълнете всички полета!");
                return;
            }

            var flight = new Flight
            {

                Origin = txtOrigin.Text.Trim(),
                Destination = txtDestination.Text.Trim(),
                DepartureTime = DateTime.Parse(txtDeparture.Text.Trim()),
                ArrivalTime = DateTime.Parse(txtArrival.Text.Trim()),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                AvailableSeats = int.Parse(txtSeasts.Text.Trim())



            };

            _flightService.Add(flight);
            MessageBox.Show("Полетът бе добавен!");
            txtOrigin.Text = "";
            txtDestination.Text = "";
            txtDeparture.Text = "";
            txtArrival.Text = "";
            txtPrice.Text = "";
            txtSeasts.Text = "";

            RefreshAllData();
        }

        private void btnBookTicket_Click(object sender, EventArgs e)
        {
            if (cmbCustomers.SelectedValue == null || cmbFlights.SelectedValue == null)
            {
                MessageBox.Show("Моля, изберете пътник и полет!");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtSeatNumber.Text))
            {
                MessageBox.Show("Моля, попълнете номера на мястото!");
                return;
            }

            try
            {
                int customerId = (int)cmbCustomers.SelectedValue;
                int flightId = (int)cmbFlights.SelectedValue;
                string seat = txtSeatNumber.Text.Trim();

                _bookingService.BookTicket(customerId, flightId, seat);

                MessageBox.Show("Резервацията беше направена!");
                txtSeatNumber.Text = "";
                RefreshAllData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при резервацията: " + ex.Message +
                                "\nInner: " + (ex.InnerException?.Message ?? ""));
            }
        }

        private void dgvBookingsAdmin_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBookingsAdmin.CurrentRow == null) return;

            string status = dgvBookingsAdmin.CurrentRow.Cells["Status"].Value.ToString();
            cmbBookingStatus.SelectedItem = status;
        }

        private void btnUpdateBookingStatus_Click(object sender, EventArgs e)
        {
            if (dgvBookingsAdmin.CurrentRow == null) return;

            int bookingId = Convert.ToInt32(dgvBookingsAdmin.CurrentRow.Cells["BookingId"].Value);
            string newStatus = cmbBookingStatus.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newStatus))
            {
                MessageBox.Show("Моля, изберете статус!");
                return;
            }

            try
            {
                using (var context = new AppDbContext())
                {
                    var booking = context.Bookings.FirstOrDefault(b => b.BookingId == bookingId);
                    if (booking != null)
                    {
                        booking.Status = newStatus;
                        context.SaveChanges();
                        MessageBox.Show("Статусът е обновен!");
                        RefreshAllData();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Грешка при обновяване на статуса: " + ex.Message + "\n\nINNER: " + ex.InnerException?.Message);
            }
        }     
    }
}