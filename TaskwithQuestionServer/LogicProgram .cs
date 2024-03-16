using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aspose.Cells;

namespace TaskwithQuestionServer
{
    internal class LogicProgram
    {
        private TcpListener _listener;

        private List<byte> _answerAndQuestion = new List<byte>();

        public string _path = null;
        private int _count = 0;

        public async void ConnectToClient() // Подключение к клиентам 
        {
            IPEndPoint ipPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888);
            _listener = new TcpListener(ipPoint);
            try
            {
                _listener.Start();
                //MessageBox.Show("Соединение с клиентом установлено");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public async void SendQuestionAndAnswer() // Отправка вопросов и ответов
        {

            try
            {
                TcpClient handler = await _listener.AcceptTcpClientAsync();
                NetworkStream stream = handler.GetStream();

                stream.Write(_answerAndQuestion.ToArray(), 0, _answerAndQuestion.Count);  
                GetAnswerUsers(stream);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
          
            
        }

        public void ReadExcelDock() // Чтение Excel документа
        {
            if (_path == null)
            {
                //MessageBox.Show("Выберите Excel документ");
            }
            else
            {
                try
                {

                    Workbook ExcelDock = new Workbook(@_path);

                    WorksheetCollection collection = ExcelDock.Worksheets;

                    for (int worksheetIndex = 0; worksheetIndex < collection.Count; worksheetIndex++)
                    {

                        Worksheet worksheet = collection[worksheetIndex];


                        //MessageBox.Show("Worksheet: " + worksheet.Name);

                        int rows = worksheet.Cells.MaxDataRow + 1;
                        int cols = worksheet.Cells.MaxDataColumn + 1;


                        for (int i = 0; i < rows; i++)
                        {

                            for (int j = 0; j < cols; j++)
                            {

                                if (Convert.ToString(worksheet.Cells[i, j].Value) != "")
                                {
                                    _answerAndQuestion.AddRange(Encoding.UTF8.GetBytes(worksheet.Cells[i, j].Value.ToString()));

                                    _answerAndQuestion.Add((byte)'|');
                                }
                            }
                            _answerAndQuestion.Add((byte)'\n');
                            _count++;


                        }
                        //MessageBox.Show(Encoding.UTF8.GetString(_answerAndQuestion.ToArray()));
                        //MessageBox.Show(_count.ToString());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка выбранного файла");

                }
            }
        }

        public void SelectExcelDock() // Выбор Excel документа (Нужно сделать проверку на то что расшиерние именно .xlsx)
        {
            string path = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            path = openFileDialog.FileName;
            _path = Path.GetFullPath(path);

            //MessageBox.Show(_path);
        }

        public void GetAnswer() // Получение ответов от пользователя (Пока не работает)
        {
            MessageBox.Show("В разработке");
        }

        public async void GetAnswerUsers(NetworkStream stream)
        {
            try
            {
                
               
                byte[] buffer = new byte[1024];
                int b = stream.Read(buffer, 0, 1024);
                string answerUsers = Encoding.UTF8.GetString(buffer);
                MessageBox.Show(answerUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }

}
