using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataBaseLab1_2
{
    public partial class DMS : Form
    {
        string pathNames;
        public string pathSaves = TheLastSave();
        public int countStId = 0, countVarId = 0;
        public Random rand = new Random();
        public List<List<string>> studentsData, variantsData, testingData;

        public DMS()
        {
            InitializeComponent();
        }

        private static string TheLastSave()
        {
            return File.ReadAllText(OpenDB.DBname + "\\Saves\\LastSave.txt");
        }

        private void OutputStudents(string path)
        {
            if (studentsData == null) return;
            string[] headers = { "id", "name", "surname", "patronymic" };
            int[] maxes = new int[4];
            for (int i = 0; i < maxes.Length; ++i) maxes[i] = headers[i].Length;
            for (int i = 0; i < studentsData.Count; ++i)
                for (int j = 0; j < studentsData[i].Count; ++j)
                    maxes[j] = Math.Max(maxes[j], studentsData[i][j].Length);
            File.WriteAllText(path + "\\Students.txt", string.Empty);
            using (StreamWriter streamWriter = new StreamWriter(path + "\\Students.txt"))
            {
                for (int i = 0; i < headers.Length; ++i)
                {
                    streamWriter.Write(" " + headers[i] + " ");
                    for (int j = 0; j < maxes[i] - (headers[i].Length); ++j) streamWriter.Write(" ");
                    streamWriter.Write("|");
                }
                streamWriter.Write('\n');
                for (int i = 0; i < studentsData.Count; ++i)
                {
                    for (int j = 0; j < studentsData[i].Count; ++j)
                    {
                        streamWriter.Write(" " + studentsData[i][j] + " ");
                        int l = maxes[j] - (studentsData[i][j].Length);
                        for (int k = 0; k < l; ++k) streamWriter.Write(" ");
                        streamWriter.Write("|");
                    }
                    streamWriter.Write("\n");
                }

            }
        } //Checked

        private void OutputVariants(string path)
        {
            if (variantsData == null) return;
            string[] headersVars = { "id", "path_to_file" };
            int[] maxes = { 5, headersVars[1].Length };
            using (FileStream fStudents = new FileStream(path + "\\Variants.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter streamWriter = new StreamWriter(fStudents))
                {
                    for (int i = 0; i < 2; ++i)
                    {
                        streamWriter.Write(" " + headersVars[i] + " ");
                        for (int k = 0; k < maxes[i] - headersVars[i].Length; ++k) streamWriter.Write(' ');
                        streamWriter.Write("|");
                    }
                    streamWriter.Write("\n");
                    for (int i = 0; i < variantsData.Count; ++i)
                    {
                        for (int j = 0; j < variantsData[i].Count; ++j)
                        {
                            streamWriter.Write(" " + variantsData[i][j] + " ");
                            for (int k = 0; k < maxes[j] - variantsData[i][j].Length; ++k) streamWriter.Write(' ');
                            streamWriter.Write('|');
                        }
                        streamWriter.Write('\n');
                    }
                }
            }
        } //Checked

        private void OutputTeacher(string path)
        {
            if (testingData == null || studentsData == null || variantsData == null) return;
            File.WriteAllText(path + "\\TeacherTable.txt", string.Empty);
            using (FileStream fTable = new FileStream(path + "\\TeacherTable.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fTable))
                {
                    string[] headers = { "full_name", "path_to_file", "mark" };
                    int[] maxes = { headers[0].Length, headers[1].Length, headers[2].Length };
                    for (int i = 1; i < studentsData.Count; ++i)
                        for (int j = 0; j < studentsData[i].Count; ++j)
                            maxes[0] = Math.Max(maxes[0], studentsData[i][j].Length);
                    for (int i = 0; i < headers.Length; ++i)
                    {
                        sw.Write(" " + headers[i] + " ");
                        for (int j = 0; j < maxes[i] - (headers[i].Length); ++j) sw.Write(" ");
                        sw.Write("|");
                    }
                    sw.Write('\n');
                    for (int i = 0; i < maxes.Length; ++i)
                    {
                        for (int j = 0; j < maxes[i]; ++j) sw.Write("_");
                        sw.Write("__|");
                    }
                    sw.Write("\n");
                    for (int studentsInd = 0; studentsInd < studentsData.Count; ++studentsInd)
                    {
                        sw.Write(" " + studentsData[studentsInd][1] + " ");
                        int l = maxes[0] - (studentsData[studentsInd][1].Length);
                        for (int k = 0; k < l; ++k) sw.Write(" ");
                        sw.Write("|");
                        int varInd = 0;
                        while (variantsData[varInd++][0] != testingData[studentsInd][1]) { }
                        --varInd;
                        sw.Write(" " + variantsData[varInd][1] + " ");
                        l = maxes[1] - (variantsData[varInd][1].Length);
                        for (int k = 0; k < l; ++k) sw.Write(" ");
                        sw.Write("|");
                        for (int k = 0; k < maxes[2] + 2; ++k) sw.Write(" ");
                        sw.Write("|\n");
                        sw.Write(" " + studentsData[studentsInd][2] + " ");
                        l = maxes[0] - (studentsData[studentsInd][2].Length);
                        for (int k = 0; k < l; ++k) sw.Write(" ");
                        sw.Write("|");
                        for (int k = 0; k < maxes[1] + 2; ++k) sw.Write(" ");
                        sw.Write("|");
                        for (int k = 0; k < maxes[2] + 2; ++k) sw.Write(" ");
                        sw.Write("|\n");
                        sw.Write(" " + studentsData[studentsInd][3] + " ");
                        l = maxes[0] - (studentsData[studentsInd][3].Length);
                        for (int k = 0; k < l; ++k) sw.Write(" ");
                        sw.Write("|");
                        for (int k = 0; k < maxes[1] + 2; ++k) sw.Write(" ");
                        sw.Write("|");
                        for (int k = 0; k < maxes[2] + 2; ++k) sw.Write(" ");
                        sw.Write("|\n");
                        for (int i = 0; i < maxes.Length; ++i)
                        {
                            for (int j = 0; j < maxes[i]; ++j) sw.Write("_");
                            sw.Write("__|");
                        }
                        sw.Write("\n");
                    }
                }
            }
        } //Checked

        private void OutputTesting(string path)
        {
            if (testingData == null) return;
            File.WriteAllText(path + "\\Testing.txt", string.Empty);
            using (FileStream fTesting = new FileStream(path + "\\Testing.txt", FileMode.OpenOrCreate))
            {
                using (StreamWriter sw = new StreamWriter(fTesting))
                {
                    string[] headers = { "id_student", "id_var" };
                    sw.Write(" " + headers[0] + " | " + headers[1] + " |\n");
                    for (int i = 0; i < testingData.Count; ++i)
                    {
                        for (int j = 0; j < 2; ++j)
                        {
                            sw.Write(" " + testingData[i][j] + " ");
                            for (int k = 0; k < headers[j].Length - testingData[i][j].Length; ++k) sw.Write(" ");
                            sw.Write("|");
                        }
                        sw.Write('\n');
                    }
                }
            }
        } //Checked

        private void GenerateStudentsTable()
        {
            studentsData = new List<List<string>>();
            using (FileStream fNames = new FileStream(pathNames, FileMode.OpenOrCreate))
            {
                using (StreamReader sw = new StreamReader(fNames))
                {
                    int row = 0;
                    string line = sw.ReadLine();
                    while (line != null)
                    {
                        studentsData.Add(new List<string>());
                        studentsData[row].Add(row.ToString());
                        string[] attributes = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        for (int i = 0; i < attributes.Length; ++i) studentsData[row].Add(attributes[i]);
                        ++row;
                        countStId = Math.Max(countStId, row);
                        line = sw.ReadLine();
                    }
                }
            }
        } //Checked

        private void GenerateVariantsTable()
        {
            variantsData = new List<List<string>>();
            for (int i = 0; i < 50; ++i)
                variantsData.Add(new List<string>() { i.ToString(), "Var_" + i.ToString()});
            countVarId = 50;
        } //Checked

        private void GenerateTestingTable()
        {
            testingData = new List<List<string>>();                   
            for (int i = 0; i<studentsData.Count; ++i)
                testingData.Add(new List<string>() { studentsData[i][0] , variantsData[rand.Next(0, variantsData.Count)][0] });
        } //Checked

        private void GenerateTestingTable(int id)
        {
            if (testingData == null) testingData = new List<List<string>>();
            testingData.Add(new List<string>() {  id.ToString(), variantsData[rand.Next(0, variantsData.Count)][0] });
        }  //Checked

        public void ReadStudents(string path)
        {
            if (studentsData != null) return;
            using (var fStudents = new FileStream(path + "\\Students.txt", FileMode.OpenOrCreate))
            {
                using (var sr = new StreamReader(fStudents))
                {
                    string line;
                    line = sr.ReadLine();
                    line = sr.ReadLine();
                    studentsData = new List<List<string>>();
                    while (line != null)
                    {
                        string[] attributes = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        studentsData.Add(new List<string>(attributes));
                        line = sr.ReadLine();
                        countStId = Math.Max(countStId, int.Parse(studentsData[studentsData.Count - 1][0]) + 1);
                    }
                }
            }
        } //Checked

        private void ReadVariants(string path)
        {
            if (variantsData != null) return;
            using (FileStream fStudents = new FileStream(path + "\\Variants.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fStudents))
                {
                    string line;
                    line = sr.ReadLine();
                    line = sr.ReadLine();
                    variantsData = new List<List<string>>();
                    while (!sr.EndOfStream)
                    {
                        string[] attributes = line.Split(new char[] { '|', ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        variantsData.Add(new List<string>(attributes));
                        line = sr.ReadLine();
                        countVarId = Math.Max(countVarId, 1 + int.Parse(variantsData[variantsData.Count - 1][0]));
                    }
                }
            }
        } //Checked

        private void ReadTesting(string path)
        {
            if (testingData != null) return;
            using (FileStream fTesting = new FileStream(path + "\\Testing.txt", FileMode.OpenOrCreate))
            {
                using (StreamReader sr = new StreamReader(fTesting))
                {
                    string line;
                    line = sr.ReadLine();
                    line = sr.ReadLine();
                    testingData = new List<List<string>>();
                    while (line != null)
                    {
                        string[] attributes = line.Split(new char[] { ' ', '|' }, StringSplitOptions.RemoveEmptyEntries);
                        testingData.Add(new List<string>(attributes));
                        line = sr.ReadLine();
                    }
                }
            }
        } //Checked

        private void GenerateTables()
        {
            GenerateVariantsTable();
            GenerateStudentsTable();
            GenerateTestingTable();
        } 

        private void OutputTables(string path)
        {
            OutputVariants(path);
            OutputStudents(path);
            OutputTesting(path);
            OutputTeacher(path);
        }

        private void ReadTables(string path)
        {
            ReadVariants(path);
            ReadStudents(path);
            ReadTesting(path);
        }

        private void ConsoleStudents()
        {
            using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput(), Encoding.Unicode))
            {
                if (studentsData == null) return;
                string[] headers = { "id", "name", "surname", "patronymic" };
                int[] maxes = new int[4];
                for (int i = 0; i < maxes.Length; ++i) maxes[i] = headers[i].Length;
                for (int i = 0; i < studentsData.Count; ++i)
                    for (int j = 0; j < studentsData[i].Count; ++j)
                        maxes[j] = Math.Max(maxes[j], studentsData[i][j].Length);
                for (int i = 0; i < headers.Length; ++i)
                {
                    sw.Write(" " + headers[i] + " ");
                    for (int j = 0; j < maxes[i] - (headers[i].Length); ++j) sw.Write(" ");
                    sw.Write("|");
                }
                sw.Write('\n');
                for (int i = 0; i < studentsData.Count; ++i)
                {
                    for (int j = 0; j < studentsData[i].Count; ++j)
                    {
                        sw.Write(" " + studentsData[i][j] + " ");
                        int l = maxes[j] - (studentsData[i][j].Length);
                        for (int k = 0; k < l; ++k) sw.Write(" ");
                        sw.Write("|");
                    }
                    sw.Write("\n");
                }
            } 
        }

        private void ConsoleVariants()
        {
            Console.OpenStandardOutput();
            Console.Clear();
            if (variantsData == null) return;
            string[] headersVars = { "id", "path_to_file" };
            int[] maxes = { 5, headersVars[1].Length };
            for (int i = 0; i < 2; ++i)
            {
                Console.Write(" " + headersVars[i] + " ");
                for (int k = 0; k < maxes[i] - headersVars[i].Length; ++k) Console.Write(' ');
                Console.Write("|");
            }
            Console.Write("\n");
            for (int i = 0; i < variantsData.Count; ++i)
            {
                for (int j = 0; j < variantsData[i].Count; ++j)
                {
                    Console.Write(" " + variantsData[i][j] + " ");
                    for (int k = 0; k < maxes[j] - variantsData[i][j].Length; ++k) Console.Write(' ');
                    Console.Write('|');
                }
                Console.Write('\n');
            }
        }

        private void btnGenerateTables_Click(object sender, EventArgs e)
        {
            DialogResult result = openTable.ShowDialog();

            if (result == DialogResult.OK)
            {
                pathNames = openTable.FileName;
                GenerateTables();
            }
            else return;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (studentsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Students.txt") fl = true;
                if (fl) { ReadTables(pathSaves); }
                else { studentsData = new List<List<string>>(); testingData = new List<List<string>>(); }
            }
            AddRow addRow = new AddRow(this);
            addRow.ShowDialog();
            GenerateTestingTable(countStId);
        } //Checked

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (studentsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Students.txt") fl = true;
                if (!fl) { MessageBox.Show("Нет данных."); return; }
                ReadStudents(pathSaves);
                ReadTesting(pathSaves);
            }
            if (studentsData.Count == 0) { MessageBox.Show("Нет данных."); return; }
            DeleteRow deleteRow = new DeleteRow(this);
            deleteRow.ShowDialog();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (studentsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Students.txt") fl = true;
                if (!fl) { MessageBox.Show("Нет данных."); return; }
                ReadStudents(pathSaves);
                ReadTesting(pathSaves);
            }
            if (studentsData.Count == 0) { MessageBox.Show("Нет данных."); return; }
            EditRow editRow = new EditRow(this);
            editRow.ShowDialog();
        }

        private void btnChoice_Click(object sender, EventArgs e)
        {
            ChoiceSaveId choiceSaveId = new ChoiceSaveId(this);
            choiceSaveId.ShowDialog();
            File.WriteAllText(OpenDB.DBname + "\\Saves\\LastSave.txt", pathSaves);
        } //Checked

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (studentsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Students.txt") fl = true;
                if (!fl) { MessageBox.Show("Нет данных."); return; }
                ReadStudents(pathSaves);
                ReadTesting(pathSaves);
            }
            if (studentsData.Count == 0) { MessageBox.Show("Нет данных."); return; }
            //OutRow outRow = new OutRow(this);
            //outRow.ShowDialog();

            //ConsoleStudents();

            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("name", "Name");
            dataGridView1.Columns.Add("surname", "Surname");
            dataGridView1.Columns.Add("patronymic", "Patrinymic");
            for (int i = 0; i < studentsData.Count; ++i)
            {
                dataGridView1.Rows.Add(studentsData[i][0], studentsData[i][1], studentsData[i][2], studentsData[i][3]);
            }
        } //Checked

        private void btnEditVar_Click(object sender, EventArgs e)
        {
            if (variantsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Variants.txt") fl = true;
                if (!fl) { MessageBox.Show("Нет данных."); return; }
                ReadVariants(pathSaves);
            }
            if (variantsData.Count == 0) { MessageBox.Show("Нет данных."); return; }
            EditVar editVar = new EditVar(this);
            editVar.ShowDialog();
        }

        private void btnDeleteVar_Click(object sender, EventArgs e)
        {
            if (variantsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Variants.txt") fl = true;
                if (!fl) { MessageBox.Show("Нет данных."); return; }
                ReadTables(pathSaves);
            }
            if (variantsData.Count == 0) { MessageBox.Show("Нет данных."); return; }
            DeleteVar deleteVar = new DeleteVar(this);
            deleteVar.ShowDialog();
        }

        private void btnOutVar_Click(object sender, EventArgs e)
        {
            if (variantsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Variants.txt") fl = true;
                if (!fl) { MessageBox.Show("Нет данных."); return; }
                ReadVariants(pathSaves);
            }
            dataGridView1.Columns.Add("id", "Id");
            dataGridView1.Columns.Add("path", "Path");
            for (int i = 0; i < variantsData.Count; ++i) {
                dataGridView1.Rows.Add(variantsData[i][0], variantsData[i][1]);
            }
        }

        private void btnAddVar_Click(object sender, EventArgs e)
        {
            if (variantsData == null)
            {
                DirectoryInfo dir = new DirectoryInfo(pathSaves);
                bool fl = false;
                foreach (var i in dir.GetFiles())
                    if (i.Name == "Variants.txt") fl = true;
                if (fl) { ReadTables(pathSaves); }
                else { GenerateVariantsTable(); }
            }
            AddVar addVar = new AddVar(this);
            addVar.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OutputTables(pathSaves);
        }

        private void btnNewSave_Click(object sender, EventArgs e)
        {
            DirectoryInfo dir = new DirectoryInfo(OpenDB.DBname + "\\Saves");
            dir.CreateSubdirectory("Save" + dir.GetDirectories().Count().ToString());
            File.WriteAllText(dir.FullName + "\\LastSave.txt", dir.FullName + "\\Save" + (dir.GetDirectories().Count() - 1).ToString());
            if (studentsData == null) ReadTables(pathSaves);
            pathSaves = TheLastSave();
            OutputTables(pathSaves);
        }
    }
}
