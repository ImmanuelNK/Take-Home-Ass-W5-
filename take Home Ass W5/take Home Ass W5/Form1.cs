using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace take_Home_Ass_W5
{
    public partial class Form1 : Form
    {
        
        DataTable data1 = new DataTable();
        DataTable data2 = new DataTable();
        DataTable data3 = new DataTable();
        int cek = 0;
        bool sama = false;
        int angka = 0;
        string id = "";
        string idcat = "";
        string pilih = "";
        string pilihcat = "";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.Khaki;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            data1.Columns.Add("ID Product");
            data1.Columns.Add("Nama Product");
            data1.Columns.Add("Harga");
            data1.Columns.Add("Stock");
            data1.Columns.Add("ID Category");
            dataGridView1.DataSource = data1;

            data2.Columns.Add("ID Category");
            data2.Columns.Add("Nama Category");
            dataGridView2.DataSource = data2;

            data1.Rows.Add("J001", "Jas Hitam", "100000", "10", "C1");
            data1.Rows.Add("T001", "T-Shirt Black Pink", "70000", "20", "C2");
            data1.Rows.Add("T002", "T-Shirt Obsessive", "75000", "16", "C2");
            data1.Rows.Add("R001", "Rok Mini", "82000", "26", "C3");
            data1.Rows.Add("J002", "Jeans Biru", "90000", "5", "C4");
            data1.Rows.Add("C001", "Celana Pendek Coklat", "60000", "11", "C4");
            data1.Rows.Add("C002", "Cawat Blink-blink", "1000000", "1", "C5");
            data1.Rows.Add("R002", "Rocca Shirt", "50000", "8", "C2");

            data2.Rows.Add("C1", "Jas");
            data2.Rows.Add("C2", "T-Shirt");
            data2.Rows.Add("C3", "Rok");
            data2.Rows.Add("C4", "Celana");
            data2.Rows.Add("C5", "Cawat");

            data3 = data1.Clone();


            button_addcty.BackColor = Color.Blue;
            button_rmvcty.BackColor = Color.BlueViolet;
            button_add.BackColor = Color.Ivory;
            button_edit.BackColor = Color.Aqua;
            button_remove.BackColor = Color.Coral;
            


            for (int i = 0; i < data2.Rows.Count; i++)
            {
                comboBox_categ.Items.Add(data2.Rows[i][1].ToString());
                comboBox_filter.Items.Add(data2.Rows[i][1].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox_namadet.Text == "" || comboBox_categ.SelectedItem == null || textBox_harga.Text == "" || textBox_stock.Text == "")
            {
                MessageBox.Show("Input yang lengkap", "wooo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else
            {
                for ( int i = 0; i < data1.Rows.Count; i++)
                {
                    if (textBox_namadet.Text[0].ToString() == data1.Rows[i][0] )
                    {
                        if (angka <= Convert.ToInt32(data1.Rows[i][0].ToString().Substring(1)) )
                        {
                            angka = Convert.ToInt32(data1.Rows[i][0].ToString().Substring(1));
                        }
                    }
                    
                }
                angka += 1; 
                id = textBox_namadet.Text[0].ToString();

                for ( int i = 0; i < 3-angka.ToString().Length ; i++ )
                {
                    id += "0";
                }
                for ( int i = 0; i < data2.Rows.Count; i++)
                {
                    if ( comboBox_categ.SelectedItem == data2.Rows[i][1])
                    {
                        idcat = data2.Rows[i][0].ToString();
                    }
                }
                data1.Rows.Add(id + angka, textBox_namadet.Text, textBox_harga.Text, textBox_stock.Text , idcat);
                angka = 0;
            }
        }

        private void button_filter_Click(object sender, EventArgs e)
        {
            comboBox_filter.Enabled = true;
        }

        private void comboBox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
            data3.Rows.Clear();
            for ( int i = 0; i < data1.Rows.Count; i ++ )
            {
                for ( int j = 0; j < data2.Rows.Count; j ++)
                {
                    if ( comboBox_filter.SelectedItem == data2.Rows[j][1] )
                    {
                        if (data1.Rows[i][4].ToString() == data2.Rows[j][0])
                        {
                            
                            data3.Rows.Add(data1.Rows[i][0].ToString(), data1.Rows[i][1].ToString(), data1.Rows[i][2].ToString(), data1.Rows[i][3].ToString(),data1.Rows[i][4].ToString());
                        }
                    }
                   
                }
               
            }

            dataGridView1.DataSource = data3;
        }

        private void button_addcty_Click(object sender, EventArgs e)
        {
            if (textBox_namacat.Text == "")
            {
                MessageBox.Show("HAIZ", " otakmu dimana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                for ( int i = 0; i <data2.Rows.Count; i++)
                {
                    if ( textBox_namacat.Text == data2.Rows[i][1])
                    {
                        sama = true;
                    }

                }
                if ( sama == true )
                {
                    MessageBox.Show("HAIZ", " otakmu dimana", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    for (int i = 0; i < data2.Rows.Count; i++)
                    {
                      
                            if (angka <= Convert.ToInt32(data2.Rows[i][0].ToString().Substring(1)))
                            {
                                angka = Convert.ToInt32(data2.Rows[i][0].ToString().Substring(1));
                            }
                    

                    }
                    angka += 1;

                    data2.Rows.Add("C" + angka, textBox_namacat.Text);
                    comboBox_filter.Items.Add(textBox_namacat.Text);
                    comboBox_categ.Items.Add(textBox_namacat.Text);
                    angka = 0;
                }
            }

        }

        private void button_rmvcty_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data2.Rows.Count; i++)
            {
                if (pilihcat == data2.Rows[i][0].ToString())
                {
                    comboBox_categ.Items.Remove(data2.Rows[i][1].ToString());
                    comboBox_filter.Items.Remove(data2.Rows[i][1].ToString());
                    data2.Rows.Remove(data2.Rows[i]);
                }
            }
            for ( int i = data1.Rows.Count-1; i >= 0; i--)
            {
                if (data1.Rows[i][4] == pilihcat)
                {
                    data1.Rows.Remove(data1.Rows[i]);
                }
            }
        }

        private void button_edit_Click(object sender, EventArgs e)
        {
            for ( int i = 0; i < data1.Rows.Count; i ++)
            {
                if (pilih == data1.Rows[i][0].ToString())
                {
                    
                    data1.Rows[i][1] = textBox_namadet.Text;
                    data1.Rows[i][2] = textBox_harga.Text;
                    if ( Convert.ToInt32(textBox_stock.Text) == 0)
                    {
                        data1.Rows.Remove(data1.Rows[i]);
                    }

                    for ( int j = 0; j < data2.Rows.Count; j ++)
                    {
                        if (comboBox_categ.Text == data2.Rows[j][1])

                        {
                            data1.Rows[i][4] = data2.Rows[j][0];
                        }
                    }

                }

            }
        }

        private void textBox_harga_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void textBox_harga_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_stock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pilih = data1.Rows[e.RowIndex][0].ToString();
            pilih = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();

            for (int i = 0; i < data1.Rows.Count; i++)
            {
                if (pilih == data1.Rows[i][0].ToString())
                {
                    for ( int j = 0; j < data2.Rows.Count; j++)
                    {
                        if (data1.Rows[i][4].ToString() == data2.Rows[j][0])
                        {
                            textBox_namadet.Text = data1.Rows[i][1].ToString();
                            textBox_stock.Text = data1.Rows[i][3].ToString();
                            textBox_harga.Text = data1.Rows[i][2].ToString();
                            comboBox_categ.Text = data2.Rows[j][1].ToString(); ;
                        }
                       
                    }
                   
                }
            }

        }

        private void button_remove_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < data1.Rows.Count; i++)
            {
                if (pilih == data1.Rows[i][0].ToString())
                {
                    
                    data1.Rows.Remove(data1.Rows[i]);
                }

            }
        }

        private void comboBox_categ_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_all_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = data1;
            comboBox_filter.Enabled = false;
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            pilihcat = data2.Rows[e.RowIndex][0].ToString();

        }
    }
}
