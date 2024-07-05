using System.ComponentModel;
using System.Data;

namespace CarReportSystem {
    public partial class Form1 : Form {

        //�J�[���|�[�g�Ǘ��p���X�g
        BindingList<CarReport> listCarReports = new BindingList<CarReport>();

        //�R���X�g���N�^
        public Form1() {
            InitializeComponent();
            dgvCarReport.DataSource = listCarReports;
        }

        private void btAddReport_Click(object sender, EventArgs e) {
            if(cbAuthor.Text == "" || cbCarName.Text == "") {
                tslbMessage.Text = "�L�^�ҁA�܂��͎Ԗ������L���ł�";
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
            setRadioButtonMaker(CarReport.MakerGroup.����);
            cbCarName.Text = "";
            tbReport.Text = "";
            pbPicture.Image = null;
        }



        //�L�^�҂̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbAuthor(string author) {
            if(!cbAuthor.Items.Contains(author))
                cbAuthor.Items.Add(author);
        }

        //�Ԗ��̗������R���{�{�b�N�X�֓o�^�i�d���Ȃ��j
        private void setCbCarName(string carName) {
            if(!cbCarName.Items.Contains(carName))
                cbCarName.Items.Add(carName);

        }

        //�I������Ă��郁�[�J�[����񋓌^�ŕԂ�
        private CarReport.MakerGroup GetRadioButtonMaker() {
            if(rbToyota.Checked)
                return CarReport.MakerGroup.�g���^;
            if(rbNissan.Checked)
                return CarReport.MakerGroup.���Y;
            if(rbHonda.Checked)
                return CarReport.MakerGroup.�z���_;
            if(rbSubaru.Checked)
                return CarReport.MakerGroup.�X�o��;
            if(rbImport.Checked)
                return CarReport.MakerGroup.�A����;
            if(rbOther.Checked)
                return CarReport.MakerGroup.���̑�;

            return CarReport.MakerGroup.���̑�;
        }
        //�w�肵�����[�J�[�̃��W�I�{�^�����Z�b�g
        private void setRadioButtonMaker(CarReport.MakerGroup targetMaker) {

            switch(targetMaker) {
                case CarReport.MakerGroup.  ����:
                    rbToyota.Checked = false;
                    rbNissan.Checked = false;
                    rbHonda.Checked = false;
                    rbSubaru.Checked = false;
                    rbImport.Checked = false;
                    rbOther.Checked = false;
                    break;
                case CarReport.MakerGroup.�g���^:
                    rbToyota.Checked = true;
                    break;
                case CarReport.MakerGroup.���Y:
                    rbNissan.Checked = true;
                    break;
                case CarReport.MakerGroup.�z���_:
                    rbHonda.Checked = true;
                    break;
                case CarReport.MakerGroup.�X�o��:
                    rbSubaru.Checked = true;
                    break;
                case CarReport.MakerGroup.�A����:
                    rbImport.Checked = true;
                    break;
                case CarReport.MakerGroup.���̑�:
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
            dgvCarReport.Columns["Picture"].Visible = false;  //�摜�\�����Ȃ�
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

            dgvCarReport.Refresh();//�f�[�^�O���b�h�r���[�̍X�V
        }

        //�L�^�҂̃e�L�X�g���ҏW���ꂽ��
        private void cbAthor_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }

        private void cbCarName_TextChanged(object sender, EventArgs e) {
            tslbMessage.Text = "";
        }
    }
}