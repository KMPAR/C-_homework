using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections;
using System.IO;

namespace 박규민_202211415
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
		private void btn_file_Click(object sender, EventArgs e)
		{
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filepath = openFileDialog1.FileName;
                tb_file.Text = filepath;

                FileStream fs = File.OpenRead(filepath);
                StreamReader sr = new StreamReader(fs);

                JsonData1[] arrJsonDatas = JsonConvert.DeserializeObject<JsonData1[]>(sr.ReadToEnd());

                DataTable table = new DataTable();
                table.Columns.Add("id", typeof(string));
                table.Columns.Add("name", typeof(string));
                table.Columns.Add("title", typeof(string));
                table.Columns.Add("title_eng", typeof(string));
                table.Columns.Add("astrtCont", typeof(string));
                table.Columns.Add("app_num", typeof(string));
                table.Columns.Add("app_date", typeof(string));
                table.Columns.Add("open_num", typeof(string));
                table.Columns.Add("open_date", typeof(string));
                table.Columns.Add("pub_num", typeof(string));
                table.Columns.Add("pub_date", typeof(string));
                table.Columns.Add("reg_num", typeof(string));
                table.Columns.Add("reg_date", typeof(string));

                foreach (var item in arrJsonDatas)
                {
                    table.Rows.Add(item.id, item.name, item.inventionTitle, item.inventionTitleEng, item.astrtCont, item.applicationNumber, 
                        item.applicationDate, item.openNumber,item.openDate, item.publicationNumber, item.publicationDate, item.registerNumber,
                        item.registerDate);
                }
                dataGridView1.DataSource = table;
                dataGridView2.DataSource = table;

                dt.Columns.Add("id", typeof(string));
                dt.Columns.Add("name", typeof(string));
                dt.Columns.Add("title", typeof(string));
                dt.Columns.Add("title_eng", typeof(string));
                dt.Columns.Add("astrtCont", typeof(string));
                dt.Columns.Add("app_num", typeof(string));
                dt.Columns.Add("app_date", typeof(string));
                dt.Columns.Add("open_num", typeof(string));
                dt.Columns.Add("open_date", typeof(string));
                dt.Columns.Add("pub_num", typeof(string));
                dt.Columns.Add("pub_date", typeof(string));
                dt.Columns.Add("reg_num", typeof(string));
                dt.Columns.Add("reg_date", typeof(string));
            }
        }

        class JsonData1
        {
            public string id;
            public string inventionTitle;
            public string inventionTitleEng;
            public string applicationNumber;
            public string applicationDate;
            public string openNumber;
            public string openDate;
            public string publicationNumber;
            public string publicationDate;
            public string registerNumber;
            public string registerDate;
            public string originalApplicationKind;
            public string originalApplicationNumber;
            public string originalApplicationDate;
            public string finalDisposal;
            public string registerStatus;
            public string examinerName;
            public string originalExaminationRequestFlag;
            public string originalExaminationRequestDate;
            public string claimCount;
            public string applicationFlag;
            public string translationSubmitDate;
            public string chk_pat;
            public string astrtCont;
            public string name;
            public string engName;
            public string code;
            public string address;
            public string country;
            public string businessRegistrationNumber;
            public string corporationNumber;
            public string ipcNumber;
            public string ipcDate;
        }
        class JsonData2
        {
            public string id;
            public string astrtCont;
        }

        class JsonData3
        {
            public string id;
            public string name;
            public string engName;
            public string code;
            public string address;
            public string country;
            public string businessRegistrationNumber;
            public string corporationNumber;
        }

        class JsonData4
        {
            public string id;
            public string ipcNumber;
            public string ipcDate;
        }

		private void btn_create_Click(object sender, EventArgs e)
		{
            string filepath1 = @"C:\Users\82102\Desktop\박규민_202211415\bibliosummary.json";
            string filepath2 = @"C:\Users\82102\Desktop\박규민_202211415\abstract.json";
            string filepath3 = @"C:\Users\82102\Desktop\박규민_202211415\applicant.json";
            string filepath4 = @"C:\Users\82102\Desktop\박규민_202211415\ipc.json";

            FileStream fs1 = File.OpenRead(filepath1);
            FileStream fs2 = File.OpenRead(filepath2);
            FileStream fs3 = File.OpenRead(filepath3);
            FileStream fs4 = File.OpenRead(filepath4);

            StreamReader sr1 = new StreamReader(fs1);
            StreamReader sr2 = new StreamReader(fs2);
            StreamReader sr3 = new StreamReader(fs3);
            StreamReader sr4 = new StreamReader(fs4);

            JsonData1[] arrJsonDatas1 = JsonConvert.DeserializeObject<JsonData1[]>(sr1.ReadToEnd());
            JsonData2[] arrJsonDatas2 = JsonConvert.DeserializeObject<JsonData2[]>(sr2.ReadToEnd());
            JsonData3[] arrJsonDatas3 = JsonConvert.DeserializeObject<JsonData3[]>(sr3.ReadToEnd());
            JsonData4[] arrJsonDatas4 = JsonConvert.DeserializeObject<JsonData4[]>(sr4.ReadToEnd());

            for (int i = 0; i < arrJsonDatas1.Length; i++)
            {
                arrJsonDatas1[i].astrtCont = arrJsonDatas2[i].astrtCont;
                arrJsonDatas1[i].name = arrJsonDatas3[i].name;
                arrJsonDatas1[i].engName = arrJsonDatas3[i].engName;
                arrJsonDatas1[i].code = arrJsonDatas3[i].code;
                arrJsonDatas1[i].address = arrJsonDatas3[i].address;
                arrJsonDatas1[i].country = arrJsonDatas3[i].country;
                arrJsonDatas1[i].businessRegistrationNumber = arrJsonDatas3[i].businessRegistrationNumber;
                arrJsonDatas1[i].corporationNumber = arrJsonDatas3[i].corporationNumber;
                arrJsonDatas1[i].ipcNumber = arrJsonDatas4[i].ipcNumber;
                arrJsonDatas1[i].ipcDate = arrJsonDatas4[i].ipcDate;
            }

            string newfile = @"C:\Users\82102\Desktop\박규민_202211415\개인과제data.json";
            if (File.Exists(newfile) == false)
            {
                using (File.Create(newfile)) { }

                var jFriends = new JArray();
                foreach (var item in arrJsonDatas1)
                {
                    JObject jobject = new JObject();
                    jobject.Add(new JProperty("id", item.id));
                    jobject.Add(new JProperty("inventionTitle", item.inventionTitle));
                    jobject.Add(new JProperty("inventionTitleEng", item.inventionTitleEng));
                    jobject.Add(new JProperty("applicationNumber", item.applicationNumber));
                    jobject.Add(new JProperty("applicationDate", item.applicationDate));
                    jobject.Add(new JProperty("openNumber", item.openNumber));
                    jobject.Add(new JProperty("openDate", item.openDate));
                    jobject.Add(new JProperty("publicationNumber", item.publicationDate));
                    jobject.Add(new JProperty("publicationDate", item.publicationDate));
                    jobject.Add(new JProperty("registerNumber", item.registerNumber));
                    jobject.Add(new JProperty("registerDate", item.registerDate));
                    jobject.Add(new JProperty("originalApplicationKind", item.originalApplicationKind));
                    jobject.Add(new JProperty("originalApplicationNumber", item.originalApplicationNumber));
                    jobject.Add(new JProperty("originalApplicationDate", item.originalApplicationDate));
                    jobject.Add(new JProperty("finalDisposal", item.finalDisposal));
                    jobject.Add(new JProperty("registerStatus", item.registerStatus));
                    jobject.Add(new JProperty("examinerName", item.examinerName));
                    jobject.Add(new JProperty("originalExaminationRequestFlag", item.originalExaminationRequestFlag));
                    jobject.Add(new JProperty("originalExaminationRequestDate", item.originalExaminationRequestDate));
                    jobject.Add(new JProperty("claimCount", item.claimCount));
                    jobject.Add(new JProperty("applicationFlag", item.applicationFlag));
                    jobject.Add(new JProperty("translationSubmitDate", item.applicationDate));
                    jobject.Add(new JProperty("chk_pat", item.chk_pat));
                    jobject.Add(new JProperty("astrtCont", item.astrtCont));
                    jobject.Add(new JProperty("name", item.name));
                    jobject.Add(new JProperty("engName", item.engName));
                    jobject.Add(new JProperty("code", item.code));
                    jobject.Add(new JProperty("address", item.address));
                    jobject.Add(new JProperty("country", item.country));
                    jobject.Add(new JProperty("businessRegistrationNumber", item.businessRegistrationNumber));
                    jobject.Add(new JProperty("corporationNumber", item.corporationNumber));
                    jobject.Add(new JProperty("ipcNumber", item.ipcNumber));
                    jobject.Add(new JProperty("ipcDate", item.ipcDate));
                    jFriends.Add(jobject);
                }
                File.AppendAllText(newfile, jFriends.ToString());
            }
            else
            {
                MessageBox.Show("파일이 이미 생성되었습니다.");
                return;
            }
        }

		private void btn_search_Click(object sender, EventArgs e)
		{
            string filepath = @"C:\Users\82102\Desktop\박규민_202211415\개인과제data.json";

            FileStream fs = File.OpenRead(filepath);
            StreamReader sr = new StreamReader(fs);

            JsonData1[] arrJsonDatas = JsonConvert.DeserializeObject<JsonData1[]>(sr.ReadToEnd());
            DataTable table = new DataTable();
            table.Columns.Add("id", typeof(string));
            table.Columns.Add("name", typeof(string));
            table.Columns.Add("title", typeof(string));
            table.Columns.Add("title_eng", typeof(string));
            table.Columns.Add("astrtCont", typeof(string));
            table.Columns.Add("app_num", typeof(string));
            table.Columns.Add("app_date", typeof(string));
            table.Columns.Add("open_num", typeof(string));
            table.Columns.Add("open_date", typeof(string));
            table.Columns.Add("pub_num", typeof(string));
            table.Columns.Add("pub_date", typeof(string));
            table.Columns.Add("reg_num", typeof(string));
            table.Columns.Add("reg_date", typeof(string));

            string word = tb_search.Text;

            for (int i = 0; i < arrJsonDatas.Length; i++)
            {
                if (this.rb_title.Checked)
                {
                    if (arrJsonDatas[i].inventionTitle.Contains(word) == true)
                    {
                        table.Rows.Add(arrJsonDatas[i].id, arrJsonDatas[i].name, arrJsonDatas[i].inventionTitle, arrJsonDatas[i].inventionTitleEng,
                            arrJsonDatas[i].astrtCont, arrJsonDatas[i].applicationNumber, arrJsonDatas[i].applicationDate, arrJsonDatas[i].openNumber,
                            arrJsonDatas[i].openDate, arrJsonDatas[i].publicationNumber, arrJsonDatas[i].publicationDate, arrJsonDatas[i].registerNumber,
                            arrJsonDatas[i].registerDate);
                    }
                }
                if (this.rb_name.Checked)
                {
                    if (arrJsonDatas[i].name.Contains(word) == true)
                    {
                        table.Rows.Add(arrJsonDatas[i].id, arrJsonDatas[i].name, arrJsonDatas[i].inventionTitle, arrJsonDatas[i].inventionTitleEng,
                               arrJsonDatas[i].astrtCont, arrJsonDatas[i].applicationNumber, arrJsonDatas[i].applicationDate, arrJsonDatas[i].openNumber,
                               arrJsonDatas[i].openDate, arrJsonDatas[i].publicationNumber, arrJsonDatas[i].publicationDate, arrJsonDatas[i].registerNumber,
                               arrJsonDatas[i].registerDate);
                    }
                }
                if (this.rb_astrt.Checked)
                {
                    if (arrJsonDatas[i].astrtCont.Contains(word) == true)
                    {
                        table.Rows.Add(arrJsonDatas[i].id, arrJsonDatas[i].name, arrJsonDatas[i].inventionTitle, arrJsonDatas[i].inventionTitleEng,
                            arrJsonDatas[i].astrtCont, arrJsonDatas[i].applicationNumber, arrJsonDatas[i].applicationDate, arrJsonDatas[i].openNumber,
                            arrJsonDatas[i].openDate, arrJsonDatas[i].publicationNumber, arrJsonDatas[i].publicationDate, arrJsonDatas[i].registerNumber,
                            arrJsonDatas[i].registerDate);
                    }
                }
                if (this.rb_title.Checked == false && this.rb_name.Checked == false && this.rb_astrt.Checked == false)
                {
                    MessageBox.Show("Radio Button 하나 선택해주세요 !");
                    break;
                }
                
            }
            dataGridView2.DataSource = table;
        }
        private DataTable dt = new DataTable();
		private void btn2_put_Click(object sender, EventArgs e)
		{
            DataGridView dgv = dataGridView3;
            DataGridViewRow dgvr = dataGridView2.CurrentRow;

            foreach (DataGridViewRow dgr in dgv.Rows)
            {
                if (dgr.Cells[0].Value == dgvr.Cells[0].Value)
                {
                    MessageBox.Show("같은 특허를 중복 저장할 수 없습니다.");
                    return;
                }
            }

            dt.Rows.Add(dgvr.Cells[0].Value, dgvr.Cells[1].Value, dgvr.Cells[2].Value, dgvr.Cells[3].Value, dgvr.Cells[4].Value,
                    dgvr.Cells[5].Value, dgvr.Cells[6].Value, dgvr.Cells[7].Value,
                    dgvr.Cells[8].Value, dgvr.Cells[9].Value, dgvr.Cells[10].Value, dgvr.Cells[11].Value, dgvr.Cells[12].Value);

            dataGridView3.DataSource = dt;
        }

        private void btn_remove_Click(object sender, EventArgs e)
		{
            DataGridView dgv = dataGridView3;

            foreach (DataGridViewRow dgr in dgv.SelectedRows)
            {
                dgv.Rows.Remove(dgr);
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView3;

            string newfile = @"C:\Users\82102\Desktop\박규민_202211415\장바구니data.json";
            if (File.Exists(newfile) == false)
            {
                using (File.Create(newfile)) { }

                string filepath = @"C:\Users\82102\Desktop\박규민_202211415\개인과제data.json";

                FileStream fs = File.OpenRead(filepath);
                StreamReader sr = new StreamReader(fs);

                JsonData1[] arrJsonDatas = JsonConvert.DeserializeObject<JsonData1[]>(sr.ReadToEnd());

                var jFriends = new JArray();
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    DataGridViewRow dgvr = dgv.Rows[i];
                    foreach (var item in arrJsonDatas)
                    {
                        if (dgvr.Cells[0].Value.Equals(item.id))
                        {
                            JObject jobject = new JObject();
                            jobject.Add(new JProperty("id", item.id));
                            jobject.Add(new JProperty("inventionTitle", item.inventionTitle));
                            jobject.Add(new JProperty("inventionTitleEng", item.inventionTitleEng));
                            jobject.Add(new JProperty("applicationNumber", item.applicationNumber));
                            jobject.Add(new JProperty("applicationDate", item.applicationDate));
                            jobject.Add(new JProperty("openNumber", item.openNumber));
                            jobject.Add(new JProperty("openDate", item.openDate));
                            jobject.Add(new JProperty("publicationNumber", item.publicationDate));
                            jobject.Add(new JProperty("publicationDate", item.publicationDate));
                            jobject.Add(new JProperty("registerNumber", item.registerNumber));
                            jobject.Add(new JProperty("registerDate", item.registerDate));
                            jobject.Add(new JProperty("originalApplicationKind", item.originalApplicationKind));
                            jobject.Add(new JProperty("originalApplicationNumber", item.originalApplicationNumber));
                            jobject.Add(new JProperty("originalApplicationDate", item.originalApplicationDate));
                            jobject.Add(new JProperty("finalDisposal", item.finalDisposal));
                            jobject.Add(new JProperty("registerStatus", item.registerStatus));
                            jobject.Add(new JProperty("examinerName", item.examinerName));
                            jobject.Add(new JProperty("originalExaminationRequestFlag", item.originalExaminationRequestFlag));
                            jobject.Add(new JProperty("originalExaminationRequestDate", item.originalExaminationRequestDate));
                            jobject.Add(new JProperty("claimCount", item.claimCount));
                            jobject.Add(new JProperty("applicationFlag", item.applicationFlag));
                            jobject.Add(new JProperty("translationSubmitDate", item.applicationDate));
                            jobject.Add(new JProperty("chk_pat", item.chk_pat));
                            jobject.Add(new JProperty("astrtCont", item.astrtCont));
                            jobject.Add(new JProperty("name", item.name));
                            jobject.Add(new JProperty("engName", item.engName));
                            jobject.Add(new JProperty("code", item.code));
                            jobject.Add(new JProperty("address", item.address));
                            jobject.Add(new JProperty("country", item.country));
                            jobject.Add(new JProperty("businessRegistrationNumber", item.businessRegistrationNumber));
                            jobject.Add(new JProperty("corporationNumber", item.corporationNumber));
                            jobject.Add(new JProperty("ipcNumber", item.ipcNumber));
                            jobject.Add(new JProperty("ipcDate", item.ipcDate));
                            jFriends.Add(jobject);
                        }
                    }
                }
                File.AppendAllText(newfile, jFriends.ToString());

            }
            else
            {
                MessageBox.Show("파일이 이미 생성되었습니다.");
                return;
            }
        }
	}

}
