using System;
using System.Windows.Forms;


namespace TaskwithQuestionServer
{
    public partial class Server : Form
    {
        LogicProgram _logicProgram = new LogicProgram();

        public Server()
        {
            InitializeComponent();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e) // Кнопка меню выбора документа
        {
            _logicProgram.SelectExcelDock();
            _logicProgram.ReadExcelDock();
        }

        private void ButtonConection_Click(object sender, EventArgs e) // Кнопка подключения
        {
            _logicProgram.ConnectToClient();
        }

        private void ButtonLoadingQuestion_Click(object sender, EventArgs e) // Кнопка отправки вопросов
        {
            _logicProgram.SendQuestionAndAnswer();
        }

        private void ButtonGetAnswer_Click(object sender, EventArgs e) // Кнопка получения ответов от user
        {
            //_logicProgram.GetAnswerUsers();
        }
    }
}
