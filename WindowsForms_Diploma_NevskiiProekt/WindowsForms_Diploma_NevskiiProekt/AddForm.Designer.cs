namespace WindowsForms_Diploma_NevskiiProekt
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label fioPolnostjuLabel;
            System.Windows.Forms.Label innLabel;
            System.Windows.Forms.Label snilsLabel;
            System.Windows.Forms.Label polLabel;
            System.Windows.Forms.Label pasportNoLabel;
            System.Windows.Forms.Label dataVidachiPasportaLabel;
            System.Windows.Forms.Label pasportVidanLabel;
            System.Windows.Forms.Label adresPoPropiskeLabel;
            System.Windows.Forms.Label indexPoPropiskeLabel;
            System.Windows.Forms.Label adresFakticheskiiLabel;
            System.Windows.Forms.Label indexFakticheskiiLabel;
            System.Windows.Forms.Label telefonLabel;
            System.Windows.Forms.Label dataRozhdenijaLabel;
            System.Windows.Forms.Label mestoRozhdenijaLabel;
            System.Windows.Forms.Label mestoRozhdenijaKodLabel;
            System.Windows.Forms.Label grazhdanstvoLabel;
            System.Windows.Forms.Label grazhdanstvoKodLabel;
            System.Windows.Forms.Label obrazovanijeLabel;
            System.Windows.Forms.Label obrazovanijeKodLabel;
            System.Windows.Forms.Label statusVOrganizatsiiLabel;
            System.Windows.Forms.Label professijaLabel;
            System.Windows.Forms.Label professijaKodLabel;
            System.Windows.Forms.Label professijaDrugajaLabel;
            System.Windows.Forms.Label professijaDrugajaKodLabel;
            System.Windows.Forms.Label dataNachalaRabotiLabel;
            System.Windows.Forms.Label kharakterRabotiLabel;
            System.Windows.Forms.Label vidRabotiLabel;
            System.Windows.Forms.Label okladCiframiLabel;
            System.Windows.Forms.Label okladPropisjuLabel;
            System.Windows.Forms.Label nomerTDLabel;
            System.Windows.Forms.Label dataTDLabel;
            System.Windows.Forms.Label dataPrikazaOPriemeLabel;
            System.Windows.Forms.Label okonchanijeTDLabel;
            System.Windows.Forms.Label ispitSrokLabel;
            System.Windows.Forms.Label primechanijaLabel;
            System.Windows.Forms.Label tabNomerLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label7;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.personalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.diploma_NevskiiProectDataSet = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSet();
            this.personalTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.PersonalTableAdapter();
            this.tableAdapterManager = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.TableAdapterManager();
            this.personalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.fioPolnostjuTextBox = new System.Windows.Forms.TextBox();
            this.innTextBox = new System.Windows.Forms.TextBox();
            this.snilsTextBox = new System.Windows.Forms.TextBox();
            this.pasportNoTextBox = new System.Windows.Forms.TextBox();
            this.dataVidachiPasportaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pasportVidanTextBox = new System.Windows.Forms.TextBox();
            this.adresPoPropiskeTextBox = new System.Windows.Forms.TextBox();
            this.indexPoPropiskeTextBox = new System.Windows.Forms.TextBox();
            this.adresFakticheskiiTextBox = new System.Windows.Forms.TextBox();
            this.indexFakticheskiiTextBox = new System.Windows.Forms.TextBox();
            this.telefonTextBox = new System.Windows.Forms.TextBox();
            this.dataRozhdenijaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.mestoRozhdenijaTextBox = new System.Windows.Forms.TextBox();
            this.mestoRozhdenijaKodTextBox = new System.Windows.Forms.TextBox();
            this.grazhdanstvoKodTextBox = new System.Windows.Forms.TextBox();
            this.obrazovanijeKodTextBox = new System.Windows.Forms.TextBox();
            this.professijaKodTextBox = new System.Windows.Forms.TextBox();
            this.professijaDrugajaKodTextBox = new System.Windows.Forms.TextBox();
            this.dataNachalaRabotiDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.okladCiframiTextBox = new System.Windows.Forms.TextBox();
            this.okladPropisjuTextBox = new System.Windows.Forms.TextBox();
            this.nomerTDTextBox = new System.Windows.Forms.TextBox();
            this.dataTDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.dataPrikazaOPriemeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.okonchanijeTDDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ispitSrokTextBox = new System.Windows.Forms.TextBox();
            this.primechanijaTextBox = new System.Windows.Forms.TextBox();
            this.nalichieAnketiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieLichnKartochkiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieFotoCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieKopiiPasportaCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePrikazaOPriemeCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieTrudovogoDogovoraCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieZajavlenijaNaRabotuCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieDogOMatOtvetstvennostiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieDolzhnInstrukciiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieSoglasijaNaNochCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieSoglasijaNaFotoCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieTrudovojKnijkiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieZajavlNaVidachuTrudovojCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieZajavlNaPolstavkiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieKopiiInnCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieKopiiSnilsCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichieSanKnizhkiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaAnketeCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaLichnKart2strCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaPVTRCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaPravIspPersDannihCheckBox = new System.Windows.Forms.CheckBox();
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox = new System.Windows.Forms.CheckBox();
            this.tabNomerTextBox = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.formPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.formButton = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button21 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.docPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.toDocFormButton = new System.Windows.Forms.Button();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.personalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripMainButton = new System.Windows.Forms.ToolStripButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.kindOfWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kindOfWorkTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.KindOfWorkTableAdapter();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.SexTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.kodiOkinObrazovanijeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodiOkinObrazovanijeTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.KodiOkinObrazovanijeTableAdapter();
            this.kodiOkinGrazhdanstvoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kodiOkinGrazhdanstvoTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.KodiOkinGrazhdanstvoTableAdapter();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.statusInOrganizationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusInOrganizationTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.StatusInOrganizationTableAdapter();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languagesTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.LanguagesTableAdapter();
            this.manningTableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.manningTableTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.ManningTableTableAdapter();
            this.personalBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.characterOfWorkBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.characterOfWorkTableAdapter = new WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.CharacterOfWorkTableAdapter();
            fioPolnostjuLabel = new System.Windows.Forms.Label();
            innLabel = new System.Windows.Forms.Label();
            snilsLabel = new System.Windows.Forms.Label();
            polLabel = new System.Windows.Forms.Label();
            pasportNoLabel = new System.Windows.Forms.Label();
            dataVidachiPasportaLabel = new System.Windows.Forms.Label();
            pasportVidanLabel = new System.Windows.Forms.Label();
            adresPoPropiskeLabel = new System.Windows.Forms.Label();
            indexPoPropiskeLabel = new System.Windows.Forms.Label();
            adresFakticheskiiLabel = new System.Windows.Forms.Label();
            indexFakticheskiiLabel = new System.Windows.Forms.Label();
            telefonLabel = new System.Windows.Forms.Label();
            dataRozhdenijaLabel = new System.Windows.Forms.Label();
            mestoRozhdenijaLabel = new System.Windows.Forms.Label();
            mestoRozhdenijaKodLabel = new System.Windows.Forms.Label();
            grazhdanstvoLabel = new System.Windows.Forms.Label();
            grazhdanstvoKodLabel = new System.Windows.Forms.Label();
            obrazovanijeLabel = new System.Windows.Forms.Label();
            obrazovanijeKodLabel = new System.Windows.Forms.Label();
            statusVOrganizatsiiLabel = new System.Windows.Forms.Label();
            professijaLabel = new System.Windows.Forms.Label();
            professijaKodLabel = new System.Windows.Forms.Label();
            professijaDrugajaLabel = new System.Windows.Forms.Label();
            professijaDrugajaKodLabel = new System.Windows.Forms.Label();
            dataNachalaRabotiLabel = new System.Windows.Forms.Label();
            kharakterRabotiLabel = new System.Windows.Forms.Label();
            vidRabotiLabel = new System.Windows.Forms.Label();
            okladCiframiLabel = new System.Windows.Forms.Label();
            okladPropisjuLabel = new System.Windows.Forms.Label();
            nomerTDLabel = new System.Windows.Forms.Label();
            dataTDLabel = new System.Windows.Forms.Label();
            dataPrikazaOPriemeLabel = new System.Windows.Forms.Label();
            okonchanijeTDLabel = new System.Windows.Forms.Label();
            ispitSrokLabel = new System.Windows.Forms.Label();
            primechanijaLabel = new System.Windows.Forms.Label();
            tabNomerLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploma_NevskiiProectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).BeginInit();
            this.personalBindingNavigator.SuspendLayout();
            this.formPanel.SuspendLayout();
            this.docPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kindOfWorkBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodiOkinObrazovanijeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodiOkinGrazhdanstvoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInOrganizationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manningTableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterOfWorkBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // fioPolnostjuLabel
            // 
            fioPolnostjuLabel.AutoSize = true;
            fioPolnostjuLabel.Location = new System.Drawing.Point(26, 141);
            fioPolnostjuLabel.Name = "fioPolnostjuLabel";
            fioPolnostjuLabel.Size = new System.Drawing.Size(101, 13);
            fioPolnostjuLabel.TabIndex = 22;
            fioPolnostjuLabel.Text = "ФИО (полностью):";
            // 
            // innLabel
            // 
            innLabel.AutoSize = true;
            innLabel.Location = new System.Drawing.Point(26, 167);
            innLabel.Name = "innLabel";
            innLabel.Size = new System.Drawing.Size(34, 13);
            innLabel.TabIndex = 24;
            innLabel.Text = "ИНН:";
            // 
            // snilsLabel
            // 
            snilsLabel.AutoSize = true;
            snilsLabel.Location = new System.Drawing.Point(26, 193);
            snilsLabel.Name = "snilsLabel";
            snilsLabel.Size = new System.Drawing.Size(48, 13);
            snilsLabel.TabIndex = 26;
            snilsLabel.Text = "СНИЛС:";
            // 
            // polLabel
            // 
            polLabel.AutoSize = true;
            polLabel.Location = new System.Drawing.Point(26, 219);
            polLabel.Name = "polLabel";
            polLabel.Size = new System.Drawing.Size(30, 13);
            polLabel.TabIndex = 28;
            polLabel.Text = "Пол:";
            // 
            // pasportNoLabel
            // 
            pasportNoLabel.AutoSize = true;
            pasportNoLabel.Location = new System.Drawing.Point(26, 245);
            pasportNoLabel.Name = "pasportNoLabel";
            pasportNoLabel.Size = new System.Drawing.Size(135, 13);
            pasportNoLabel.TabIndex = 30;
            pasportNoLabel.Text = "Серия и номер паспорта:";
            // 
            // dataVidachiPasportaLabel
            // 
            dataVidachiPasportaLabel.AutoSize = true;
            dataVidachiPasportaLabel.Location = new System.Drawing.Point(26, 272);
            dataVidachiPasportaLabel.Name = "dataVidachiPasportaLabel";
            dataVidachiPasportaLabel.Size = new System.Drawing.Size(126, 13);
            dataVidachiPasportaLabel.TabIndex = 32;
            dataVidachiPasportaLabel.Text = "Дата выдачи паспорта:";
            // 
            // pasportVidanLabel
            // 
            pasportVidanLabel.AutoSize = true;
            pasportVidanLabel.Location = new System.Drawing.Point(26, 297);
            pasportVidanLabel.Name = "pasportVidanLabel";
            pasportVidanLabel.Size = new System.Drawing.Size(231, 13);
            pasportVidanLabel.TabIndex = 34;
            pasportVidanLabel.Text = "Наименование органа, выдавшего паспорт:";
            // 
            // adresPoPropiskeLabel
            // 
            adresPoPropiskeLabel.AutoSize = true;
            adresPoPropiskeLabel.Location = new System.Drawing.Point(26, 323);
            adresPoPropiskeLabel.Name = "adresPoPropiskeLabel";
            adresPoPropiskeLabel.Size = new System.Drawing.Size(107, 13);
            adresPoPropiskeLabel.TabIndex = 36;
            adresPoPropiskeLabel.Text = "Адрес по прописке:";
            // 
            // indexPoPropiskeLabel
            // 
            indexPoPropiskeLabel.AutoSize = true;
            indexPoPropiskeLabel.Location = new System.Drawing.Point(26, 349);
            indexPoPropiskeLabel.Name = "indexPoPropiskeLabel";
            indexPoPropiskeLabel.Size = new System.Drawing.Size(114, 13);
            indexPoPropiskeLabel.TabIndex = 38;
            indexPoPropiskeLabel.Text = "Индекс по прописке:";
            // 
            // adresFakticheskiiLabel
            // 
            adresFakticheskiiLabel.AutoSize = true;
            adresFakticheskiiLabel.Location = new System.Drawing.Point(26, 375);
            adresFakticheskiiLabel.Name = "adresFakticheskiiLabel";
            adresFakticheskiiLabel.Size = new System.Drawing.Size(112, 13);
            adresFakticheskiiLabel.TabIndex = 40;
            adresFakticheskiiLabel.Text = "Фактический адрес:";
            // 
            // indexFakticheskiiLabel
            // 
            indexFakticheskiiLabel.AutoSize = true;
            indexFakticheskiiLabel.Location = new System.Drawing.Point(26, 401);
            indexFakticheskiiLabel.Name = "indexFakticheskiiLabel";
            indexFakticheskiiLabel.Size = new System.Drawing.Size(118, 13);
            indexFakticheskiiLabel.TabIndex = 42;
            indexFakticheskiiLabel.Text = "Фактический индекс:";
            // 
            // telefonLabel
            // 
            telefonLabel.AutoSize = true;
            telefonLabel.Location = new System.Drawing.Point(26, 427);
            telefonLabel.Name = "telefonLabel";
            telefonLabel.Size = new System.Drawing.Size(117, 13);
            telefonLabel.TabIndex = 44;
            telefonLabel.Text = "Контантный телефон:";
            // 
            // dataRozhdenijaLabel
            // 
            dataRozhdenijaLabel.AutoSize = true;
            dataRozhdenijaLabel.Location = new System.Drawing.Point(26, 454);
            dataRozhdenijaLabel.Name = "dataRozhdenijaLabel";
            dataRozhdenijaLabel.Size = new System.Drawing.Size(89, 13);
            dataRozhdenijaLabel.TabIndex = 46;
            dataRozhdenijaLabel.Text = "Дата рождения:";
            // 
            // mestoRozhdenijaLabel
            // 
            mestoRozhdenijaLabel.AutoSize = true;
            mestoRozhdenijaLabel.Location = new System.Drawing.Point(26, 479);
            mestoRozhdenijaLabel.Name = "mestoRozhdenijaLabel";
            mestoRozhdenijaLabel.Size = new System.Drawing.Size(95, 13);
            mestoRozhdenijaLabel.TabIndex = 48;
            mestoRozhdenijaLabel.Text = "Место рождения:";
            // 
            // mestoRozhdenijaKodLabel
            // 
            mestoRozhdenijaKodLabel.AutoSize = true;
            mestoRozhdenijaKodLabel.Location = new System.Drawing.Point(26, 505);
            mestoRozhdenijaKodLabel.Name = "mestoRozhdenijaKodLabel";
            mestoRozhdenijaKodLabel.Size = new System.Drawing.Size(171, 13);
            mestoRozhdenijaKodLabel.TabIndex = 50;
            mestoRozhdenijaKodLabel.Text = "Код места рождения по ОКАТО:";
            // 
            // grazhdanstvoLabel
            // 
            grazhdanstvoLabel.AutoSize = true;
            grazhdanstvoLabel.Location = new System.Drawing.Point(26, 531);
            grazhdanstvoLabel.Name = "grazhdanstvoLabel";
            grazhdanstvoLabel.Size = new System.Drawing.Size(77, 13);
            grazhdanstvoLabel.TabIndex = 52;
            grazhdanstvoLabel.Text = "Гражданство:";
            // 
            // grazhdanstvoKodLabel
            // 
            grazhdanstvoKodLabel.AutoSize = true;
            grazhdanstvoKodLabel.Location = new System.Drawing.Point(26, 557);
            grazhdanstvoKodLabel.Name = "grazhdanstvoKodLabel";
            grazhdanstvoKodLabel.Size = new System.Drawing.Size(147, 13);
            grazhdanstvoKodLabel.TabIndex = 54;
            grazhdanstvoKodLabel.Text = "Код гражданства по ОКИН:";
            // 
            // obrazovanijeLabel
            // 
            obrazovanijeLabel.AutoSize = true;
            obrazovanijeLabel.Location = new System.Drawing.Point(26, 583);
            obrazovanijeLabel.Name = "obrazovanijeLabel";
            obrazovanijeLabel.Size = new System.Drawing.Size(78, 13);
            obrazovanijeLabel.TabIndex = 56;
            obrazovanijeLabel.Text = "Образование:";
            // 
            // obrazovanijeKodLabel
            // 
            obrazovanijeKodLabel.AutoSize = true;
            obrazovanijeKodLabel.Location = new System.Drawing.Point(26, 609);
            obrazovanijeKodLabel.Name = "obrazovanijeKodLabel";
            obrazovanijeKodLabel.Size = new System.Drawing.Size(147, 13);
            obrazovanijeKodLabel.TabIndex = 58;
            obrazovanijeKodLabel.Text = "Код образования по ОКИН:";
            // 
            // statusVOrganizatsiiLabel
            // 
            statusVOrganizatsiiLabel.AutoSize = true;
            statusVOrganizatsiiLabel.Location = new System.Drawing.Point(534, 35);
            statusVOrganizatsiiLabel.Name = "statusVOrganizatsiiLabel";
            statusVOrganizatsiiLabel.Size = new System.Drawing.Size(121, 13);
            statusVOrganizatsiiLabel.TabIndex = 60;
            statusVOrganizatsiiLabel.Text = "Статус в организации:";
            // 
            // professijaLabel
            // 
            professijaLabel.AutoSize = true;
            professijaLabel.Location = new System.Drawing.Point(534, 61);
            professijaLabel.Name = "professijaLabel";
            professijaLabel.Size = new System.Drawing.Size(68, 13);
            professijaLabel.TabIndex = 62;
            professijaLabel.Text = "Профессия:";
            // 
            // professijaKodLabel
            // 
            professijaKodLabel.AutoSize = true;
            professijaKodLabel.Location = new System.Drawing.Point(534, 87);
            professijaKodLabel.Name = "professijaKodLabel";
            professijaKodLabel.Size = new System.Drawing.Size(152, 13);
            professijaKodLabel.TabIndex = 64;
            professijaKodLabel.Text = "Код профессии по ОКПДТР:";
            // 
            // professijaDrugajaLabel
            // 
            professijaDrugajaLabel.AutoSize = true;
            professijaDrugajaLabel.Location = new System.Drawing.Point(534, 113);
            professijaDrugajaLabel.Name = "professijaDrugajaLabel";
            professijaDrugajaLabel.Size = new System.Drawing.Size(106, 13);
            professijaDrugajaLabel.TabIndex = 66;
            professijaDrugajaLabel.Text = "Другая профессия:";
            // 
            // professijaDrugajaKodLabel
            // 
            professijaDrugajaKodLabel.AutoSize = true;
            professijaDrugajaKodLabel.Location = new System.Drawing.Point(534, 139);
            professijaDrugajaKodLabel.Name = "professijaDrugajaKodLabel";
            professijaDrugajaKodLabel.Size = new System.Drawing.Size(174, 13);
            professijaDrugajaKodLabel.TabIndex = 68;
            professijaDrugajaKodLabel.Text = "Код другой профессии ОКПДТР:";
            // 
            // dataNachalaRabotiLabel
            // 
            dataNachalaRabotiLabel.AutoSize = true;
            dataNachalaRabotiLabel.Location = new System.Drawing.Point(534, 166);
            dataNachalaRabotiLabel.Name = "dataNachalaRabotiLabel";
            dataNachalaRabotiLabel.Size = new System.Drawing.Size(114, 13);
            dataNachalaRabotiLabel.TabIndex = 70;
            dataNachalaRabotiLabel.Text = "Дата начала работы:";
            // 
            // kharakterRabotiLabel
            // 
            kharakterRabotiLabel.AutoSize = true;
            kharakterRabotiLabel.Location = new System.Drawing.Point(534, 193);
            kharakterRabotiLabel.Name = "kharakterRabotiLabel";
            kharakterRabotiLabel.Size = new System.Drawing.Size(98, 13);
            kharakterRabotiLabel.TabIndex = 72;
            kharakterRabotiLabel.Text = "Характер работы:";
            // 
            // vidRabotiLabel
            // 
            vidRabotiLabel.AutoSize = true;
            vidRabotiLabel.Location = new System.Drawing.Point(26, 35);
            vidRabotiLabel.Name = "vidRabotiLabel";
            vidRabotiLabel.Size = new System.Drawing.Size(69, 13);
            vidRabotiLabel.TabIndex = 74;
            vidRabotiLabel.Text = "Вид работы:";
            // 
            // okladCiframiLabel
            // 
            okladCiframiLabel.AutoSize = true;
            okladCiframiLabel.Location = new System.Drawing.Point(534, 220);
            okladCiframiLabel.Name = "okladCiframiLabel";
            okladCiframiLabel.Size = new System.Drawing.Size(113, 13);
            okladCiframiLabel.TabIndex = 76;
            okladCiframiLabel.Text = "Должностной оклад:";
            // 
            // okladPropisjuLabel
            // 
            okladPropisjuLabel.AutoSize = true;
            okladPropisjuLabel.Location = new System.Drawing.Point(534, 246);
            okladPropisjuLabel.Name = "okladPropisjuLabel";
            okladPropisjuLabel.Size = new System.Drawing.Size(172, 13);
            okladPropisjuLabel.TabIndex = 78;
            okladPropisjuLabel.Text = "Должностной оклад (прописью):";
            // 
            // nomerTDLabel
            // 
            nomerTDLabel.AutoSize = true;
            nomerTDLabel.Location = new System.Drawing.Point(534, 272);
            nomerTDLabel.Name = "nomerTDLabel";
            nomerTDLabel.Size = new System.Drawing.Size(148, 13);
            nomerTDLabel.TabIndex = 80;
            nomerTDLabel.Text = "Номер трудового договора:";
            // 
            // dataTDLabel
            // 
            dataTDLabel.AutoSize = true;
            dataTDLabel.Location = new System.Drawing.Point(534, 299);
            dataTDLabel.Name = "dataTDLabel";
            dataTDLabel.Size = new System.Drawing.Size(140, 13);
            dataTDLabel.TabIndex = 82;
            dataTDLabel.Text = "Дата трудового договора:";
            // 
            // dataPrikazaOPriemeLabel
            // 
            dataPrikazaOPriemeLabel.AutoSize = true;
            dataPrikazaOPriemeLabel.Location = new System.Drawing.Point(534, 351);
            dataPrikazaOPriemeLabel.Name = "dataPrikazaOPriemeLabel";
            dataPrikazaOPriemeLabel.Size = new System.Drawing.Size(131, 13);
            dataPrikazaOPriemeLabel.TabIndex = 84;
            dataPrikazaOPriemeLabel.Text = "Дата приказа о приеме:";
            // 
            // okonchanijeTDLabel
            // 
            okonchanijeTDLabel.AutoSize = true;
            okonchanijeTDLabel.Location = new System.Drawing.Point(534, 377);
            okonchanijeTDLabel.Name = "okonchanijeTDLabel";
            okonchanijeTDLabel.Size = new System.Drawing.Size(196, 13);
            okonchanijeTDLabel.TabIndex = 86;
            okonchanijeTDLabel.Text = "Дата окончания трудового договора:";
            // 
            // ispitSrokLabel
            // 
            ispitSrokLabel.AutoSize = true;
            ispitSrokLabel.Location = new System.Drawing.Point(534, 402);
            ispitSrokLabel.Name = "ispitSrokLabel";
            ispitSrokLabel.Size = new System.Drawing.Size(119, 13);
            ispitSrokLabel.TabIndex = 88;
            ispitSrokLabel.Text = "Испытательный срок:";
            // 
            // primechanijaLabel
            // 
            primechanijaLabel.AutoSize = true;
            primechanijaLabel.Location = new System.Drawing.Point(534, 428);
            primechanijaLabel.Name = "primechanijaLabel";
            primechanijaLabel.Size = new System.Drawing.Size(73, 13);
            primechanijaLabel.TabIndex = 94;
            primechanijaLabel.Text = "Примечания:";
            // 
            // tabNomerLabel
            // 
            tabNomerLabel.AutoSize = true;
            tabNomerLabel.Location = new System.Drawing.Point(26, 61);
            tabNomerLabel.Name = "tabNomerLabel";
            tabNomerLabel.Size = new System.Drawing.Size(67, 13);
            tabNomerLabel.TabIndex = 208;
            tabNomerLabel.Text = "Таб. номер:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(31, 30);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(157, 16);
            label1.TabIndex = 215;
            label1.Text = "Наличие документа";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label3.Location = new System.Drawing.Point(498, 30);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(166, 16);
            label3.TabIndex = 217;
            label3.Text = "Образец заполнения";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label4.Location = new System.Drawing.Point(715, 30);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(239, 16);
            label4.TabIndex = 218;
            label4.Text = "Наличие подписей сотрудника";
            // 
            // personalBindingSource
            // 
            this.personalBindingSource.DataMember = "Personal";
            this.personalBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // diploma_NevskiiProectDataSet
            // 
            this.diploma_NevskiiProectDataSet.DataSetName = "Diploma_NevskiiProectDataSet";
            this.diploma_NevskiiProectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personalTableAdapter
            // 
            this.personalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CharacterOfWorkTableAdapter = null;
            this.tableAdapterManager.DismissalReasonTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.KindOfWorkTableAdapter = null;
            this.tableAdapterManager.KodiOkatoTableAdapter = null;
            this.tableAdapterManager.KodiOkinGrazhdanstvoTableAdapter = null;
            this.tableAdapterManager.KodiOkinInYazikTableAdapter = null;
            this.tableAdapterManager.KodiOkinObrazovanijeTableAdapter = null;
            this.tableAdapterManager.KodiOkinPosleVuzaTableAdapter = null;
            this.tableAdapterManager.KodiOkinStepenYazikaTableAdapter = null;
            this.tableAdapterManager.KodiOkpdtrTableAdapter = null;
            this.tableAdapterManager.KodiOksoTableAdapter = null;
            this.tableAdapterManager.LanguagesTableAdapter = null;
            this.tableAdapterManager.ManningTableTableAdapter = null;
            this.tableAdapterManager.OrganizationTableAdapter = null;
            this.tableAdapterManager.PersonalTableAdapter = this.personalTableAdapter;
            this.tableAdapterManager.SexTableAdapter = null;
            this.tableAdapterManager.StatusInOrganizationTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = WindowsForms_Diploma_NevskiiProekt.Diploma_NevskiiProectDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // personalBindingNavigator
            // 
            this.personalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.personalBindingNavigator.AutoSize = false;
            this.personalBindingNavigator.BindingSource = this.personalBindingSource;
            this.personalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.personalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.personalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.personalBindingNavigatorSaveItem,
            this.toolStripMainButton});
            this.personalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.personalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.personalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.personalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.personalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.personalBindingNavigator.Name = "personalBindingNavigator";
            this.personalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.personalBindingNavigator.Size = new System.Drawing.Size(1015, 37);
            this.personalBindingNavigator.TabIndex = 17;
            this.personalBindingNavigator.Text = "ц";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 34);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 37);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 37);
            // 
            // fioPolnostjuTextBox
            // 
            this.fioPolnostjuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "FioPolnostju", true));
            this.fioPolnostjuTextBox.Location = new System.Drawing.Point(270, 138);
            this.fioPolnostjuTextBox.Name = "fioPolnostjuTextBox";
            this.fioPolnostjuTextBox.Size = new System.Drawing.Size(200, 20);
            this.fioPolnostjuTextBox.TabIndex = 23;
            // 
            // innTextBox
            // 
            this.innTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Inn", true));
            this.innTextBox.Location = new System.Drawing.Point(270, 164);
            this.innTextBox.Name = "innTextBox";
            this.innTextBox.Size = new System.Drawing.Size(200, 20);
            this.innTextBox.TabIndex = 25;
            this.innTextBox.Enter += new System.EventHandler(this.innTextBox_Enter);
            this.innTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.innTextBox_KeyPress);
            // 
            // snilsTextBox
            // 
            this.snilsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Snils", true));
            this.snilsTextBox.Location = new System.Drawing.Point(270, 190);
            this.snilsTextBox.Name = "snilsTextBox";
            this.snilsTextBox.Size = new System.Drawing.Size(200, 20);
            this.snilsTextBox.TabIndex = 27;
            this.snilsTextBox.Enter += new System.EventHandler(this.snilsTextBox_Enter);
            this.snilsTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.snilsTextBox_KeyPress);
            // 
            // pasportNoTextBox
            // 
            this.pasportNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "PasportNo", true));
            this.pasportNoTextBox.Location = new System.Drawing.Point(270, 242);
            this.pasportNoTextBox.Name = "pasportNoTextBox";
            this.pasportNoTextBox.Size = new System.Drawing.Size(200, 20);
            this.pasportNoTextBox.TabIndex = 31;
            // 
            // dataVidachiPasportaDateTimePicker
            // 
            this.dataVidachiPasportaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataVidachiPasporta", true));
            this.dataVidachiPasportaDateTimePicker.Location = new System.Drawing.Point(270, 268);
            this.dataVidachiPasportaDateTimePicker.Name = "dataVidachiPasportaDateTimePicker";
            this.dataVidachiPasportaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataVidachiPasportaDateTimePicker.TabIndex = 33;
            // 
            // pasportVidanTextBox
            // 
            this.pasportVidanTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "PasportVidan", true));
            this.pasportVidanTextBox.Location = new System.Drawing.Point(270, 294);
            this.pasportVidanTextBox.Name = "pasportVidanTextBox";
            this.pasportVidanTextBox.Size = new System.Drawing.Size(200, 20);
            this.pasportVidanTextBox.TabIndex = 35;
            // 
            // adresPoPropiskeTextBox
            // 
            this.adresPoPropiskeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "AdresPoPropiske", true));
            this.adresPoPropiskeTextBox.Location = new System.Drawing.Point(270, 320);
            this.adresPoPropiskeTextBox.Name = "adresPoPropiskeTextBox";
            this.adresPoPropiskeTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresPoPropiskeTextBox.TabIndex = 37;
            // 
            // indexPoPropiskeTextBox
            // 
            this.indexPoPropiskeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "IndexPoPropiske", true));
            this.indexPoPropiskeTextBox.Location = new System.Drawing.Point(270, 346);
            this.indexPoPropiskeTextBox.Name = "indexPoPropiskeTextBox";
            this.indexPoPropiskeTextBox.Size = new System.Drawing.Size(200, 20);
            this.indexPoPropiskeTextBox.TabIndex = 39;
            // 
            // adresFakticheskiiTextBox
            // 
            this.adresFakticheskiiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "AdresFakticheskii", true));
            this.adresFakticheskiiTextBox.Location = new System.Drawing.Point(270, 372);
            this.adresFakticheskiiTextBox.Name = "adresFakticheskiiTextBox";
            this.adresFakticheskiiTextBox.Size = new System.Drawing.Size(200, 20);
            this.adresFakticheskiiTextBox.TabIndex = 41;
            // 
            // indexFakticheskiiTextBox
            // 
            this.indexFakticheskiiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "IndexFakticheskii", true));
            this.indexFakticheskiiTextBox.Location = new System.Drawing.Point(270, 398);
            this.indexFakticheskiiTextBox.Name = "indexFakticheskiiTextBox";
            this.indexFakticheskiiTextBox.Size = new System.Drawing.Size(200, 20);
            this.indexFakticheskiiTextBox.TabIndex = 43;
            // 
            // telefonTextBox
            // 
            this.telefonTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Telefon", true));
            this.telefonTextBox.Location = new System.Drawing.Point(270, 424);
            this.telefonTextBox.Name = "telefonTextBox";
            this.telefonTextBox.Size = new System.Drawing.Size(200, 20);
            this.telefonTextBox.TabIndex = 45;
            // 
            // dataRozhdenijaDateTimePicker
            // 
            this.dataRozhdenijaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataRozhdenija", true));
            this.dataRozhdenijaDateTimePicker.Location = new System.Drawing.Point(270, 450);
            this.dataRozhdenijaDateTimePicker.Name = "dataRozhdenijaDateTimePicker";
            this.dataRozhdenijaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataRozhdenijaDateTimePicker.TabIndex = 47;
            // 
            // mestoRozhdenijaTextBox
            // 
            this.mestoRozhdenijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "MestoRozhdenija", true));
            this.mestoRozhdenijaTextBox.Location = new System.Drawing.Point(270, 476);
            this.mestoRozhdenijaTextBox.Name = "mestoRozhdenijaTextBox";
            this.mestoRozhdenijaTextBox.Size = new System.Drawing.Size(200, 20);
            this.mestoRozhdenijaTextBox.TabIndex = 49;
            // 
            // mestoRozhdenijaKodTextBox
            // 
            this.mestoRozhdenijaKodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "MestoRozhdenijaKod", true));
            this.mestoRozhdenijaKodTextBox.Location = new System.Drawing.Point(270, 502);
            this.mestoRozhdenijaKodTextBox.Name = "mestoRozhdenijaKodTextBox";
            this.mestoRozhdenijaKodTextBox.Size = new System.Drawing.Size(200, 20);
            this.mestoRozhdenijaKodTextBox.TabIndex = 51;
            // 
            // grazhdanstvoKodTextBox
            // 
            this.grazhdanstvoKodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "GrazhdanstvoKod", true));
            this.grazhdanstvoKodTextBox.Location = new System.Drawing.Point(270, 554);
            this.grazhdanstvoKodTextBox.Name = "grazhdanstvoKodTextBox";
            this.grazhdanstvoKodTextBox.Size = new System.Drawing.Size(200, 20);
            this.grazhdanstvoKodTextBox.TabIndex = 55;
            // 
            // obrazovanijeKodTextBox
            // 
            this.obrazovanijeKodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ObrazovanijeKod", true));
            this.obrazovanijeKodTextBox.Location = new System.Drawing.Point(270, 606);
            this.obrazovanijeKodTextBox.Name = "obrazovanijeKodTextBox";
            this.obrazovanijeKodTextBox.Size = new System.Drawing.Size(200, 20);
            this.obrazovanijeKodTextBox.TabIndex = 59;
            // 
            // professijaKodTextBox
            // 
            this.professijaKodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ProfessijaKod", true));
            this.professijaKodTextBox.Location = new System.Drawing.Point(778, 84);
            this.professijaKodTextBox.Name = "professijaKodTextBox";
            this.professijaKodTextBox.Size = new System.Drawing.Size(200, 20);
            this.professijaKodTextBox.TabIndex = 65;
            // 
            // professijaDrugajaKodTextBox
            // 
            this.professijaDrugajaKodTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "ProfessijaDrugajaKod", true));
            this.professijaDrugajaKodTextBox.Location = new System.Drawing.Point(778, 136);
            this.professijaDrugajaKodTextBox.Name = "professijaDrugajaKodTextBox";
            this.professijaDrugajaKodTextBox.Size = new System.Drawing.Size(200, 20);
            this.professijaDrugajaKodTextBox.TabIndex = 69;
            // 
            // dataNachalaRabotiDateTimePicker
            // 
            this.dataNachalaRabotiDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataNachalaRaboti", true));
            this.dataNachalaRabotiDateTimePicker.Location = new System.Drawing.Point(778, 162);
            this.dataNachalaRabotiDateTimePicker.Name = "dataNachalaRabotiDateTimePicker";
            this.dataNachalaRabotiDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataNachalaRabotiDateTimePicker.TabIndex = 71;
            this.dataNachalaRabotiDateTimePicker.Enter += new System.EventHandler(this.dataNachalaRabotiDateTimePicker_Enter);
            // 
            // okladCiframiTextBox
            // 
            this.okladCiframiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "OkladCiframi", true));
            this.okladCiframiTextBox.Location = new System.Drawing.Point(778, 217);
            this.okladCiframiTextBox.Name = "okladCiframiTextBox";
            this.okladCiframiTextBox.Size = new System.Drawing.Size(200, 20);
            this.okladCiframiTextBox.TabIndex = 77;
            this.okladCiframiTextBox.Enter += new System.EventHandler(this.okladCiframiTextBox_Enter);
            this.okladCiframiTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.okladCiframiTextBox_KeyPress);
            // 
            // okladPropisjuTextBox
            // 
            this.okladPropisjuTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "OkladPropisju", true));
            this.okladPropisjuTextBox.Location = new System.Drawing.Point(778, 243);
            this.okladPropisjuTextBox.Name = "okladPropisjuTextBox";
            this.okladPropisjuTextBox.Size = new System.Drawing.Size(200, 20);
            this.okladPropisjuTextBox.TabIndex = 79;
            // 
            // nomerTDTextBox
            // 
            this.nomerTDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "NomerTD", true));
            this.nomerTDTextBox.Location = new System.Drawing.Point(778, 269);
            this.nomerTDTextBox.Name = "nomerTDTextBox";
            this.nomerTDTextBox.Size = new System.Drawing.Size(200, 20);
            this.nomerTDTextBox.TabIndex = 81;
            this.nomerTDTextBox.Enter += new System.EventHandler(this.nomerTDTextBox_Enter);
            // 
            // dataTDDateTimePicker
            // 
            this.dataTDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataTD", true));
            this.dataTDDateTimePicker.Location = new System.Drawing.Point(778, 295);
            this.dataTDDateTimePicker.Name = "dataTDDateTimePicker";
            this.dataTDDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataTDDateTimePicker.TabIndex = 83;
            this.dataTDDateTimePicker.Enter += new System.EventHandler(this.dataTDDateTimePicker_Enter);
            // 
            // dataPrikazaOPriemeDateTimePicker
            // 
            this.dataPrikazaOPriemeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "DataPrikazaOPrieme", true));
            this.dataPrikazaOPriemeDateTimePicker.Location = new System.Drawing.Point(778, 347);
            this.dataPrikazaOPriemeDateTimePicker.Name = "dataPrikazaOPriemeDateTimePicker";
            this.dataPrikazaOPriemeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataPrikazaOPriemeDateTimePicker.TabIndex = 85;
            this.dataPrikazaOPriemeDateTimePicker.Enter += new System.EventHandler(this.dataPrikazaOPriemeDateTimePicker_Enter);
            // 
            // okonchanijeTDDateTimePicker
            // 
            this.okonchanijeTDDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.personalBindingSource, "OkonchanijeTD", true));
            this.okonchanijeTDDateTimePicker.Location = new System.Drawing.Point(778, 373);
            this.okonchanijeTDDateTimePicker.Name = "okonchanijeTDDateTimePicker";
            this.okonchanijeTDDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.okonchanijeTDDateTimePicker.TabIndex = 87;
            this.okonchanijeTDDateTimePicker.Enter += new System.EventHandler(this.okonchanijeTDDateTimePicker_Enter);
            // 
            // ispitSrokTextBox
            // 
            this.ispitSrokTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "IspitSrok", true));
            this.ispitSrokTextBox.Location = new System.Drawing.Point(778, 399);
            this.ispitSrokTextBox.Name = "ispitSrokTextBox";
            this.ispitSrokTextBox.Size = new System.Drawing.Size(200, 20);
            this.ispitSrokTextBox.TabIndex = 89;
            this.ispitSrokTextBox.Enter += new System.EventHandler(this.ispitSrokTextBox_Enter);
            // 
            // primechanijaTextBox
            // 
            this.primechanijaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "Primechanija", true));
            this.primechanijaTextBox.Location = new System.Drawing.Point(778, 425);
            this.primechanijaTextBox.Name = "primechanijaTextBox";
            this.primechanijaTextBox.Size = new System.Drawing.Size(200, 20);
            this.primechanijaTextBox.TabIndex = 95;
            // 
            // nalichieAnketiCheckBox
            // 
            this.nalichieAnketiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieAnketi", true));
            this.nalichieAnketiCheckBox.Location = new System.Drawing.Point(35, 63);
            this.nalichieAnketiCheckBox.Name = "nalichieAnketiCheckBox";
            this.nalichieAnketiCheckBox.Size = new System.Drawing.Size(131, 24);
            this.nalichieAnketiCheckBox.TabIndex = 135;
            this.nalichieAnketiCheckBox.Text = "Анкета";
            this.nalichieAnketiCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieLichnKartochkiCheckBox
            // 
            this.nalichieLichnKartochkiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieLichnKartochki", true));
            this.nalichieLichnKartochkiCheckBox.Location = new System.Drawing.Point(35, 93);
            this.nalichieLichnKartochkiCheckBox.Name = "nalichieLichnKartochkiCheckBox";
            this.nalichieLichnKartochkiCheckBox.Size = new System.Drawing.Size(162, 24);
            this.nalichieLichnKartochkiCheckBox.TabIndex = 137;
            this.nalichieLichnKartochkiCheckBox.Text = "Личная карточка";
            this.nalichieLichnKartochkiCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieFotoCheckBox
            // 
            this.nalichieFotoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieFoto", true));
            this.nalichieFotoCheckBox.Location = new System.Drawing.Point(35, 123);
            this.nalichieFotoCheckBox.Name = "nalichieFotoCheckBox";
            this.nalichieFotoCheckBox.Size = new System.Drawing.Size(101, 24);
            this.nalichieFotoCheckBox.TabIndex = 139;
            this.nalichieFotoCheckBox.Text = "Фотография 3x4";
            this.nalichieFotoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieKopiiPasportaCheckBox
            // 
            this.nalichieKopiiPasportaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieKopiiPasporta", true));
            this.nalichieKopiiPasportaCheckBox.Location = new System.Drawing.Point(35, 153);
            this.nalichieKopiiPasportaCheckBox.Name = "nalichieKopiiPasportaCheckBox";
            this.nalichieKopiiPasportaCheckBox.Size = new System.Drawing.Size(150, 24);
            this.nalichieKopiiPasportaCheckBox.TabIndex = 141;
            this.nalichieKopiiPasportaCheckBox.Text = "Копия паспорта (2 стр.)";
            this.nalichieKopiiPasportaCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePrikazaOPriemeCheckBox
            // 
            this.nalichiePrikazaOPriemeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePrikazaOPrieme", true));
            this.nalichiePrikazaOPriemeCheckBox.Location = new System.Drawing.Point(35, 183);
            this.nalichiePrikazaOPriemeCheckBox.Name = "nalichiePrikazaOPriemeCheckBox";
            this.nalichiePrikazaOPriemeCheckBox.Size = new System.Drawing.Size(153, 24);
            this.nalichiePrikazaOPriemeCheckBox.TabIndex = 143;
            this.nalichiePrikazaOPriemeCheckBox.Text = "Приказ о приеме";
            this.nalichiePrikazaOPriemeCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieTrudovogoDogovoraCheckBox
            // 
            this.nalichieTrudovogoDogovoraCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieTrudovogoDogovora", true));
            this.nalichieTrudovogoDogovoraCheckBox.Location = new System.Drawing.Point(35, 213);
            this.nalichieTrudovogoDogovoraCheckBox.Name = "nalichieTrudovogoDogovoraCheckBox";
            this.nalichieTrudovogoDogovoraCheckBox.Size = new System.Drawing.Size(144, 24);
            this.nalichieTrudovogoDogovoraCheckBox.TabIndex = 145;
            this.nalichieTrudovogoDogovoraCheckBox.Text = "Трудовой договор";
            this.nalichieTrudovogoDogovoraCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieZajavlenijaNaRabotuCheckBox
            // 
            this.nalichieZajavlenijaNaRabotuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieZajavlenijaNaRabotu", true));
            this.nalichieZajavlenijaNaRabotuCheckBox.Location = new System.Drawing.Point(35, 243);
            this.nalichieZajavlenijaNaRabotuCheckBox.Name = "nalichieZajavlenijaNaRabotuCheckBox";
            this.nalichieZajavlenijaNaRabotuCheckBox.Size = new System.Drawing.Size(144, 24);
            this.nalichieZajavlenijaNaRabotuCheckBox.TabIndex = 147;
            this.nalichieZajavlenijaNaRabotuCheckBox.Text = "Заявление на работу";
            this.nalichieZajavlenijaNaRabotuCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieDogOMatOtvetstvennostiCheckBox
            // 
            this.nalichieDogOMatOtvetstvennostiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieDogOMatOtvetstvennosti", true));
            this.nalichieDogOMatOtvetstvennostiCheckBox.Location = new System.Drawing.Point(35, 273);
            this.nalichieDogOMatOtvetstvennostiCheckBox.Name = "nalichieDogOMatOtvetstvennostiCheckBox";
            this.nalichieDogOMatOtvetstvennostiCheckBox.Size = new System.Drawing.Size(144, 24);
            this.nalichieDogOMatOtvetstvennostiCheckBox.TabIndex = 149;
            this.nalichieDogOMatOtvetstvennostiCheckBox.Text = "Д-р о мат. отв-ти";
            this.nalichieDogOMatOtvetstvennostiCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieDolzhnInstrukciiCheckBox
            // 
            this.nalichieDolzhnInstrukciiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieDolzhnInstrukcii", true));
            this.nalichieDolzhnInstrukciiCheckBox.Location = new System.Drawing.Point(35, 303);
            this.nalichieDolzhnInstrukciiCheckBox.Name = "nalichieDolzhnInstrukciiCheckBox";
            this.nalichieDolzhnInstrukciiCheckBox.Size = new System.Drawing.Size(131, 24);
            this.nalichieDolzhnInstrukciiCheckBox.TabIndex = 151;
            this.nalichieDolzhnInstrukciiCheckBox.Text = "Должн. инструкция";
            this.nalichieDolzhnInstrukciiCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieSoglasijaNaNochCheckBox
            // 
            this.nalichieSoglasijaNaNochCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieSoglasijaNaNoch", true));
            this.nalichieSoglasijaNaNochCheckBox.Location = new System.Drawing.Point(35, 483);
            this.nalichieSoglasijaNaNochCheckBox.Name = "nalichieSoglasijaNaNochCheckBox";
            this.nalichieSoglasijaNaNochCheckBox.Size = new System.Drawing.Size(162, 24);
            this.nalichieSoglasijaNaNochCheckBox.TabIndex = 153;
            this.nalichieSoglasijaNaNochCheckBox.Text = "Согласие на работу ночью";
            this.nalichieSoglasijaNaNochCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieSoglasijaNaFotoCheckBox
            // 
            this.nalichieSoglasijaNaFotoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieSoglasijaNaFoto", true));
            this.nalichieSoglasijaNaFotoCheckBox.Location = new System.Drawing.Point(35, 513);
            this.nalichieSoglasijaNaFotoCheckBox.Name = "nalichieSoglasijaNaFotoCheckBox";
            this.nalichieSoglasijaNaFotoCheckBox.Size = new System.Drawing.Size(195, 24);
            this.nalichieSoglasijaNaFotoCheckBox.TabIndex = 155;
            this.nalichieSoglasijaNaFotoCheckBox.Text = "Соглас. на использ. фото";
            this.nalichieSoglasijaNaFotoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieTrudovojKnijkiCheckBox
            // 
            this.nalichieTrudovojKnijkiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieTrudovojKnijki", true));
            this.nalichieTrudovojKnijkiCheckBox.Location = new System.Drawing.Point(35, 333);
            this.nalichieTrudovojKnijkiCheckBox.Name = "nalichieTrudovojKnijkiCheckBox";
            this.nalichieTrudovojKnijkiCheckBox.Size = new System.Drawing.Size(144, 24);
            this.nalichieTrudovojKnijkiCheckBox.TabIndex = 157;
            this.nalichieTrudovojKnijkiCheckBox.Text = "Трудовая книжка";
            this.nalichieTrudovojKnijkiCheckBox.UseVisualStyleBackColor = true;
            this.nalichieTrudovojKnijkiCheckBox.MouseHover += new System.EventHandler(this.nalichieTrudovojKnijkiCheckBox_MouseHover);
            // 
            // nalichieZajavlNaVidachuTrudovojCheckBox
            // 
            this.nalichieZajavlNaVidachuTrudovojCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieZajavlNaVidachuTrudovoj", true));
            this.nalichieZajavlNaVidachuTrudovojCheckBox.Location = new System.Drawing.Point(35, 363);
            this.nalichieZajavlNaVidachuTrudovojCheckBox.Name = "nalichieZajavlNaVidachuTrudovojCheckBox";
            this.nalichieZajavlNaVidachuTrudovojCheckBox.Size = new System.Drawing.Size(231, 24);
            this.nalichieZajavlNaVidachuTrudovojCheckBox.TabIndex = 159;
            this.nalichieZajavlNaVidachuTrudovojCheckBox.Text = "Заявл. на выдачу труд. книжки";
            this.nalichieZajavlNaVidachuTrudovojCheckBox.UseVisualStyleBackColor = true;
            this.nalichieZajavlNaVidachuTrudovojCheckBox.MouseHover += new System.EventHandler(this.nalichieZajavlNaVidachuTrudovojCheckBox_MouseHover);
            // 
            // nalichieZajavlNaPolstavkiCheckBox
            // 
            this.nalichieZajavlNaPolstavkiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieZajavlNaPolstavki", true));
            this.nalichieZajavlNaPolstavkiCheckBox.Location = new System.Drawing.Point(35, 543);
            this.nalichieZajavlNaPolstavkiCheckBox.Name = "nalichieZajavlNaPolstavkiCheckBox";
            this.nalichieZajavlNaPolstavkiCheckBox.Size = new System.Drawing.Size(144, 24);
            this.nalichieZajavlNaPolstavkiCheckBox.TabIndex = 161;
            this.nalichieZajavlNaPolstavkiCheckBox.Text = "Заявл. на полставки";
            this.nalichieZajavlNaPolstavkiCheckBox.UseVisualStyleBackColor = true;
            this.nalichieZajavlNaPolstavkiCheckBox.MouseHover += new System.EventHandler(this.nalichieZajavlNaPolstavkiCheckBox_MouseHover);
            // 
            // nalichieKopiiInnCheckBox
            // 
            this.nalichieKopiiInnCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieKopiiInn", true));
            this.nalichieKopiiInnCheckBox.Location = new System.Drawing.Point(35, 393);
            this.nalichieKopiiInnCheckBox.Name = "nalichieKopiiInnCheckBox";
            this.nalichieKopiiInnCheckBox.Size = new System.Drawing.Size(101, 24);
            this.nalichieKopiiInnCheckBox.TabIndex = 163;
            this.nalichieKopiiInnCheckBox.Text = "Копия ИНН";
            this.nalichieKopiiInnCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieKopiiSnilsCheckBox
            // 
            this.nalichieKopiiSnilsCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieKopiiSnils", true));
            this.nalichieKopiiSnilsCheckBox.Location = new System.Drawing.Point(35, 423);
            this.nalichieKopiiSnilsCheckBox.Name = "nalichieKopiiSnilsCheckBox";
            this.nalichieKopiiSnilsCheckBox.Size = new System.Drawing.Size(101, 24);
            this.nalichieKopiiSnilsCheckBox.TabIndex = 165;
            this.nalichieKopiiSnilsCheckBox.Text = "Копия СНИЛС";
            this.nalichieKopiiSnilsCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichieSanKnizhkiCheckBox
            // 
            this.nalichieSanKnizhkiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichieSanKnizhki", true));
            this.nalichieSanKnizhkiCheckBox.Location = new System.Drawing.Point(35, 453);
            this.nalichieSanKnizhkiCheckBox.Name = "nalichieSanKnizhkiCheckBox";
            this.nalichieSanKnizhkiCheckBox.Size = new System.Drawing.Size(162, 24);
            this.nalichieSanKnizhkiCheckBox.TabIndex = 167;
            this.nalichieSanKnizhkiCheckBox.Text = "Санитарная книжка";
            this.nalichieSanKnizhkiCheckBox.UseVisualStyleBackColor = true;
            this.nalichieSanKnizhkiCheckBox.MouseHover += new System.EventHandler(this.nalichieSanKnizhkiCheckBox_MouseHover);
            // 
            // nalichiePodpisiNaAnketeCheckBox
            // 
            this.nalichiePodpisiNaAnketeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaAnkete", true));
            this.nalichiePodpisiNaAnketeCheckBox.Location = new System.Drawing.Point(768, 63);
            this.nalichiePodpisiNaAnketeCheckBox.Name = "nalichiePodpisiNaAnketeCheckBox";
            this.nalichiePodpisiNaAnketeCheckBox.Size = new System.Drawing.Size(117, 24);
            this.nalichiePodpisiNaAnketeCheckBox.TabIndex = 173;
            this.nalichiePodpisiNaAnketeCheckBox.Text = "На анкете";
            this.nalichiePodpisiNaAnketeCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaLichnKart2strCheckBox
            // 
            this.nalichiePodpisiNaLichnKart2strCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaLichnKart2str", true));
            this.nalichiePodpisiNaLichnKart2strCheckBox.Location = new System.Drawing.Point(768, 93);
            this.nalichiePodpisiNaLichnKart2strCheckBox.Name = "nalichiePodpisiNaLichnKart2strCheckBox";
            this.nalichiePodpisiNaLichnKart2strCheckBox.Size = new System.Drawing.Size(163, 24);
            this.nalichiePodpisiNaLichnKart2strCheckBox.TabIndex = 175;
            this.nalichiePodpisiNaLichnKart2strCheckBox.Text = "На 2-й стр. личн. карт.";
            this.nalichiePodpisiNaLichnKart2strCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaPrikazeOPriemeCheckBox
            // 
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaPrikazeOPrieme", true));
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox.Location = new System.Drawing.Point(768, 182);
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox.Name = "nalichiePodpisiNaPrikazeOPriemeCheckBox";
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox.Size = new System.Drawing.Size(156, 24);
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox.TabIndex = 177;
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox.Text = "На приказе о приеме";
            this.nalichiePodpisiNaPrikazeOPriemeCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaTrudovomDogovoreCheckBox
            // 
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaTrudovomDogovore", true));
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox.Location = new System.Drawing.Point(768, 212);
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox.Name = "nalichiePodpisiNaTrudovomDogovoreCheckBox";
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox.Size = new System.Drawing.Size(188, 24);
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox.TabIndex = 179;
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox.Text = "На трудовом договоре (2 шт.)";
            this.nalichiePodpisiNaTrudovomDogovoreCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaZajavleniiNaRabotuCheckBox
            // 
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaZajavleniiNaRabotu", true));
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox.Location = new System.Drawing.Point(768, 242);
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox.Name = "nalichiePodpisiNaZajavleniiNaRabotuCheckBox";
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox.Size = new System.Drawing.Size(156, 24);
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox.TabIndex = 181;
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox.Text = "На заявл. на работу";
            this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox
            // 
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaDogOMatOtvetstvennosti", true));
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox.Location = new System.Drawing.Point(768, 272);
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox.Name = "nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox";
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox.Size = new System.Drawing.Size(156, 24);
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox.TabIndex = 183;
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox.Text = "На д-ре о мат. отв-ти";
            this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaDolzhnInstrukciiCheckBox
            // 
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaDolzhnInstrukcii", true));
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox.Location = new System.Drawing.Point(768, 302);
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox.Name = "nalichiePodpisiNaDolzhnInstrukciiCheckBox";
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox.Size = new System.Drawing.Size(156, 24);
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox.TabIndex = 185;
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox.Text = "На должн. инстр-ии";
            this.nalichiePodpisiNaDolzhnInstrukciiCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaSoglasiiNaNochCheckBox
            // 
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaSoglasiiNaNoch", true));
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox.Location = new System.Drawing.Point(768, 481);
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox.Name = "nalichiePodpisiNaSoglasiiNaNochCheckBox";
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox.Size = new System.Drawing.Size(156, 24);
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox.TabIndex = 187;
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox.Text = "На согл. на работу ночью";
            this.nalichiePodpisiNaSoglasiiNaNochCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaSoglasiiNaFotoCheckBox
            // 
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaSoglasiiNaFoto", true));
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox.Location = new System.Drawing.Point(768, 512);
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox.Name = "nalichiePodpisiNaSoglasiiNaFotoCheckBox";
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox.Size = new System.Drawing.Size(156, 24);
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox.TabIndex = 189;
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox.Text = "На согл. на исп. фото";
            this.nalichiePodpisiNaSoglasiiNaFotoCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox
            // 
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaZajavlNaVidachuTrudovoj", true));
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox.Location = new System.Drawing.Point(768, 365);
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox.Name = "nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox";
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox.Size = new System.Drawing.Size(229, 24);
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox.TabIndex = 191;
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox.Text = "На заявл. на выдачу труд. книжки";
            this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaZajavlNaPolstavkiCheckBox
            // 
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaZajavlNaPolstavki", true));
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox.Location = new System.Drawing.Point(768, 541);
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox.Name = "nalichiePodpisiNaZajavlNaPolstavkiCheckBox";
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox.Size = new System.Drawing.Size(156, 24);
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox.TabIndex = 193;
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox.Text = "На звявл. на полставки";
            this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaPVTRCheckBox
            // 
            this.nalichiePodpisiNaPVTRCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaPVTR", true));
            this.nalichiePodpisiNaPVTRCheckBox.Location = new System.Drawing.Point(768, 572);
            this.nalichiePodpisiNaPVTRCheckBox.Name = "nalichiePodpisiNaPVTRCheckBox";
            this.nalichiePodpisiNaPVTRCheckBox.Size = new System.Drawing.Size(229, 24);
            this.nalichiePodpisiNaPVTRCheckBox.TabIndex = 195;
            this.nalichiePodpisiNaPVTRCheckBox.Text = "На правилах внутр.труд.расп";
            this.nalichiePodpisiNaPVTRCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaPravIspPersDannihCheckBox
            // 
            this.nalichiePodpisiNaPravIspPersDannihCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaPravIspPersDannih", true));
            this.nalichiePodpisiNaPravIspPersDannihCheckBox.Location = new System.Drawing.Point(768, 602);
            this.nalichiePodpisiNaPravIspPersDannihCheckBox.Name = "nalichiePodpisiNaPravIspPersDannihCheckBox";
            this.nalichiePodpisiNaPravIspPersDannihCheckBox.Size = new System.Drawing.Size(198, 24);
            this.nalichiePodpisiNaPravIspPersDannihCheckBox.TabIndex = 197;
            this.nalichiePodpisiNaPravIspPersDannihCheckBox.Text = "На правилах исп. перс.данных";
            this.nalichiePodpisiNaPravIspPersDannihCheckBox.UseVisualStyleBackColor = true;
            // 
            // nalichiePodpisiNaInstrPoOhrTrudaCheckBox
            // 
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.personalBindingSource, "NalichiePodpisiNaInstrPoOhrTruda", true));
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox.Location = new System.Drawing.Point(768, 632);
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox.Name = "nalichiePodpisiNaInstrPoOhrTrudaCheckBox";
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox.Size = new System.Drawing.Size(188, 24);
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox.TabIndex = 199;
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox.Text = "На инстр. по охр. труда";
            this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabNomerTextBox
            // 
            this.tabNomerTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "TabNomer", true));
            this.tabNomerTextBox.Location = new System.Drawing.Point(270, 58);
            this.tabNomerTextBox.Name = "tabNomerTextBox";
            this.tabNomerTextBox.Size = new System.Drawing.Size(200, 20);
            this.tabNomerTextBox.TabIndex = 209;
            this.tabNomerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tabNomerTextBox_KeyPress);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(257, 64);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(153, 23);
            this.button6.TabIndex = 219;
            this.button6.Text = "Анкета";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(257, 93);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(153, 23);
            this.button7.TabIndex = 220;
            this.button7.Text = "Личная карточка";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(507, 93);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(148, 23);
            this.button8.TabIndex = 221;
            this.button8.Text = "Личная карточка";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // formPanel
            // 
            this.formPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.formPanel.Controls.Add(this.comboBox8);
            this.formPanel.Controls.Add(this.comboBox7);
            this.formPanel.Controls.Add(this.comboBox5);
            this.formPanel.Controls.Add(this.comboBox4);
            this.formPanel.Controls.Add(this.comboBox3);
            this.formPanel.Controls.Add(this.comboBox2);
            this.formPanel.Controls.Add(this.comboBox6);
            this.formPanel.Controls.Add(this.comboBox1);
            this.formPanel.Controls.Add(this.textBox1);
            this.formPanel.Controls.Add(label7);
            this.formPanel.Controls.Add(this.button1);
            this.formPanel.Controls.Add(this.label6);
            this.formPanel.Controls.Add(this.label8);
            this.formPanel.Controls.Add(tabNomerLabel);
            this.formPanel.Controls.Add(this.tabNomerTextBox);
            this.formPanel.Controls.Add(this.label5);
            this.formPanel.Controls.Add(fioPolnostjuLabel);
            this.formPanel.Controls.Add(this.fioPolnostjuTextBox);
            this.formPanel.Controls.Add(innLabel);
            this.formPanel.Controls.Add(this.innTextBox);
            this.formPanel.Controls.Add(snilsLabel);
            this.formPanel.Controls.Add(this.snilsTextBox);
            this.formPanel.Controls.Add(polLabel);
            this.formPanel.Controls.Add(pasportNoLabel);
            this.formPanel.Controls.Add(this.pasportNoTextBox);
            this.formPanel.Controls.Add(dataVidachiPasportaLabel);
            this.formPanel.Controls.Add(this.dataVidachiPasportaDateTimePicker);
            this.formPanel.Controls.Add(pasportVidanLabel);
            this.formPanel.Controls.Add(this.pasportVidanTextBox);
            this.formPanel.Controls.Add(adresPoPropiskeLabel);
            this.formPanel.Controls.Add(this.adresPoPropiskeTextBox);
            this.formPanel.Controls.Add(indexPoPropiskeLabel);
            this.formPanel.Controls.Add(this.indexPoPropiskeTextBox);
            this.formPanel.Controls.Add(adresFakticheskiiLabel);
            this.formPanel.Controls.Add(this.adresFakticheskiiTextBox);
            this.formPanel.Controls.Add(indexFakticheskiiLabel);
            this.formPanel.Controls.Add(this.indexFakticheskiiTextBox);
            this.formPanel.Controls.Add(telefonLabel);
            this.formPanel.Controls.Add(this.telefonTextBox);
            this.formPanel.Controls.Add(dataRozhdenijaLabel);
            this.formPanel.Controls.Add(this.dataRozhdenijaDateTimePicker);
            this.formPanel.Controls.Add(mestoRozhdenijaLabel);
            this.formPanel.Controls.Add(this.primechanijaTextBox);
            this.formPanel.Controls.Add(this.mestoRozhdenijaTextBox);
            this.formPanel.Controls.Add(primechanijaLabel);
            this.formPanel.Controls.Add(mestoRozhdenijaKodLabel);
            this.formPanel.Controls.Add(this.mestoRozhdenijaKodTextBox);
            this.formPanel.Controls.Add(grazhdanstvoLabel);
            this.formPanel.Controls.Add(grazhdanstvoKodLabel);
            this.formPanel.Controls.Add(this.ispitSrokTextBox);
            this.formPanel.Controls.Add(this.grazhdanstvoKodTextBox);
            this.formPanel.Controls.Add(ispitSrokLabel);
            this.formPanel.Controls.Add(obrazovanijeLabel);
            this.formPanel.Controls.Add(this.okonchanijeTDDateTimePicker);
            this.formPanel.Controls.Add(okonchanijeTDLabel);
            this.formPanel.Controls.Add(obrazovanijeKodLabel);
            this.formPanel.Controls.Add(this.dataPrikazaOPriemeDateTimePicker);
            this.formPanel.Controls.Add(this.obrazovanijeKodTextBox);
            this.formPanel.Controls.Add(dataPrikazaOPriemeLabel);
            this.formPanel.Controls.Add(statusVOrganizatsiiLabel);
            this.formPanel.Controls.Add(this.dataTDDateTimePicker);
            this.formPanel.Controls.Add(dataTDLabel);
            this.formPanel.Controls.Add(professijaLabel);
            this.formPanel.Controls.Add(this.nomerTDTextBox);
            this.formPanel.Controls.Add(nomerTDLabel);
            this.formPanel.Controls.Add(professijaKodLabel);
            this.formPanel.Controls.Add(this.okladPropisjuTextBox);
            this.formPanel.Controls.Add(this.professijaKodTextBox);
            this.formPanel.Controls.Add(okladPropisjuLabel);
            this.formPanel.Controls.Add(professijaDrugajaLabel);
            this.formPanel.Controls.Add(this.okladCiframiTextBox);
            this.formPanel.Controls.Add(okladCiframiLabel);
            this.formPanel.Controls.Add(professijaDrugajaKodLabel);
            this.formPanel.Controls.Add(this.professijaDrugajaKodTextBox);
            this.formPanel.Controls.Add(vidRabotiLabel);
            this.formPanel.Controls.Add(dataNachalaRabotiLabel);
            this.formPanel.Controls.Add(this.dataNachalaRabotiDateTimePicker);
            this.formPanel.Controls.Add(kharakterRabotiLabel);
            this.formPanel.Location = new System.Drawing.Point(3, 701);
            this.formPanel.Name = "formPanel";
            this.formPanel.Size = new System.Drawing.Size(1011, 643);
            this.formPanel.TabIndex = 224;
            this.formPanel.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 247;
            this.button1.Text = "Список табельных номеров";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(26, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(159, 16);
            this.label6.TabIndex = 247;
            this.label6.Text = "Личная информация";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(534, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 16);
            this.label8.TabIndex = 245;
            this.label8.Text = "Информация о работе";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(25, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 20);
            this.label5.TabIndex = 244;
            this.label5.Text = "Заполнение данных";
            // 
            // formButton
            // 
            this.formButton.Location = new System.Drawing.Point(3, 672);
            this.formButton.Name = "formButton";
            this.formButton.Size = new System.Drawing.Size(1011, 23);
            this.formButton.TabIndex = 225;
            this.formButton.Text = "Показать/ скрыть форму заполнения данных";
            this.formButton.UseVisualStyleBackColor = true;
            this.formButton.Click += new System.EventHandler(this.formButton_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(257, 188);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(153, 23);
            this.button10.TabIndex = 226;
            this.button10.Text = "Приказ о приеме";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(257, 219);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(153, 23);
            this.button11.TabIndex = 227;
            this.button11.Text = "Трудовой договор";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(257, 249);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(153, 23);
            this.button12.TabIndex = 228;
            this.button12.Text = "Заявление на работу";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(257, 279);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(153, 23);
            this.button13.TabIndex = 229;
            this.button13.Text = "Д-р о мат. отв-ти";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(257, 308);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(153, 23);
            this.button14.TabIndex = 230;
            this.button14.Text = "Дожн. инструкция";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(507, 274);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(153, 23);
            this.button16.TabIndex = 234;
            this.button16.Text = "Д-р о мат. отв-ти";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(507, 244);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(153, 23);
            this.button17.TabIndex = 233;
            this.button17.Text = "Заявление на работу";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(507, 214);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(153, 23);
            this.button18.TabIndex = 232;
            this.button18.Text = "Трудовой договор";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(507, 183);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(153, 23);
            this.button19.TabIndex = 231;
            this.button19.Text = "Приказ о приеме";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(507, 304);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(153, 23);
            this.button15.TabIndex = 235;
            this.button15.Text = "Дожн. инструкция";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button20
            // 
            this.button20.Location = new System.Drawing.Point(507, 334);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(153, 23);
            this.button20.TabIndex = 236;
            this.button20.Text = "Трудовая книжка";
            this.button20.UseVisualStyleBackColor = true;
            // 
            // button21
            // 
            this.button21.Location = new System.Drawing.Point(257, 363);
            this.button21.Name = "button21";
            this.button21.Size = new System.Drawing.Size(153, 23);
            this.button21.TabIndex = 237;
            this.button21.Text = "Заявл. на выдачу труд. книжки";
            this.button21.UseVisualStyleBackColor = true;
            // 
            // button22
            // 
            this.button22.Location = new System.Drawing.Point(507, 363);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(153, 23);
            this.button22.TabIndex = 238;
            this.button22.Text = "Заявл. на выдачу труд. книжки";
            this.button22.UseVisualStyleBackColor = true;
            // 
            // button23
            // 
            this.button23.Location = new System.Drawing.Point(257, 489);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(153, 23);
            this.button23.TabIndex = 239;
            this.button23.Text = "Согл. на работу ночью";
            this.button23.UseVisualStyleBackColor = true;
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(257, 519);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(153, 23);
            this.button24.TabIndex = 240;
            this.button24.Text = "Согл. на использ. фото";
            this.button24.UseVisualStyleBackColor = true;
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(507, 484);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(153, 23);
            this.button25.TabIndex = 241;
            this.button25.Text = "Согл. на работу ночью";
            this.button25.UseVisualStyleBackColor = true;
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(507, 514);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(153, 23);
            this.button26.TabIndex = 242;
            this.button26.Text = "Согл. на использ. фото";
            this.button26.UseVisualStyleBackColor = true;
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(507, 542);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(153, 23);
            this.button27.TabIndex = 243;
            this.button27.Text = "Заявл. на полставки";
            this.button27.UseVisualStyleBackColor = true;
            // 
            // docPanel
            // 
            this.docPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.docPanel.Controls.Add(this.label2);
            this.docPanel.Controls.Add(label4);
            this.docPanel.Controls.Add(this.button27);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaInstrPoOhrTrudaCheckBox);
            this.docPanel.Controls.Add(this.button26);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaPravIspPersDannihCheckBox);
            this.docPanel.Controls.Add(this.button25);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaPVTRCheckBox);
            this.docPanel.Controls.Add(this.button24);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaZajavlNaPolstavkiCheckBox);
            this.docPanel.Controls.Add(this.button23);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox);
            this.docPanel.Controls.Add(this.button22);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaSoglasiiNaFotoCheckBox);
            this.docPanel.Controls.Add(this.button21);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaSoglasiiNaNochCheckBox);
            this.docPanel.Controls.Add(this.button20);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaDolzhnInstrukciiCheckBox);
            this.docPanel.Controls.Add(this.button15);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox);
            this.docPanel.Controls.Add(this.button16);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaZajavleniiNaRabotuCheckBox);
            this.docPanel.Controls.Add(this.button17);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaTrudovomDogovoreCheckBox);
            this.docPanel.Controls.Add(this.button18);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaPrikazeOPriemeCheckBox);
            this.docPanel.Controls.Add(this.button19);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaLichnKart2strCheckBox);
            this.docPanel.Controls.Add(this.nalichiePodpisiNaAnketeCheckBox);
            this.docPanel.Controls.Add(this.button14);
            this.docPanel.Controls.Add(this.nalichieSanKnizhkiCheckBox);
            this.docPanel.Controls.Add(this.nalichieKopiiSnilsCheckBox);
            this.docPanel.Controls.Add(this.button13);
            this.docPanel.Controls.Add(this.nalichieKopiiInnCheckBox);
            this.docPanel.Controls.Add(this.button12);
            this.docPanel.Controls.Add(this.nalichieZajavlNaPolstavkiCheckBox);
            this.docPanel.Controls.Add(this.button11);
            this.docPanel.Controls.Add(this.nalichieZajavlNaVidachuTrudovojCheckBox);
            this.docPanel.Controls.Add(this.button10);
            this.docPanel.Controls.Add(this.nalichieTrudovojKnijkiCheckBox);
            this.docPanel.Controls.Add(this.nalichieSoglasijaNaFotoCheckBox);
            this.docPanel.Controls.Add(this.nalichieSoglasijaNaNochCheckBox);
            this.docPanel.Controls.Add(this.button8);
            this.docPanel.Controls.Add(this.nalichieDolzhnInstrukciiCheckBox);
            this.docPanel.Controls.Add(this.button7);
            this.docPanel.Controls.Add(this.nalichieDogOMatOtvetstvennostiCheckBox);
            this.docPanel.Controls.Add(this.button6);
            this.docPanel.Controls.Add(this.nalichieZajavlenijaNaRabotuCheckBox);
            this.docPanel.Controls.Add(this.nalichieTrudovogoDogovoraCheckBox);
            this.docPanel.Controls.Add(label3);
            this.docPanel.Controls.Add(this.nalichiePrikazaOPriemeCheckBox);
            this.docPanel.Controls.Add(this.nalichieKopiiPasportaCheckBox);
            this.docPanel.Controls.Add(label1);
            this.docPanel.Controls.Add(this.nalichieFotoCheckBox);
            this.docPanel.Controls.Add(this.nalichieAnketiCheckBox);
            this.docPanel.Controls.Add(this.nalichieLichnKartochkiCheckBox);
            this.docPanel.Location = new System.Drawing.Point(3, 3);
            this.docPanel.Name = "docPanel";
            this.docPanel.Size = new System.Drawing.Size(1011, 663);
            this.docPanel.TabIndex = 244;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(244, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(179, 16);
            this.label2.TabIndex = 245;
            this.label2.Text = "Распечатать документ";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.docPanel);
            this.flowLayoutPanel1.Controls.Add(this.formButton);
            this.flowLayoutPanel1.Controls.Add(this.formPanel);
            this.flowLayoutPanel1.Controls.Add(this.toDocFormButton);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1014, 1390);
            this.flowLayoutPanel1.TabIndex = 246;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(534, 324);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(136, 13);
            label7.TabIndex = 248;
            label7.Text = "Номер приказа о приеме";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.IndianRed;
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personalBindingSource, "NomerTD", true));
            this.textBox1.ForeColor = System.Drawing.Color.Black;
            this.textBox1.Location = new System.Drawing.Point(778, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 20);
            this.textBox1.TabIndex = 249;
            // 
            // toDocFormButton
            // 
            this.toDocFormButton.Location = new System.Drawing.Point(3, 1350);
            this.toDocFormButton.Name = "toDocFormButton";
            this.toDocFormButton.Size = new System.Drawing.Size(1011, 23);
            this.toDocFormButton.TabIndex = 245;
            this.toDocFormButton.Text = "Перейти к форме для заполнения документов";
            this.toDocFormButton.UseVisualStyleBackColor = true;
            this.toDocFormButton.Click += new System.EventHandler(this.toDocFormButton_Click);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.AutoSize = false;
            this.bindingNavigatorAddNewItem.BackgroundImage = global::WindowsForms_Diploma_NevskiiProekt.Properties.Resources.newCrossGreen;
            this.bindingNavigatorAddNewItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(27, 27);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.AutoSize = false;
            this.bindingNavigatorDeleteItem.BackgroundImage = global::WindowsForms_Diploma_NevskiiProekt.Properties.Resources.newCrossRed;
            this.bindingNavigatorDeleteItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(27, 27);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.AutoSize = false;
            this.bindingNavigatorMoveFirstItem.BackgroundImage = global::WindowsForms_Diploma_NevskiiProekt.Properties.Resources._1234;
            this.bindingNavigatorMoveFirstItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(27, 27);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.AutoSize = false;
            this.bindingNavigatorMovePreviousItem.BackgroundImage = global::WindowsForms_Diploma_NevskiiProekt.Properties.Resources.play2;
            this.bindingNavigatorMovePreviousItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(27, 27);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.AutoSize = false;
            this.bindingNavigatorMoveNextItem.BackgroundImage = global::WindowsForms_Diploma_NevskiiProekt.Properties.Resources.play;
            this.bindingNavigatorMoveNextItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(27, 27);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.AutoSize = false;
            this.bindingNavigatorMoveLastItem.BackgroundImage = global::WindowsForms_Diploma_NevskiiProekt.Properties.Resources._123;
            this.bindingNavigatorMoveLastItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(27, 27);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // personalBindingNavigatorSaveItem
            // 
            this.personalBindingNavigatorSaveItem.AutoSize = false;
            this.personalBindingNavigatorSaveItem.BackgroundImage = global::WindowsForms_Diploma_NevskiiProekt.Properties.Resources.newSave;
            this.personalBindingNavigatorSaveItem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.personalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.personalBindingNavigatorSaveItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("personalBindingNavigatorSaveItem.Image")));
            this.personalBindingNavigatorSaveItem.ImageTransparentColor = System.Drawing.Color.Transparent;
            this.personalBindingNavigatorSaveItem.Name = "personalBindingNavigatorSaveItem";
            this.personalBindingNavigatorSaveItem.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.personalBindingNavigatorSaveItem.Size = new System.Drawing.Size(27, 27);
            this.personalBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.personalBindingNavigatorSaveItem.Click += new System.EventHandler(this.personalBindingNavigatorSaveItem_Click);
            // 
            // toolStripMainButton
            // 
            this.toolStripMainButton.AutoSize = false;
            this.toolStripMainButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.toolStripMainButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMainButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toolStripMainButton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMainButton.Image")));
            this.toolStripMainButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripMainButton.Name = "toolStripMainButton";
            this.toolStripMainButton.Size = new System.Drawing.Size(197, 27);
            this.toolStripMainButton.Text = "Главное меню";
            this.toolStripMainButton.Click += new System.EventHandler(this.toolStripMainButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.kindOfWorkBindingSource;
            this.comboBox1.DisplayMember = "VidRaboti";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(270, 31);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 250;
            // 
            // kindOfWorkBindingSource
            // 
            this.kindOfWorkBindingSource.DataMember = "KindOfWork";
            this.kindOfWorkBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // kindOfWorkTableAdapter
            // 
            this.kindOfWorkTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox6
            // 
            this.comboBox6.DataSource = this.sexBindingSource;
            this.comboBox6.DisplayMember = "Sex";
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(270, 216);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(200, 21);
            this.comboBox6.TabIndex = 250;
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataMember = "Sex";
            this.sexBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // sexTableAdapter
            // 
            this.sexTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.kodiOkinGrazhdanstvoBindingSource;
            this.comboBox2.DisplayMember = "VidiGrazhdanstva";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(270, 528);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 251;
            // 
            // comboBox3
            // 
            this.comboBox3.DataSource = this.kodiOkinObrazovanijeBindingSource;
            this.comboBox3.DisplayMember = "UrovenObrazovanija";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(270, 579);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 252;
            // 
            // kodiOkinObrazovanijeBindingSource
            // 
            this.kodiOkinObrazovanijeBindingSource.DataMember = "KodiOkinObrazovanije";
            this.kodiOkinObrazovanijeBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // kodiOkinObrazovanijeTableAdapter
            // 
            this.kodiOkinObrazovanijeTableAdapter.ClearBeforeFill = true;
            // 
            // kodiOkinGrazhdanstvoBindingSource
            // 
            this.kodiOkinGrazhdanstvoBindingSource.DataMember = "KodiOkinGrazhdanstvo";
            this.kodiOkinGrazhdanstvoBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // kodiOkinGrazhdanstvoTableAdapter
            // 
            this.kodiOkinGrazhdanstvoTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox4
            // 
            this.comboBox4.DataSource = this.statusInOrganizationBindingSource;
            this.comboBox4.DisplayMember = "StatusVOrganizatsii";
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(778, 32);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(200, 21);
            this.comboBox4.TabIndex = 253;
            // 
            // statusInOrganizationBindingSource
            // 
            this.statusInOrganizationBindingSource.DataMember = "StatusInOrganization";
            this.statusInOrganizationBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // statusInOrganizationTableAdapter
            // 
            this.statusInOrganizationTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox5
            // 
            this.comboBox5.DataSource = this.personalBindingSource1;
            this.comboBox5.DisplayMember = "Professija";
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(778, 58);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(200, 21);
            this.comboBox5.TabIndex = 254;
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataMember = "Languages";
            this.languagesBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // languagesTableAdapter
            // 
            this.languagesTableAdapter.ClearBeforeFill = true;
            // 
            // manningTableBindingSource
            // 
            this.manningTableBindingSource.DataMember = "ManningTable";
            this.manningTableBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // manningTableTableAdapter
            // 
            this.manningTableTableAdapter.ClearBeforeFill = true;
            // 
            // personalBindingSource1
            // 
            this.personalBindingSource1.DataMember = "Personal";
            this.personalBindingSource1.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // comboBox7
            // 
            this.comboBox7.DataSource = this.personalBindingSource1;
            this.comboBox7.DisplayMember = "Professija";
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(778, 110);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(200, 21);
            this.comboBox7.TabIndex = 255;
            // 
            // comboBox8
            // 
            this.comboBox8.DataSource = this.characterOfWorkBindingSource;
            this.comboBox8.DisplayMember = "KharakterRaboti";
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(778, 188);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(200, 21);
            this.comboBox8.TabIndex = 256;
            // 
            // characterOfWorkBindingSource
            // 
            this.characterOfWorkBindingSource.DataMember = "CharacterOfWork";
            this.characterOfWorkBindingSource.DataSource = this.diploma_NevskiiProectDataSet;
            // 
            // characterOfWorkTableAdapter
            // 
            this.characterOfWorkTableAdapter.ClearBeforeFill = true;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1032, 761);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.personalBindingNavigator);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Прием на работу";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AddForm_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddForm_FormClosed);
            this.Load += new System.EventHandler(this.AddForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.diploma_NevskiiProectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingNavigator)).EndInit();
            this.personalBindingNavigator.ResumeLayout(false);
            this.personalBindingNavigator.PerformLayout();
            this.formPanel.ResumeLayout(false);
            this.formPanel.PerformLayout();
            this.docPanel.ResumeLayout(false);
            this.docPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kindOfWorkBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodiOkinObrazovanijeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kodiOkinGrazhdanstvoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusInOrganizationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manningTableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personalBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.characterOfWorkBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Diploma_NevskiiProectDataSet diploma_NevskiiProectDataSet;
        private System.Windows.Forms.BindingSource personalBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.PersonalTableAdapter personalTableAdapter;
        private Diploma_NevskiiProectDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator personalBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton personalBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox fioPolnostjuTextBox;
        private System.Windows.Forms.TextBox innTextBox;
        private System.Windows.Forms.TextBox snilsTextBox;
        private System.Windows.Forms.TextBox pasportNoTextBox;
        private System.Windows.Forms.DateTimePicker dataVidachiPasportaDateTimePicker;
        private System.Windows.Forms.TextBox pasportVidanTextBox;
        private System.Windows.Forms.TextBox adresPoPropiskeTextBox;
        private System.Windows.Forms.TextBox indexPoPropiskeTextBox;
        private System.Windows.Forms.TextBox adresFakticheskiiTextBox;
        private System.Windows.Forms.TextBox indexFakticheskiiTextBox;
        private System.Windows.Forms.TextBox telefonTextBox;
        private System.Windows.Forms.DateTimePicker dataRozhdenijaDateTimePicker;
        private System.Windows.Forms.TextBox mestoRozhdenijaTextBox;
        private System.Windows.Forms.TextBox mestoRozhdenijaKodTextBox;
        private System.Windows.Forms.TextBox grazhdanstvoKodTextBox;
        private System.Windows.Forms.TextBox obrazovanijeKodTextBox;
        private System.Windows.Forms.TextBox professijaKodTextBox;
        private System.Windows.Forms.TextBox professijaDrugajaKodTextBox;
        private System.Windows.Forms.DateTimePicker dataNachalaRabotiDateTimePicker;
        private System.Windows.Forms.TextBox okladCiframiTextBox;
        private System.Windows.Forms.TextBox okladPropisjuTextBox;
        private System.Windows.Forms.TextBox nomerTDTextBox;
        private System.Windows.Forms.DateTimePicker dataTDDateTimePicker;
        private System.Windows.Forms.DateTimePicker dataPrikazaOPriemeDateTimePicker;
        private System.Windows.Forms.DateTimePicker okonchanijeTDDateTimePicker;
        private System.Windows.Forms.TextBox ispitSrokTextBox;
        private System.Windows.Forms.TextBox primechanijaTextBox;
        private System.Windows.Forms.CheckBox nalichieAnketiCheckBox;
        private System.Windows.Forms.CheckBox nalichieLichnKartochkiCheckBox;
        private System.Windows.Forms.CheckBox nalichieFotoCheckBox;
        private System.Windows.Forms.CheckBox nalichieKopiiPasportaCheckBox;
        private System.Windows.Forms.CheckBox nalichiePrikazaOPriemeCheckBox;
        private System.Windows.Forms.CheckBox nalichieTrudovogoDogovoraCheckBox;
        private System.Windows.Forms.CheckBox nalichieZajavlenijaNaRabotuCheckBox;
        private System.Windows.Forms.CheckBox nalichieDogOMatOtvetstvennostiCheckBox;
        private System.Windows.Forms.CheckBox nalichieDolzhnInstrukciiCheckBox;
        private System.Windows.Forms.CheckBox nalichieSoglasijaNaNochCheckBox;
        private System.Windows.Forms.CheckBox nalichieSoglasijaNaFotoCheckBox;
        private System.Windows.Forms.CheckBox nalichieTrudovojKnijkiCheckBox;
        private System.Windows.Forms.CheckBox nalichieZajavlNaVidachuTrudovojCheckBox;
        private System.Windows.Forms.CheckBox nalichieZajavlNaPolstavkiCheckBox;
        private System.Windows.Forms.CheckBox nalichieKopiiInnCheckBox;
        private System.Windows.Forms.CheckBox nalichieKopiiSnilsCheckBox;
        private System.Windows.Forms.CheckBox nalichieSanKnizhkiCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaAnketeCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaLichnKart2strCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaPrikazeOPriemeCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaTrudovomDogovoreCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaZajavleniiNaRabotuCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaDogOMatOtvetstvennostiCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaDolzhnInstrukciiCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaSoglasiiNaNochCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaSoglasiiNaFotoCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaZajavlNaVidachuTrudovojCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaZajavlNaPolstavkiCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaPVTRCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaPravIspPersDannihCheckBox;
        private System.Windows.Forms.CheckBox nalichiePodpisiNaInstrPoOhrTrudaCheckBox;
        private System.Windows.Forms.TextBox tabNomerTextBox;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Panel formPanel;
        private System.Windows.Forms.Button formButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button21;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Panel docPanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripButton toolStripMainButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button toDocFormButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource kindOfWorkBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.KindOfWorkTableAdapter kindOfWorkTableAdapter;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.BindingSource sexBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.SexTableAdapter sexTableAdapter;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource kodiOkinObrazovanijeBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.KodiOkinObrazovanijeTableAdapter kodiOkinObrazovanijeTableAdapter;
        private System.Windows.Forms.BindingSource kodiOkinGrazhdanstvoBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.KodiOkinGrazhdanstvoTableAdapter kodiOkinGrazhdanstvoTableAdapter;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.BindingSource statusInOrganizationBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.StatusInOrganizationTableAdapter statusInOrganizationTableAdapter;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.BindingSource languagesBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.LanguagesTableAdapter languagesTableAdapter;
        private System.Windows.Forms.BindingSource manningTableBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.ManningTableTableAdapter manningTableTableAdapter;
        private System.Windows.Forms.ComboBox comboBox8;
        private System.Windows.Forms.BindingSource personalBindingSource1;
        private System.Windows.Forms.ComboBox comboBox7;
        private System.Windows.Forms.BindingSource characterOfWorkBindingSource;
        private Diploma_NevskiiProectDataSetTableAdapters.CharacterOfWorkTableAdapter characterOfWorkTableAdapter;
    }
}