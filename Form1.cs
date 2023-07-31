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

                if (string.IsNullOrEmpty(txtNome.Text) ||
                   string.IsNullOrEmpty(txtEmail.Text) ||
                   string.IsNullOrEmpty(txtTelefone.Text))
                {
                    MessageBox.Show("Nome, E-mail, Telefone\r\n  " +
                                    "São obrigatórios!!", "Erro!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }
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

                MessageBox.Show("Contato inserido com sucesso!!", "Sucesso!",
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
                Conexao = new MySqlConnection(data_souce);
                Conexao.Open();

                //atribui comando sql ao cmd
                MySqlCommand cmd = new MySqlCommand();

                //cria conexao com mysql
                cmd.Connection = Conexao;

                if (string.IsNullOrWhiteSpace(txt_buscar_contato.Text))
                {

                    MessageBox.Show("Digite um contato!!", "Erro",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                    return;
                }

                cmd.CommandText = "SELECT * FROM contato WHERE nome LIKE  @q OR  email LIKE @q ";
                cmd.Parameters.AddWithValue("@q", "%" + txt_buscar_contato.Text + "%");
                cmd.Prepare();
               
                //Recupera os dados do MySql
                MySqlDataReader ler = cmd.ExecuteReader();

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
                    
                    list_contato.Items.Add(new ListViewItem(linha));
                }



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
    }
}