namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ServicoDados.Service1Client servico = new ServicoDados.Service1Client();
            dataGridView1.DataSource = "";
            dataGridView1.DataSource = servico.listarAlunos();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ServicoDados.Aluno aluno = new ServicoDados.Aluno();
            aluno.id = -1;
            aluno.nome = textBox2.Text;
            aluno.disciplina = textBox3.Text;
            aluno.nota = Convert.ToSingle(textBox4.Text);

            ServicoDados.Service1Client servico = new ServicoDados.Service1Client(); 
            servico.inserirAluno(aluno);

            dataGridView1.DataSource = "";
            dataGridView1.DataSource = servico.listarAlunos(); 


        }
    }
}
