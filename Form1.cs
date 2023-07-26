using MySql.Data.MySqlClient;
namespace WinFormsCRUD
{
    public partial class Form1 : Form
    {
        MySqlConnection Conexao;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string data_souce = "datasource= localhost;username=root;password=;database=db_agenda";
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
    }
}