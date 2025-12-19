namespace BT_WinForm
{
    partial class Form13
    {
        private System.ComponentModel.IContainer components = null;
        private ListBox lbSong;
        private ListBox lbFavorite;
        private Button btSelect;
        private Button btDeselect;
        private Button btSelectAll;
        private Button btDeselectAll;
        private Label label1;
        private Label label2;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lbSong = new ListBox();
            lbFavorite = new ListBox();
            btSelect = new Button();
            btDeselect = new Button();
            btSelectAll = new Button();
            btDeselectAll = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lbSong
            // 
            lbSong.Location = new Point(12, 46);
            lbSong.Name = "lbSong";
            lbSong.Size = new Size(250, 244);
            lbSong.TabIndex = 0;
            lbSong.SelectedIndexChanged += lbSong_SelectedIndexChanged;
            lbSong.MouseDoubleClick += lbSong_MouseDoubleClick;
            // 
            // lbFavorite
            // 
            lbFavorite.Location = new Point(381, 46);
            lbFavorite.Name = "lbFavorite";
            lbFavorite.Size = new Size(250, 244);
            lbFavorite.TabIndex = 1;
            lbFavorite.MouseDoubleClick += lbFavorite_MouseDoubleClick;
            // 
            // btSelect
            // 
            btSelect.Location = new Point(287, 80);
            btSelect.Name = "btSelect";
            btSelect.Size = new Size(75, 23);
            btSelect.TabIndex = 2;
            btSelect.Text = ">";
            btSelect.Click += btSelect_Click;
            // 
            // btDeselect
            // 
            btDeselect.Location = new Point(287, 120);
            btDeselect.Name = "btDeselect";
            btDeselect.Size = new Size(75, 23);
            btDeselect.TabIndex = 3;
            btDeselect.Text = "<";
            btDeselect.Click += btDeselect_Click;
            // 
            // btSelectAll
            // 
            btSelectAll.Location = new Point(287, 160);
            btSelectAll.Name = "btSelectAll";
            btSelectAll.Size = new Size(75, 23);
            btSelectAll.TabIndex = 4;
            btSelectAll.Text = ">>";
            btSelectAll.Click += btSelectAll_Click;
            // 
            // btDeselectAll
            // 
            btDeselectAll.Location = new Point(287, 198);
            btDeselectAll.Name = "btDeselectAll";
            btDeselectAll.Size = new Size(75, 23);
            btDeselectAll.TabIndex = 5;
            btDeselectAll.Text = "<<";
            btDeselectAll.Click += btDeselectAll_Click;
            // 
            // label1
            // 
            label1.Location = new Point(40, 20);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 6;
            label1.Text = "Danh sách bài hát";
            // 
            // label2
            // 
            label2.Location = new Point(381, 20);
            label2.Name = "label2";
            label2.Size = new Size(100, 23);
            label2.TabIndex = 7;
            label2.Text = "Danh sách yêu thích";
            // 
            // Form13
            // 
            ClientSize = new Size(650, 350);
            Controls.Add(lbSong);
            Controls.Add(lbFavorite);
            Controls.Add(btSelect);
            Controls.Add(btDeselect);
            Controls.Add(btSelectAll);
            Controls.Add(btDeselectAll);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form13";
            Text = "Form 13 - Music";
            Load += Form13_Load;
            ResumeLayout(false);
        }
    }
}
