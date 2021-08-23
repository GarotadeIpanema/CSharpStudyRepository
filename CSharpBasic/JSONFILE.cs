using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
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

namespace CSharpBasic
{
    public partial class JSONFILE : Form
    {
        public JSONFILE()
        {
            InitializeComponent();

            InitEvent();
        }

        private void InitEvent()
        {
            create_json_btn.Click += createJsonBtn_Click;
            write_json_btn.Click += writeJsonBtn_Click;
            read_json_btn.Click += readJsonBtn_Click;
        }

        private void readJsonBtn_Click(object sender, EventArgs e)
        {
            json_txt.Clear();
            ReadJson();
        }

        private void ReadJson()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            string str = string.Empty;
            string users = string.Empty;

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                using(StreamReader file = File.OpenText(path))
                using(JsonTextReader reader = new JsonTextReader(file))
                {
                    JObject json = (JObject)JToken.ReadFrom(reader);

                    DataBase _db = new DataBase();

                    _db.IP = (string)json["IP"].ToString();
                    _db.ID = (string)json["ID"].ToString();
                    _db.PW = (string)json["PW"].ToString();
                    _db.SID = (string)json["SID"].ToString();
                    _db.DATABASE = (string)json["DATABASE"].ToString();

                    var user = json.SelectToken("USERS");
                    var cnt = user.Count();

                    for(int idx = 0; idx < user.Count(); idx++)
                    {
                        var name = user[idx].ToString();

                        if(idx == 0)
                        {
                            users += $"{name}";
                        }
                        else
                        {
                            users += $" , {name}";
                        }
                    }

                    str = $" IP : {_db.IP}\n ID : {_db.ID}\n PW : {_db.PW}\n SID : {_db.SID}\n DATABASE : {_db.DATABASE}\n USERS : {users}";
                    json_txt.Text = str;
                }
            }
        }

        private void writeJsonBtn_Click(object sender, EventArgs e)
        {
            json_txt.Clear();
            WriteJson();
        }

        private void WriteJson()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = openFileDialog.FileName;

                if(File.Exists(path))
                {
                    InputJson(path);
                }
            }
        }

        private void InputJson(string path)
        {
            var users = new[] { "USER1", "USER2", "USER3", "USER4" };

            JObject dbSpec = new JObject(
                new JProperty("IP", "127.0.0.1")
                , new JProperty("ID", "TEST")
                , new JProperty("PW", "1234")
                , new JProperty("SID", "TEST")
                , new JProperty("DATABASE", "TEST")
                );

            dbSpec.Add("USERS", JArray.FromObject(users));

            File.WriteAllText(path, dbSpec.ToString());

            json_txt.Text = dbSpec.ToString();
        }

        private void createJsonBtn_Click(object sender, EventArgs e)
        {
            CreateJson();
        }

        private void CreateJson()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "test.json";
            saveFileDialog.Filter = "Json files (*.json)|*.json|Text files (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = saveFileDialog.FileName;
                if (!File.Exists(path))
                {
                    using (File.Create(path))
                    {
                        MessageBox.Show("파일 생성 성공");
                    }
                }
                else
                {
                    MessageBox.Show("이미 파일이 존재 합니다.");
                }
            }
        }

    }

    public class DataBase
    {
        public string IP = string.Empty;
        public string ID = string.Empty;
        public string PW = string.Empty;
        public string SID = string.Empty;
        public string DATABASE = string.Empty;
    }
}
