using ChapeauModel;
using ChapeauLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChapeauUI
{
    public partial class RestaurantOverview : Form
    {
        private Employee employee;
        private Table table;
        private Table[] tables;
        private Button[] buttons;
        TableService tableService;
        private MessageBoxButtons msgBoxButtons;
        private DialogResult result;
        private OrderItemService orderItemService;
        private Order order;
        private OrderService orderService;
        private ChoosingMenuForm choosingMenuForm;

        public RestaurantOverview(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            lblName.Text = $"{this.employee.EmployeeFirstName} {this.employee.EmployeeLastName}";
            msgBoxButtons = MessageBoxButtons.YesNo;
            tableService = new TableService();
            orderItemService = new OrderItemService();
            tables = LoadTables();
            buttons = AddButtonsToList();
            LoadButtons(tables, AddButtonsToList());
            pnlDisplayOrderItems.Visible = false;
            orderService = new OrderService();
            orderItemsListView.FullRowSelect = true;

        }

        private Table[] LoadTables()
        {
            Table[] tableArray = new Table[10];
            for (int i = 1; i <= tableArray.Length; i++)
            {
                tableArray[i - 1] = tableService.GetTable(i);
            }

            return tableArray;
        }

        private Button[] AddButtonsToList()
        {
            Button[] buttonArray = new Button[10] { btnTable1, btnTable2, btnTable3, btnTable4, btnTable5, btnTable6, btnTable7, btnTable8, btnTable9, btnTable10 };

            return buttonArray;
        }

        private void LoadButtons(Table[] tables, Button[] buttons)
        {
            // set colors for buttons depending on the table status
            for (int i = 0; i < buttons.Length; i++)
            {
                // set table color to green if it is free
                if (tables[i].TableStatus == TableStatus.free) buttons[i].BackColor = ColorTranslator.FromHtml("#47D147");
                // set table color to red if it is occupied
                else if (tables[i].TableStatus == TableStatus.occupied) buttons[i].BackColor = ColorTranslator.FromHtml("#EC5C5C");
                // set table color to yellow if it has an order
                else if (tables[i].TableStatus == TableStatus.haveOrder) buttons[i].BackColor = ColorTranslator.FromHtml("#ECEF58");
            }
        }

        private void CheckTableStatus(Table table)
        {
            if (table.TableStatus == TableStatus.free)
            {
                // hide items panel
                if (pnlDisplayOrderItems.Visible) 
                    pnlDisplayOrderItems.Visible = false;

                OccupyDialogBox occupyDialogBox = OccupyDialogBox.GetInstance();
                if (occupyDialogBox.ShowDialog() == DialogResult.Yes)
                {
                    table.TableStatus = TableStatus.occupied;
                    tableService.UpdateTableStatus(table);
                    LoadButtons(tables, buttons);
                }
            }
            else if (table.TableStatus == TableStatus.occupied)
            {
                // hide items panel
                if (pnlDisplayOrderItems.Visible) 
                    pnlDisplayOrderItems.Visible = false;

                StartOrderDialogBox orderDialogBox = StartOrderDialogBox.GetInstance();
                if (orderDialogBox.ShowDialog() == DialogResult.Yes)
                {
                    // change table status 
                    table.TableStatus = TableStatus.haveOrder;
                    tableService.UpdateTableStatus(table);

                    Payment payment = new Payment()
                    {
                        PaymentPrice = 0,
                        Tip = 0,
                        TableId = table.TableId
                    };
                    PaymentService paymentService = new PaymentService();
                    paymentService.InsertPayment(payment);
                    payment = paymentService.GetLastPayment(table.TableId);

                    order = new Order()
                    {
                        WaiterId = employee.EmployeeID,
                        TableId = table.TableId,
                        PaymentId = payment.PaymentId,
                        IsPaid = false
                    };
                    orderService.InsertNewOrder(order);
                    order = orderService.GetLastOrder(table.TableId);

                    LoadButtons(tables, buttons);
                    this.Hide();
                    choosingMenuForm = new ChoosingMenuForm(table.TableId, employee, orderService, this);
                    choosingMenuForm.Show();
                }
                //
                else if (orderDialogBox.ShowDialog() == DialogResult.OK)
                {
                    table.TableStatus = TableStatus.free;
                    tableService.UpdateTableStatus(table);
                    LoadButtons(tables, buttons);
                }
            }
            else if (table.TableStatus == TableStatus.haveOrder)
            {
                if (!pnlDisplayOrderItems.Visible) 
                    pnlDisplayOrderItems.Visible = true;

                orderItemsListView.Items.Clear();
                lblTable.Text = "Orders of Table " + table.TableId.ToString();

                order = orderService.GetLastOrder(table.TableId);
                List<OrderItem> orderItems = orderItemService.GetAllOrders(order.OrderId);
                if (orderItems.Count == 0)
                {
                    btnDeleteOrder.Visible = true;
                    btnAddOrderItems.Visible = true;
                    btnSetItemAsServed.Visible = false;
                    btnPay.Visible = false;
                }
                else
                {
                    btnDeleteOrder.Visible = false;
                    btnSetItemAsServed.Visible = true;
                    btnPay.Visible = true;
                    btnAddOrderItems.Visible = true;
                }

                foreach(OrderItem orderItem in orderItems)
                {
                    string[] output = { orderItem.OrderItemID.ToString(), orderItem.OrderDesign, orderItem.Status.ToString() };
                    ListViewItem item = new ListViewItem(output);
                    orderItemsListView.Items.Add(item);
                }
            }

        }
        // set status for all the tables
        private void btnTable1_Click(object sender, EventArgs e)
        {
            table = tables[0];
            CheckTableStatus(table);
        }

        private void btnTable2_Click(object sender, EventArgs e)
        {
            table = tables[1];
            CheckTableStatus(table);
        }

        private void btnTable3_Click(object sender, EventArgs e)
        {
            table = tables[2];
            CheckTableStatus(table);
        }

        private void btnTable4_Click(object sender, EventArgs e)
        {
            table = tables[3];
            CheckTableStatus(table);
        }

        private void btnTable5_Click(object sender, EventArgs e)
        {
            table = tables[4];
            CheckTableStatus(table);
        }

        private void btnTable6_Click(object sender, EventArgs e)
        {
            table = tables[5];
            CheckTableStatus(table);
        }

        private void btnTable7_Click(object sender, EventArgs e)
        {
            table = tables[6];
            CheckTableStatus(table);
        }

        private void btnTable8_Click(object sender, EventArgs e)
        {
            table = tables[7];
            CheckTableStatus(table);
        }

        private void btnTable9_Click(object sender, EventArgs e)
        {
            table = tables[8];
            CheckTableStatus(table);
        }

        private void btnTable10_Click(object sender, EventArgs e)
        {
            table = tables[9];
            CheckTableStatus(table);
        }

        private void lblName_Click(object sender, EventArgs e)
        {

            string message = "Are you sure you want to Logout?";
            string title = "Logout";
            result = MessageBox.Show(message, title, msgBoxButtons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                LogIn login = new LogIn();
                login.Show();
                this.Close();
            }
        }

        private List<OrderItem> GetSelectedOrderItemsFromListView()
        {
            List<OrderItem> selectedOrderItems = new List<OrderItem>();
            foreach (ListViewItem item in orderItemsListView.SelectedItems)
            {
                selectedOrderItems.Add(orderItemService.GetSpecificOrder(int.Parse(item.SubItems[0].Text)));
            }
            return selectedOrderItems;
        }

        private void btnPay_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteOrder_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show($"Do you want to free table {table.TableId}?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes)
            {
                // delete the order
                orderService.DeleteOrder(order.OrderId);
                // set the table status
                table.TableStatus = TableStatus.free;
                // update the table status
                tableService.UpdateTableStatus(table);
                // close the panel displaying the order items
                pnlDisplayOrderItems.Visible = false;
                // load buttons again
                LoadButtons(tables, buttons);
            }
        }

        private void btnSetItemAsServed_Click(object sender, EventArgs e)
        {
            // the waiter hasn't selected any items
            if(orderItemsListView.SelectedItems.Count == 0) 
                MessageBox.Show($"No items have been selected.", "Please select an item first", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                DialogResult result = MessageBox.Show($"Do you want to set {orderItemsListView.SelectedItems.Count} items of table {table.TableId} as served?", "Conformation", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    List<OrderItem> orderItems = GetSelectedOrderItemsFromListView();
                    foreach (OrderItem orderItem in orderItems)
                    {
                        if (orderItem.Status == Status.ready)
                        {
                            orderItemService.UpdateOrderItemStatus(orderItem.OrderItemID, Status.finished);
                            orderItemsListView.SelectedItems.Clear();
                            CheckTableStatus(table);
                        }
                        else
                        {
                            MessageBox.Show("Only ready items in that table can be checked as served.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                            break;
                        }
                    }
                }
            }
        }

        private void btnAddOrderItems_Click(object sender, EventArgs e)
        {
            // open the menu form to add order items to the table
            this.Hide();
            choosingMenuForm = new ChoosingMenuForm(table.TableId, employee, orderService, this);
            choosingMenuForm.Show();
        }
    }
}
