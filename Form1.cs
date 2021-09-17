using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ACK_KimHyunWoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 이 코드는 데이터를 'ackDataSet1.student' 테이블에 로드합니다. 필요 시 이 코드를 이동하거나 제거할 수 있습니다.
            //this.studentTableAdapter1.Fill(this.ackDataSet1.student);

        }

        private void Btn_Read_Click(object sender, EventArgs e)
        {
            this.studentTableAdapter.Fill(this.ackDataSet.student);
            MessageBox.Show("Read 성공");
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.ackDataSet);
            MessageBox.Show("Update 성공");
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.ackDataSet);
            MessageBox.Show("Insert 성공");
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(dataGridView1.Rows[i].Selected == true)
                {
                    dataGridView1.Rows.Remove(dataGridView1.Rows[i]);
                }
            }
            this.Validate();
            this.studentBindingSource.EndEdit();
            this.studentTableAdapter.Update(this.ackDataSet);
            MessageBox.Show("Delete 성공");
        }
    }
}
