namespace 박규민_202211415
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.rb_name = new System.Windows.Forms.RadioButton();
			this.rb_astrt = new System.Windows.Forms.RadioButton();
			this.rb_title = new System.Windows.Forms.RadioButton();
			this.btn2_put = new System.Windows.Forms.Button();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.tb_search = new System.Windows.Forms.TextBox();
			this.btn_search = new System.Windows.Forms.Button();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.btn_create = new System.Windows.Forms.Button();
			this.tb_file = new System.Windows.Forms.TextBox();
			this.btn_file = new System.Windows.Forms.Button();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.장바구니 = new System.Windows.Forms.TabPage();
			this.dataGridView3 = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_remove = new System.Windows.Forms.Button();
			this.btn_save = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.장바구니.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.rb_name);
			this.tabPage2.Controls.Add(this.rb_astrt);
			this.tabPage2.Controls.Add(this.rb_title);
			this.tabPage2.Controls.Add(this.btn2_put);
			this.tabPage2.Controls.Add(this.dataGridView2);
			this.tabPage2.Controls.Add(this.tb_search);
			this.tabPage2.Controls.Add(this.btn_search);
			this.tabPage2.Location = new System.Drawing.Point(4, 28);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1257, 774);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "특허 검색";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// rb_name
			// 
			this.rb_name.AutoSize = true;
			this.rb_name.Location = new System.Drawing.Point(205, 26);
			this.rb_name.Name = "rb_name";
			this.rb_name.Size = new System.Drawing.Size(69, 22);
			this.rb_name.TabIndex = 11;
			this.rb_name.TabStop = true;
			this.rb_name.Text = "저자";
			this.rb_name.UseVisualStyleBackColor = true;
			// 
			// rb_astrt
			// 
			this.rb_astrt.AutoSize = true;
			this.rb_astrt.Location = new System.Drawing.Point(130, 26);
			this.rb_astrt.Name = "rb_astrt";
			this.rb_astrt.Size = new System.Drawing.Size(69, 22);
			this.rb_astrt.TabIndex = 10;
			this.rb_astrt.TabStop = true;
			this.rb_astrt.Text = "초록";
			this.rb_astrt.UseVisualStyleBackColor = true;
			// 
			// rb_title
			// 
			this.rb_title.AutoSize = true;
			this.rb_title.Location = new System.Drawing.Point(55, 26);
			this.rb_title.Name = "rb_title";
			this.rb_title.Size = new System.Drawing.Size(69, 22);
			this.rb_title.TabIndex = 10;
			this.rb_title.TabStop = true;
			this.rb_title.Text = "제목";
			this.rb_title.UseVisualStyleBackColor = true;
			// 
			// btn2_put
			// 
			this.btn2_put.Location = new System.Drawing.Point(1070, 19);
			this.btn2_put.Name = "btn2_put";
			this.btn2_put.Size = new System.Drawing.Size(155, 37);
			this.btn2_put.TabIndex = 9;
			this.btn2_put.Text = "장바구니 담기";
			this.btn2_put.UseVisualStyleBackColor = true;
			this.btn2_put.Click += new System.EventHandler(this.btn2_put_Click);
			// 
			// dataGridView2
			// 
			this.dataGridView2.AllowUserToAddRows = false;
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView2.Location = new System.Drawing.Point(3, 78);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.ReadOnly = true;
			this.dataGridView2.RowHeadersWidth = 62;
			this.dataGridView2.RowTemplate.Height = 30;
			this.dataGridView2.Size = new System.Drawing.Size(1251, 693);
			this.dataGridView2.TabIndex = 8;
			// 
			// tb_search
			// 
			this.tb_search.Location = new System.Drawing.Point(328, 24);
			this.tb_search.Name = "tb_search";
			this.tb_search.Size = new System.Drawing.Size(656, 28);
			this.tb_search.TabIndex = 7;
			// 
			// btn_search
			// 
			this.btn_search.Location = new System.Drawing.Point(991, 19);
			this.btn_search.Name = "btn_search";
			this.btn_search.Size = new System.Drawing.Size(75, 37);
			this.btn_search.TabIndex = 6;
			this.btn_search.Text = "검색";
			this.btn_search.UseVisualStyleBackColor = true;
			this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.dataGridView1);
			this.tabPage1.Controls.Add(this.btn_create);
			this.tabPage1.Controls.Add(this.tb_file);
			this.tabPage1.Controls.Add(this.btn_file);
			this.tabPage1.Location = new System.Drawing.Point(4, 28);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1257, 774);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "특허 로딩";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.dataGridView1.Location = new System.Drawing.Point(3, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersWidth = 62;
			this.dataGridView1.RowTemplate.Height = 30;
			this.dataGridView1.Size = new System.Drawing.Size(1251, 693);
			this.dataGridView1.TabIndex = 9;
			// 
			// btn_create
			// 
			this.btn_create.Location = new System.Drawing.Point(36, 19);
			this.btn_create.Name = "btn_create";
			this.btn_create.Size = new System.Drawing.Size(123, 34);
			this.btn_create.TabIndex = 7;
			this.btn_create.Text = "파일 합치기";
			this.btn_create.UseVisualStyleBackColor = true;
			this.btn_create.Click += new System.EventHandler(this.btn_create_Click);
			// 
			// tb_file
			// 
			this.tb_file.Location = new System.Drawing.Point(328, 24);
			this.tb_file.Name = "tb_file";
			this.tb_file.Size = new System.Drawing.Size(656, 28);
			this.tb_file.TabIndex = 5;
			// 
			// btn_file
			// 
			this.btn_file.Location = new System.Drawing.Point(182, 19);
			this.btn_file.Name = "btn_file";
			this.btn_file.Size = new System.Drawing.Size(122, 34);
			this.btn_file.TabIndex = 3;
			this.btn_file.Text = "파일 검색";
			this.btn_file.UseVisualStyleBackColor = true;
			this.btn_file.Click += new System.EventHandler(this.btn_file_Click);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.장바구니);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1265, 806);
			this.tabControl1.TabIndex = 2;
			// 
			// 장바구니
			// 
			this.장바구니.Controls.Add(this.dataGridView3);
			this.장바구니.Controls.Add(this.panel1);
			this.장바구니.Location = new System.Drawing.Point(4, 28);
			this.장바구니.Name = "장바구니";
			this.장바구니.Padding = new System.Windows.Forms.Padding(3);
			this.장바구니.Size = new System.Drawing.Size(1257, 774);
			this.장바구니.TabIndex = 2;
			this.장바구니.Text = "장바구니";
			this.장바구니.UseVisualStyleBackColor = true;
			// 
			// dataGridView3
			// 
			this.dataGridView3.AllowUserToAddRows = false;
			this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView3.Location = new System.Drawing.Point(3, 77);
			this.dataGridView3.Name = "dataGridView3";
			this.dataGridView3.ReadOnly = true;
			this.dataGridView3.RowHeadersWidth = 62;
			this.dataGridView3.RowTemplate.Height = 30;
			this.dataGridView3.Size = new System.Drawing.Size(1251, 694);
			this.dataGridView3.TabIndex = 1;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_remove);
			this.panel1.Controls.Add(this.btn_save);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1251, 74);
			this.panel1.TabIndex = 0;
			// 
			// btn_remove
			// 
			this.btn_remove.Location = new System.Drawing.Point(1103, 19);
			this.btn_remove.Name = "btn_remove";
			this.btn_remove.Size = new System.Drawing.Size(108, 34);
			this.btn_remove.TabIndex = 3;
			this.btn_remove.Text = "삭제";
			this.btn_remove.UseVisualStyleBackColor = true;
			this.btn_remove.Click += new System.EventHandler(this.btn_remove_Click);
			// 
			// btn_save
			// 
			this.btn_save.Location = new System.Drawing.Point(36, 19);
			this.btn_save.Name = "btn_save";
			this.btn_save.Size = new System.Drawing.Size(123, 34);
			this.btn_save.TabIndex = 2;
			this.btn_save.Text = "파일 저장";
			this.btn_save.UseVisualStyleBackColor = true;
			this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
			// 
			// textBox1
			// 
			this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.textBox1.Font = new System.Drawing.Font("굴림", 15F);
			this.textBox1.Location = new System.Drawing.Point(537, 19);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(183, 35);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "장바구니";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1265, 806);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.장바구니.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.TextBox tb_search;
		private System.Windows.Forms.Button btn_search;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button btn_create;
		private System.Windows.Forms.TextBox tb_file;
		private System.Windows.Forms.Button btn_file;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage 장바구니;
		private System.Windows.Forms.RadioButton rb_name;
		private System.Windows.Forms.RadioButton rb_astrt;
		private System.Windows.Forms.RadioButton rb_title;
		private System.Windows.Forms.Button btn2_put;
		private System.Windows.Forms.DataGridView dataGridView3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_save;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button btn_remove;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}

