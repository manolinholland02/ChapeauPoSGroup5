using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ChapeauModel;
using ChapeauLogic;
using System.Drawing.Drawing2D;

namespace ChapeauUI
{
    public partial class KitchenBarView : Form
    {
        private KitchenBarViewService _kitchenBarViewService;
        private List<KitchenBarViewModel> _orderedItems;
        private DataTable _incomingOrdersDataTable;
        private DataTable _pastOrdersDataTable;
        private List<Timer> _timers;
        private string _menuType;

        public KitchenBarView(Employee employee)
        {
            InitializeComponent();

            //Calling the unique instance of the KitchenBarViewService class
            _kitchenBarViewService = KitchenBarViewService.GetInstance();
            _orderedItems = new List<KitchenBarViewModel>();
            _incomingOrdersDataTable = new DataTable();
            _pastOrdersDataTable = new DataTable();
            _timers = new List<Timer>();
            _menuType = ReturnMenuTypeBasedOnEmployee(employee);

            //Set the data table used as source for the DataGridView with the appropriate columns and their types
            DeclareDataTable(_incomingOrdersDataTable);
            DeclareDataTable(_pastOrdersDataTable);

            lblEmployeeName.Text = $"{employee.EmployeeFirstName} {employee.EmployeeLastName}";
            lblEmployeeName.Location = new Point(kitchenBarViewHeader.Width - lblEmployeeName.Width, 12);
            ExtractCorrespondingOrderItems(employee);

            //Populate data table with the corresponding data from the database
            PopulateIncomingOrdersDataTable();

            //Fill the DataGridView with the respective data from the data table
            InitializeDataGridView(_incomingOrdersDataTable);

            //Set design of components
            SetDesignOfComponents();
        }

        //Method to declare the data table that is going to be used as a data source for the DataGridView
        private void DeclareDataTable(DataTable specificDataTable)
        {
            specificDataTable.Columns.Add("OrderItemId", typeof(int));
            specificDataTable.Columns.Add("Name", typeof(string));
            specificDataTable.Columns.Add("TableOfOrder", typeof(int));
            specificDataTable.Columns.Add("Comment", typeof(string));
            specificDataTable.Columns.Add("Time", typeof(string));
        }

        //Method that returns the corresponding menu type based on the employee's role
        public string ReturnMenuTypeBasedOnEmployee(Employee employee)
        {
            if (employee.EmployeeType == EmployeeType.chef) return "food";
            else if (employee.EmployeeType == EmployeeType.barman) return "drink";
            else throw new Exception("Employee type doesn't corresponnd to chef or barman.");
        }

        //Extracting all order items from the database from the corresponding type (food or drink)
        public void ExtractCorrespondingOrderItems(Employee employee)
        {
            if (employee.EmployeeType == EmployeeType.chef)
                _orderedItems = _kitchenBarViewService.GetAllIncomingOrderItems("food");
            else if (employee.EmployeeType == EmployeeType.barman)
                _orderedItems = _kitchenBarViewService.GetAllIncomingOrderItems("drink");
        }

        //Method to populate the data table of the incoming orders with the data from the database and set a timer for their elapsed time
        private void PopulateIncomingOrdersDataTable()
        {
            //Delete rows on next call of the PopulateIncomingOrdersDataTable method
            _incomingOrdersDataTable.Rows.Clear();

            //Initialize the data table with the corresponding data
            foreach (KitchenBarViewModel model in _orderedItems)
            {
                DataRow row = _incomingOrdersDataTable.NewRow();
                row["OrderItemId"] = model.OrderItemId;
                row["Name"] = model.Name;
                row["TableOfOrder"] = model.TableOfOrder;
                row["Comment"] = model.Comment;

                //For every order a timer is assigned that triggers an event method on every tick
                Timer timer = new Timer();
                timer.Interval = 1000;
                timer.Tick += (ss, ee) => myTimer_Tick(ss, ee, _orderedItems.IndexOf(model), model.StartTime, model.AveragePreparationTime);
                timer.Start();

                _timers.Add(timer);

                _incomingOrdersDataTable.Rows.Add(row);
            }
        }

        //Method to populate the data table of the past orders with the data from the database
        private void PopulatePastOrdersDataTable()
        {
            //Delete rows on next call of the PopulatePastOrdersDataTable method
            _pastOrdersDataTable.Clear();

            //Initialize the data table with the corresponding data
            foreach (KitchenBarViewModel model in _orderedItems)
            {
                DataRow row = _pastOrdersDataTable.NewRow();
                row["OrderItemId"] = model.OrderItemId;
                row["Name"] = model.Name;
                row["TableOfOrder"] = model.TableOfOrder;
                row["Comment"] = model.Comment;
                row["Time"] = model.TimeElapsed;

                _pastOrdersDataTable.Rows.Add(row);
            }
        }

        //Method to set User/System permissions in the DataGridView
        private void SetDataGridViewPermission()
        {
            ordersDataGridView.AllowUserToAddRows = false;
            ordersDataGridView.AllowUserToDeleteRows = false;
            ordersDataGridView.AllowUserToResizeColumns = false;
            ordersDataGridView.AllowUserToOrderColumns = false;
            ordersDataGridView.AllowUserToResizeRows = false;
            ordersDataGridView.AutoGenerateColumns = false;
        }

        //Method to set the width of some columns in the DataGridView
        //(based on Interaction Design feedback)
        private void SetWidthSettingsInDataGridView(DataGridViewTextBoxColumn orderItemName, DataGridViewTextBoxColumn tableOfOrder, DataGridViewTextBoxColumn orderItemComment)
        {
            ordersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            orderItemName.Width = 450;
            tableOfOrder.Width = 120;
            orderItemComment.Width = 450;
        }

        //Method to declare and initialize the DataGridView with the corresponding columns needed
        private void InitializeDataGridView(DataTable dataTable)
        {
            SetDataGridViewPermission();

            DataGridViewTextBoxColumn orderItemId = new DataGridViewTextBoxColumn();
            orderItemId.HeaderText = "OrderId:";
            orderItemId.DataPropertyName = "OrderItemId";
            orderItemId.ReadOnly = true;
            orderItemId.Visible = false;

            DataGridViewTextBoxColumn orderItemName = new DataGridViewTextBoxColumn();
            orderItemName.HeaderText = "Order:";
            orderItemName.DataPropertyName = "Name";
            orderItemName.ReadOnly = true;

            DataGridViewTextBoxColumn tableOfOrder = new DataGridViewTextBoxColumn();
            tableOfOrder.HeaderText = "Table:";
            tableOfOrder.DataPropertyName = "TableOfOrder";
            tableOfOrder.ReadOnly = true;

            DataGridViewTextBoxColumn orderItemComment = new DataGridViewTextBoxColumn();
            orderItemComment.HeaderText = "Comment:";
            orderItemComment.DataPropertyName = "Comment";
            orderItemComment.ReadOnly = true;

            DataGridViewTextBoxColumn orderItemTimeElapsed = new DataGridViewTextBoxColumn();
            orderItemTimeElapsed.HeaderText = "Time:";
            orderItemTimeElapsed.DataPropertyName = "Time";
            orderItemTimeElapsed.ReadOnly = true;

            DataGridViewButtonColumn button = new DataGridViewButtonColumn();
            button.Text = "Ready";
            button.DataPropertyName = "SetReady";
            button.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#000");
            button.FlatStyle = FlatStyle.Flat;
            button.UseColumnTextForButtonValue = true;

            ordersDataGridView.Columns.Add(orderItemId);
            ordersDataGridView.Columns.Add(orderItemName);
            ordersDataGridView.Columns.Add(tableOfOrder);
            ordersDataGridView.Columns.Add(orderItemComment);
            ordersDataGridView.Columns.Add(orderItemTimeElapsed);
            ordersDataGridView.DataSource = dataTable;
            ordersDataGridView.Columns.Add(button);

            SetWidthSettingsInDataGridView(orderItemName, tableOfOrder, orderItemComment);
        }

        //Method to set the design of the components used in the form
        //(based on Interaction Design feedback)
        private void SetDesignOfComponents()
        {
            //Set the background color of the form
            this.BackColor = ColorTranslator.FromHtml("#E8DCCA");

            //Set the background color of the header panel
            kitchenBarViewHeader.BackColor = ColorTranslator.FromHtml("#D9D9D9");

            //Set the style of button in this form
            SetStyleOfButtons();

            //Set the styling for the DataGridView
            SetStylesOfDataGridView();
        }

        //Method to create round shaped buttons
        private void SetCircularButton(Button button)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(1, 1, button.Width - 4, button.Height - 4);
            button.Region = new Region(path);
        }

        //Method to set the style of the selected button in the panelFilterButtons
        //(based on Interaction Design feedback)
        private void SetStyleOfSelectedButton(Button button)
        {
            button.BackColor = ColorTranslator.FromHtml("#D9D9D9");
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.BorderSize = 2;
            button.Font = new Font("Arial", 20, FontStyle.Bold, GraphicsUnit.Pixel);
        }

        //Method to set the style of the unselected button in the panelFilterButtons
        //(based on Interaction Design feedback)
        private void SetStyleOfUnselectedButton(Button button)
        {
            button.BackColor = ColorTranslator.FromHtml("#E7E7E7");
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderColor = Color.Black;
            button.FlatAppearance.BorderSize = 1;
            button.Font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        //Method to set the style of button in this form
        private void SetStyleOfButtons()
        {
            //Set the shape of the green and red buttons to a circle
            SetCircularButton(btnGreen);
            SetCircularButton(btnRed);

            //Set the style of the selected and unselected button
            SetStyleOfSelectedButton(btnIncomingOrders);
            SetStyleOfUnselectedButton(btnPastOrders);

            //Style of the Refresh button
            btnRefresh.BackColor = ColorTranslator.FromHtml("#D9D9D9");
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderColor = Color.Black;
            btnRefresh.FlatAppearance.BorderSize = 2;
            btnRefresh.Font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        //Method to set the styling of the DataGridView
        //(based on Interaction Design feedback)
        private void SetStylesOfDataGridView()
        {
            //Resert the styles
            ordersDataGridView.AlternatingRowsDefaultCellStyle = null;
            ordersDataGridView.DefaultCellStyle = null;

            //Set the background color of the DataGridView
            ordersDataGridView.BackgroundColor = ColorTranslator.FromHtml("#E4E4E4");

            //Creating a custom style for the header
            DataGridViewCellStyle column_header_cell_style = new DataGridViewCellStyle();
            column_header_cell_style.BackColor = ColorTranslator.FromHtml("#E4E4E4");
            column_header_cell_style.ForeColor = Color.Black;
            column_header_cell_style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            column_header_cell_style.Font = new Font("Arial", 24, FontStyle.Underline, GraphicsUnit.Pixel);
            ordersDataGridView.ColumnHeadersDefaultCellStyle = column_header_cell_style;

            //Creating a custom style for the rows
            DataGridViewCellStyle row_cell_style = new DataGridViewCellStyle();
            row_cell_style.BackColor = ColorTranslator.FromHtml("#D9EFFF");
            row_cell_style.ForeColor = Color.Black;
            row_cell_style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            row_cell_style.Font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
            ordersDataGridView.DefaultCellStyle = row_cell_style;

            //Creating a specific style for the tableId cells
            DataGridViewCellStyle table_cell_style = new DataGridViewCellStyle();
            table_cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ordersDataGridView.Columns[2].DefaultCellStyle = table_cell_style;

            //Creating a specific style for the timer cells
            DataGridViewCellStyle timer_cell_style = new DataGridViewCellStyle();
            timer_cell_style.ForeColor = ColorTranslator.FromHtml("#1D7E1D");
            ordersDataGridView.Columns[4].DefaultCellStyle = timer_cell_style;

            //Creating a specific style for the button cells
            DataGridViewCellStyle button_cell_style = new DataGridViewCellStyle();
            button_cell_style.ForeColor = Color.Black;
            button_cell_style.BackColor = Color.White;
            button_cell_style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ordersDataGridView.Columns[5].DefaultCellStyle = button_cell_style;
        }

        //When the Employee name is clicked, system asks the user if he wants to log out
        private void lblEmployeeName_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                try
                {
                    this.Hide();
                    LogIn logIn = new LogIn();
                    logIn.Closed += (ss, ee) => this.Close();
                    logIn.Show();
                }
                catch (Exception a)
                {
                    MessageBox.Show("An error occured while trying to log out: " + a.Message);
                }
                finally
                {
                    this.Close();
                }
            }
        }
        
        //Tick even method
        private void myTimer_Tick(object sender, EventArgs e, int row, DateTime startTime, TimeSpan averagePerparationTime)
        {
            try
            {
                //Calculates the time elapsed between the current moment and the time when the order was placed in the system
                TimeSpan timeElapsed = DateTime.Now - startTime;
                ordersDataGridView[4, row].Value = timeElapsed.ToString("hh':'mm':'ss");
            }
            catch (Exception a)
            {
                MessageBox.Show("An error occured while trying to record time: " + a.Message);
            }
            
            //Gets the cell where the timer is stored
            string cellValue = ordersDataGridView[4, row].Value.ToString();
            if (cellValue != string.Empty)
            {
                //comparing the average preparation time of an order with the actual time that was spent
                //if the value is -1 that the average has already passed
                if (TimeSpan.Compare(averagePerparationTime, TimeSpan.Parse(cellValue)) == -1)
                {
                    //set cell style of delayed orders
                    DataGridViewContentAlignment contentAlignment = DataGridViewContentAlignment.MiddleLeft;
                    StyleStyleOfDelayedOrders(0, row, "#000000", contentAlignment);
                    StyleStyleOfDelayedOrders(1, row, "#000000", contentAlignment);
                    StyleStyleOfDelayedOrders(3, row, "#000000", contentAlignment);
                    StyleStyleOfDelayedOrders(4, row, "#FF0000", contentAlignment);
                    contentAlignment = DataGridViewContentAlignment.MiddleCenter;
                    StyleStyleOfDelayedOrders(2, row, "#000000", contentAlignment);
                }
            }
        }

        //Method to set cell style of delayed orders
        //(based on Interaction Design feedback)
        private void StyleStyleOfDelayedOrders(int columnIndex, int rowIndex, string hexCode, DataGridViewContentAlignment contentAlignment)
        {
            ordersDataGridView[columnIndex, rowIndex].Style.BackColor = ColorTranslator.FromHtml("#FF9494");
            ordersDataGridView[columnIndex, rowIndex].Style.ForeColor = ColorTranslator.FromHtml(hexCode);
            ordersDataGridView[columnIndex, rowIndex].Style.Alignment = contentAlignment;
            ordersDataGridView[columnIndex, rowIndex].Style.Font = new Font("Arial", 20, FontStyle.Regular, GraphicsUnit.Pixel);
        }

        //When a cell has been selected it is automatically cleared
        //(Because we don't need to select any)
        private void ordersDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            ordersDataGridView.ClearSelection();
        }

        //Code executed when pressing Incoming orders button
        private void btnIncomingOrders_Click(object sender, EventArgs e)
        {
            SetStyleOfSelectedButton(btnIncomingOrders);
            SetStyleOfUnselectedButton(btnPastOrders);
            panelLegend.Visible = true;
            btnRefresh.Visible = true;

            UpdateIncommingOrders();

            ordersDataGridView.Columns[5].Visible = true;
        }

        private void UpdateIncommingOrders()
        {
            //stopping every timer from ticking
            foreach (Timer timer in _timers)
            {
                timer.Stop();
            }
            //clearing the timers from the list
            this._timers.Clear();

            //Extracting all incoming order items from the database from the corresponding type (food or drink)
            _orderedItems = _kitchenBarViewService.GetAllIncomingOrderItems(_menuType);
            PopulateIncomingOrdersDataTable();
            ordersDataGridView.DataSource = _incomingOrdersDataTable;
        }

        //Code executed when pressing Past orders button
        private void btnPastOrders_Click(object sender, EventArgs e)
        {
            SetStyleOfSelectedButton(btnPastOrders);
            SetStyleOfUnselectedButton(btnIncomingOrders);
            panelLegend.Visible = false;
            btnRefresh.Visible = false;
            ordersDataGridView.Columns[5].Visible = false;

            //Extracting all order items from the database from the corresponding type (food or drink) that have been prepared today
            _orderedItems = _kitchenBarViewService.GetPastOrderItemsForToday(_menuType);
            PopulatePastOrdersDataTable();
            foreach (Timer timer in _timers)
            {
                timer.Stop();
            }
            ordersDataGridView.DataSource = _pastOrdersDataTable;
            ordersDataGridView.Columns[4].DefaultCellStyle.ForeColor = Color.Black;
            ordersDataGridView.Columns[5].Visible = false;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            UpdateIncommingOrders();
        }
        
        //Event method that checks when the button in each row is clicked
        private void ordersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //Validating if the button is clicked and it hasn't been clicked before
            if (e.ColumnIndex == 5 && ordersDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor != ColorTranslator.FromHtml("#25E45A"))
            {
                DialogResult result = MessageBox.Show("Do you want to indicate to the waiters that this order is ready for serving?", "Verify order ready", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    //stopping the timer for that already prepared order
                    Timer timer = _timers.ElementAt(e.RowIndex);
                    timer.Stop();
                    //storing the time elapsed for making the order
                    string stopedAt = ordersDataGridView[4, e.RowIndex].Value.ToString();

                    //indicating that order has been prepared
                    ordersDataGridView[e.ColumnIndex, e.RowIndex].Style.BackColor = ColorTranslator.FromHtml("#25E45A");
                    int orderItemId = (int)ordersDataGridView[0, e.RowIndex].Value;
                    //updating the corresponding order in the database
                    _kitchenBarViewService.SetOrderItemAsPrepared(orderItemId, Status.ready, stopedAt);
                }
            }
        }
    }
}
