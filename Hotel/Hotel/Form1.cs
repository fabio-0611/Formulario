using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using  MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Hotel
{
    public partial class Form1 : Form
    {
        Campovazio a = new Campovazio();
        MySqlConnection conn = new MySqlConnection("server =127.0.0.1;database=hotel; Uid=root; pwd=spartak10;");
        private MySqlCommand comando;
        public DataSet data = new DataSet();
        MySqlDataAdapter obj = new MySqlDataAdapter();




        public Form1()
        {
           
            InitializeComponent();
           
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            carregar();
        }
        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            obj = new MySqlDataAdapter ( "SELECT * FROM hotel.cliente WHERE Nome LIKE + '%" + textPesquisa.Text + "%'",conn);
            DataTable novo = new DataTable();
            
                conn.Open();
            if (conn.State == ConnectionState.Open)
            {
                try
                {

                    obj.Fill(novo);
                    datagrid.DataSource = novo;


                }

                catch (Exception)
                {
                    MessageBox.Show("Falha na leitura dos dados no banco!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error); ;

                }
                finally
                {
                    conn.Close();
                }
            }

            else
            {
                MessageBox.Show("Falha na abertura da conexão");
            }
            
        }

        private void BtnDeletar_Click(object sender, EventArgs e)
        {
            int indice = datagrid.CurrentRow.Index;

            data = new DataSet();
            obj = new MySqlDataAdapter("DELETE from cliente  WHERE idCliente = " + datagrid[0, 1].Value.ToString(), conn);
            obj.Fill(data);
            carregar();
            if (conn.State == ConnectionState.Open)
            {

                if (MessageBox.Show("Tem certeza que deseja Excluir o registro?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    try
                    {
                         MessageBox.Show("Usuário REMOVIDO com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                    }

                    catch (Exception)
                    {
                        MessageBox.Show("Ocorreu um erro na hora de excluir o registro!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    finally
                    {
                        conn.Close();
                    }

            }

            else
            {
                MessageBox.Show("Falha na conexão com o banco de dados", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void BtnAdicionar_Click(object sender, EventArgs e)
        {
            textNome.Enabled = true;
            textendereco.Enabled = true;
            
        }

        private void BtnCadastrar_Click(object sender, EventArgs e)
        {
            if (a.campo(textNome, "Nome"))
                return;
            if (a.campo(textendereco, "Endereço"))
                return; 
            string cadastrar = "INSERT INTO cliente(Nome,Endereco) VALUES('"
                               +textNome.Text+"','"
                               +textendereco.Text+"')";
            comando = new MySqlCommand(cadastrar, conn);
            

            conn.Open();
            textNome.Clear();
            textNome.Clear();

            if (conn.State == ConnectionState.Open)
            {

                if (MessageBox.Show("Deseja salvar o registro?", "Pergunta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)

                    try
                    {
                        MessageBox.Show("Registro salvo com sucesso!", "Sucesso!", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Ocorreu um erro naa hora de salvar o registro.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    finally
                    {
                        conn.Close();
                    }
            }
            else
            {
                MessageBox.Show("Não foi possível conectar com o banco de dados.", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

        }

       void carregar()
        {
          

           obj= new MySqlDataAdapter ("SELECT * FROM cliente;",conn);
            DataTable data = new DataTable();
            try
            {
              
                
                obj.Fill(data);
                datagrid.DataSource = data;
                
            }    
            catch(Exception ex)
            {
                MessageBox.Show("Ocorreu um erro no banco" + ex);
            }
             
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Tem certeza que deseja sair do sistema?", "Pergunta!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
                conn.Close();
                try
                {
                    MessageBox.Show("Você desejou sair do sistema!", "Até breve!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                }
                catch
                {
                    MessageBox.Show("Ocorreu um erro na hora de sair!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            else
            {
                MessageBox.Show("Seja bem vindo novamente a tela de cadastro", "Seja bem vindo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            data = new DataSet();

            obj = new MySqlDataAdapter ( "UPDATE cliente SET Nome = '"
                  + textNome.Text + "', Endereco = '"
                  + textendereco.Text + "' WHERE idCliente = '"
                  + textBoxId.Text + "'",conn);
            obj.Fill(data);
            
            conn.Open();
            
            carregar();

            if (conn.State == ConnectionState.Open)
            {
              
              
                if (MessageBox.Show("Tem certeza que deseja alterar?", "Pergunta?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)


                    try
                    {
                       
                        MessageBox.Show("Registro alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        conn.Close();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Ocorreu um erro na hora de Alterar!", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }

            else
            {
                MessageBox.Show("Ocorreu um erro no banco de dados", "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void datagrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = datagrid.Rows[e.RowIndex];
            textBoxId.Text = row.Cells[0].Value.ToString();
            textNome.Text = row.Cells[1].Value.ToString();
            textendereco.Text = row.Cells[2].Value.ToString();
        }
    }
} 
    

