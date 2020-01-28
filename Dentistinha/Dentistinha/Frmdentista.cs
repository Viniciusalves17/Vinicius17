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
    public partial class Frmdentista : Form , Interface1
    {
        Dentista objdentista;
        Conexao con = new Conexao();
        public Frmdentista()
        {
            InitializeComponent();
            con = new Conexao();
        }
        public void limparcampos ()
        {
            txt_ID.Text = "";
            txt_Nome.Text = "";
            txt_CRO.Text = "";
        }
              private void desbloquearcampos ()
        {
            txt_ID.ReadOnly = false;
            txt_Nome.ReadOnly = false;
            txt_CRO.ReadOnly = false;
        }
        private void bloquearcampos ()
        {
            txt_ID.ReadOnly = true;
            txt_Nome.ReadOnly = true;
            txt_CRO.ReadOnly = true;
                
        }
        public void lerdados ()
        {
            objdentista = new Dentista();
            objdentista.ID = int.Parse(txt_ID.Text.Trim());
            objdentista.nome = txt_Nome.Text;
            objdentista.CRO = txt_CRO.Text;
            objdentista.Instagram = CH_instagram.Checked ? 1 : 0;
            objdentista.Facebook = CH_Facebook.Checked ? 1 : 0;
            objdentista.Twitter = CH_twitter.Checked ? 1 : 0;
            objdentista.Linkedin = CH_twitter.Checked ? 1 : 0;

            if (RB_Feminino.Checked)
            {
                objdentista.sexo = "F";
            }
            else
            {
                objdentista.sexo = "M";
            }
            //objdentista.sexo = rbFeminino.Checked ? "F" ; "M";

        }
        public void atualizargrid ()
        {
            List<Dentista> listDentista = new List<Dentista>();
            con.conectar();
            SqlDataReader reader;
            reader = con.execonsulta(" select * from tb_dentista");
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    Dentista dentista = new Dentista();
                    dentista.ID = reader.GetInt32(0);
                    dentista.nome = reader.GetString(1);
                    dentista.CRO = reader.GetString(2);
                    dentista.sexo = reader.GetValue(3) == null ? "" : reader.GetSqlValue(3).ToString();
                    dentista.Instagram = reader.GetSqlValue(4).ToString() == "true" ? 1 : 0;
                    dentista.Twitter = reader.GetValue(5).ToString() == "true" ? 1 : 0;
                    dentista.Facebook = reader.GetValue(6).ToString() == "true" ? 1 : 0;
                    dentista.Linkedin = reader.GetValue(7).ToString() == " true" ? 1 : 0;
                    listDentista.Add(dentista); 
                }
                reader.Close();

            }
            else
            {
                Console.WriteLine("Não Retornou os Dados");

            }
            DT_Dentista.DataSource = null;
            DT_Dentista.DataSource = listDentista;
        }
        private void Form1_Load (object sender , EventArgs e)
        {
            atualizargrid();
            bloquearcampos();
        }

        private void btn_Salvar_Click(object sender, EventArgs e)
        {
            lerdados();
            String sql = "insert into tb_dentista values (" + objdentista.ID + ", '" +
                objdentista.nome + "', '" +
                objdentista.CRO + "', '" +
                objdentista.sexo + "', " +
                objdentista.Instagram + ", " +
                objdentista.Facebook + "," +
                objdentista.Twitter + ", " +
                objdentista.Linkedin + ") ";
            con.conectar();
            if(con.executar(sql) == 1)
            {
                MessageBox.Show(" Seus Dados foram Salvos com sucesso !!!");
            } else
            {
                MessageBox.Show("Seus dados não foram Salvos");
            }
            bloquearcampos();
            atualizargrid();
        }


        private void btn_Novo_Click(object sender, EventArgs e)
        {
            limparcampos();
            desbloquearcampos();
            txt_ID.Focus();
        }

        private void DT_Dentista_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_ID.Text = DT_Dentista.CurrentRow.Cells[0].Value.ToString();
            txt_Nome.Text = DT_Dentista.CurrentRow.Cells[1].Value.ToString();
            txt_CRO.Text = DT_Dentista.CurrentRow.Cells[2].Value.ToString();
            RB_Feminino.Checked = DT_Dentista.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            RB_Masculino.Checked = DT_Dentista.CurrentRow.Cells[3].Value.Equals(1) ? true : false;
            CH_instagram.Checked = DT_Dentista.CurrentRow.Cells[4].Value.Equals(1);
            CH_twitter.Checked = DT_Dentista.CurrentRow.Cells[4].Value.Equals(1);
            CH_Facebook.Checked = DT_Dentista.CurrentRow.Cells[4].Value.Equals(1);
            CH_Linkedin.Checked = DT_Dentista.CurrentRow.Cells[4].Value.Equals(1);

        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            if (txt_ID.Text.Equals (""))
            {
                MessageBox.Show("Favor clicar em um campo");
            }
            else
            {
                String sql = " delete from tb_dentista where ID = " + txt_ID.Text;
                con.executar(sql);
                atualizargrid();
            }
        }
    }
}
