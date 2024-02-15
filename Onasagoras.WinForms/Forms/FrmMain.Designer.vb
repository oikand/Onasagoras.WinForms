<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMain
    Inherits MaterialSkin.Controls.MaterialForm

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMain))
        TabCtrMenu = New MaterialSkin.Controls.MaterialTabControl()
        TabPgHome = New TabPage()
        LblHomePersonnel = New MaterialSkin.Controls.MaterialLabel()
        ImgLstMenu = New ImageList(components)
        LblHomeTitle = New MaterialSkin.Controls.MaterialLabel()
        PicBoxLogo = New PictureBox()
        TabPgPersonnel = New TabPage()
        SplitCntPersonnel = New SplitContainer()
        LstViewPersonnel = New BrightIdeasSoftware.ObjectListView()
        ColPersID = New BrightIdeasSoftware.OLVColumn()
        ColPersFirstName = New BrightIdeasSoftware.OLVColumn()
        ColPersLastName = New BrightIdeasSoftware.OLVColumn()
        ColPersMilitaryUnitStructureID = New BrightIdeasSoftware.OLVColumn()
        ColPersBirthDate = New BrightIdeasSoftware.OLVColumn()
        ColPersBloodTypesID = New BrightIdeasSoftware.OLVColumn()
        ColPersIdentityCard = New BrightIdeasSoftware.OLVColumn()
        ColPersMilitaryCard = New BrightIdeasSoftware.OLVColumn()
        ColPersFatherName = New BrightIdeasSoftware.OLVColumn()
        ColPersMotherName = New BrightIdeasSoftware.OLVColumn()
        ColPersProfession = New BrightIdeasSoftware.OLVColumn()
        ColPersImageFileName = New BrightIdeasSoftware.OLVColumn()
        ExpPanSearchPersonnel = New MaterialSkin.Controls.MaterialExpansionPanel()
        TxtSrchPerMilitaryID = New MaterialSkin.Controls.MaterialTextBox()
        TxtSrchPerID = New MaterialSkin.Controls.MaterialTextBox()
        TxtSrchPerLastName = New MaterialSkin.Controls.MaterialTextBox()
        TxtSrchPerFirstName = New MaterialSkin.Controls.MaterialTextBox()
        TabCtrPersonnel = New TabControl()
        TabPgPersAddresses = New TabPage()
        TabPgPersCommunication = New TabPage()
        TabPgPersEmergencyContacts = New TabPage()
        TabPgPersExpendableEquipment = New TabPage()
        TabPgPersMedicalCerts = New TabPage()
        TabPgPersMedicalConditions = New TabPage()
        TabPgPersMilitaryRanks = New TabPage()
        TabPgPersSpeakingLanguages = New TabPage()
        TabPgPersStatuses = New TabPage()
        TabPgPersSecondaryEquipment = New TabPage()
        TabPgPersSpecialSkills = New TabPage()
        TabPgPersVehicles = New TabPage()
        TabPgPersWeapons = New TabPage()
        TabPgUnitStructure = New TabPage()
        TabPgTraining = New TabPage()
        TabPgSchedule = New TabPage()
        TabPgParticipation = New TabPage()
        TabPgMissions = New TabPage()
        TabPgStorage = New TabPage()
        TabPgSetup = New TabPage()
        TabPgExit = New TabPage()
        TabCtrMenu.SuspendLayout()
        TabPgHome.SuspendLayout()
        CType(PicBoxLogo, ComponentModel.ISupportInitialize).BeginInit()
        TabPgPersonnel.SuspendLayout()
        CType(SplitCntPersonnel, ComponentModel.ISupportInitialize).BeginInit()
        SplitCntPersonnel.Panel1.SuspendLayout()
        SplitCntPersonnel.Panel2.SuspendLayout()
        SplitCntPersonnel.SuspendLayout()
        CType(LstViewPersonnel, ComponentModel.ISupportInitialize).BeginInit()
        ExpPanSearchPersonnel.SuspendLayout()
        TabCtrPersonnel.SuspendLayout()
        SuspendLayout()
        ' 
        ' TabCtrMenu
        ' 
        TabCtrMenu.Controls.Add(TabPgHome)
        TabCtrMenu.Controls.Add(TabPgPersonnel)
        TabCtrMenu.Controls.Add(TabPgUnitStructure)
        TabCtrMenu.Controls.Add(TabPgTraining)
        TabCtrMenu.Controls.Add(TabPgSchedule)
        TabCtrMenu.Controls.Add(TabPgParticipation)
        TabCtrMenu.Controls.Add(TabPgMissions)
        TabCtrMenu.Controls.Add(TabPgStorage)
        TabCtrMenu.Controls.Add(TabPgSetup)
        TabCtrMenu.Controls.Add(TabPgExit)
        TabCtrMenu.Depth = 0
        TabCtrMenu.Dock = DockStyle.Fill
        TabCtrMenu.ImageList = ImgLstMenu
        TabCtrMenu.Location = New Point(3, 64)
        TabCtrMenu.MouseState = MaterialSkin.MouseState.HOVER
        TabCtrMenu.Multiline = True
        TabCtrMenu.Name = "TabCtrMenu"
        TabCtrMenu.SelectedIndex = 0
        TabCtrMenu.Size = New Size(1277, 733)
        TabCtrMenu.TabIndex = 0
        ' 
        ' TabPgHome
        ' 
        TabPgHome.BackColor = Color.White
        TabPgHome.Controls.Add(LblHomePersonnel)
        TabPgHome.Controls.Add(LblHomeTitle)
        TabPgHome.Controls.Add(PicBoxLogo)
        TabPgHome.ImageKey = "icons8-home-48.png"
        TabPgHome.Location = New Point(4, 39)
        TabPgHome.Name = "TabPgHome"
        TabPgHome.Size = New Size(1269, 690)
        TabPgHome.TabIndex = 9
        TabPgHome.Text = "Home"
        ' 
        ' LblHomePersonnel
        ' 
        LblHomePersonnel.AutoSize = True
        LblHomePersonnel.Depth = 0
        LblHomePersonnel.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        LblHomePersonnel.FontType = MaterialSkin.MaterialSkinManager.fontType.Subtitle1
        LblHomePersonnel.ImageIndex = 1
        LblHomePersonnel.ImageList = ImgLstMenu
        LblHomePersonnel.Location = New Point(338, 209)
        LblHomePersonnel.MouseState = MaterialSkin.MouseState.HOVER
        LblHomePersonnel.Name = "LblHomePersonnel"
        LblHomePersonnel.Size = New Size(255, 19)
        LblHomePersonnel.TabIndex = 2
        LblHomePersonnel.Text = "Προσωπικό - Στοιχεία προσωπικού"
        ' 
        ' ImgLstMenu
        ' 
        ImgLstMenu.ColorDepth = ColorDepth.Depth32Bit
        ImgLstMenu.ImageStream = CType(resources.GetObject("ImgLstMenu.ImageStream"), ImageListStreamer)
        ImgLstMenu.TransparentColor = Color.Transparent
        ImgLstMenu.Images.SetKeyName(0, "icons8-home-48.png")
        ImgLstMenu.Images.SetKeyName(1, "icons8-users-48.png")
        ImgLstMenu.Images.SetKeyName(2, "icons8-structure-48.png")
        ImgLstMenu.Images.SetKeyName(3, "icons8-classroom-48.png")
        ImgLstMenu.Images.SetKeyName(4, "icons8-schedule-48.png")
        ImgLstMenu.Images.SetKeyName(5, "icons8-student-registration-48.png")
        ImgLstMenu.Images.SetKeyName(6, "icons8-mission-48.png")
        ImgLstMenu.Images.SetKeyName(7, "icons8-warehouse-48.png")
        ImgLstMenu.Images.SetKeyName(8, "icons8-setup-48.png")
        ImgLstMenu.Images.SetKeyName(9, "icons8-exit-48.png")
        ' 
        ' LblHomeTitle
        ' 
        LblHomeTitle.Anchor = AnchorStyles.Top
        LblHomeTitle.AutoSize = True
        LblHomeTitle.BackColor = Color.Transparent
        LblHomeTitle.Depth = 0
        LblHomeTitle.Font = New Font("Roboto Light", 60.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        LblHomeTitle.FontType = MaterialSkin.MaterialSkinManager.fontType.H2
        LblHomeTitle.ForeColor = SystemColors.ControlText
        LblHomeTitle.Location = New Point(209, 13)
        LblHomeTitle.MouseState = MaterialSkin.MouseState.HOVER
        LblHomeTitle.Name = "LblHomeTitle"
        LblHomeTitle.Size = New Size(1031, 72)
        LblHomeTitle.TabIndex = 1
        LblHomeTitle.Text = "Ονασαγόρας - Διαχείριση Προσωπικού"
        LblHomeTitle.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' PicBoxLogo
        ' 
        PicBoxLogo.Anchor = AnchorStyles.Top
        PicBoxLogo.Image = CType(resources.GetObject("PicBoxLogo.Image"), Image)
        PicBoxLogo.Location = New Point(3, 3)
        PicBoxLogo.Name = "PicBoxLogo"
        PicBoxLogo.Size = New Size(190, 148)
        PicBoxLogo.SizeMode = PictureBoxSizeMode.Zoom
        PicBoxLogo.TabIndex = 0
        PicBoxLogo.TabStop = False
        ' 
        ' TabPgPersonnel
        ' 
        TabPgPersonnel.BackColor = Color.White
        TabPgPersonnel.Controls.Add(SplitCntPersonnel)
        TabPgPersonnel.ImageKey = "icons8-users-48.png"
        TabPgPersonnel.Location = New Point(4, 39)
        TabPgPersonnel.Name = "TabPgPersonnel"
        TabPgPersonnel.Padding = New Padding(3)
        TabPgPersonnel.Size = New Size(1269, 690)
        TabPgPersonnel.TabIndex = 0
        TabPgPersonnel.Text = " Personnel"
        ' 
        ' SplitCntPersonnel
        ' 
        SplitCntPersonnel.Dock = DockStyle.Fill
        SplitCntPersonnel.Location = New Point(3, 3)
        SplitCntPersonnel.Name = "SplitCntPersonnel"
        SplitCntPersonnel.Orientation = Orientation.Horizontal
        ' 
        ' SplitCntPersonnel.Panel1
        ' 
        SplitCntPersonnel.Panel1.Controls.Add(LstViewPersonnel)
        SplitCntPersonnel.Panel1.Controls.Add(ExpPanSearchPersonnel)
        ' 
        ' SplitCntPersonnel.Panel2
        ' 
        SplitCntPersonnel.Panel2.Controls.Add(TabCtrPersonnel)
        SplitCntPersonnel.Size = New Size(1263, 684)
        SplitCntPersonnel.SplitterDistance = 342
        SplitCntPersonnel.TabIndex = 0
        ' 
        ' LstViewPersonnel
        ' 
        LstViewPersonnel.Columns.AddRange(New ColumnHeader() {ColPersID, ColPersFirstName, ColPersLastName, ColPersMilitaryUnitStructureID, ColPersBirthDate, ColPersBloodTypesID, ColPersIdentityCard, ColPersMilitaryCard, ColPersFatherName, ColPersMotherName, ColPersProfession, ColPersImageFileName})
        LstViewPersonnel.Dock = DockStyle.Fill
        LstViewPersonnel.Location = New Point(0, 200)
        LstViewPersonnel.Name = "LstViewPersonnel"
        LstViewPersonnel.Size = New Size(1263, 142)
        LstViewPersonnel.TabIndex = 1
        LstViewPersonnel.View = View.Details
        ' 
        ' ColPersID
        ' 
        ColPersID.AspectName = "ID"
        ColPersID.IsVisible = False
        ColPersID.Text = "ID"
        ' 
        ' ColPersFirstName
        ' 
        ColPersFirstName.AspectName = "FirstName"
        ColPersFirstName.Text = "First Name"
        ' 
        ' ColPersLastName
        ' 
        ColPersLastName.AspectName = "LastName"
        ColPersLastName.Text = "Last Name"
        ' 
        ' ColPersMilitaryUnitStructureID
        ' 
        ColPersMilitaryUnitStructureID.AspectName = "MilitaryUnitStructureID"
        ColPersMilitaryUnitStructureID.Text = "Military Grade"
        ' 
        ' ColPersBirthDate
        ' 
        ColPersBirthDate.AspectName = "BirthDate"
        ColPersBirthDate.AspectToStringFormat = "0:d"
        ColPersBirthDate.Text = "Birth Date"
        ' 
        ' ColPersBloodTypesID
        ' 
        ColPersBloodTypesID.AspectName = "BloodTypesID"
        ColPersBloodTypesID.Text = "Blood Type"
        ' 
        ' ColPersIdentityCard
        ' 
        ColPersIdentityCard.AspectName = "IdentityCard"
        ColPersIdentityCard.Text = "Identity No"
        ' 
        ' ColPersMilitaryCard
        ' 
        ColPersMilitaryCard.AspectName = "MilitaryCard"
        ColPersMilitaryCard.Text = "Military ID"
        ' 
        ' ColPersFatherName
        ' 
        ColPersFatherName.AspectName = "FatherName"
        ColPersFatherName.Text = "Father Name"
        ' 
        ' ColPersMotherName
        ' 
        ColPersMotherName.AspectName = "MotherName"
        ColPersMotherName.Text = "Mother Name"
        ' 
        ' ColPersProfession
        ' 
        ColPersProfession.AspectName = "Profession"
        ColPersProfession.Text = "Profession"
        ' 
        ' ColPersImageFileName
        ' 
        ColPersImageFileName.AspectName = "ImageFileName"
        ColPersImageFileName.IsVisible = False
        ColPersImageFileName.Text = "Image FileName"
        ' 
        ' ExpPanSearchPersonnel
        ' 
        ExpPanSearchPersonnel.BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(255))
        ExpPanSearchPersonnel.CancelButtonText = "Clear"
        ExpPanSearchPersonnel.Controls.Add(TxtSrchPerMilitaryID)
        ExpPanSearchPersonnel.Controls.Add(TxtSrchPerID)
        ExpPanSearchPersonnel.Controls.Add(TxtSrchPerLastName)
        ExpPanSearchPersonnel.Controls.Add(TxtSrchPerFirstName)
        ExpPanSearchPersonnel.Depth = 0
        ExpPanSearchPersonnel.Description = ""
        ExpPanSearchPersonnel.Dock = DockStyle.Top
        ExpPanSearchPersonnel.ExpandHeight = 200
        ExpPanSearchPersonnel.Font = New Font("Microsoft Sans Serif", 14.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        ExpPanSearchPersonnel.ForeColor = Color.FromArgb(CByte(222), CByte(0), CByte(0), CByte(0))
        ExpPanSearchPersonnel.Location = New Point(0, 0)
        ExpPanSearchPersonnel.Margin = New Padding(3, 16, 3, 16)
        ExpPanSearchPersonnel.MouseState = MaterialSkin.MouseState.HOVER
        ExpPanSearchPersonnel.Name = "ExpPanSearchPersonnel"
        ExpPanSearchPersonnel.Padding = New Padding(24, 64, 24, 16)
        ExpPanSearchPersonnel.Size = New Size(1263, 200)
        ExpPanSearchPersonnel.TabIndex = 0
        ExpPanSearchPersonnel.Title = "Search Personnel"
        ExpPanSearchPersonnel.ValidationButtonEnable = True
        ExpPanSearchPersonnel.ValidationButtonText = "Search"
        ' 
        ' TxtSrchPerMilitaryID
        ' 
        TxtSrchPerMilitaryID.AnimateReadOnly = False
        TxtSrchPerMilitaryID.BorderStyle = BorderStyle.None
        TxtSrchPerMilitaryID.Depth = 0
        TxtSrchPerMilitaryID.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtSrchPerMilitaryID.Hint = "Military ID"
        TxtSrchPerMilitaryID.LeadingIcon = Nothing
        TxtSrchPerMilitaryID.Location = New Point(831, 67)
        TxtSrchPerMilitaryID.MaxLength = 50
        TxtSrchPerMilitaryID.MouseState = MaterialSkin.MouseState.OUT
        TxtSrchPerMilitaryID.Multiline = False
        TxtSrchPerMilitaryID.Name = "TxtSrchPerMilitaryID"
        TxtSrchPerMilitaryID.Size = New Size(240, 50)
        TxtSrchPerMilitaryID.TabIndex = 5
        TxtSrchPerMilitaryID.Text = ""
        TxtSrchPerMilitaryID.TrailingIcon = Nothing
        ' 
        ' TxtSrchPerID
        ' 
        TxtSrchPerID.AnimateReadOnly = False
        TxtSrchPerID.BorderStyle = BorderStyle.None
        TxtSrchPerID.Depth = 0
        TxtSrchPerID.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtSrchPerID.Hint = "Identity No"
        TxtSrchPerID.LeadingIcon = Nothing
        TxtSrchPerID.Location = New Point(562, 67)
        TxtSrchPerID.MaxLength = 50
        TxtSrchPerID.MouseState = MaterialSkin.MouseState.OUT
        TxtSrchPerID.Multiline = False
        TxtSrchPerID.Name = "TxtSrchPerID"
        TxtSrchPerID.Size = New Size(240, 50)
        TxtSrchPerID.TabIndex = 4
        TxtSrchPerID.Text = ""
        TxtSrchPerID.TrailingIcon = Nothing
        ' 
        ' TxtSrchPerLastName
        ' 
        TxtSrchPerLastName.AnimateReadOnly = False
        TxtSrchPerLastName.BorderStyle = BorderStyle.None
        TxtSrchPerLastName.Depth = 0
        TxtSrchPerLastName.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtSrchPerLastName.Hint = "Last Name"
        TxtSrchPerLastName.LeadingIcon = Nothing
        TxtSrchPerLastName.Location = New Point(292, 67)
        TxtSrchPerLastName.MaxLength = 50
        TxtSrchPerLastName.MouseState = MaterialSkin.MouseState.OUT
        TxtSrchPerLastName.Multiline = False
        TxtSrchPerLastName.Name = "TxtSrchPerLastName"
        TxtSrchPerLastName.Size = New Size(240, 50)
        TxtSrchPerLastName.TabIndex = 3
        TxtSrchPerLastName.Text = ""
        TxtSrchPerLastName.TrailingIcon = Nothing
        ' 
        ' TxtSrchPerFirstName
        ' 
        TxtSrchPerFirstName.AnimateReadOnly = False
        TxtSrchPerFirstName.BorderStyle = BorderStyle.None
        TxtSrchPerFirstName.Depth = 0
        TxtSrchPerFirstName.Font = New Font("Roboto", 16.0F, FontStyle.Regular, GraphicsUnit.Pixel)
        TxtSrchPerFirstName.Hint = "First Name"
        TxtSrchPerFirstName.LeadingIcon = Nothing
        TxtSrchPerFirstName.Location = New Point(27, 67)
        TxtSrchPerFirstName.MaxLength = 50
        TxtSrchPerFirstName.MouseState = MaterialSkin.MouseState.OUT
        TxtSrchPerFirstName.Multiline = False
        TxtSrchPerFirstName.Name = "TxtSrchPerFirstName"
        TxtSrchPerFirstName.Size = New Size(240, 50)
        TxtSrchPerFirstName.TabIndex = 2
        TxtSrchPerFirstName.Text = ""
        TxtSrchPerFirstName.TrailingIcon = Nothing
        ' 
        ' TabCtrPersonnel
        ' 
        TabCtrPersonnel.Controls.Add(TabPgPersAddresses)
        TabCtrPersonnel.Controls.Add(TabPgPersCommunication)
        TabCtrPersonnel.Controls.Add(TabPgPersEmergencyContacts)
        TabCtrPersonnel.Controls.Add(TabPgPersExpendableEquipment)
        TabCtrPersonnel.Controls.Add(TabPgPersMedicalCerts)
        TabCtrPersonnel.Controls.Add(TabPgPersMedicalConditions)
        TabCtrPersonnel.Controls.Add(TabPgPersMilitaryRanks)
        TabCtrPersonnel.Controls.Add(TabPgPersSpeakingLanguages)
        TabCtrPersonnel.Controls.Add(TabPgPersStatuses)
        TabCtrPersonnel.Controls.Add(TabPgPersSecondaryEquipment)
        TabCtrPersonnel.Controls.Add(TabPgPersSpecialSkills)
        TabCtrPersonnel.Controls.Add(TabPgPersVehicles)
        TabCtrPersonnel.Controls.Add(TabPgPersWeapons)
        TabCtrPersonnel.Dock = DockStyle.Fill
        TabCtrPersonnel.Location = New Point(0, 0)
        TabCtrPersonnel.Multiline = True
        TabCtrPersonnel.Name = "TabCtrPersonnel"
        TabCtrPersonnel.SelectedIndex = 0
        TabCtrPersonnel.Size = New Size(1263, 338)
        TabCtrPersonnel.TabIndex = 0
        ' 
        ' TabPgPersAddresses
        ' 
        TabPgPersAddresses.BackColor = Color.White
        TabPgPersAddresses.Location = New Point(4, 24)
        TabPgPersAddresses.Name = "TabPgPersAddresses"
        TabPgPersAddresses.Padding = New Padding(3)
        TabPgPersAddresses.Size = New Size(1255, 310)
        TabPgPersAddresses.TabIndex = 0
        TabPgPersAddresses.Text = "Addresses"
        ' 
        ' TabPgPersCommunication
        ' 
        TabPgPersCommunication.BackColor = Color.White
        TabPgPersCommunication.Location = New Point(4, 24)
        TabPgPersCommunication.Name = "TabPgPersCommunication"
        TabPgPersCommunication.Padding = New Padding(3)
        TabPgPersCommunication.Size = New Size(1255, 310)
        TabPgPersCommunication.TabIndex = 1
        TabPgPersCommunication.Text = "Communication"
        ' 
        ' TabPgPersEmergencyContacts
        ' 
        TabPgPersEmergencyContacts.BackColor = Color.White
        TabPgPersEmergencyContacts.Location = New Point(4, 24)
        TabPgPersEmergencyContacts.Name = "TabPgPersEmergencyContacts"
        TabPgPersEmergencyContacts.Size = New Size(1255, 310)
        TabPgPersEmergencyContacts.TabIndex = 2
        TabPgPersEmergencyContacts.Text = "Emergency Contacts"
        ' 
        ' TabPgPersExpendableEquipment
        ' 
        TabPgPersExpendableEquipment.BackColor = Color.White
        TabPgPersExpendableEquipment.Location = New Point(4, 24)
        TabPgPersExpendableEquipment.Name = "TabPgPersExpendableEquipment"
        TabPgPersExpendableEquipment.Size = New Size(1255, 310)
        TabPgPersExpendableEquipment.TabIndex = 3
        TabPgPersExpendableEquipment.Text = "Expendable Equipment"
        ' 
        ' TabPgPersMedicalCerts
        ' 
        TabPgPersMedicalCerts.BackColor = Color.White
        TabPgPersMedicalCerts.Location = New Point(4, 24)
        TabPgPersMedicalCerts.Name = "TabPgPersMedicalCerts"
        TabPgPersMedicalCerts.Size = New Size(1255, 310)
        TabPgPersMedicalCerts.TabIndex = 4
        TabPgPersMedicalCerts.Text = "Medical Certs"
        ' 
        ' TabPgPersMedicalConditions
        ' 
        TabPgPersMedicalConditions.BackColor = Color.White
        TabPgPersMedicalConditions.Location = New Point(4, 24)
        TabPgPersMedicalConditions.Name = "TabPgPersMedicalConditions"
        TabPgPersMedicalConditions.Size = New Size(1255, 310)
        TabPgPersMedicalConditions.TabIndex = 5
        TabPgPersMedicalConditions.Text = "Medical Conditions"
        ' 
        ' TabPgPersMilitaryRanks
        ' 
        TabPgPersMilitaryRanks.BackColor = Color.White
        TabPgPersMilitaryRanks.Location = New Point(4, 24)
        TabPgPersMilitaryRanks.Name = "TabPgPersMilitaryRanks"
        TabPgPersMilitaryRanks.Size = New Size(1255, 310)
        TabPgPersMilitaryRanks.TabIndex = 6
        TabPgPersMilitaryRanks.Text = "Military Ranks"
        ' 
        ' TabPgPersSpeakingLanguages
        ' 
        TabPgPersSpeakingLanguages.BackColor = Color.White
        TabPgPersSpeakingLanguages.Location = New Point(4, 24)
        TabPgPersSpeakingLanguages.Name = "TabPgPersSpeakingLanguages"
        TabPgPersSpeakingLanguages.Size = New Size(1255, 310)
        TabPgPersSpeakingLanguages.TabIndex = 7
        TabPgPersSpeakingLanguages.Text = "Speaking Languages"
        ' 
        ' TabPgPersStatuses
        ' 
        TabPgPersStatuses.BackColor = Color.White
        TabPgPersStatuses.Location = New Point(4, 24)
        TabPgPersStatuses.Name = "TabPgPersStatuses"
        TabPgPersStatuses.Size = New Size(1255, 310)
        TabPgPersStatuses.TabIndex = 8
        TabPgPersStatuses.Text = "Statuses"
        ' 
        ' TabPgPersSecondaryEquipment
        ' 
        TabPgPersSecondaryEquipment.BackColor = Color.White
        TabPgPersSecondaryEquipment.Location = New Point(4, 24)
        TabPgPersSecondaryEquipment.Name = "TabPgPersSecondaryEquipment"
        TabPgPersSecondaryEquipment.Size = New Size(1255, 310)
        TabPgPersSecondaryEquipment.TabIndex = 9
        TabPgPersSecondaryEquipment.Text = "Secondary Equipment"
        ' 
        ' TabPgPersSpecialSkills
        ' 
        TabPgPersSpecialSkills.BackColor = Color.White
        TabPgPersSpecialSkills.Location = New Point(4, 24)
        TabPgPersSpecialSkills.Name = "TabPgPersSpecialSkills"
        TabPgPersSpecialSkills.Size = New Size(1255, 310)
        TabPgPersSpecialSkills.TabIndex = 10
        TabPgPersSpecialSkills.Text = "Special Skills"
        ' 
        ' TabPgPersVehicles
        ' 
        TabPgPersVehicles.BackColor = Color.White
        TabPgPersVehicles.Location = New Point(4, 24)
        TabPgPersVehicles.Name = "TabPgPersVehicles"
        TabPgPersVehicles.Size = New Size(1255, 310)
        TabPgPersVehicles.TabIndex = 11
        TabPgPersVehicles.Text = "Vehicles"
        ' 
        ' TabPgPersWeapons
        ' 
        TabPgPersWeapons.BackColor = Color.White
        TabPgPersWeapons.Location = New Point(4, 24)
        TabPgPersWeapons.Name = "TabPgPersWeapons"
        TabPgPersWeapons.Size = New Size(1255, 310)
        TabPgPersWeapons.TabIndex = 12
        TabPgPersWeapons.Text = "Weapons"
        ' 
        ' TabPgUnitStructure
        ' 
        TabPgUnitStructure.BackColor = Color.White
        TabPgUnitStructure.ImageKey = "icons8-structure-48.png"
        TabPgUnitStructure.Location = New Point(4, 39)
        TabPgUnitStructure.Name = "TabPgUnitStructure"
        TabPgUnitStructure.Padding = New Padding(3)
        TabPgUnitStructure.Size = New Size(1269, 690)
        TabPgUnitStructure.TabIndex = 1
        TabPgUnitStructure.Text = "Unit Structure"
        ' 
        ' TabPgTraining
        ' 
        TabPgTraining.BackColor = Color.White
        TabPgTraining.ImageKey = "icons8-classroom-48.png"
        TabPgTraining.Location = New Point(4, 39)
        TabPgTraining.Name = "TabPgTraining"
        TabPgTraining.Size = New Size(1269, 690)
        TabPgTraining.TabIndex = 2
        TabPgTraining.Text = "Training List"
        ' 
        ' TabPgSchedule
        ' 
        TabPgSchedule.BackColor = Color.White
        TabPgSchedule.ImageKey = "icons8-schedule-48.png"
        TabPgSchedule.Location = New Point(4, 39)
        TabPgSchedule.Name = "TabPgSchedule"
        TabPgSchedule.Size = New Size(1269, 690)
        TabPgSchedule.TabIndex = 3
        TabPgSchedule.Text = "Training Schedule"
        ' 
        ' TabPgParticipation
        ' 
        TabPgParticipation.BackColor = Color.White
        TabPgParticipation.ImageKey = "icons8-student-registration-48.png"
        TabPgParticipation.Location = New Point(4, 39)
        TabPgParticipation.Name = "TabPgParticipation"
        TabPgParticipation.Size = New Size(1269, 690)
        TabPgParticipation.TabIndex = 4
        TabPgParticipation.Text = "Training Participation"
        ' 
        ' TabPgMissions
        ' 
        TabPgMissions.BackColor = Color.White
        TabPgMissions.ImageKey = "icons8-mission-48.png"
        TabPgMissions.Location = New Point(4, 39)
        TabPgMissions.Name = "TabPgMissions"
        TabPgMissions.Size = New Size(1269, 690)
        TabPgMissions.TabIndex = 5
        TabPgMissions.Text = "Missions"
        ' 
        ' TabPgStorage
        ' 
        TabPgStorage.BackColor = Color.White
        TabPgStorage.ImageKey = "icons8-warehouse-48.png"
        TabPgStorage.Location = New Point(4, 39)
        TabPgStorage.Name = "TabPgStorage"
        TabPgStorage.Size = New Size(1269, 690)
        TabPgStorage.TabIndex = 6
        TabPgStorage.Text = "Storage"
        ' 
        ' TabPgSetup
        ' 
        TabPgSetup.BackColor = Color.White
        TabPgSetup.ImageKey = "icons8-setup-48.png"
        TabPgSetup.Location = New Point(4, 39)
        TabPgSetup.Name = "TabPgSetup"
        TabPgSetup.Size = New Size(1269, 690)
        TabPgSetup.TabIndex = 7
        TabPgSetup.Text = "Setup"
        ' 
        ' TabPgExit
        ' 
        TabPgExit.BackColor = Color.White
        TabPgExit.ImageKey = "icons8-exit-48.png"
        TabPgExit.Location = New Point(4, 39)
        TabPgExit.Name = "TabPgExit"
        TabPgExit.Size = New Size(1269, 690)
        TabPgExit.TabIndex = 8
        TabPgExit.Text = "Exit"
        ' 
        ' FrmMain
        ' 
        AutoScaleDimensions = New SizeF(7.0F, 15.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1283, 800)
        Controls.Add(TabCtrMenu)
        DrawerShowIconsWhenHidden = True
        DrawerTabControl = TabCtrMenu
        Name = "FrmMain"
        Text = "42 ΤΕΘ - Διμοιρία Ταχείας Αντίδρασης (Ονασαγόρας)"
        WindowState = FormWindowState.Maximized
        TabCtrMenu.ResumeLayout(False)
        TabPgHome.ResumeLayout(False)
        TabPgHome.PerformLayout()
        CType(PicBoxLogo, ComponentModel.ISupportInitialize).EndInit()
        TabPgPersonnel.ResumeLayout(False)
        SplitCntPersonnel.Panel1.ResumeLayout(False)
        SplitCntPersonnel.Panel2.ResumeLayout(False)
        CType(SplitCntPersonnel, ComponentModel.ISupportInitialize).EndInit()
        SplitCntPersonnel.ResumeLayout(False)
        CType(LstViewPersonnel, ComponentModel.ISupportInitialize).EndInit()
        ExpPanSearchPersonnel.ResumeLayout(False)
        ExpPanSearchPersonnel.PerformLayout()
        TabCtrPersonnel.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents TabCtrMenu As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPgPersonnel As TabPage
    Friend WithEvents TabPgUnitStructure As TabPage
    Friend WithEvents ImgLstMenu As ImageList
    Friend WithEvents TabPgTraining As TabPage
    Friend WithEvents TabPgSchedule As TabPage
    Friend WithEvents TabPgParticipation As TabPage
    Friend WithEvents TabPgMissions As TabPage
    Friend WithEvents TabPgStorage As TabPage
    Friend WithEvents TabPgSetup As TabPage
    Friend WithEvents TabPgExit As TabPage
    Friend WithEvents SplitCntPersonnel As SplitContainer
    Friend WithEvents ExpPanSearchPersonnel As MaterialSkin.Controls.MaterialExpansionPanel
    Friend WithEvents TxtSrchPerFirstName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TabPgHome As TabPage
    Friend WithEvents PicBoxLogo As PictureBox
    Friend WithEvents LblHomeTitle As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents LblHomePersonnel As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabCtrPersonnel As TabControl
    Friend WithEvents TabPgPersAddresses As TabPage
    Friend WithEvents TabPgPersCommunication As TabPage
    Friend WithEvents TabPgPersEmergencyContacts As TabPage
    Friend WithEvents TabPgPersExpendableEquipment As TabPage
    Friend WithEvents TabPgPersMedicalCerts As TabPage
    Friend WithEvents TabPgPersMedicalConditions As TabPage
    Friend WithEvents TabPgPersMilitaryRanks As TabPage
    Friend WithEvents TabPgPersSpeakingLanguages As TabPage
    Friend WithEvents TabPgPersStatuses As TabPage
    Friend WithEvents TabPgPersSecondaryEquipment As TabPage
    Friend WithEvents TabPgPersSpecialSkills As TabPage
    Friend WithEvents TabPgPersVehicles As TabPage
    Friend WithEvents TabPgPersWeapons As TabPage
    Friend WithEvents TxtSrchPerLastName As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtSrchPerMilitaryID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents TxtSrchPerID As MaterialSkin.Controls.MaterialTextBox
    Friend WithEvents LstViewPersonnel As BrightIdeasSoftware.ObjectListView
    Friend WithEvents ColPersID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersFirstName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersLastName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersBirthDate As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersMilitaryUnitStructureID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersBloodTypesID As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersIdentityCard As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersMilitaryCard As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersFatherName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersMotherName As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersProfession As BrightIdeasSoftware.OLVColumn
    Friend WithEvents ColPersImageFileName As BrightIdeasSoftware.OLVColumn
End Class
