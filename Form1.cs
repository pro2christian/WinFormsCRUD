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

                string sql = "INSERT INTO contato (nome, email, telefone) " + "VALUES" +
                    "('" + txt_nome.Text + "','" + txt_Email.Text + "', '" + txt_Telefone.Text + "')";
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                Conexao.Open();

                comando.ExecuteReader();
                MessageBox.Show("Cadastrado com sucesso!!");
                // executar comando insert

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
                //
                string query ="%" + txt_buscar_contato.Text + "%";

                //criar conexao com Mysql
                Conexao = new MySqlConnection(data_souce);

                string sql = "SELECT * " +
                    " FROM contato " +
                    "WHERE nome LIKE " + query +  "OR email LIKE " + query;
                
                Conexao.Open();
                
                MySqlCommand comando = new MySqlCommand(sql, Conexao);
                
                MySqlDataReader ler = comando.ExecuteReader();

                list_contato.Items.Clear();

                while (ler.Read())
                {
                    string[] linha =
                    {
                       ler.GetString(0),
                       ler.GetString(1),
                       ler.GetString(2),
                       ler.GetString(3),
                    };

                    var linha_listview = new ListViewItem(linha);
                    list_contato.Items.Add(linha_listview);
                }
               
                

            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } finally { 
            Conexao.Close();
            }
        }
    }
}