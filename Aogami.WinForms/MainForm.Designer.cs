namespace Aogami.WinForms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            OpenSaveFileButton = new Button();
            LogoPictureBox = new PictureBox();
            SaveChangesButton = new Button();
            SaveDataTabControl = new TabControl();
            GeneralStatsTabPage = new TabPage();
            DifficultyComboBox = new ComboBox();
            DifficultyLabel = new Label();
            DateSavedDateTimePicker = new DateTimePicker();
            DateSavedLabel = new Label();
            MinutesLabel = new Label();
            PlayTimeMinutesNumUpDown = new NumericUpDown();
            HoursLabel = new Label();
            PlayTimeHoursNumUpDown = new NumericUpDown();
            PlayTimeLabel = new Label();
            GloryNumUpDown = new NumericUpDown();
            GloryLabel = new Label();
            MaccaNumUpDown = new NumericUpDown();
            MaccaLabel = new Label();
            LastNameTextBox = new TextBox();
            FirstNameTextBox = new TextBox();
            LastNameLabel = new Label();
            FirstNameLabel = new Label();
            DebugTestsButton = new Button();
            ItemsTabPage = new TabPage();
            ItemsShowUnusedCheckBox = new CheckBox();
            ItemsSetAllTo99Button = new Button();
            ItemsSetAllTo255Button = new Button();
            ItemListDataGridView = new DataGridView();
            ItemIndexColumn = new DataGridViewTextBoxColumn();
            ItemNameColumn = new DataGridViewTextBoxColumn();
            ItemTypeColumn = new DataGridViewTextBoxColumn();
            ItemAmountColumn = new DataGridViewTextBoxColumn();
            DemonsTabPage = new TabPage();
            DemonClearButton = new Button();
            DemonTypeComboBox = new ComboBox();
            EditSkillsButton = new Button();
            DemonStockListView = new ListView();
            DemonNameColumn = new ColumnHeader();
            DemonNoColumn = new ColumnHeader();
            SetDemonToMaxButton = new Button();
            LuckNumUpDown = new NumericUpDown();
            LuckLabel = new Label();
            AgilityNumUpDown = new NumericUpDown();
            AgilityLabel = new Label();
            MagicNumUpDown = new NumericUpDown();
            MagicLabel = new Label();
            VitalityNumUpDown = new NumericUpDown();
            VitalityLabel = new Label();
            StrengthNumUpDown = new NumericUpDown();
            StrengthLabel = new Label();
            DemonMpNumericUpDown = new NumericUpDown();
            DemonMpLabel = new Label();
            DemonHpNumericUpDown = new NumericUpDown();
            DemonHpLabel = new Label();
            DemonExperienceNumUpDown = new NumericUpDown();
            DemonLevelNumUpDown = new NumericUpDown();
            DemonExperienceLabel = new Label();
            DemonLevelLabel = new Label();
            MiraclesTabPage = new TabPage();
            SetMiraclesLearnedButton = new Button();
            SetMiraclesNotLearnedButton = new Button();
            MiracleListDataGridView = new DataGridView();
            MiracleIndexTextBoxColumn = new DataGridViewTextBoxColumn();
            MiracleNameTextBoxColumn = new DataGridViewTextBoxColumn();
            MiracleValueTextBoxColumn = new DataGridViewTextBoxColumn();
            SaveDataGroupBox = new GroupBox();
            MakeBackUpCheckbox = new CheckBox();
            ImportDecryptedDataButton = new Button();
            ExportDecryptedDataButton = new Button();
            DemonImageList = new ImageList(components);
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).BeginInit();
            SaveDataTabControl.SuspendLayout();
            GeneralStatsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PlayTimeMinutesNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PlayTimeHoursNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)GloryNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MaccaNumUpDown).BeginInit();
            ItemsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ItemListDataGridView).BeginInit();
            DemonsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)LuckNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AgilityNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)MagicNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)VitalityNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)StrengthNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DemonMpNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DemonHpNumericUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DemonExperienceNumUpDown).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DemonLevelNumUpDown).BeginInit();
            MiraclesTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)MiracleListDataGridView).BeginInit();
            SaveDataGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // OpenSaveFileButton
            // 
            OpenSaveFileButton.Location = new Point(168, 12);
            OpenSaveFileButton.Name = "OpenSaveFileButton";
            OpenSaveFileButton.Size = new Size(144, 60);
            OpenSaveFileButton.TabIndex = 0;
            OpenSaveFileButton.Text = "Open Save File...";
            OpenSaveFileButton.UseVisualStyleBackColor = true;
            OpenSaveFileButton.Click += OpenSaveFileButton_Click;
            // 
            // LogoPictureBox
            // 
            LogoPictureBox.Location = new Point(12, 12);
            LogoPictureBox.Name = "LogoPictureBox";
            LogoPictureBox.Size = new Size(150, 60);
            LogoPictureBox.TabIndex = 1;
            LogoPictureBox.TabStop = false;
            // 
            // SaveChangesButton
            // 
            SaveChangesButton.BackColor = Color.Honeydew;
            SaveChangesButton.Enabled = false;
            SaveChangesButton.Location = new Point(318, 12);
            SaveChangesButton.Name = "SaveChangesButton";
            SaveChangesButton.Size = new Size(111, 33);
            SaveChangesButton.TabIndex = 2;
            SaveChangesButton.Text = "Save Changes";
            SaveChangesButton.UseVisualStyleBackColor = false;
            SaveChangesButton.Click += SaveChangesButton_Click;
            // 
            // SaveDataTabControl
            // 
            SaveDataTabControl.Controls.Add(GeneralStatsTabPage);
            SaveDataTabControl.Controls.Add(ItemsTabPage);
            SaveDataTabControl.Controls.Add(DemonsTabPage);
            SaveDataTabControl.Controls.Add(MiraclesTabPage);
            SaveDataTabControl.Location = new Point(6, 22);
            SaveDataTabControl.Name = "SaveDataTabControl";
            SaveDataTabControl.SelectedIndex = 0;
            SaveDataTabControl.Size = new Size(548, 259);
            SaveDataTabControl.TabIndex = 3;
            // 
            // GeneralStatsTabPage
            // 
            GeneralStatsTabPage.Controls.Add(DifficultyComboBox);
            GeneralStatsTabPage.Controls.Add(DifficultyLabel);
            GeneralStatsTabPage.Controls.Add(DateSavedDateTimePicker);
            GeneralStatsTabPage.Controls.Add(DateSavedLabel);
            GeneralStatsTabPage.Controls.Add(MinutesLabel);
            GeneralStatsTabPage.Controls.Add(PlayTimeMinutesNumUpDown);
            GeneralStatsTabPage.Controls.Add(HoursLabel);
            GeneralStatsTabPage.Controls.Add(PlayTimeHoursNumUpDown);
            GeneralStatsTabPage.Controls.Add(PlayTimeLabel);
            GeneralStatsTabPage.Controls.Add(GloryNumUpDown);
            GeneralStatsTabPage.Controls.Add(GloryLabel);
            GeneralStatsTabPage.Controls.Add(MaccaNumUpDown);
            GeneralStatsTabPage.Controls.Add(MaccaLabel);
            GeneralStatsTabPage.Controls.Add(LastNameTextBox);
            GeneralStatsTabPage.Controls.Add(FirstNameTextBox);
            GeneralStatsTabPage.Controls.Add(LastNameLabel);
            GeneralStatsTabPage.Controls.Add(FirstNameLabel);
            GeneralStatsTabPage.Controls.Add(DebugTestsButton);
            GeneralStatsTabPage.Location = new Point(4, 24);
            GeneralStatsTabPage.Name = "GeneralStatsTabPage";
            GeneralStatsTabPage.Padding = new Padding(3);
            GeneralStatsTabPage.Size = new Size(540, 231);
            GeneralStatsTabPage.TabIndex = 0;
            GeneralStatsTabPage.Text = "General";
            GeneralStatsTabPage.UseVisualStyleBackColor = true;
            // 
            // DifficultyComboBox
            // 
            DifficultyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DifficultyComboBox.FormattingEnabled = true;
            DifficultyComboBox.Items.AddRange(new object[] { "Safety", "Casual", "Normal", "Hard" });
            DifficultyComboBox.Location = new Point(303, 69);
            DifficultyComboBox.Name = "DifficultyComboBox";
            DifficultyComboBox.Size = new Size(82, 23);
            DifficultyComboBox.TabIndex = 17;
            DifficultyComboBox.SelectedIndexChanged += DifficultyComboBox_SelectedIndexChanged;
            // 
            // DifficultyLabel
            // 
            DifficultyLabel.AutoSize = true;
            DifficultyLabel.Location = new Point(229, 71);
            DifficultyLabel.Name = "DifficultyLabel";
            DifficultyLabel.Size = new Size(58, 15);
            DifficultyLabel.TabIndex = 16;
            DifficultyLabel.Text = "Difficulty:";
            // 
            // DateSavedDateTimePicker
            // 
            DateSavedDateTimePicker.CustomFormat = "MMMM dd',' yyyy 'at' h':'mm tt";
            DateSavedDateTimePicker.Format = DateTimePickerFormat.Custom;
            DateSavedDateTimePicker.Location = new Point(303, 40);
            DateSavedDateTimePicker.MaxDate = new DateTime(2999, 12, 31, 0, 0, 0, 0);
            DateSavedDateTimePicker.MinDate = new DateTime(2020, 1, 1, 0, 0, 0, 0);
            DateSavedDateTimePicker.Name = "DateSavedDateTimePicker";
            DateSavedDateTimePicker.Size = new Size(231, 23);
            DateSavedDateTimePicker.TabIndex = 15;
            DateSavedDateTimePicker.ValueChanged += DateSavedDateTimePicker_ValueChanged;
            // 
            // DateSavedLabel
            // 
            DateSavedLabel.AutoSize = true;
            DateSavedLabel.Location = new Point(229, 43);
            DateSavedLabel.Name = "DateSavedLabel";
            DateSavedLabel.Size = new Size(68, 15);
            DateSavedLabel.TabIndex = 14;
            DateSavedLabel.Text = "Date Saved:";
            // 
            // MinutesLabel
            // 
            MinutesLabel.AutoSize = true;
            MinutesLabel.Location = new Point(459, 14);
            MinutesLabel.Name = "MinutesLabel";
            MinutesLabel.Size = new Size(33, 15);
            MinutesLabel.TabIndex = 13;
            MinutesLabel.Text = "mins";
            // 
            // PlayTimeMinutesNumUpDown
            // 
            PlayTimeMinutesNumUpDown.Location = new Point(400, 11);
            PlayTimeMinutesNumUpDown.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            PlayTimeMinutesNumUpDown.Name = "PlayTimeMinutesNumUpDown";
            PlayTimeMinutesNumUpDown.Size = new Size(53, 23);
            PlayTimeMinutesNumUpDown.TabIndex = 12;
            PlayTimeMinutesNumUpDown.ValueChanged += PlayTimeMinutesNumUpDown_ValueChanged;
            // 
            // HoursLabel
            // 
            HoursLabel.AutoSize = true;
            HoursLabel.Location = new Point(362, 14);
            HoursLabel.Name = "HoursLabel";
            HoursLabel.Size = new Size(23, 15);
            HoursLabel.TabIndex = 11;
            HoursLabel.Text = "hrs";
            // 
            // PlayTimeHoursNumUpDown
            // 
            PlayTimeHoursNumUpDown.Location = new Point(303, 11);
            PlayTimeHoursNumUpDown.Maximum = new decimal(new int[] { 9999, 0, 0, 0 });
            PlayTimeHoursNumUpDown.Name = "PlayTimeHoursNumUpDown";
            PlayTimeHoursNumUpDown.Size = new Size(53, 23);
            PlayTimeHoursNumUpDown.TabIndex = 10;
            PlayTimeHoursNumUpDown.ValueChanged += PlayTimeHoursNumUpDown_ValueChanged;
            // 
            // PlayTimeLabel
            // 
            PlayTimeLabel.AutoSize = true;
            PlayTimeLabel.Location = new Point(229, 14);
            PlayTimeLabel.Name = "PlayTimeLabel";
            PlayTimeLabel.Size = new Size(61, 15);
            PlayTimeLabel.TabIndex = 9;
            PlayTimeLabel.Text = "Play Time:";
            // 
            // GloryNumUpDown
            // 
            GloryNumUpDown.Location = new Point(78, 98);
            GloryNumUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            GloryNumUpDown.Name = "GloryNumUpDown";
            GloryNumUpDown.Size = new Size(90, 23);
            GloryNumUpDown.TabIndex = 8;
            GloryNumUpDown.ValueChanged += GloryNumUpDown_ValueChanged;
            // 
            // GloryLabel
            // 
            GloryLabel.AutoSize = true;
            GloryLabel.Location = new Point(6, 100);
            GloryLabel.Name = "GloryLabel";
            GloryLabel.Size = new Size(38, 15);
            GloryLabel.TabIndex = 7;
            GloryLabel.Text = "Glory:";
            // 
            // MaccaNumUpDown
            // 
            MaccaNumUpDown.Location = new Point(78, 69);
            MaccaNumUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            MaccaNumUpDown.Name = "MaccaNumUpDown";
            MaccaNumUpDown.Size = new Size(90, 23);
            MaccaNumUpDown.TabIndex = 6;
            MaccaNumUpDown.ValueChanged += MaccaNumUpDown_ValueChanged;
            // 
            // MaccaLabel
            // 
            MaccaLabel.AutoSize = true;
            MaccaLabel.Location = new Point(6, 71);
            MaccaLabel.Name = "MaccaLabel";
            MaccaLabel.Size = new Size(45, 15);
            MaccaLabel.TabIndex = 5;
            MaccaLabel.Text = "Macca:";
            // 
            // LastNameTextBox
            // 
            LastNameTextBox.Location = new Point(78, 40);
            LastNameTextBox.MaxLength = 8;
            LastNameTextBox.Name = "LastNameTextBox";
            LastNameTextBox.Size = new Size(90, 23);
            LastNameTextBox.TabIndex = 4;
            LastNameTextBox.TextChanged += LastNameTextBox_TextChanged;
            // 
            // FirstNameTextBox
            // 
            FirstNameTextBox.Location = new Point(78, 11);
            FirstNameTextBox.MaxLength = 8;
            FirstNameTextBox.Name = "FirstNameTextBox";
            FirstNameTextBox.Size = new Size(90, 23);
            FirstNameTextBox.TabIndex = 3;
            FirstNameTextBox.TextChanged += FirstNameTextBox_TextChanged;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(6, 43);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(66, 15);
            LastNameLabel.TabIndex = 2;
            LastNameLabel.Text = "Last Name:";
            // 
            // FirstNameLabel
            // 
            FirstNameLabel.AutoSize = true;
            FirstNameLabel.Location = new Point(6, 14);
            FirstNameLabel.Name = "FirstNameLabel";
            FirstNameLabel.Size = new Size(67, 15);
            FirstNameLabel.TabIndex = 1;
            FirstNameLabel.Text = "First Name:";
            // 
            // DebugTestsButton
            // 
            DebugTestsButton.BackColor = Color.SteelBlue;
            DebugTestsButton.FlatAppearance.BorderColor = Color.Blue;
            DebugTestsButton.FlatStyle = FlatStyle.Flat;
            DebugTestsButton.ForeColor = SystemColors.ControlLightLight;
            DebugTestsButton.Location = new Point(459, 196);
            DebugTestsButton.Name = "DebugTestsButton";
            DebugTestsButton.Size = new Size(75, 29);
            DebugTestsButton.TabIndex = 0;
            DebugTestsButton.Text = "Test";
            DebugTestsButton.UseVisualStyleBackColor = false;
            DebugTestsButton.Visible = false;
            DebugTestsButton.Click += DebugTestsButton_Click;
            // 
            // ItemsTabPage
            // 
            ItemsTabPage.Controls.Add(ItemsShowUnusedCheckBox);
            ItemsTabPage.Controls.Add(ItemsSetAllTo99Button);
            ItemsTabPage.Controls.Add(ItemsSetAllTo255Button);
            ItemsTabPage.Controls.Add(ItemListDataGridView);
            ItemsTabPage.Location = new Point(4, 24);
            ItemsTabPage.Name = "ItemsTabPage";
            ItemsTabPage.Padding = new Padding(3);
            ItemsTabPage.Size = new Size(540, 231);
            ItemsTabPage.TabIndex = 1;
            ItemsTabPage.Text = "Items";
            ItemsTabPage.UseVisualStyleBackColor = true;
            // 
            // ItemsShowUnusedCheckBox
            // 
            ItemsShowUnusedCheckBox.AutoSize = true;
            ItemsShowUnusedCheckBox.Location = new Point(6, 205);
            ItemsShowUnusedCheckBox.Name = "ItemsShowUnusedCheckBox";
            ItemsShowUnusedCheckBox.Size = new Size(129, 19);
            ItemsShowUnusedCheckBox.TabIndex = 3;
            ItemsShowUnusedCheckBox.Text = "Show unused items";
            ItemsShowUnusedCheckBox.UseVisualStyleBackColor = true;
            ItemsShowUnusedCheckBox.CheckedChanged += ItemsShowUnusedCheckBox_CheckedChanged;
            // 
            // ItemsSetAllTo99Button
            // 
            ItemsSetAllTo99Button.BackColor = Color.MintCream;
            ItemsSetAllTo99Button.Location = new Point(328, 202);
            ItemsSetAllTo99Button.Name = "ItemsSetAllTo99Button";
            ItemsSetAllTo99Button.Size = new Size(100, 23);
            ItemsSetAllTo99Button.TabIndex = 2;
            ItemsSetAllTo99Button.Text = "Set All To 99";
            ItemsSetAllTo99Button.UseVisualStyleBackColor = false;
            ItemsSetAllTo99Button.Click += ItemsSetAllTo99Button_Click;
            // 
            // ItemsSetAllTo255Button
            // 
            ItemsSetAllTo255Button.BackColor = Color.Ivory;
            ItemsSetAllTo255Button.Location = new Point(434, 202);
            ItemsSetAllTo255Button.Name = "ItemsSetAllTo255Button";
            ItemsSetAllTo255Button.Size = new Size(100, 23);
            ItemsSetAllTo255Button.TabIndex = 1;
            ItemsSetAllTo255Button.Text = "Set All To 255";
            ItemsSetAllTo255Button.UseVisualStyleBackColor = false;
            ItemsSetAllTo255Button.Click += ItemsSetAllTo255Button_Click;
            // 
            // ItemListDataGridView
            // 
            ItemListDataGridView.AllowUserToAddRows = false;
            ItemListDataGridView.AllowUserToDeleteRows = false;
            ItemListDataGridView.AllowUserToResizeColumns = false;
            ItemListDataGridView.AllowUserToResizeRows = false;
            ItemListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ItemListDataGridView.Columns.AddRange(new DataGridViewColumn[] { ItemIndexColumn, ItemNameColumn, ItemTypeColumn, ItemAmountColumn });
            ItemListDataGridView.Location = new Point(6, 6);
            ItemListDataGridView.MultiSelect = false;
            ItemListDataGridView.Name = "ItemListDataGridView";
            ItemListDataGridView.RowHeadersVisible = false;
            ItemListDataGridView.RowTemplate.Height = 25;
            ItemListDataGridView.ShowEditingIcon = false;
            ItemListDataGridView.Size = new Size(528, 190);
            ItemListDataGridView.TabIndex = 0;
            ItemListDataGridView.CellValueChanged += ItemListDataGridView_CellValueChanged;
            ItemListDataGridView.EditingControlShowing += ItemListDataGridView_EditingControlShowing;
            // 
            // ItemIndexColumn
            // 
            ItemIndexColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemIndexColumn.FillWeight = 25F;
            ItemIndexColumn.HeaderText = "Index";
            ItemIndexColumn.MinimumWidth = 10;
            ItemIndexColumn.Name = "ItemIndexColumn";
            // 
            // ItemNameColumn
            // 
            ItemNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemNameColumn.HeaderText = "Name";
            ItemNameColumn.MinimumWidth = 50;
            ItemNameColumn.Name = "ItemNameColumn";
            ItemNameColumn.ReadOnly = true;
            // 
            // ItemTypeColumn
            // 
            ItemTypeColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemTypeColumn.FillWeight = 60F;
            ItemTypeColumn.HeaderText = "Type";
            ItemTypeColumn.MinimumWidth = 25;
            ItemTypeColumn.Name = "ItemTypeColumn";
            ItemTypeColumn.ReadOnly = true;
            // 
            // ItemAmountColumn
            // 
            ItemAmountColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ItemAmountColumn.FillWeight = 26F;
            ItemAmountColumn.HeaderText = "Amount";
            ItemAmountColumn.Name = "ItemAmountColumn";
            // 
            // DemonsTabPage
            // 
            DemonsTabPage.Controls.Add(DemonClearButton);
            DemonsTabPage.Controls.Add(DemonTypeComboBox);
            DemonsTabPage.Controls.Add(EditSkillsButton);
            DemonsTabPage.Controls.Add(DemonStockListView);
            DemonsTabPage.Controls.Add(SetDemonToMaxButton);
            DemonsTabPage.Controls.Add(LuckNumUpDown);
            DemonsTabPage.Controls.Add(LuckLabel);
            DemonsTabPage.Controls.Add(AgilityNumUpDown);
            DemonsTabPage.Controls.Add(AgilityLabel);
            DemonsTabPage.Controls.Add(MagicNumUpDown);
            DemonsTabPage.Controls.Add(MagicLabel);
            DemonsTabPage.Controls.Add(VitalityNumUpDown);
            DemonsTabPage.Controls.Add(VitalityLabel);
            DemonsTabPage.Controls.Add(StrengthNumUpDown);
            DemonsTabPage.Controls.Add(StrengthLabel);
            DemonsTabPage.Controls.Add(DemonMpNumericUpDown);
            DemonsTabPage.Controls.Add(DemonMpLabel);
            DemonsTabPage.Controls.Add(DemonHpNumericUpDown);
            DemonsTabPage.Controls.Add(DemonHpLabel);
            DemonsTabPage.Controls.Add(DemonExperienceNumUpDown);
            DemonsTabPage.Controls.Add(DemonLevelNumUpDown);
            DemonsTabPage.Controls.Add(DemonExperienceLabel);
            DemonsTabPage.Controls.Add(DemonLevelLabel);
            DemonsTabPage.Location = new Point(4, 24);
            DemonsTabPage.Name = "DemonsTabPage";
            DemonsTabPage.Padding = new Padding(3);
            DemonsTabPage.Size = new Size(540, 231);
            DemonsTabPage.TabIndex = 2;
            DemonsTabPage.Text = "Demons";
            DemonsTabPage.UseVisualStyleBackColor = true;
            // 
            // DemonClearButton
            // 
            DemonClearButton.BackColor = Color.Linen;
            DemonClearButton.Location = new Point(260, 202);
            DemonClearButton.Name = "DemonClearButton";
            DemonClearButton.Size = new Size(75, 23);
            DemonClearButton.TabIndex = 23;
            DemonClearButton.Text = "Clear";
            DemonClearButton.UseVisualStyleBackColor = false;
            DemonClearButton.Click += DemonClearButton_Click;
            // 
            // DemonTypeComboBox
            // 
            DemonTypeComboBox.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            DemonTypeComboBox.AutoCompleteSource = AutoCompleteSource.ListItems;
            DemonTypeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            DemonTypeComboBox.FormattingEnabled = true;
            DemonTypeComboBox.Location = new Point(261, 12);
            DemonTypeComboBox.Name = "DemonTypeComboBox";
            DemonTypeComboBox.Size = new Size(146, 23);
            DemonTypeComboBox.TabIndex = 22;
            DemonTypeComboBox.SelectedIndexChanged += DemonTypeComboBox_SelectedIndexChanged;
            // 
            // EditSkillsButton
            // 
            EditSkillsButton.Location = new Point(260, 157);
            EditSkillsButton.Name = "EditSkillsButton";
            EditSkillsButton.Size = new Size(95, 23);
            EditSkillsButton.TabIndex = 21;
            EditSkillsButton.Text = "Edit Skills";
            EditSkillsButton.UseVisualStyleBackColor = true;
            EditSkillsButton.Click += EditSkillsButton_Click;
            // 
            // DemonStockListView
            // 
            DemonStockListView.Columns.AddRange(new ColumnHeader[] { DemonNameColumn, DemonNoColumn });
            DemonStockListView.FullRowSelect = true;
            DemonStockListView.Location = new Point(6, 6);
            DemonStockListView.Name = "DemonStockListView";
            DemonStockListView.Size = new Size(248, 219);
            DemonStockListView.TabIndex = 19;
            DemonStockListView.UseCompatibleStateImageBehavior = false;
            DemonStockListView.View = View.Details;
            DemonStockListView.SelectedIndexChanged += DemonStockListView_SelectedIndexChanged;
            // 
            // DemonNameColumn
            // 
            DemonNameColumn.DisplayIndex = 1;
            DemonNameColumn.Text = "Name";
            DemonNameColumn.Width = 180;
            // 
            // DemonNoColumn
            // 
            DemonNoColumn.DisplayIndex = 0;
            DemonNoColumn.Text = "No.";
            DemonNoColumn.Width = 40;
            // 
            // SetDemonToMaxButton
            // 
            SetDemonToMaxButton.BackColor = Color.Honeydew;
            SetDemonToMaxButton.Location = new Point(384, 202);
            SetDemonToMaxButton.Name = "SetDemonToMaxButton";
            SetDemonToMaxButton.Size = new Size(150, 23);
            SetDemonToMaxButton.TabIndex = 18;
            SetDemonToMaxButton.Text = "Set Everything to Max";
            SetDemonToMaxButton.UseVisualStyleBackColor = false;
            SetDemonToMaxButton.Click += SetDemonToMaxButton_Click;
            // 
            // LuckNumUpDown
            // 
            LuckNumUpDown.Location = new Point(474, 129);
            LuckNumUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            LuckNumUpDown.Name = "LuckNumUpDown";
            LuckNumUpDown.Size = new Size(51, 23);
            LuckNumUpDown.TabIndex = 17;
            LuckNumUpDown.ValueChanged += LuckNumUpDown_ValueChanged;
            // 
            // LuckLabel
            // 
            LuckLabel.AutoSize = true;
            LuckLabel.Location = new Point(414, 131);
            LuckLabel.Name = "LuckLabel";
            LuckLabel.Size = new Size(35, 15);
            LuckLabel.TabIndex = 16;
            LuckLabel.Text = "Luck:";
            // 
            // AgilityNumUpDown
            // 
            AgilityNumUpDown.Location = new Point(474, 100);
            AgilityNumUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            AgilityNumUpDown.Name = "AgilityNumUpDown";
            AgilityNumUpDown.Size = new Size(51, 23);
            AgilityNumUpDown.TabIndex = 15;
            AgilityNumUpDown.ValueChanged += AgilityNumUpDown_ValueChanged;
            // 
            // AgilityLabel
            // 
            AgilityLabel.AutoSize = true;
            AgilityLabel.Location = new Point(414, 102);
            AgilityLabel.Name = "AgilityLabel";
            AgilityLabel.Size = new Size(44, 15);
            AgilityLabel.TabIndex = 14;
            AgilityLabel.Text = "Agility:";
            // 
            // MagicNumUpDown
            // 
            MagicNumUpDown.Location = new Point(474, 71);
            MagicNumUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            MagicNumUpDown.Name = "MagicNumUpDown";
            MagicNumUpDown.Size = new Size(51, 23);
            MagicNumUpDown.TabIndex = 13;
            MagicNumUpDown.ValueChanged += MagicNumUpDown_ValueChanged;
            // 
            // MagicLabel
            // 
            MagicLabel.AutoSize = true;
            MagicLabel.Location = new Point(414, 73);
            MagicLabel.Name = "MagicLabel";
            MagicLabel.Size = new Size(43, 15);
            MagicLabel.TabIndex = 12;
            MagicLabel.Text = "Magic:";
            // 
            // VitalityNumUpDown
            // 
            VitalityNumUpDown.Location = new Point(474, 42);
            VitalityNumUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            VitalityNumUpDown.Name = "VitalityNumUpDown";
            VitalityNumUpDown.Size = new Size(51, 23);
            VitalityNumUpDown.TabIndex = 11;
            VitalityNumUpDown.ValueChanged += VitalityNumUpDown_ValueChanged;
            // 
            // VitalityLabel
            // 
            VitalityLabel.AutoSize = true;
            VitalityLabel.Location = new Point(414, 44);
            VitalityLabel.Name = "VitalityLabel";
            VitalityLabel.Size = new Size(46, 15);
            VitalityLabel.TabIndex = 10;
            VitalityLabel.Text = "Vitality:";
            // 
            // StrengthNumUpDown
            // 
            StrengthNumUpDown.Location = new Point(474, 13);
            StrengthNumUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            StrengthNumUpDown.Name = "StrengthNumUpDown";
            StrengthNumUpDown.Size = new Size(51, 23);
            StrengthNumUpDown.TabIndex = 9;
            StrengthNumUpDown.ValueChanged += StrengthNumUpDown_ValueChanged;
            // 
            // StrengthLabel
            // 
            StrengthLabel.AutoSize = true;
            StrengthLabel.Location = new Point(413, 15);
            StrengthLabel.Name = "StrengthLabel";
            StrengthLabel.Size = new Size(55, 15);
            StrengthLabel.TabIndex = 8;
            StrengthLabel.Text = "Strength:";
            // 
            // DemonMpNumericUpDown
            // 
            DemonMpNumericUpDown.Location = new Point(304, 128);
            DemonMpNumericUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            DemonMpNumericUpDown.Name = "DemonMpNumericUpDown";
            DemonMpNumericUpDown.Size = new Size(51, 23);
            DemonMpNumericUpDown.TabIndex = 7;
            DemonMpNumericUpDown.ValueChanged += DemonMpNumericUpDown_ValueChanged;
            // 
            // DemonMpLabel
            // 
            DemonMpLabel.AutoSize = true;
            DemonMpLabel.Location = new Point(261, 131);
            DemonMpLabel.Name = "DemonMpLabel";
            DemonMpLabel.Size = new Size(28, 15);
            DemonMpLabel.TabIndex = 6;
            DemonMpLabel.Text = "MP:";
            // 
            // DemonHpNumericUpDown
            // 
            DemonHpNumericUpDown.Location = new Point(304, 99);
            DemonHpNumericUpDown.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            DemonHpNumericUpDown.Name = "DemonHpNumericUpDown";
            DemonHpNumericUpDown.Size = new Size(51, 23);
            DemonHpNumericUpDown.TabIndex = 5;
            DemonHpNumericUpDown.ValueChanged += DemonHpNumericUpDown_ValueChanged;
            // 
            // DemonHpLabel
            // 
            DemonHpLabel.AutoSize = true;
            DemonHpLabel.Location = new Point(260, 101);
            DemonHpLabel.Name = "DemonHpLabel";
            DemonHpLabel.Size = new Size(26, 15);
            DemonHpLabel.TabIndex = 4;
            DemonHpLabel.Text = "HP:";
            // 
            // DemonExperienceNumUpDown
            // 
            DemonExperienceNumUpDown.Location = new Point(304, 41);
            DemonExperienceNumUpDown.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            DemonExperienceNumUpDown.Name = "DemonExperienceNumUpDown";
            DemonExperienceNumUpDown.Size = new Size(103, 23);
            DemonExperienceNumUpDown.TabIndex = 2;
            DemonExperienceNumUpDown.ValueChanged += DemonExperienceNumUpDown_ValueChanged;
            // 
            // DemonLevelNumUpDown
            // 
            DemonLevelNumUpDown.Location = new Point(304, 70);
            DemonLevelNumUpDown.Maximum = new decimal(new int[] { 150, 0, 0, 0 });
            DemonLevelNumUpDown.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            DemonLevelNumUpDown.Name = "DemonLevelNumUpDown";
            DemonLevelNumUpDown.Size = new Size(51, 23);
            DemonLevelNumUpDown.TabIndex = 3;
            DemonLevelNumUpDown.Value = new decimal(new int[] { 1, 0, 0, 0 });
            DemonLevelNumUpDown.ValueChanged += DemonLevelNumUpDown_ValueChanged;
            // 
            // DemonExperienceLabel
            // 
            DemonExperienceLabel.AutoSize = true;
            DemonExperienceLabel.Location = new Point(261, 44);
            DemonExperienceLabel.Name = "DemonExperienceLabel";
            DemonExperienceLabel.Size = new Size(30, 15);
            DemonExperienceLabel.TabIndex = 0;
            DemonExperienceLabel.Text = "EXP:";
            // 
            // DemonLevelLabel
            // 
            DemonLevelLabel.AutoSize = true;
            DemonLevelLabel.Location = new Point(261, 72);
            DemonLevelLabel.Name = "DemonLevelLabel";
            DemonLevelLabel.Size = new Size(37, 15);
            DemonLevelLabel.TabIndex = 1;
            DemonLevelLabel.Text = "Level:";
            // 
            // MiraclesTabPage
            // 
            MiraclesTabPage.Controls.Add(SetMiraclesLearnedButton);
            MiraclesTabPage.Controls.Add(SetMiraclesNotLearnedButton);
            MiraclesTabPage.Controls.Add(MiracleListDataGridView);
            MiraclesTabPage.Location = new Point(4, 24);
            MiraclesTabPage.Name = "MiraclesTabPage";
            MiraclesTabPage.Size = new Size(540, 231);
            MiraclesTabPage.TabIndex = 3;
            MiraclesTabPage.Text = "Miracles";
            MiraclesTabPage.UseVisualStyleBackColor = true;
            // 
            // SetMiraclesLearnedButton
            // 
            SetMiraclesLearnedButton.BackColor = Color.MintCream;
            SetMiraclesLearnedButton.Location = new Point(328, 202);
            SetMiraclesLearnedButton.Name = "SetMiraclesLearnedButton";
            SetMiraclesLearnedButton.Size = new Size(100, 23);
            SetMiraclesLearnedButton.TabIndex = 4;
            SetMiraclesLearnedButton.Text = "Learn All";
            SetMiraclesLearnedButton.UseVisualStyleBackColor = false;
            SetMiraclesLearnedButton.Click += SetMiraclesLearnedButton_Click;
            // 
            // SetMiraclesNotLearnedButton
            // 
            SetMiraclesNotLearnedButton.BackColor = Color.Ivory;
            SetMiraclesNotLearnedButton.Location = new Point(434, 202);
            SetMiraclesNotLearnedButton.Name = "SetMiraclesNotLearnedButton";
            SetMiraclesNotLearnedButton.Size = new Size(100, 23);
            SetMiraclesNotLearnedButton.TabIndex = 3;
            SetMiraclesNotLearnedButton.Text = "Unlearn All";
            SetMiraclesNotLearnedButton.UseVisualStyleBackColor = false;
            SetMiraclesNotLearnedButton.Click += SetMiraclesNotLearnedButton_Click;
            // 
            // MiracleListDataGridView
            // 
            MiracleListDataGridView.AllowUserToAddRows = false;
            MiracleListDataGridView.AllowUserToDeleteRows = false;
            MiracleListDataGridView.AllowUserToResizeColumns = false;
            MiracleListDataGridView.AllowUserToResizeRows = false;
            MiracleListDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            MiracleListDataGridView.Columns.AddRange(new DataGridViewColumn[] { MiracleIndexTextBoxColumn, MiracleNameTextBoxColumn, MiracleValueTextBoxColumn });
            MiracleListDataGridView.Location = new Point(6, 6);
            MiracleListDataGridView.MultiSelect = false;
            MiracleListDataGridView.Name = "MiracleListDataGridView";
            MiracleListDataGridView.RowHeadersVisible = false;
            MiracleListDataGridView.RowTemplate.Height = 25;
            MiracleListDataGridView.ShowEditingIcon = false;
            MiracleListDataGridView.Size = new Size(528, 190);
            MiracleListDataGridView.TabIndex = 1;
            MiracleListDataGridView.CellValueChanged += MiracleListDataGridView_CellValueChanged;
            MiracleListDataGridView.EditingControlShowing += MiracleListDataGridView_EditingControlShowing;
            // 
            // MiracleIndexTextBoxColumn
            // 
            MiracleIndexTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MiracleIndexTextBoxColumn.FillWeight = 25F;
            MiracleIndexTextBoxColumn.HeaderText = "Index";
            MiracleIndexTextBoxColumn.MinimumWidth = 10;
            MiracleIndexTextBoxColumn.Name = "MiracleIndexTextBoxColumn";
            // 
            // MiracleNameTextBoxColumn
            // 
            MiracleNameTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MiracleNameTextBoxColumn.HeaderText = "Name";
            MiracleNameTextBoxColumn.MinimumWidth = 50;
            MiracleNameTextBoxColumn.Name = "MiracleNameTextBoxColumn";
            MiracleNameTextBoxColumn.ReadOnly = true;
            // 
            // MiracleValueTextBoxColumn
            // 
            MiracleValueTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            MiracleValueTextBoxColumn.FillWeight = 26F;
            MiracleValueTextBoxColumn.HeaderText = "Value Byte";
            MiracleValueTextBoxColumn.Name = "MiracleValueTextBoxColumn";
            // 
            // SaveDataGroupBox
            // 
            SaveDataGroupBox.Controls.Add(SaveDataTabControl);
            SaveDataGroupBox.Location = new Point(12, 78);
            SaveDataGroupBox.Name = "SaveDataGroupBox";
            SaveDataGroupBox.Size = new Size(560, 287);
            SaveDataGroupBox.TabIndex = 4;
            SaveDataGroupBox.TabStop = false;
            SaveDataGroupBox.Text = "Save Data";
            // 
            // MakeBackUpCheckbox
            // 
            MakeBackUpCheckbox.AutoSize = true;
            MakeBackUpCheckbox.Checked = true;
            MakeBackUpCheckbox.CheckState = CheckState.Checked;
            MakeBackUpCheckbox.Location = new Point(318, 51);
            MakeBackUpCheckbox.Name = "MakeBackUpCheckbox";
            MakeBackUpCheckbox.Size = new Size(111, 19);
            MakeBackUpCheckbox.TabIndex = 5;
            MakeBackUpCheckbox.Text = "Make a back-up";
            MakeBackUpCheckbox.UseVisualStyleBackColor = true;
            // 
            // ImportDecryptedDataButton
            // 
            ImportDecryptedDataButton.Location = new Point(435, 12);
            ImportDecryptedDataButton.Name = "ImportDecryptedDataButton";
            ImportDecryptedDataButton.Size = new Size(137, 27);
            ImportDecryptedDataButton.TabIndex = 6;
            ImportDecryptedDataButton.Text = "Import Decrypted Data";
            ImportDecryptedDataButton.UseVisualStyleBackColor = true;
            ImportDecryptedDataButton.Click += ImportDecryptedDataButton_Click;
            // 
            // ExportDecryptedDataButton
            // 
            ExportDecryptedDataButton.Location = new Point(435, 45);
            ExportDecryptedDataButton.Name = "ExportDecryptedDataButton";
            ExportDecryptedDataButton.Size = new Size(137, 27);
            ExportDecryptedDataButton.TabIndex = 7;
            ExportDecryptedDataButton.Text = "Export Decrypted Data";
            ExportDecryptedDataButton.UseVisualStyleBackColor = true;
            ExportDecryptedDataButton.Click += ExportDecryptedDataButton_Click;
            // 
            // DemonImageList
            // 
            DemonImageList.ColorDepth = ColorDepth.Depth32Bit;
            DemonImageList.ImageSize = new Size(68, 52);
            DemonImageList.TransparentColor = Color.Transparent;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(584, 381);
            Controls.Add(ExportDecryptedDataButton);
            Controls.Add(ImportDecryptedDataButton);
            Controls.Add(MakeBackUpCheckbox);
            Controls.Add(SaveDataGroupBox);
            Controls.Add(SaveChangesButton);
            Controls.Add(LogoPictureBox);
            Controls.Add(OpenSaveFileButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "Aogami";
            ((System.ComponentModel.ISupportInitialize)LogoPictureBox).EndInit();
            SaveDataTabControl.ResumeLayout(false);
            GeneralStatsTabPage.ResumeLayout(false);
            GeneralStatsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PlayTimeMinutesNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)PlayTimeHoursNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)GloryNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MaccaNumUpDown).EndInit();
            ItemsTabPage.ResumeLayout(false);
            ItemsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ItemListDataGridView).EndInit();
            DemonsTabPage.ResumeLayout(false);
            DemonsTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)LuckNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)AgilityNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)MagicNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)VitalityNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)StrengthNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DemonMpNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DemonHpNumericUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DemonExperienceNumUpDown).EndInit();
            ((System.ComponentModel.ISupportInitialize)DemonLevelNumUpDown).EndInit();
            MiraclesTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)MiracleListDataGridView).EndInit();
            SaveDataGroupBox.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button OpenSaveFileButton;
        private PictureBox LogoPictureBox;
        private Button SaveChangesButton;
        private TabControl SaveDataTabControl;
        private TabPage GeneralStatsTabPage;
        private TabPage ItemsTabPage;
        private GroupBox SaveDataGroupBox;
        private CheckBox MakeBackUpCheckbox;
        private Button ImportDecryptedDataButton;
        private Button ExportDecryptedDataButton;
        private Button DebugTestsButton;
        private TextBox LastNameTextBox;
        private TextBox FirstNameTextBox;
        private Label LastNameLabel;
        private Label FirstNameLabel;
        private NumericUpDown MaccaNumUpDown;
        private Label MaccaLabel;
        private NumericUpDown GloryNumUpDown;
        private Label GloryLabel;
        private Label PlayTimeLabel;
        private Label MinutesLabel;
        private NumericUpDown PlayTimeMinutesNumUpDown;
        private Label HoursLabel;
        private NumericUpDown PlayTimeHoursNumUpDown;
        private Label DateSavedLabel;
        private DateTimePicker DateSavedDateTimePicker;
        private ComboBox DifficultyComboBox;
        private Label DifficultyLabel;
        private Button ItemsSetAllTo99Button;
        private Button ItemsSetAllTo255Button;
        private DataGridView ItemListDataGridView;
        private DataGridViewTextBoxColumn ItemIndexColumn;
        private DataGridViewTextBoxColumn ItemNameColumn;
        private DataGridViewTextBoxColumn ItemTypeColumn;
        private DataGridViewTextBoxColumn ItemAmountColumn;
        private CheckBox ItemsShowUnusedCheckBox;
        private TabPage DemonsTabPage;
        private Label DemonExperienceLabel;
        private Label DemonLevelLabel;
        private NumericUpDown DemonLevelNumUpDown;
        private NumericUpDown VitalityNumUpDown;
        private Label VitalityLabel;
        private NumericUpDown StrengthNumUpDown;
        private Label StrengthLabel;
        private NumericUpDown DemonMpNumericUpDown;
        private Label DemonMpLabel;
        private NumericUpDown DemonHpNumericUpDown;
        private Label DemonHpLabel;
        private NumericUpDown DemonExperienceNumUpDown;
        private NumericUpDown LuckNumUpDown;
        private Label LuckLabel;
        private NumericUpDown AgilityNumUpDown;
        private Label AgilityLabel;
        private NumericUpDown MagicNumUpDown;
        private Label MagicLabel;
        private Button SetDemonToMaxButton;
        private ListView DemonStockListView;
        private ColumnHeader DemonNameColumn;
        private ColumnHeader DemonNoColumn;
        private ComboBox DemonTypeComboBox;
        private Button EditSkillsButton;
        private ImageList DemonImageList;
        private Button DemonClearButton;
        private TabPage MiraclesTabPage;
        private Button SetMiraclesLearnedButton;
        private Button SetMiraclesNotLearnedButton;
        private DataGridView MiracleListDataGridView;
        private DataGridViewTextBoxColumn MiracleIndexTextBoxColumn;
        private DataGridViewTextBoxColumn MiracleNameTextBoxColumn;
        private DataGridViewTextBoxColumn MiracleValueTextBoxColumn;
    }
}