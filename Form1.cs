using MySql.Data.MySqlClient;
namespace WinFormsCRUD
{
    public partial class Form1 : Form
    {
        private MySqlConnection Conexao;
        private string data_souce = "datasource= localhost;username=root;password=;database=db_agenda";
        private int? id_contato_selecionado = null;

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
                Conexao.Open();

                
                if(id_contato_selecionado == null)
                {

                    // executar comando insert
                    string sql = "INSERT INTO contato (nome, email, telefone) " + "VALUES" +
                        "('" + txt_nome.Text + "','" + txt_telefone.Text + "', '" + txt_email.Text + "')";
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);


                    //controle vazio || nulo
                    if (string.IsNullOrWhiteSpace(txt_nome.Text) ||
                       string.IsNullOrWhiteSpace(txt_telefone.Text) ||
                       string.IsNullOrWhiteSpace(txt_email.Text))

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
                    txt_email.Clear();
                    txt_telefone.Clear();

                    MessageBox.Show("Cadastrado com sucesso!!");
                }
                else
                {

                    // executar comando atualizar
                    string sql = "UPDATE contato SET (nome, email, telefone)  +  WHERE id = (' "+ txt_nome.Text + "','" + txt_telefone.Text + "', " +
                                 "'" + txt_email.Text + "', '" + id_contato_selecionado + "')";
                                                     
                    
                    MySqlCommand comando = new MySqlCommand(sql, Conexao);


                    comando.ExecuteReader();

                    MessageBox.Show("Contato Atualizado com sucesso!!");
                }

                                
            }
            catch (Exception ex)
            {

                MessageBox.Show("Não foi possivel Atualizar o contato:\r\n" + ex.Message);
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
                MessageBox.Show("Não foi possivel estabelecer a conexão com MySQL:\r\n" + ex.Message);
            }
            finally
            {
                Conexao.Close();
            }
        }

        //retona o valor que está selecionado no listview para o campo apontado, nome,telefone, e-mail
        private void list_contato_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            ListView.SelectedListViewItemCollection itens_selecionados = list_contato.SelectedItems;

            //percorre cada item da seleção

            foreach (ListViewItem item in itens_selecionados)
            {
                id_contato_selecionado = Convert.ToInt32(item.SubItems[0].Text);

                txt_nome.Text = item.SubItems[1].Text;
                txt_email.Text = item.SubItems[2].Text;
                txt_telefone.Text = item.SubItems[3].Text;

            }
        }
    }
}