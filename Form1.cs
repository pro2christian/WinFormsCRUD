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

                //criar conexao com Mysql
                Conexao = new MySqlConnection(data_souce);

                // executar comando insert
                string sql = "INSERT INTO contato (nome, email, telefone) " + "VALUES" +
                    "('" + txt_nome.Text + "','" + txt_Email.Text + "', '" + txt_Telefone.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                //controle vazio || nulo
                if (string.IsNullOrWhiteSpace(txt_nome.Text) ||
                   string.IsNullOrWhiteSpace(txt_Email.Text) ||
                   string.IsNullOrWhiteSpace(txt_Telefone.Text))
                {
                    string erro = "Nome......:\n" +
                                  "Telefone.:\n" +
                                  "E-mail.....:\n" +
                                  "São obrigatórios!";
                    MessageBox.Show(erro);
                    return;
                }

                comando.ExecuteReader();

                txt_nome.Clear();
                txt_Telefone.Clear();
                txt_Email.Clear();

                MessageBox.Show("Cadastrado com sucesso!!");
                 


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