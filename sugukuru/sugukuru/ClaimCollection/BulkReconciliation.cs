using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace sugukuru.ClaimCollection
{
    public partial class BulkReconciliation : FormMaster.UserControlMST
    {
        public BulkReconciliation()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            List<String> receiveList = BulkSelectForm.ShowForm();
        }

        private void btFileOpen_Click(object sender, EventArgs e)
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.csv";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "CSVファイル(*.html;*.htm)|*.csv|すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            //ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tbFileName.Text = ofd.FileName;
            }
        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            //入金データを入れるList
            List<Dictionary<string, string>> tbl = new List<Dictionary<string, string>>();

            //CSVファイルを読み込んで、内容を取得、確認
            Encoding enc = Encoding.GetEncoding("utf-8");
            StreamReader sr = new StreamReader(tbFileName.Text, enc);
            String rec = sr.ReadLine();
            string[] rtbl = rec.Split(',');
            while (!"9".Equals(rtbl[0].ToString()))
            {
                switch (rtbl[0].ToString())
                {
                    case "1":
                        break;
                    case "2":
                        Dictionary<string, string> d = new Dictionary<string, string>();
                        d.Add("date", rtbl[2].ToString());
                        d.Add("price", rtbl[4].ToString());
                        d.Add("name", rtbl[6].ToString());
                        tbl.Add(d);
                        break;
                    case "8":
                        bool checkFlag = true;

                        if(!(int.Parse(rtbl[1]) == tbl.Count))
                        {
                            checkFlag = false;
                        }
                        else
                        {
                            int sumPrice = 0;
                            for (int i = 0; i < tbl.Count; i++)
                            {
                                Dictionary<string, string> dic = tbl[i];
                                sumPrice += int.Parse(dic["price"]);
                            }
                            if(!(int.Parse(rtbl[2]) == sumPrice))
                            {
                                checkFlag = false;
                            }
                        }

                        if(!checkFlag)
                        {
                            MessageBox.Show("入金情報が正しくありません。");
                            sr.Close();
                            return;
                        }
                        break;
                }
                rec = sr.ReadLine();
                rtbl = rec.Split(',');
            }
            sr.Close();

            //消込処理
            for (int i = tbl.Count - 1; i >= 0; i--)
            {
                
                if (true)
                {
                    tbl.RemoveAt(i);
                }
            }
        }
    }
}
