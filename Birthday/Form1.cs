using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Birthday
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            Day.Text = date;
            Time.Text = time;
            timer1.Enabled = true;
        }

        private void datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
                datagridview.Rows.Add(1);//add row
            if (e.ColumnIndex == 3)
                datagridview.Rows.RemoveAt(e.RowIndex);//delete row
        }

        private void Check_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string date_now = DateTime.Now.ToShortDateString();//دریافت تاریخ فعلی
            string[] date_array = date_now.Split('/');//جداسازی روز و ماه و سال تاریخ فعلی
            int day = Convert.ToInt32(date_array[0]);//ذخیره روز فعلی
            int month = Convert.ToInt32(date_array[1]);//ذخیره ماه فعلی
            for (int i = 0; i < datagridview.RowCount; i++)
            {
                string temp1 = Convert.ToString(datagridview.Rows[i].Cells[3].Value);
                string temp2 = temp1.Trim();
                if (temp2 != "")//تست تاریخ تولد کارمند
                {
                    string employee = datagridview.Rows[i].Cells[3].Value.ToString().Trim();
                    string date_employee = employee;//دریافت تاریخ تولد کارمند
                    string[] date_employee_array = date_employee.Split('/', ' ');//جداسازی روز و ماه و سال
                    int day_employee = Convert.ToInt32(date_employee_array[1]);//ذخیره روز تولد کارمند
                    int month_employee = Convert.ToInt32(date_employee_array[0]);//ذخیره ماه تولد کارمند
                    if (day_employee == day && month_employee == month)//تست ماه و روز کارمند با ماه و روز تاریخ فعلی
                    {
                        counter++;
                        if (Convert.ToString(datagridview.Rows[i].Cells[1].Value) != "")//خالی نبودن قسمت نام کارمند
                            MessageBox.Show($"happy birthday {datagridview.Rows[i].Cells[1].Value.ToString().Trim()}");
                        else//یه قدم تا کامل و بی نقص بودن برداشتم
                            MessageBox.Show("happy birthday Anonymous:)");
                    }
                }
            }
            if (counter == 0)
                MessageBox.Show("متاسفانه امروز تولد کسی نیست");
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            DialogResult message = MessageBox.Show("are you sure?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
                datagridview.Rows.Clear();
            else
                MessageBox.Show("Operation canceled");
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            datagridview.Rows.Add(1);
            int row_count = datagridview.RowCount;

            int id = Convert.ToInt32(ID_Textbox.Text);
            string firstname = Firstname_Textbox.Text, lastname = Lastname_Textbox.Text,
            sex = Sex_Textbox.Text, age = Age_Textbox.Text;

            datagridview.Rows[row_count - 1].Cells[0].Value = id;
            datagridview.Rows[row_count - 1].Cells[1].Value = firstname;
            datagridview.Rows[row_count - 1].Cells[2].Value = lastname;
            datagridview.Rows[row_count - 1].Cells[3].Value = sex;
            datagridview.Rows[row_count - 1].Cells[4].Value = age;
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedIndex == 0)
                {
                    int id = Convert.ToInt32(ID_Textbox.Text);
                    for (int i = 0; i < datagridview.RowCount; i++)
                    {
                        if (Convert.ToInt32(datagridview.Rows[i].Cells[0].Value) == id)
                            MessageBox.Show($"[{id}] Found! it is in row [{i + 1}]");
                    }
                }
                if (comboBox1.SelectedIndex == 1)
                {
                    string firstname = Firstname_Textbox.Text;
                    for (int i = 0; i < datagridview.RowCount; i++)
                    {
                        if (datagridview.Rows[i].Cells[1].Value.ToString() == firstname)
                            MessageBox.Show($"[{firstname}] Found! it is in row [{i + 1}]");
                    }
                }
                if (comboBox1.SelectedIndex == 2)
                {
                    string lastname = Lastname_Textbox.Text;
                    for (int i = 0; i < datagridview.RowCount; i++)
                    {
                        if (datagridview.Rows[i].Cells[1].Value.ToString() == lastname)
                            MessageBox.Show($"[{lastname}] Found! it is in row [{i + 1}]");
                    }
                }
                if (comboBox1.SelectedIndex == 3)
                {
                    string sex = Sex_Textbox.Text;
                    for (int i = 0; i < datagridview.RowCount; i++)
                    {
                        if (datagridview.Rows[i].Cells[1].Value.ToString() == sex)
                            MessageBox.Show($"[{sex}] Found! it is in row [{i + 1}]");
                    }
                }
                if (comboBox1.SelectedIndex == 4)
                {
                    string age = Age_Textbox.Text;
                    for (int i = 0; i < datagridview.RowCount; i++)
                    {
                        if (datagridview.Rows[i].Cells[1].Value.ToString() == age)
                            MessageBox.Show($"[{age}] Found! it is in row [{i + 1}]");
                    }
                }
            }
            catch
            {
                MessageBox.Show("لطفا اطلاعات مورد نظر را وارد کنید یا از کمبوباکس انتخاب کنید برچه اساسی جست و جو انجام شود");
            }
            finally
            {
                MessageBox.Show("Finish");
            }
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            int row_index = Convert.ToInt32(Remove_Column_Textbox.Text);
            DialogResult message = MessageBox.Show($"are you sure to delete row [{row_index}]?",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (message == DialogResult.Yes)
                datagridview.Rows.RemoveAt(row_index);
            else
                MessageBox.Show("Operation canceled");
        }

        private void ID_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
                && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void Age_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
                && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void Remove_Column_Textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != Convert.ToChar(8)
                && e.KeyChar < '0' || e.KeyChar > '9')
                e.Handled = true;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            datagridview.Rows.Add(3);
            datagridview.Rows[0].Cells[0].Value = "1";
            datagridview.Rows[0].Cells[1].Value = "ALI";
            datagridview.Rows[0].Cells[3].Value = "05/03/1995 gdfgfdfg";

            datagridview.Rows[1].Cells[0].Value = "2";
            datagridview.Rows[1].Cells[1].Value = "mohammad";
            datagridview.Rows[1].Cells[3].Value = "2014/5/1401 gfddgfgfd";
        }

        private void simpleButton2_Click_1(object sender, EventArgs e)
        {
            int count = datagridview.GetCellCount(DataGridViewElementStates.Visible);
            MessageBox.Show($"All cells : {count}");
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string date_now = DateTime.Now.ToShortDateString();//دریافت تاریخ فعلی
            string[] date_array = date_now.Split('/');//جداسازی روز و ماه و سال تاریخ فعلی
            int day = Convert.ToInt32(date_array[0]);//ذخیره روز فعلی
            int month = Convert.ToInt32(date_array[1]);//ذخیره ماه فعلی
            for (int i = 0; i < datagridview.RowCount; i++)
            {
                string temp1 = Convert.ToString(datagridview.Rows[i].Cells[3].Value);
                string temp2 = temp1.Trim();
                if (temp2 != "")//تست تاریخ تولد کارمند
                {
                    string employee = datagridview.Rows[i].Cells[2].Value.ToString().Trim();
                    string date_employee = employee;//دریافت تاریخ تولد کارمند
                    string[] date_employee_array = date_employee.Split('/', ' ');//جداسازی روز و ماه و سال
                    int day_employee = Convert.ToInt32(date_employee_array[3]);//ذخیره روز تولد کارمند
                    int month_employee = Convert.ToInt32(date_employee_array[1]);//ذخیره ماه تولد کارمند
                    if (day_employee == day && month_employee == month)//تست ماه و روز کارمند با ماه و روز تاریخ فعلی
                    {
                        counter++;
                        if (Convert.ToString(datagridview.Rows[i].Cells[1].Value) != "")//خالی نبودن قسمت نام کارمند
                            MessageBox.Show($"happy birthday {datagridview.Rows[i].Cells[1].Value.ToString().Trim()}");
                        else//یه قدم تا کامل و بی نقص بودن برداشتم
                            MessageBox.Show("happy birthday Anonymous:)");//عملا هیچ وقت جواب نمیده
                    }
                }
            }
            if (counter == 0)
                MessageBox.Show("متاسفانه امروز تولد کسی نیست");
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            string employee, date_employee, temp;
            string[] date_employee_array;
            int day_employee, month_employee;
            string date_now = DateTime.Now.ToShortDateString();//دریافت تاریخ فعلی
            string[] date_array = date_now.Split('/');//جداسازی روز و ماه و سال تاریخ فعلی
            int day = Convert.ToInt32(date_array[0]);//ذخیره روز فعلی
            int month = Convert.ToInt32(date_array[1]);//ذخیره ماه فعلی
            string connection_string = "Server = server name; Database = database; User Id = username; Password = password;";
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();
            try
            {
                listBox1.Items.Clear();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "select * from نام جدول";
                SqlDataReader data_reader = command.ExecuteReader();
                while (data_reader.Read())
                {
                    temp = Convert.ToString(data_reader["نام ستون تاریخ توی دیتابیس"]).Trim();
                    if (temp != "")//تست تاریخ تولد کارمند
                    {
                        employee = temp;
                        date_employee = employee;//دریافت تاریخ تولد کارمند
                        date_employee_array = date_employee.Split('/', ' ');//جداسازی روز و ماه و سال
                        day_employee = Convert.ToInt32(date_employee_array[1]);//ذخیره روز تولد کارمند
                        month_employee = Convert.ToInt32(date_employee_array[0]);//ذخیره ماه تولد کارمند
                        if (day_employee == day && month_employee == month)//تست ماه و روز کارمند با ماه و روز تاریخ فعلی
                            listBox1.Items.Add(data_reader["ستون نام افراد در دیتابیس"]);
                    }
                }
                if (listBox1.Items.Count == 0)
                    MessageBox.Show("متاسفانه امروز تولد کسی نیست");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            string connection_string = "Server = server name; Database = database; User Id = username; Password = password;";
            SqlConnection connection = new SqlConnection(connection_string);
            connection.Open();
            try
            {
                listBox1.Items.Clear();
                SqlCommand command = new SqlCommand();
                command.Connection = connection;
                command.CommandText = "YOUR FULL QUERY";
                SqlDataReader data_reader = command.ExecuteReader();
                while (data_reader.Read())
                {
                    listBox1.Items.Add(data_reader["ستون نام افراد"]);
                }
                if (listBox1.Items.Count == 0)
                    MessageBox.Show("متاسفانه امروز تولد کسی نیست");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        private void Add_Button_Click_1(object sender, EventArgs e)
        {
            datagridview.Rows.Add();
            int index = datagridview.RowCount - 1;
            string id = ID_Textbox.Text,
                firstname = Firstname_Textbox.Text,
                lastname = Lastname_Textbox.Text,
                sex = Sex_Textbox.Text,
                age = Age_Textbox.Text;
            datagridview.Rows.Add();
            datagridview.Rows[index].Cells[0].Value = id;
            datagridview.Rows[index].Cells[1].Value = firstname;
            datagridview.Rows[index].Cells[2].Value = lastname;
            datagridview.Rows[index].Cells[4].Value = sex;
            datagridview.Rows[index].Cells[5].Value = age;
            listBox1.Items.Add($"{firstname} {lastname}");
        }

        private void Search_Button_Click_1(object sender, EventArgs e)
        {
            int index = comboBox1.SelectedIndex;
            //search by id
            if (index == 1)
            {
                bool flag = false;
                int length = datagridview.RowCount;
                string id = ID_Textbox.Text;
                for (int i = 0; i < length; i++)
                {
                    string temp = Convert.ToString(datagridview.Rows[i].Cells[0].Value);
                    if (temp == id)
                    {
                        flag = true;
                        MessageBox.Show($"{id} Found! it's in row {i + 1}");
                    }
                }
                if (!flag)
                    MessageBox.Show($"{id} Not found!");
            }
            //------------------//
            //search by firstname
            if (index == 2)
            {
                bool flag = false;
                int length = datagridview.RowCount;
                string firstname = Firstname_Textbox.Text;
                for (int i = 0; i < length; i++)
                {
                    string temp = Convert.ToString(datagridview.Rows[i].Cells[1].Value);
                    if (temp == firstname)
                    {
                        flag = true;
                        MessageBox.Show($"{firstname} Found! it's in row {i + 1}");
                    }
                }
                if (!flag)
                    MessageBox.Show($"{firstname} Not found!");
            }
            //--------------------//
            //search by lastname
            if (index == 3)
            {
                bool flag = false;
                int length = datagridview.RowCount;
                string lastname = Lastname_Textbox.Text;
                for (int i = 0; i < length; i++)
                {
                    string temp = Convert.ToString(datagridview.Rows[i].Cells[2].Value);
                    if (temp == lastname)
                    {
                        flag = true;
                        MessageBox.Show($"{lastname} Found! it's in row {i + 1}");
                    }
                }
                if (!flag)
                    MessageBox.Show($"{lastname} Not found!");
            }
            //------------------//
            //search by sex
            if (index == 4)
            {
                bool flag = false;
                int length = datagridview.RowCount;
                string sex = Sex_Textbox.Text;
                for (int i = 0; i < length; i++)
                {
                    string temp = Convert.ToString(datagridview.Rows[i].Cells[4].Value);
                    if (temp == sex)
                    {
                        flag = true;
                        MessageBox.Show($"{sex} Found! it's in row {i + 1}");
                    }
                }
                if (!flag)
                    MessageBox.Show($"{sex} Not found!");
            }
            //---------------------//
            //search by age
            if (index == 5)
            {
                bool flag = false;
                int length = datagridview.RowCount;
                string age = Age_Textbox.Text;
                for (int i = 0; i < length; i++)
                {
                    string temp = Convert.ToString(datagridview.Rows[i].Cells[5].Value);
                    if (temp == age)
                    {
                        flag = true;
                        MessageBox.Show($"{age} Found! it's in row {i + 1}");
                    }
                }
                if (!flag)
                    MessageBox.Show($"{age} Not found!");
            }
            //---------------------//
        }

        private void Remove_Row_Click(object sender, EventArgs e)
        {
            int remove = Convert.ToInt32(Remove_Column_Textbox.Text);
            datagridview.Rows.RemoveAt(remove);
            listBox1.Items.RemoveAt(remove);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            datagridview.Rows.Clear();
            listBox1.Items.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToLongDateString();
            string time = DateTime.Now.ToLongTimeString();
            Day.Text = date;
            Time.Text = time;
        }
    }
}