<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RPGitemEditor
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(RPGitemEditor))
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.UID = New System.Windows.Forms.RichTextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Author = New System.Windows.Forms.RichTextBox()
        Me.Note = New System.Windows.Forms.RichTextBox()
        Me.MinecraftVersion = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FilleToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.License = New System.Windows.Forms.RichTextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.PluginSerial = New System.Windows.Forms.RichTextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.SkillAPI = New System.Windows.Forms.TabPage()
        Me.Powers = New System.Windows.Forms.TabPage()
        Me.MenuPower = New System.Windows.Forms.Panel()
        Me.ButtonPower10 = New System.Windows.Forms.Button()
        Me.ButtonPower9 = New System.Windows.Forms.Button()
        Me.ButtonPower11 = New System.Windows.Forms.Button()
        Me.ButtonPower20 = New System.Windows.Forms.Button()
        Me.ButtonPower8 = New System.Windows.Forms.Button()
        Me.ButtonPower12 = New System.Windows.Forms.Button()
        Me.ButtonPower19 = New System.Windows.Forms.Button()
        Me.ButtonPower18 = New System.Windows.Forms.Button()
        Me.ButtonPower7 = New System.Windows.Forms.Button()
        Me.ButtonPower6 = New System.Windows.Forms.Button()
        Me.ButtonPower13 = New System.Windows.Forms.Button()
        Me.ButtonPower17 = New System.Windows.Forms.Button()
        Me.ButtonPower16 = New System.Windows.Forms.Button()
        Me.ButtonPower14 = New System.Windows.Forms.Button()
        Me.ButtonPower5 = New System.Windows.Forms.Button()
        Me.ButtonPower15 = New System.Windows.Forms.Button()
        Me.ButtonPower4 = New System.Windows.Forms.Button()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.ButtonPower3 = New System.Windows.Forms.Button()
        Me.ButtonPower2 = New System.Windows.Forms.Button()
        Me.ButtonPower1 = New System.Windows.Forms.Button()
        Me.General = New System.Windows.Forms.TabPage()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.ForceBar = New System.Windows.Forms.ComboBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.AlwaysAllowMelee = New System.Windows.Forms.ComboBox()
        Me.HasPermission = New System.Windows.Forms.ComboBox()
        Me.IgnoreWorldGuard = New System.Windows.Forms.ComboBox()
        Me.HitCostByDamage = New System.Windows.Forms.ComboBox()
        Me.HasDurabilityBar = New System.Windows.Forms.ComboBox()
        Me.ShowPowerText = New System.Windows.Forms.ComboBox()
        Me.ShowArmourLore = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ItemData = New System.Windows.Forms.NumericUpDown()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.DamageMode = New System.Windows.Forms.ComboBox()
        Me.Item = New System.Windows.Forms.ComboBox()
        Me.Armour = New System.Windows.Forms.NumericUpDown()
        Me.Level = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Hand = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Type = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.DamageMax = New System.Windows.Forms.NumericUpDown()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.DamageMin = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DurabilityUpper = New System.Windows.Forms.NumericUpDown()
        Me.DurabilityLower = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Durability = New System.Windows.Forms.NumericUpDown()
        Me.HitCost = New System.Windows.Forms.NumericUpDown()
        Me.HittingCost = New System.Windows.Forms.NumericUpDown()
        Me.BlockBreakingCost = New System.Windows.Forms.NumericUpDown()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DescriptionL6 = New System.Windows.Forms.RichTextBox()
        Me.DescriptionL5 = New System.Windows.Forms.RichTextBox()
        Me.DescriptionL4 = New System.Windows.Forms.RichTextBox()
        Me.DescriptionL3 = New System.Windows.Forms.RichTextBox()
        Me.DescriptionL2 = New System.Windows.Forms.RichTextBox()
        Me.ID = New System.Windows.Forms.RichTextBox()
        Me.Display = New System.Windows.Forms.RichTextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.DescriptionL1 = New System.Windows.Forms.RichTextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.RemovePower = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Powers.SuspendLayout()
        Me.MenuPower.SuspendLayout()
        Me.General.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.ItemData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Armour, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DamageMin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DurabilityUpper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DurabilityLower, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Durability, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HitCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HittingCost, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlockBreakingCost, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'UID
        '
        Me.UID.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.UID.Location = New System.Drawing.Point(172, 133)
        Me.UID.MaxLength = 20
        Me.UID.Multiline = False
        Me.UID.Name = "UID"
        Me.UID.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.UID.Size = New System.Drawing.Size(177, 18)
        Me.UID.TabIndex = 55
        Me.UID.TabStop = False
        Me.UID.Text = ""
        Me.UID.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Checked = True
        Me.CheckBox1.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(12, 133)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(158, 20)
        Me.CheckBox1.TabIndex = 54
        Me.CheckBox1.Text = "Generate random UID"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label23
        '
        Me.Label23.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label23.AutoSize = True
        Me.Label23.BackColor = System.Drawing.Color.Silver
        Me.Label23.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(9, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(68, 18)
        Me.Label23.TabIndex = 60
        Me.Label23.Text = "Notes : "
        '
        'Label22
        '
        Me.Label22.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(9, 65)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(72, 18)
        Me.Label22.TabIndex = 59
        Me.Label22.Text = "Author :"
        '
        'Author
        '
        Me.Author.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Author.Location = New System.Drawing.Point(93, 64)
        Me.Author.MaxLength = 16
        Me.Author.Multiline = False
        Me.Author.Name = "Author"
        Me.Author.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Author.Size = New System.Drawing.Size(121, 18)
        Me.Author.TabIndex = 58
        Me.Author.TabStop = False
        Me.Author.Text = ""
        '
        'Note
        '
        Me.Note.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Note.Location = New System.Drawing.Point(93, 38)
        Me.Note.MaxLength = 200
        Me.Note.Multiline = False
        Me.Note.Name = "Note"
        Me.Note.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.Note.Size = New System.Drawing.Size(200, 17)
        Me.Note.TabIndex = 57
        Me.Note.TabStop = False
        Me.Note.Text = ""
        '
        'MinecraftVersion
        '
        Me.MinecraftVersion.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.MinecraftVersion.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.MinecraftVersion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.MinecraftVersion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.MinecraftVersion.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.MinecraftVersion.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MinecraftVersion.FormatString = "True, False"
        Me.MinecraftVersion.FormattingEnabled = True
        Me.MinecraftVersion.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.MinecraftVersion.IntegralHeight = False
        Me.MinecraftVersion.Items.AddRange(New Object() {"1.10", "1.11", "1.12", "1.13.2"})
        Me.MinecraftVersion.Location = New System.Drawing.Point(172, 6)
        Me.MinecraftVersion.MaxLength = 5
        Me.MinecraftVersion.Name = "MinecraftVersion"
        Me.MinecraftVersion.Size = New System.Drawing.Size(121, 23)
        Me.MinecraftVersion.Sorted = True
        Me.MinecraftVersion.TabIndex = 57
        Me.MinecraftVersion.Text = "1.13.2"
        '
        'Label21
        '
        Me.Label21.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label21.AutoSize = True
        Me.Label21.BackColor = System.Drawing.Color.Silver
        Me.Label21.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(11, 8)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(153, 18)
        Me.Label21.TabIndex = 57
        Me.Label21.Text = "MinecraftVersion :"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FilleToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(781, 24)
        Me.MenuStrip1.TabIndex = 56
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FilleToolStripMenuItem
        '
        Me.FilleToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveToolStripMenuItem})
        Me.FilleToolStripMenuItem.Name = "FilleToolStripMenuItem"
        Me.FilleToolStripMenuItem.Size = New System.Drawing.Size(40, 20)
        Me.FilleToolStripMenuItem.Text = "Fille"
        '
        'SaveToolStripMenuItem
        '
        Me.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem"
        Me.SaveToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SaveToolStripMenuItem.Text = "Save"
        '
        'License
        '
        Me.License.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.License.Location = New System.Drawing.Point(93, 87)
        Me.License.MaxLength = 16
        Me.License.Multiline = False
        Me.License.Name = "License"
        Me.License.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.License.Size = New System.Drawing.Size(121, 18)
        Me.License.TabIndex = 61
        Me.License.TabStop = False
        Me.License.Text = ""
        '
        'Label28
        '
        Me.Label28.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.Location = New System.Drawing.Point(9, 87)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(80, 18)
        Me.Label28.TabIndex = 62
        Me.Label28.Text = "License :"
        '
        'PluginSerial
        '
        Me.PluginSerial.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.PluginSerial.Location = New System.Drawing.Point(127, 113)
        Me.PluginSerial.MaxLength = 16
        Me.PluginSerial.Multiline = False
        Me.PluginSerial.Name = "PluginSerial"
        Me.PluginSerial.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.PluginSerial.Size = New System.Drawing.Size(121, 18)
        Me.PluginSerial.TabIndex = 63
        Me.PluginSerial.TabStop = False
        Me.PluginSerial.Text = "659"
        '
        'Label29
        '
        Me.Label29.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.Location = New System.Drawing.Point(9, 112)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(112, 18)
        Me.Label29.TabIndex = 64
        Me.Label29.Text = "PluginSerial :"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.Silver
        Me.Panel5.Controls.Add(Me.UID)
        Me.Panel5.Controls.Add(Me.PluginSerial)
        Me.Panel5.Controls.Add(Me.CheckBox1)
        Me.Panel5.Controls.Add(Me.MinecraftVersion)
        Me.Panel5.Controls.Add(Me.Label29)
        Me.Panel5.Controls.Add(Me.Note)
        Me.Panel5.Controls.Add(Me.Label28)
        Me.Panel5.Controls.Add(Me.License)
        Me.Panel5.Controls.Add(Me.Label23)
        Me.Panel5.Controls.Add(Me.Label21)
        Me.Panel5.Controls.Add(Me.Label22)
        Me.Panel5.Controls.Add(Me.Author)
        Me.Panel5.Location = New System.Drawing.Point(0, 518)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(781, 165)
        Me.Panel5.TabIndex = 65
        '
        'SkillAPI
        '
        Me.SkillAPI.Location = New System.Drawing.Point(4, 22)
        Me.SkillAPI.Name = "SkillAPI"
        Me.SkillAPI.Size = New System.Drawing.Size(775, 467)
        Me.SkillAPI.TabIndex = 2
        Me.SkillAPI.Text = "SkillAPI support"
        Me.SkillAPI.UseVisualStyleBackColor = True
        '
        'Powers
        '
        Me.Powers.Controls.Add(Me.MenuPower)
        Me.Powers.Location = New System.Drawing.Point(4, 22)
        Me.Powers.Name = "Powers"
        Me.Powers.Padding = New System.Windows.Forms.Padding(3)
        Me.Powers.Size = New System.Drawing.Size(775, 467)
        Me.Powers.TabIndex = 1
        Me.Powers.Text = "Powers"
        Me.Powers.UseVisualStyleBackColor = True
        '
        'MenuPower
        '
        Me.MenuPower.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MenuPower.Controls.Add(Me.RemovePower)
        Me.MenuPower.Controls.Add(Me.ButtonPower10)
        Me.MenuPower.Controls.Add(Me.ButtonPower9)
        Me.MenuPower.Controls.Add(Me.ButtonPower11)
        Me.MenuPower.Controls.Add(Me.ButtonPower20)
        Me.MenuPower.Controls.Add(Me.ButtonPower8)
        Me.MenuPower.Controls.Add(Me.ButtonPower12)
        Me.MenuPower.Controls.Add(Me.ButtonPower19)
        Me.MenuPower.Controls.Add(Me.ButtonPower18)
        Me.MenuPower.Controls.Add(Me.ButtonPower7)
        Me.MenuPower.Controls.Add(Me.ButtonPower6)
        Me.MenuPower.Controls.Add(Me.ButtonPower13)
        Me.MenuPower.Controls.Add(Me.ButtonPower17)
        Me.MenuPower.Controls.Add(Me.ButtonPower16)
        Me.MenuPower.Controls.Add(Me.ButtonPower14)
        Me.MenuPower.Controls.Add(Me.ButtonPower5)
        Me.MenuPower.Controls.Add(Me.ButtonPower15)
        Me.MenuPower.Controls.Add(Me.ButtonPower4)
        Me.MenuPower.Controls.Add(Me.HScrollBar1)
        Me.MenuPower.Controls.Add(Me.ButtonPower3)
        Me.MenuPower.Controls.Add(Me.ButtonPower2)
        Me.MenuPower.Controls.Add(Me.ButtonPower1)
        Me.MenuPower.Location = New System.Drawing.Point(3, 3)
        Me.MenuPower.Name = "MenuPower"
        Me.MenuPower.Size = New System.Drawing.Size(769, 461)
        Me.MenuPower.TabIndex = 1
        '
        'ButtonPower10
        '
        Me.ButtonPower10.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower10.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower10.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower10.Location = New System.Drawing.Point(600, 256)
        Me.ButtonPower10.Name = "ButtonPower10"
        Me.ButtonPower10.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower10.TabIndex = 21
        Me.ButtonPower10.Text = "NEW POWER"
        Me.ButtonPower10.UseVisualStyleBackColor = False
        '
        'ButtonPower9
        '
        Me.ButtonPower9.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower9.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower9.Location = New System.Drawing.Point(512, 256)
        Me.ButtonPower9.Name = "ButtonPower9"
        Me.ButtonPower9.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower9.TabIndex = 19
        Me.ButtonPower9.Text = "NEW POWER"
        Me.ButtonPower9.UseVisualStyleBackColor = False
        '
        'ButtonPower11
        '
        Me.ButtonPower11.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower11.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower11.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower11.Location = New System.Drawing.Point(512, 175)
        Me.ButtonPower11.Name = "ButtonPower11"
        Me.ButtonPower11.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower11.TabIndex = 18
        Me.ButtonPower11.Text = "NEW POWER"
        Me.ButtonPower11.UseVisualStyleBackColor = False
        '
        'ButtonPower20
        '
        Me.ButtonPower20.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower20.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower20.Location = New System.Drawing.Point(512, 94)
        Me.ButtonPower20.Name = "ButtonPower20"
        Me.ButtonPower20.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower20.TabIndex = 17
        Me.ButtonPower20.Text = "NEW POWER"
        Me.ButtonPower20.UseVisualStyleBackColor = False
        '
        'ButtonPower8
        '
        Me.ButtonPower8.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower8.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower8.Location = New System.Drawing.Point(431, 256)
        Me.ButtonPower8.Name = "ButtonPower8"
        Me.ButtonPower8.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower8.TabIndex = 16
        Me.ButtonPower8.Text = "NEW POWER"
        Me.ButtonPower8.UseVisualStyleBackColor = False
        '
        'ButtonPower12
        '
        Me.ButtonPower12.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower12.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower12.Location = New System.Drawing.Point(431, 175)
        Me.ButtonPower12.Name = "ButtonPower12"
        Me.ButtonPower12.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower12.TabIndex = 15
        Me.ButtonPower12.Text = "NEW POWER"
        Me.ButtonPower12.UseVisualStyleBackColor = False
        '
        'ButtonPower19
        '
        Me.ButtonPower19.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower19.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower19.Location = New System.Drawing.Point(431, 94)
        Me.ButtonPower19.Name = "ButtonPower19"
        Me.ButtonPower19.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower19.TabIndex = 14
        Me.ButtonPower19.Text = "NEW POWER"
        Me.ButtonPower19.UseVisualStyleBackColor = False
        '
        'ButtonPower18
        '
        Me.ButtonPower18.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower18.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower18.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower18.Location = New System.Drawing.Point(350, 94)
        Me.ButtonPower18.Name = "ButtonPower18"
        Me.ButtonPower18.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower18.TabIndex = 13
        Me.ButtonPower18.Text = "NEW POWER"
        Me.ButtonPower18.UseVisualStyleBackColor = False
        '
        'ButtonPower7
        '
        Me.ButtonPower7.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower7.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower7.Location = New System.Drawing.Point(350, 256)
        Me.ButtonPower7.Name = "ButtonPower7"
        Me.ButtonPower7.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower7.TabIndex = 12
        Me.ButtonPower7.Text = "NEW POWER"
        Me.ButtonPower7.UseVisualStyleBackColor = False
        '
        'ButtonPower6
        '
        Me.ButtonPower6.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower6.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower6.Location = New System.Drawing.Point(262, 256)
        Me.ButtonPower6.Name = "ButtonPower6"
        Me.ButtonPower6.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower6.TabIndex = 11
        Me.ButtonPower6.Text = "NEW POWER"
        Me.ButtonPower6.UseVisualStyleBackColor = False
        '
        'ButtonPower13
        '
        Me.ButtonPower13.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower13.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower13.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower13.Location = New System.Drawing.Point(262, 175)
        Me.ButtonPower13.Name = "ButtonPower13"
        Me.ButtonPower13.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower13.TabIndex = 10
        Me.ButtonPower13.Text = "NEW POWER"
        Me.ButtonPower13.UseVisualStyleBackColor = False
        '
        'ButtonPower17
        '
        Me.ButtonPower17.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower17.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower17.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower17.Location = New System.Drawing.Point(262, 94)
        Me.ButtonPower17.Name = "ButtonPower17"
        Me.ButtonPower17.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower17.TabIndex = 9
        Me.ButtonPower17.Text = "NEW POWER"
        Me.ButtonPower17.UseVisualStyleBackColor = False
        '
        'ButtonPower16
        '
        Me.ButtonPower16.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower16.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower16.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower16.Location = New System.Drawing.Point(181, 94)
        Me.ButtonPower16.Name = "ButtonPower16"
        Me.ButtonPower16.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower16.TabIndex = 8
        Me.ButtonPower16.Text = "NEW POWER"
        Me.ButtonPower16.UseVisualStyleBackColor = False
        '
        'ButtonPower14
        '
        Me.ButtonPower14.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower14.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower14.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower14.Location = New System.Drawing.Point(181, 175)
        Me.ButtonPower14.Name = "ButtonPower14"
        Me.ButtonPower14.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower14.TabIndex = 7
        Me.ButtonPower14.Text = "NEW POWER"
        Me.ButtonPower14.UseVisualStyleBackColor = False
        '
        'ButtonPower5
        '
        Me.ButtonPower5.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower5.Location = New System.Drawing.Point(181, 256)
        Me.ButtonPower5.Name = "ButtonPower5"
        Me.ButtonPower5.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower5.TabIndex = 6
        Me.ButtonPower5.Text = "NEW POWER"
        Me.ButtonPower5.UseVisualStyleBackColor = False
        '
        'ButtonPower15
        '
        Me.ButtonPower15.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower15.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower15.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower15.Location = New System.Drawing.Point(100, 94)
        Me.ButtonPower15.Name = "ButtonPower15"
        Me.ButtonPower15.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower15.TabIndex = 5
        Me.ButtonPower15.Text = "NEW POWER"
        Me.ButtonPower15.UseVisualStyleBackColor = False
        '
        'ButtonPower4
        '
        Me.ButtonPower4.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower4.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower4.Location = New System.Drawing.Point(100, 256)
        Me.ButtonPower4.Name = "ButtonPower4"
        Me.ButtonPower4.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower4.TabIndex = 4
        Me.ButtonPower4.Text = "NEW POWER"
        Me.ButtonPower4.UseVisualStyleBackColor = False
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.HScrollBar1.Location = New System.Drawing.Point(0, 440)
        Me.HScrollBar1.Maximum = 4300
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(769, 21)
        Me.HScrollBar1.SmallChange = 10
        Me.HScrollBar1.TabIndex = 3
        '
        'ButtonPower3
        '
        Me.ButtonPower3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower3.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower3.Location = New System.Drawing.Point(600, 175)
        Me.ButtonPower3.Name = "ButtonPower3"
        Me.ButtonPower3.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower3.TabIndex = 2
        Me.ButtonPower3.Text = "NEW POWER"
        Me.ButtonPower3.UseVisualStyleBackColor = False
        '
        'ButtonPower2
        '
        Me.ButtonPower2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower2.Location = New System.Drawing.Point(350, 175)
        Me.ButtonPower2.Name = "ButtonPower2"
        Me.ButtonPower2.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower2.TabIndex = 1
        Me.ButtonPower2.Text = "NEW POWER"
        Me.ButtonPower2.UseVisualStyleBackColor = False
        '
        'ButtonPower1
        '
        Me.ButtonPower1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ButtonPower1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ButtonPower1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.ButtonPower1.Location = New System.Drawing.Point(100, 175)
        Me.ButtonPower1.Name = "ButtonPower1"
        Me.ButtonPower1.Size = New System.Drawing.Size(75, 75)
        Me.ButtonPower1.TabIndex = 0
        Me.ButtonPower1.Text = "NEW POWER"
        Me.ButtonPower1.UseVisualStyleBackColor = False
        '
        'General
        '
        Me.General.Controls.Add(Me.Panel4)
        Me.General.Controls.Add(Me.Panel3)
        Me.General.Controls.Add(Me.Panel2)
        Me.General.Controls.Add(Me.Panel1)
        Me.General.Location = New System.Drawing.Point(4, 22)
        Me.General.Name = "General"
        Me.General.Padding = New System.Windows.Forms.Padding(3)
        Me.General.Size = New System.Drawing.Size(775, 467)
        Me.General.TabIndex = 0
        Me.General.Text = "General"
        Me.General.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel4.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Panel4.Controls.Add(Me.ForceBar)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label7)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.AlwaysAllowMelee)
        Me.Panel4.Controls.Add(Me.HasPermission)
        Me.Panel4.Controls.Add(Me.IgnoreWorldGuard)
        Me.Panel4.Controls.Add(Me.HitCostByDamage)
        Me.Panel4.Controls.Add(Me.HasDurabilityBar)
        Me.Panel4.Controls.Add(Me.ShowPowerText)
        Me.Panel4.Controls.Add(Me.ShowArmourLore)
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label6)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Location = New System.Drawing.Point(444, 236)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(325, 225)
        Me.Panel4.TabIndex = 47
        '
        'ForceBar
        '
        Me.ForceBar.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.ForceBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ForceBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ForceBar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ForceBar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForceBar.FormatString = "True, False"
        Me.ForceBar.FormattingEnabled = True
        Me.ForceBar.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ForceBar.IntegralHeight = False
        Me.ForceBar.Items.AddRange(New Object() {"false", "true"})
        Me.ForceBar.Location = New System.Drawing.Point(179, 187)
        Me.ForceBar.MaxLength = 5
        Me.ForceBar.Name = "ForceBar"
        Me.ForceBar.Size = New System.Drawing.Size(121, 23)
        Me.ForceBar.Sorted = True
        Me.ForceBar.TabIndex = 18
        Me.ForceBar.Text = "true"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label31.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(8, 188)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(93, 18)
        Me.Label31.TabIndex = 17
        Me.Label31.Text = "ForceBar :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.DeepSkyBlue
        Me.Label7.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(9, 161)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(154, 18)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "ShowArmourLore:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(164, 18)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "AlwaysAllowMelee :"
        '
        'AlwaysAllowMelee
        '
        Me.AlwaysAllowMelee.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.AlwaysAllowMelee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.AlwaysAllowMelee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.AlwaysAllowMelee.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AlwaysAllowMelee.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AlwaysAllowMelee.FormatString = "True, False"
        Me.AlwaysAllowMelee.FormattingEnabled = True
        Me.AlwaysAllowMelee.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.AlwaysAllowMelee.IntegralHeight = False
        Me.AlwaysAllowMelee.Items.AddRange(New Object() {"false", "true"})
        Me.AlwaysAllowMelee.Location = New System.Drawing.Point(179, 5)
        Me.AlwaysAllowMelee.MaxLength = 5
        Me.AlwaysAllowMelee.Name = "AlwaysAllowMelee"
        Me.AlwaysAllowMelee.Size = New System.Drawing.Size(121, 23)
        Me.AlwaysAllowMelee.Sorted = True
        Me.AlwaysAllowMelee.TabIndex = 3
        Me.AlwaysAllowMelee.Text = "false"
        '
        'HasPermission
        '
        Me.HasPermission.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.HasPermission.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.HasPermission.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HasPermission.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HasPermission.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HasPermission.FormatString = "True, False"
        Me.HasPermission.FormattingEnabled = True
        Me.HasPermission.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.HasPermission.IntegralHeight = False
        Me.HasPermission.Items.AddRange(New Object() {"false", "true"})
        Me.HasPermission.Location = New System.Drawing.Point(180, 31)
        Me.HasPermission.MaxLength = 5
        Me.HasPermission.Name = "HasPermission"
        Me.HasPermission.Size = New System.Drawing.Size(121, 23)
        Me.HasPermission.Sorted = True
        Me.HasPermission.TabIndex = 4
        Me.HasPermission.Text = "false"
        '
        'IgnoreWorldGuard
        '
        Me.IgnoreWorldGuard.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.IgnoreWorldGuard.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.IgnoreWorldGuard.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.IgnoreWorldGuard.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.IgnoreWorldGuard.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IgnoreWorldGuard.FormatString = "True, False"
        Me.IgnoreWorldGuard.FormattingEnabled = True
        Me.IgnoreWorldGuard.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.IgnoreWorldGuard.IntegralHeight = False
        Me.IgnoreWorldGuard.Items.AddRange(New Object() {"false", "true"})
        Me.IgnoreWorldGuard.Location = New System.Drawing.Point(180, 57)
        Me.IgnoreWorldGuard.MaxLength = 5
        Me.IgnoreWorldGuard.Name = "IgnoreWorldGuard"
        Me.IgnoreWorldGuard.Size = New System.Drawing.Size(121, 23)
        Me.IgnoreWorldGuard.Sorted = True
        Me.IgnoreWorldGuard.TabIndex = 5
        Me.IgnoreWorldGuard.Text = "false"
        '
        'HitCostByDamage
        '
        Me.HitCostByDamage.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.HitCostByDamage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.HitCostByDamage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HitCostByDamage.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HitCostByDamage.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HitCostByDamage.FormatString = "True, False"
        Me.HitCostByDamage.FormattingEnabled = True
        Me.HitCostByDamage.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.HitCostByDamage.IntegralHeight = False
        Me.HitCostByDamage.Items.AddRange(New Object() {"false", "true"})
        Me.HitCostByDamage.Location = New System.Drawing.Point(180, 83)
        Me.HitCostByDamage.MaxLength = 5
        Me.HitCostByDamage.Name = "HitCostByDamage"
        Me.HitCostByDamage.Size = New System.Drawing.Size(121, 23)
        Me.HitCostByDamage.Sorted = True
        Me.HitCostByDamage.TabIndex = 6
        Me.HitCostByDamage.Text = "false"
        '
        'HasDurabilityBar
        '
        Me.HasDurabilityBar.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.HasDurabilityBar.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.HasDurabilityBar.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.HasDurabilityBar.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.HasDurabilityBar.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HasDurabilityBar.FormatString = "True, False"
        Me.HasDurabilityBar.FormattingEnabled = True
        Me.HasDurabilityBar.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.HasDurabilityBar.IntegralHeight = False
        Me.HasDurabilityBar.Items.AddRange(New Object() {"false", "true"})
        Me.HasDurabilityBar.Location = New System.Drawing.Point(180, 109)
        Me.HasDurabilityBar.MaxLength = 5
        Me.HasDurabilityBar.Name = "HasDurabilityBar"
        Me.HasDurabilityBar.Size = New System.Drawing.Size(121, 23)
        Me.HasDurabilityBar.Sorted = True
        Me.HasDurabilityBar.TabIndex = 7
        Me.HasDurabilityBar.Text = "true"
        '
        'ShowPowerText
        '
        Me.ShowPowerText.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.ShowPowerText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ShowPowerText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShowPowerText.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ShowPowerText.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowPowerText.FormatString = "True, False"
        Me.ShowPowerText.FormattingEnabled = True
        Me.ShowPowerText.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ShowPowerText.IntegralHeight = False
        Me.ShowPowerText.Items.AddRange(New Object() {"false", "true"})
        Me.ShowPowerText.Location = New System.Drawing.Point(180, 135)
        Me.ShowPowerText.MaxLength = 5
        Me.ShowPowerText.Name = "ShowPowerText"
        Me.ShowPowerText.Size = New System.Drawing.Size(121, 23)
        Me.ShowPowerText.Sorted = True
        Me.ShowPowerText.TabIndex = 13
        Me.ShowPowerText.Text = "true"
        '
        'ShowArmourLore
        '
        Me.ShowArmourLore.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.ShowArmourLore.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ShowArmourLore.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ShowArmourLore.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.ShowArmourLore.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ShowArmourLore.FormatString = "True, False"
        Me.ShowArmourLore.FormattingEnabled = True
        Me.ShowArmourLore.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.ShowArmourLore.IntegralHeight = False
        Me.ShowArmourLore.Items.AddRange(New Object() {"false", "true"})
        Me.ShowArmourLore.Location = New System.Drawing.Point(180, 161)
        Me.ShowArmourLore.MaxLength = 5
        Me.ShowArmourLore.Name = "ShowArmourLore"
        Me.ShowArmourLore.Size = New System.Drawing.Size(121, 23)
        Me.ShowArmourLore.Sorted = True
        Me.ShowArmourLore.TabIndex = 15
        Me.ShowArmourLore.Text = "false"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(9, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 18)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "HasPermission :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(9, 135)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(142, 18)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "ShowPowerText:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 18)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "IgnoreWorldGuard :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(9, 83)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(163, 18)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "HitCostByDamage :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(9, 109)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(153, 18)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "HasDurabilityBar :"
        '
        'Panel3
        '
        Me.Panel3.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel3.BackColor = System.Drawing.Color.Red
        Me.Panel3.Controls.Add(Me.ItemData)
        Me.Panel3.Controls.Add(Me.Label30)
        Me.Panel3.Controls.Add(Me.DamageMode)
        Me.Panel3.Controls.Add(Me.Item)
        Me.Panel3.Controls.Add(Me.Armour)
        Me.Panel3.Controls.Add(Me.Level)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Hand)
        Me.Panel3.Controls.Add(Me.Label26)
        Me.Panel3.Controls.Add(Me.Type)
        Me.Panel3.Controls.Add(Me.Label20)
        Me.Panel3.Controls.Add(Me.DamageMax)
        Me.Panel3.Controls.Add(Me.Label19)
        Me.Panel3.Controls.Add(Me.DamageMin)
        Me.Panel3.Controls.Add(Me.Label18)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Location = New System.Drawing.Point(8, 236)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(430, 225)
        Me.Panel3.TabIndex = 46
        '
        'ItemData
        '
        Me.ItemData.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ItemData.Location = New System.Drawing.Point(384, 130)
        Me.ItemData.Maximum = New Decimal(New Integer() {99, 0, 0, 0})
        Me.ItemData.Name = "ItemData"
        Me.ItemData.Size = New System.Drawing.Size(39, 20)
        Me.ItemData.TabIndex = 60
        '
        'Label30
        '
        Me.Label30.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.Location = New System.Drawing.Point(373, 129)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 18)
        Me.Label30.TabIndex = 59
        Me.Label30.Text = ":"
        '
        'DamageMode
        '
        Me.DamageMode.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DamageMode.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.DamageMode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.DamageMode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.DamageMode.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.DamageMode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DamageMode.FormatString = "True, False"
        Me.DamageMode.FormattingEnabled = True
        Me.DamageMode.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.DamageMode.IntegralHeight = False
        Me.DamageMode.Items.AddRange(New Object() {"ADDITIONAL", "FIXED", "VANILLA"})
        Me.DamageMode.Location = New System.Drawing.Point(176, 191)
        Me.DamageMode.MaxLength = 64
        Me.DamageMode.Name = "DamageMode"
        Me.DamageMode.Size = New System.Drawing.Size(246, 23)
        Me.DamageMode.Sorted = True
        Me.DamageMode.TabIndex = 58
        Me.DamageMode.Text = "FIXED"
        '
        'Item
        '
        Me.Item.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Item.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.Item.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Item.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Item.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Item.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Item.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Item.IntegralHeight = False
        Me.Item.Items.AddRange(New Object() {"DIAMOND_SWORD", "GOLDEN_SWORD", "IRON_SWORD", "STONE_SWORD", "WOODEN_SWORD"})
        Me.Item.Location = New System.Drawing.Point(138, 128)
        Me.Item.MaxLength = 64
        Me.Item.Name = "Item"
        Me.Item.Size = New System.Drawing.Size(235, 23)
        Me.Item.Sorted = True
        Me.Item.TabIndex = 42
        Me.Item.Text = "WOODEN_SWORD"
        '
        'Armour
        '
        Me.Armour.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Armour.Location = New System.Drawing.Point(176, 163)
        Me.Armour.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Armour.Name = "Armour"
        Me.Armour.Size = New System.Drawing.Size(120, 20)
        Me.Armour.TabIndex = 58
        '
        'Level
        '
        Me.Level.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Level.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.Level.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.Level.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Level.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Level.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Level.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Level.IntegralHeight = False
        Me.Level.Items.AddRange(New Object() {"1 - 5", "11 - 15", "16 - 20", "21 - 25", "26 - 30", "31 - 35", "36 - 40", "6 - 10"})
        Me.Level.Location = New System.Drawing.Point(176, 97)
        Me.Level.MaxLength = 64
        Me.Level.Name = "Level"
        Me.Level.Size = New System.Drawing.Size(247, 23)
        Me.Level.Sorted = True
        Me.Level.TabIndex = 40
        Me.Level.Text = "1 - 5"
        '
        'Label27
        '
        Me.Label27.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(6, 191)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(117, 18)
        Me.Label27.TabIndex = 43
        Me.Label27.Text = "DamageMode"
        '
        'Hand
        '
        Me.Hand.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Hand.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.Hand.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Hand.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Hand.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Hand.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Hand.FormatString = "True, False"
        Me.Hand.FormattingEnabled = True
        Me.Hand.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Hand.IntegralHeight = False
        Me.Hand.Items.AddRange(New Object() {"Deux Mains", "Une Main"})
        Me.Hand.Location = New System.Drawing.Point(176, 68)
        Me.Hand.MaxLength = 64
        Me.Hand.Name = "Hand"
        Me.Hand.Size = New System.Drawing.Size(247, 23)
        Me.Hand.Sorted = True
        Me.Hand.TabIndex = 38
        Me.Hand.Text = "Une Main"
        '
        'Label26
        '
        Me.Label26.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(6, 163)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(77, 18)
        Me.Label26.TabIndex = 42
        Me.Label26.Text = "Armour :"
        '
        'Type
        '
        Me.Type.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Type.AutoCompleteCustomSource.AddRange(New String() {"True", "False"})
        Me.Type.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.Type.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Type.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.Type.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Type.FormatString = "True, False"
        Me.Type.FormattingEnabled = True
        Me.Type.ImeMode = System.Windows.Forms.ImeMode.[On]
        Me.Type.IntegralHeight = False
        Me.Type.Items.AddRange(New Object() {"Arbalète", "Bâton", "Couteau", "Epée", "Hache", "Magie", "Masse"})
        Me.Type.Location = New System.Drawing.Point(177, 39)
        Me.Type.MaxLength = 64
        Me.Type.Name = "Type"
        Me.Type.Size = New System.Drawing.Size(246, 23)
        Me.Type.Sorted = True
        Me.Type.TabIndex = 23
        Me.Type.Text = "Epée"
        '
        'Label20
        '
        Me.Label20.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(5, 133)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(52, 18)
        Me.Label20.TabIndex = 41
        Me.Label20.Text = "Item :"
        '
        'DamageMax
        '
        Me.DamageMax.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DamageMax.Location = New System.Drawing.Point(302, 7)
        Me.DamageMax.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DamageMax.Name = "DamageMax"
        Me.DamageMax.Size = New System.Drawing.Size(120, 20)
        Me.DamageMax.TabIndex = 19
        Me.DamageMax.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'Label19
        '
        Me.Label19.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(5, 98)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(60, 18)
        Me.Label19.TabIndex = 39
        Me.Label19.Text = "Level :"
        '
        'DamageMin
        '
        Me.DamageMin.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DamageMin.Location = New System.Drawing.Point(177, 7)
        Me.DamageMin.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DamageMin.Name = "DamageMin"
        Me.DamageMin.Size = New System.Drawing.Size(120, 20)
        Me.DamageMin.TabIndex = 18
        Me.DamageMin.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(6, 68)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(59, 18)
        Me.Label18.TabIndex = 37
        Me.Label18.Text = "Hand :"
        '
        'Label11
        '
        Me.Label11.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 39)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(52, 18)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Type:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(5, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(166, 18)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Damage (Min, Max) :"
        '
        'Panel2
        '
        Me.Panel2.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Controls.Add(Me.DurabilityUpper)
        Me.Panel2.Controls.Add(Me.DurabilityLower)
        Me.Panel2.Controls.Add(Me.Label25)
        Me.Panel2.Controls.Add(Me.Label24)
        Me.Panel2.Controls.Add(Me.Label15)
        Me.Panel2.Controls.Add(Me.Label14)
        Me.Panel2.Controls.Add(Me.Label13)
        Me.Panel2.Controls.Add(Me.Durability)
        Me.Panel2.Controls.Add(Me.HitCost)
        Me.Panel2.Controls.Add(Me.HittingCost)
        Me.Panel2.Controls.Add(Me.BlockBreakingCost)
        Me.Panel2.Controls.Add(Me.Label17)
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Controls.Add(Me.Button1)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(8, 6)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(430, 225)
        Me.Panel2.TabIndex = 45
        '
        'DurabilityUpper
        '
        Me.DurabilityUpper.Location = New System.Drawing.Point(209, 177)
        Me.DurabilityUpper.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DurabilityUpper.Name = "DurabilityUpper"
        Me.DurabilityUpper.Size = New System.Drawing.Size(120, 20)
        Me.DurabilityUpper.TabIndex = 59
        '
        'DurabilityLower
        '
        Me.DurabilityLower.Location = New System.Drawing.Point(209, 151)
        Me.DurabilityLower.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.DurabilityLower.Name = "DurabilityLower"
        Me.DurabilityLower.Size = New System.Drawing.Size(120, 20)
        Me.DurabilityLower.TabIndex = 57
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(5, 179)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(198, 18)
        Me.Label25.TabIndex = 58
        Me.Label25.Text = "DurabilityUpperBound  :"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(5, 153)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(191, 18)
        Me.Label24.TabIndex = 57
        Me.Label24.Text = "DurabilityLowerBound:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(5, 124)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(171, 18)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "BlockBreakingCost :"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(5, 95)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 18)
        Me.Label14.TabIndex = 27
        Me.Label14.Text = "HittingCost :"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(5, 62)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(76, 18)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "HitCost :"
        '
        'Durability
        '
        Me.Durability.Location = New System.Drawing.Point(209, 26)
        Me.Durability.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.Durability.Name = "Durability"
        Me.Durability.Size = New System.Drawing.Size(120, 20)
        Me.Durability.TabIndex = 31
        Me.Durability.Value = New Decimal(New Integer() {500, 0, 0, 0})
        '
        'HitCost
        '
        Me.HitCost.Location = New System.Drawing.Point(209, 60)
        Me.HitCost.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.HitCost.Name = "HitCost"
        Me.HitCost.Size = New System.Drawing.Size(120, 20)
        Me.HitCost.TabIndex = 33
        '
        'HittingCost
        '
        Me.HittingCost.Location = New System.Drawing.Point(209, 93)
        Me.HittingCost.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.HittingCost.Name = "HittingCost"
        Me.HittingCost.Size = New System.Drawing.Size(120, 20)
        Me.HittingCost.TabIndex = 34
        Me.HittingCost.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'BlockBreakingCost
        '
        Me.BlockBreakingCost.Location = New System.Drawing.Point(209, 122)
        Me.BlockBreakingCost.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.BlockBreakingCost.Name = "BlockBreakingCost"
        Me.BlockBreakingCost.Size = New System.Drawing.Size(120, 20)
        Me.BlockBreakingCost.TabIndex = 35
        Me.BlockBreakingCost.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(5, 26)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(150, 18)
        Me.Label17.TabIndex = 30
        Me.Label17.Text = "DefaultDurability :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(5, 8)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(153, 18)
        Me.Label16.TabIndex = 29
        Me.Label16.Text = "Maxdurability AND"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(334, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(90, 34)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "RANDOMIZER (100 - 1250)"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel1.Controls.Add(Me.DescriptionL6)
        Me.Panel1.Controls.Add(Me.DescriptionL5)
        Me.Panel1.Controls.Add(Me.DescriptionL4)
        Me.Panel1.Controls.Add(Me.DescriptionL3)
        Me.Panel1.Controls.Add(Me.DescriptionL2)
        Me.Panel1.Controls.Add(Me.ID)
        Me.Panel1.Controls.Add(Me.Display)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Controls.Add(Me.DescriptionL1)
        Me.Panel1.Location = New System.Drawing.Point(444, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(325, 225)
        Me.Panel1.TabIndex = 21
        '
        'DescriptionL6
        '
        Me.DescriptionL6.Location = New System.Drawing.Point(3, 195)
        Me.DescriptionL6.MaxLength = 10512
        Me.DescriptionL6.Multiline = False
        Me.DescriptionL6.Name = "DescriptionL6"
        Me.DescriptionL6.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.DescriptionL6.Size = New System.Drawing.Size(315, 18)
        Me.DescriptionL6.TabIndex = 30
        Me.DescriptionL6.TabStop = False
        Me.DescriptionL6.Text = ""
        '
        'DescriptionL5
        '
        Me.DescriptionL5.Location = New System.Drawing.Point(3, 171)
        Me.DescriptionL5.MaxLength = 10512
        Me.DescriptionL5.Multiline = False
        Me.DescriptionL5.Name = "DescriptionL5"
        Me.DescriptionL5.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.DescriptionL5.Size = New System.Drawing.Size(315, 18)
        Me.DescriptionL5.TabIndex = 29
        Me.DescriptionL5.TabStop = False
        Me.DescriptionL5.Text = ""
        '
        'DescriptionL4
        '
        Me.DescriptionL4.Location = New System.Drawing.Point(3, 147)
        Me.DescriptionL4.MaxLength = 10512
        Me.DescriptionL4.Multiline = False
        Me.DescriptionL4.Name = "DescriptionL4"
        Me.DescriptionL4.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.DescriptionL4.Size = New System.Drawing.Size(315, 18)
        Me.DescriptionL4.TabIndex = 28
        Me.DescriptionL4.TabStop = False
        Me.DescriptionL4.Text = ""
        '
        'DescriptionL3
        '
        Me.DescriptionL3.Location = New System.Drawing.Point(3, 123)
        Me.DescriptionL3.MaxLength = 10512
        Me.DescriptionL3.Multiline = False
        Me.DescriptionL3.Name = "DescriptionL3"
        Me.DescriptionL3.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.DescriptionL3.Size = New System.Drawing.Size(315, 18)
        Me.DescriptionL3.TabIndex = 27
        Me.DescriptionL3.TabStop = False
        Me.DescriptionL3.Text = ""
        '
        'DescriptionL2
        '
        Me.DescriptionL2.Location = New System.Drawing.Point(3, 99)
        Me.DescriptionL2.MaxLength = 10512
        Me.DescriptionL2.Multiline = False
        Me.DescriptionL2.Name = "DescriptionL2"
        Me.DescriptionL2.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.DescriptionL2.Size = New System.Drawing.Size(315, 18)
        Me.DescriptionL2.TabIndex = 26
        Me.DescriptionL2.TabStop = False
        Me.DescriptionL2.Text = ""
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(123, 30)
        Me.ID.MaxLength = 64
        Me.ID.Multiline = False
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(195, 23)
        Me.ID.TabIndex = 23
        Me.ID.Text = "1-1-1"
        '
        'Display
        '
        Me.Display.Location = New System.Drawing.Point(123, 4)
        Me.Display.MaxLength = 512
        Me.Display.Multiline = False
        Me.Display.Name = "Display"
        Me.Display.Size = New System.Drawing.Size(195, 23)
        Me.Display.TabIndex = 22
        Me.Display.Text = "Sword"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(2, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(121, 18)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Display Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(2, 28)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 18)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "ID Name:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(3, 55)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(109, 18)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "Description :"
        '
        'DescriptionL1
        '
        Me.DescriptionL1.Location = New System.Drawing.Point(3, 75)
        Me.DescriptionL1.MaxLength = 10512
        Me.DescriptionL1.Multiline = False
        Me.DescriptionL1.Name = "DescriptionL1"
        Me.DescriptionL1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None
        Me.DescriptionL1.Size = New System.Drawing.Size(315, 18)
        Me.DescriptionL1.TabIndex = 25
        Me.DescriptionL1.TabStop = False
        Me.DescriptionL1.Text = ""
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.General)
        Me.TabControl1.Controls.Add(Me.Powers)
        Me.TabControl1.Controls.Add(Me.SkillAPI)
        Me.TabControl1.Location = New System.Drawing.Point(0, 23)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(783, 493)
        Me.TabControl1.TabIndex = 57
        '
        'RemovePower
        '
        Me.RemovePower.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RemovePower.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.RemovePower.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.RemovePower.Location = New System.Drawing.Point(600, 94)
        Me.RemovePower.Name = "RemovePower"
        Me.RemovePower.Size = New System.Drawing.Size(75, 75)
        Me.RemovePower.TabIndex = 22
        Me.RemovePower.Text = "REMOVE POWER"
        Me.RemovePower.UseVisualStyleBackColor = False
        '
        'RPGitemEditor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(781, 681)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.Panel5)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "RPGitemEditor"
        Me.Text = "RPGitem Editor"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Powers.ResumeLayout(False)
        Me.MenuPower.ResumeLayout(False)
        Me.General.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.ItemData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Armour, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DamageMin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DurabilityUpper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DurabilityLower, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Durability, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HitCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HittingCost, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlockBreakingCost, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents UID As RichTextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FilleToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label21 As Label
    Friend WithEvents MinecraftVersion As ComboBox
    Friend WithEvents Label23 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Author As RichTextBox
    Friend WithEvents Note As RichTextBox
    Friend WithEvents SaveToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents License As RichTextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents PluginSerial As RichTextBox
    Friend WithEvents Label29 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents SkillAPI As TabPage
    Friend WithEvents Powers As TabPage
    Friend WithEvents MenuPower As Panel
    Friend WithEvents ButtonPower10 As Button
    Friend WithEvents ButtonPower9 As Button
    Friend WithEvents ButtonPower11 As Button
    Friend WithEvents ButtonPower20 As Button
    Friend WithEvents ButtonPower8 As Button
    Friend WithEvents ButtonPower12 As Button
    Friend WithEvents ButtonPower19 As Button
    Friend WithEvents ButtonPower18 As Button
    Friend WithEvents ButtonPower7 As Button
    Friend WithEvents ButtonPower6 As Button
    Friend WithEvents ButtonPower13 As Button
    Friend WithEvents ButtonPower17 As Button
    Friend WithEvents ButtonPower16 As Button
    Friend WithEvents ButtonPower14 As Button
    Friend WithEvents ButtonPower5 As Button
    Friend WithEvents ButtonPower15 As Button
    Friend WithEvents ButtonPower4 As Button
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents ButtonPower3 As Button
    Friend WithEvents ButtonPower2 As Button
    Friend WithEvents ButtonPower1 As Button
    Friend WithEvents General As TabPage
    Friend WithEvents Panel4 As Panel
    Friend WithEvents ForceBar As ComboBox
    Friend WithEvents Label31 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents AlwaysAllowMelee As ComboBox
    Friend WithEvents HasPermission As ComboBox
    Friend WithEvents IgnoreWorldGuard As ComboBox
    Friend WithEvents HitCostByDamage As ComboBox
    Friend WithEvents HasDurabilityBar As ComboBox
    Friend WithEvents ShowPowerText As ComboBox
    Friend WithEvents ShowArmourLore As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ItemData As NumericUpDown
    Friend WithEvents Label30 As Label
    Friend WithEvents DamageMode As ComboBox
    Friend WithEvents Item As ComboBox
    Friend WithEvents Armour As NumericUpDown
    Friend WithEvents Level As ComboBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Hand As ComboBox
    Friend WithEvents Label26 As Label
    Friend WithEvents Type As ComboBox
    Friend WithEvents Label20 As Label
    Friend WithEvents DamageMax As NumericUpDown
    Friend WithEvents Label19 As Label
    Friend WithEvents DamageMin As NumericUpDown
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DurabilityUpper As NumericUpDown
    Friend WithEvents DurabilityLower As NumericUpDown
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Durability As NumericUpDown
    Friend WithEvents HitCost As NumericUpDown
    Friend WithEvents HittingCost As NumericUpDown
    Friend WithEvents BlockBreakingCost As NumericUpDown
    Friend WithEvents Label17 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DescriptionL6 As RichTextBox
    Friend WithEvents DescriptionL5 As RichTextBox
    Friend WithEvents DescriptionL4 As RichTextBox
    Friend WithEvents DescriptionL3 As RichTextBox
    Friend WithEvents DescriptionL2 As RichTextBox
    Friend WithEvents ID As RichTextBox
    Friend WithEvents Display As RichTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents DescriptionL1 As RichTextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents RemovePower As Button
End Class
