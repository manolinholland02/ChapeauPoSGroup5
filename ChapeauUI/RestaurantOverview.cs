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

        public RestaurantOverview(Employee employee)
        {
            this.employee = employee;
            InitializeComponent();
            lblName.Text = $"{this.employee.EmployeeFirstName} {this.employee.EmployeeLastName}";
            msgBoxButtons = MessageBoxButtons.YesNo;
            tableService = new TableService();
            tables = LoadTables();
            buttons = AddButtonsToList();
            LoadButtons(tables, AddButtonsToList());
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
            for (int i = 0; i < buttons.Length; i++)
            {
                if (tables[i].TableStatus == TableStatus.free) buttons[i].BackColor = ColorTranslator.FromHtml("#47D147");
                else if (tables[i].TableStatus == TableStatus.occupied) buttons[i].BackColor = ColorTranslator.FromHtml("#EC5C5C");
                else if (tables[i].TableStatus == TableStatus.haveOrder) buttons[i].BackColor = ColorTranslator.FromHtml("#ECEF58");
            }
        }

        private void CheckTableStatus(Table table)
        {
            if (table.TableStatus == TableStatus.free)
            {
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
                StartOrderDialogBox orderDialogBox = StartOrderDialogBox.GetInstance();
                if (orderDialogBox.ShowDialog() == DialogResult.Yes)
                {
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

                    Order order = new Order()
                    {
                        WaiterId = employee.EmployeeID,
                        TableId = table.TableId,
                        PaymentId = payment.PaymentId,
                        IsPaid = false
                    };
                    OrderService orderService = new OrderService();
                    orderService.InsertNewOrder(order);
                    order = orderService.GetLastOrder(table.TableId);

                    LoadButtons(tables, buttons);
                    this.Hide();
                    ChoosingMenuForm choosingMenuForm = new ChoosingMenuForm(table.TableId, employee, orderService, this);
                    choosingMenuForm.Show();
                }
                else if (orderDialogBox.ShowDialog() == DialogResult.OK)
                {
                    table.TableStatus = TableStatus.free;
                    tableService.UpdateTableStatus(table);
                    LoadButtons(tables, buttons);
                }
            }

        }

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
    }
}
