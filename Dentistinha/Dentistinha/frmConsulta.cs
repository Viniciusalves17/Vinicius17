using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dentistinha
{
    public partial class frmConsulta : Form
    {
        Consulta objconsulta;
        Conexao con = new Conexao();
       
        public frmConsulta()
        {
            InitializeComponent();
            con = new Conexao();
        }
        private void bloquearbotoes () // função bloquear botoês
        {
            btn_Novo.Enabled = false;
            btn_Excluir.Enabled = false;
        }
        public void limparcampos () // funcão Limpar campos
        {
            txt_Id_Consulta.Text = "";
            txt_Diagnostico.Text = "";
            txt_Motivo.Text = "";
            txt_Receita.Text = "";
            txt_Retorno.Text = "";
        }

        private void desbloquearcampos() // Função desbloquear campos
        {
            txt_Diagnostico.ReadOnly = false;
            txt_Id_Consulta.ReadOnly = false;
            txt_Motivo.ReadOnly = false;
            txt_Receita.ReadOnly = false;
            txt_Retorno.ReadOnly = false;
                
        }
        private void bloquearcampos() // Função bloquear campos
        {
            txt_Diagnostico.ReadOnly = true;
            txt_Id_Consulta.ReadOnly = true;
            txt_Motivo.ReadOnly = true;
            txt_Receita.ReadOnly = true;
            txt_Retorno.ReadOnly = true;
        }

        public void lerdados ()
        {
            objconsulta = new Consulta();
            objconsulta.ID_Consulta = int.Parse(txt_Id_Consulta.Text.Trim());
            objconsulta.Motivo = txt_Motivo.Text;
            objconsulta.DTConsulta = DT_Consulta.Value;
            objconsulta.Receita = txt_Receita.Text;
            objconsulta.Diagnostico = txt_Diagnostico.Text;
            objconsulta.DTRetorno = DT_Retorno.Value;
            objconsulta.Retorno = txt_Retorno.Text;
            objconsulta.ID_Dentista = int.Parse(cmb_Dentista.SelectedValue.ToString());
            objconsulta.ID_Paciente = int.Parse(cmb_Paciente.SelectedValue.ToString());

        }
        public void atualizargrid ()
        {
            List<Consulta> listConsulta = new List<Consulta>();
            con.conectar();
            SqlDataReader reader;
            reader = con.execonsulta("select * from TB_Consulta");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Consulta consulta = new Consulta();
                    consulta.ID_Consulta = reader.GetInt32(0);
                    consulta.Motivo = reader.GetString(1);
                    consulta.DTConsulta = reader.GetDateTime(2);
                    consulta.Receita = reader.GetString(3);
                    consulta.Diagnostico = reader.GetString(4);
                    consulta.DTRetorno = reader.GetDateTime(5);
                    consulta.Retorno = reader.GetString(6);
                    consulta.ID_Paciente = reader.GetInt32(7);
                    consulta.ID_Dentista = reader.GetInt32(8);
                    listConsulta.Add(consulta);

                }
                reader.Close();
            }
            else
            {
                Console.WriteLine("Dados Inavlidos");
            }
            DTGW_Consulta.DataSource = null;
            DTGW_Consulta.DataSource = listConsulta;
        }
     

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btn_Novo_Click(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            txt_Id_Consulta.Focus();
        }

        private void frmConsulta_Load(object sender, EventArgs e)
        {
            atualizargrid();
            bloquearcampos();
            
        }
        
        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert TB_Consulta values( " + objconsulta.ID_Consulta + ",'"
              + objconsulta.Motivo + "','"
              + objconsulta.DTConsulta + "','"
              + objconsulta.Receita + "','"
              + objconsulta.Diagnostico + "','"
              + objconsulta.DTRetorno + "','"
                + objconsulta.Retorno + "',"
                + objconsulta.ID_Paciente + ","
                + objconsulta.ID_Dentista + ")";
            con.conectar();
            if (con.executar(sql) == 1)
            {
                MessageBox.Show("Seus Dados foram Salvos !!");

            }
            else
            {
                MessageBox.Show("Erro");
            }
            bloquearcampos();
            atualizargrid();

        }

        private void DTGW_Consulta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_Id_Consulta.Text = DTGW_Consulta.CurrentRow.Cells[0].Value.ToString();
            txt_Motivo.Text = DTGW_Consulta.CurrentRow.Cells[1].Value.ToString();
            DT_Consulta.Value = DateTime.Parse(DTGW_Consulta.CurrentRow.Cells[2].Value.ToString());
            txt_Receita.Text = DTGW_Consulta.CurrentRow.Cells[3].Value.ToString();
            txt_Diagnostico.Text = DTGW_Consulta.CurrentRow.Cells[4].Value.ToString();
            DT_Retorno.Value = DateTime.Parse(DTGW_Consulta.CurrentRow.Cells[3].Value.ToString());
            txt_Retorno.Text = DTGW_Consulta.CurrentRow.Cells[5].Value.ToString();
            cmb_Paciente.Text = DTGW_Consulta.CurrentRow.Cells[6].Value.ToString();
            cmb_Dentista.Text = DTGW_Consulta.CurrentRow.Cells[7].Value.ToString();
        }

        private void btn_Excluir_Click(object sender, EventArgs e)
        {
            if (txt_Id_Consulta.Text.Equals(""))
            {
                MessageBox.Show("Favor clicar em um campo");
            }
            else
            {
                String sql = " delete from tb_consulta where ID = " + txt_Id_Consulta.Text;
                con.executar(sql);
                atualizargrid();
            }
        }
    }
}
