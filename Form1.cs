using MySql.Data.MySqlClient;
namespace WinFormsCRUD
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_souce = "datasource= localhost;username=root;password=;database=db_agenda";

        public Form1()
        {
            InitializeComponent();


            list_contato.View = View.Details;
            list_contato.LabelEdit = true;
            list_contato.AllowColumnReorder = true;
            list_contato.FullRowSelect = true;
            list_contato.GridLines = true;

            //estrutura listview
            list_contato.Columns.Add("ID", 30, HorizontalAlignment.Left);
            list_contato.Columns.Add("Nome", 150, HorizontalAlignment.Left);
            list_contato.Columns.Add("E-mail", 150, HorizontalAlignment.Left);
            list_contato.Columns.Add("Telefone", 150, HorizontalAlignment.Left);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Conexao = new MySqlConnection(data_souce);

                Conexao.Open();

                //atribui comando sql ao cmd
                MySqlCommand cmd = new MySqlCommand();

                //cria conexao com mysql
                cmd.Connection = Conexao;

                cmd.CommandText = "INSERT INTO contato (nome, email, telefone) " +
                                  "VALUES " +
                                  "(@nome, @email, @telefone)";
                
                cmd.Parameters.AddWithValue("@nome", txtNome.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@telefone", txtTelefone.Text);
                cmd.Prepare();
                cmd.ExecuteNonQuery();

                txtNome.Clear();
                txtEmail.Clear();
                txtTelefone.Clear();

                MessageBox.Show("Contato inserido com sucesso!!", "Sucessso!",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Erro " + ex.Number + " ocorreu: " + ex.Message,
                                "Erro", MessageBoxButtons.OK, 
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu: " + ex.Message,
                               "Error",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
            }
            finally
            {
                Conexao.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //LIKE
                string query = "'%" + txt_buscar_contato.Text + "%'";

                //criar conexao com Mysql
                Conexao = new MySqlConnection(data_souce);


                string sql = "SELECT * " +
                    " FROM contato " +
                    "WHERE nome LIKE " + query + "OR email LIKE " + query;

                string erro = "Digite o contato!";
                //controle vazio 
                if (string.IsNullOrWhiteSpace(txt_buscar_contato.Text))
                {
                    MessageBox.Show(erro);
                    return;
                }

                Conexao.Open();

                MySqlCommand comando = new MySqlCommand(sql, Conexao);

                //Recupera os dados do MySql
                MySqlDataReader ler = comando.ExecuteReader();

                //Limpa os dados da busca
                list_contato.Items.Clear();

                //ler os dados while false
                while (ler.Read())
                {
                    string[] linha =
                    {
                       ler.GetString(0), // "ID"
                       ler.GetString(1),// "NOME"
                       ler.GetString(2),// "E-MAIL"
                       ler.GetString(3),// "TELEFONE"
                    };

                    //Linha da lista
                    var linha_listview = new ListViewItem(linha);
                    list_contato.Items.Add(linha_listview);
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }
    }
}