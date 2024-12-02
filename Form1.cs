﻿using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _505064_MuhammadBudiSetiawan_ResponsiJuniorProject
{
    public partial class Form1 : Form
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private string sql;
        private string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=12345678;Database=responsijuniorproject";
        private DataTable dt;
        public Form1()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            try
            {
                conn = new NpgsqlConnection(connectionString);
                sql = "SELECT k.id_karyawan, k.nama, k.id_dep, d.nama_dep FROM karyawan AS k JOIN departemen AS d ON k.id_dep = d.id_dep;";
                conn.Open();
                cmd = new NpgsqlCommand(sql, conn);
                dt = new DataTable();
                dt.Load(cmd.ExecuteReader());
                dgv.DataSource = dt;
                tb_empName.Text = null;
                cb_dept.SelectedIndex = -1;
            } 
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void lbl_empName_Click(object sender, EventArgs e)
        {

        }

        private void btn_insert_Click(object sender, EventArgs e)
        {
            if (tb_empName.Text == null)
            {
                MessageBox.Show("Fill name");
                return;
            }
            if (cb_dept.SelectedIndex == -1)
            {
                MessageBox.Show("Fill Departement");
                return;
            }
            try
            {
                conn = new NpgsqlConnection(connectionString);
                conn.Open();
                sql = @"SELECT COUNT(*) FROM karyawan WHERE nama = @nama;";
                cmd = new NpgsqlCommand(sql,conn);
                cmd.Parameters.AddWithValue("@nama", tb_empName.Text);
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                {
                    sql = @"select max(id_karyawan) from karyawan;";
                    cmd = new NpgsqlCommand(sql, conn);
                    var max = cmd.ExecuteScalar();
                    if (max == DBNull.Value)
                    {
                        sql = @"INSERT INTO karyawan (id_karyawan, nama, id_dep) VALUES (@id, @nama, @id_dep);";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", 0);
                        cmd.Parameters.AddWithValue("@nama", tb_empName.Text);
                        cmd.Parameters.AddWithValue("@id_dep", cb_dept.SelectedIndex);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insert Employ Success");
                    }
                    else if (Convert.ToInt32(max) >=0)
                    {
                        sql = @"INSERT INTO karyawan (id_karyawan, nama, id_dep) VALUES (@id, @nama, @id_dep);";
                        cmd = new NpgsqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@id", Convert.ToInt32(max) + 1);
                        cmd.Parameters.AddWithValue("@nama", tb_empName.Text);
                        cmd.Parameters.AddWithValue("@id_dep", cb_dept.SelectedIndex);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Insert Employ Success");
                    }
                } 
                else
                {
                    MessageBox.Show("Employ Duplicated");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { 
                conn.Close(); 
                LoadData();
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (tb_empName.Text == null)
            {
                MessageBox.Show("Fill name");
                return;
            }
            if (cb_dept.SelectedIndex == -1)
            {
                MessageBox.Show("Fill Departement");
                return;
            }
            if (dgv.CurrentRow != null)
            {
                int id = int.Parse(dgv.CurrentRow.Cells["id_karyawan"].Value.ToString());
                try
                {
                    conn = new NpgsqlConnection(connectionString);
                    conn.Open();
                    sql = @"UPDATE karyawan SET nama=@nama, id_dep = @id_dep WHERE id_karyawan=@id;";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.Parameters.AddWithValue("@nama", tb_empName.Text);
                    cmd.Parameters.AddWithValue("@id_dep", cb_dept.SelectedIndex);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Success");
                } 
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                    LoadData();
                }
            } 
            else
            {
                MessageBox.Show("Select Employe");
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == 0)
            {
                try
                {
                    DataGridViewRow selectedRow = dgv.Rows[e.RowIndex];
                    tb_empName.Text = selectedRow.Cells["nama"].Value.ToString();
                    cb_dept.SelectedIndex = int.Parse(selectedRow.Cells["id_dep"].Value.ToString());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow != null)
            {
                int id = int.Parse(dgv.CurrentRow.Cells["id_karyawan"].Value.ToString());
                try
                {
                    conn = new NpgsqlConnection(connectionString);
                    conn.Open();
                    sql = @"DELETE FROM karyawan WHERE id_karyawan=@id;";
                    cmd = new NpgsqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}");
                }
                finally
                {
                    conn.Close();
                    LoadData();
                }
            }
        }
    }
}