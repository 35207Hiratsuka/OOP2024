using System.ComponentModel;
using System.Data;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //カーレポート管理用リスト
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //コンストラクタ
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            if(cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "記録者、または車名が未記入です";
                return;
            }



            CarReport carReport = new CarReport {
                Date = dtpDate.Value,
                Author = cbAuthor.Text,
                Maker = GetRadioButtonMaker(),
                CarName = cbCarName.Text,
                Report = tbReport.Text,
                Picture = pbPicture.Image,
            };
            listCarReports.Add(carReport);

            setCbAuthor(cbAuthor.Text);

            dgvCarReport.ClearSelection();

            inputItemsAllClear();

            
        }

        private void inputItemsAllClear() {
        
        dtpDate.Value = DateTime.Now;
            cbAuthor.Text = "";
            setRadioButtonMaker(CarReport.MakerGroup.無し);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }



        //記録者の履歴をコンボボックスへ登録（重複なし）
        private void setCbAuthor(string author) {
            if(!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //車名の履歴をコンボボックスへ登録（重複なし）
        private void setCbCarName(string carName) {
            if(!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);

        }

        //選択されているメーカー名を列挙型で返す
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if(rbToyota.Checked)
                return CarReport.MakerGroup.トヨタ;
            if(rbNissan.Checked)
                return CarReport.MakerGroup.日産;
            if(rbHonda.Checked)
                return CarReport.MakerGroup.ホンダ;
            if(rbSubaru.Checked)
                return CarReport.MakerGroup.スバル;
            if(rbImport.Checked)
                return CarReport.MakerGroup.輸入車;
            if(rbOther.Checked)
                return CarReport.MakerGroup.その他;

            return CarReport.MakerGroup.その他;
        }
        //指定したメーカーのラジオボタンをセット
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {

            switch(targetMaker) {
                case CarReport.MakerGroup.  無し:
                    rbToyota.Checked = false;
                    rbNissan.Checked = false;
                    rbHonda.Checked = false;
                    rbSubaru.Checked = false;
                    rbImport.Checked = false;
                    rbOther.Checked = false;
                    break;
                case CarReport.MakerGroup.トヨタ:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.日産:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.ホンダ:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.スバル:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.輸入車:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.その他:
                    rbOther.Checked = true;
                    break;
            }
        }


        private void btPicOpen_Click(object sender, EventArgs e) {
            if(ofdPicFileOpen.ShowDialog() == DialogResult.OK)
                pbPicture.Image = Image.FromFile(ofdPicFileOpen.FileName);
        }

        private void btPicDelete_Click(object sender, EventArgs e) {
            pbPicture.Image = null;
        }

        private void Form1_Load(object sender, EventArgs e) {
            dgvCarReport.Columns["Picture"].Visible = false;  //画像表示しない
        }

        private void dgvCarReport_Click(object sender, EventArgs e) {

            if(dgvCarReport.Rows.Count == 0)
                return;

            dtpDate.Value = (DateTime)dgvCarReport.CurrentRow.Cells["Date"].Value;
            cbAuthor.Text = (string)dgvCarReport.CurrentRow.Cells["Author"].Value;
            setRadioButtonMaker((CarReport.MakerGroup)dgvCarReport.CurrentRow.Cells["Maker"].Value);
            cbCarName.Text = (string)dgvCarReport.CurrentRow.Cells["CarName"].Value;
            tbReport.Text = (string)dgvCarReport.CurrentRow.Cells["Report"].Value;
            pbPicture.Image = (Image)dgvCarReport.CurrentRow.Cells["picture"].Value;

        }

        private void btDeleteReport_Click(object sender, EventArgs e) {
            if(dgvCarReport.CurrentRow == null)return; 
            listCarReports.RemoveAt(dgvCarReport.CurrentRow.Index);
            dgvCarReport.ClearSelection();
        }

        private void btModifyReport_Click(object sender, EventArgs e) {
            if(dgvCarReport.CurrentRow == null) return;
            if(dgvCarReport.SelectedRows == null) return;

            listCarReports[dgvCarReport.CurrentRow.Index].Date = dtpDate.Value;
            listCarReports[dgvCarReport.CurrentRow.Index].Author = cbAuthor.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Maker = GetRadioButtonMaker();
            listCarReports[dgvCarReport.CurrentRow.Index].CarName = cbCarName.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Report = tbReport.Text;
            listCarReports[dgvCarReport.CurrentRow.Index].Picture = pbPicture.Image;

            dgvCarReport.Refresh();//データグリッドビューの更新
        }

        //記録者のテキストが編集されたら
        private void cbAthor_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }

        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }
    }
}