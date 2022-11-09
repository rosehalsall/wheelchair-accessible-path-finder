<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.lstbxAccReqs = New System.Windows.Forms.ListBox()
        Me.cbxToHere = New System.Windows.Forms.ComboBox()
        Me.cbxFromHere = New System.Windows.Forms.ComboBox()
        Me.btnGo = New System.Windows.Forms.Button()
        Me.lstbxWrittenDirections = New System.Windows.Forms.ListBox()
        Me.lblFromHere = New System.Windows.Forms.Label()
        Me.lblToHere = New System.Windows.Forms.Label()
        Me.lblAccessRequirements = New System.Windows.Forms.Label()
        Me.btnEasyReadMode = New System.Windows.Forms.Button()
        Me.btnDarkMode = New System.Windows.Forms.Button()
        Me.btnRegularMode = New System.Windows.Forms.Button()
        Me.pbxMap = New System.Windows.Forms.PictureBox()
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lstbxAccReqs
        '
        Me.lstbxAccReqs.AllowDrop = True
        Me.lstbxAccReqs.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lstbxAccReqs.FormattingEnabled = True
        Me.lstbxAccReqs.ItemHeight = 25
        Me.lstbxAccReqs.Location = New System.Drawing.Point(1344, 50)
        Me.lstbxAccReqs.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstbxAccReqs.Name = "lstbxAccReqs"
        Me.lstbxAccReqs.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstbxAccReqs.Size = New System.Drawing.Size(345, 154)
        Me.lstbxAccReqs.TabIndex = 30
        '
        'cbxToHere
        '
        Me.cbxToHere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxToHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxToHere.FormattingEnabled = True
        Me.cbxToHere.Location = New System.Drawing.Point(663, 54)
        Me.cbxToHere.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxToHere.Name = "cbxToHere"
        Me.cbxToHere.Size = New System.Drawing.Size(339, 33)
        Me.cbxToHere.TabIndex = 15
        '
        'cbxFromHere
        '
        Me.cbxFromHere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxFromHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.cbxFromHere.FormattingEnabled = True
        Me.cbxFromHere.Location = New System.Drawing.Point(193, 50)
        Me.cbxFromHere.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cbxFromHere.Name = "cbxFromHere"
        Me.cbxFromHere.Size = New System.Drawing.Size(339, 33)
        Me.cbxFromHere.TabIndex = 16
        '
        'btnGo
        '
        Me.btnGo.BackColor = System.Drawing.Color.LightSkyBlue
        Me.btnGo.Location = New System.Drawing.Point(1697, 77)
        Me.btnGo.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnGo.Name = "btnGo"
        Me.btnGo.Size = New System.Drawing.Size(94, 43)
        Me.btnGo.TabIndex = 18
        Me.btnGo.Text = "Go"
        Me.btnGo.UseVisualStyleBackColor = False
        '
        'lstbxWrittenDirections
        '
        Me.lstbxWrittenDirections.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lstbxWrittenDirections.FormattingEnabled = True
        Me.lstbxWrittenDirections.HorizontalScrollbar = True
        Me.lstbxWrittenDirections.ItemHeight = 25
        Me.lstbxWrittenDirections.Location = New System.Drawing.Point(1277, 214)
        Me.lstbxWrittenDirections.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.lstbxWrittenDirections.Name = "lstbxWrittenDirections"
        Me.lstbxWrittenDirections.Size = New System.Drawing.Size(552, 654)
        Me.lstbxWrittenDirections.TabIndex = 20
        '
        'lblFromHere
        '
        Me.lblFromHere.AutoSize = True
        Me.lblFromHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblFromHere.Location = New System.Drawing.Point(107, 57)
        Me.lblFromHere.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblFromHere.Name = "lblFromHere"
        Me.lblFromHere.Size = New System.Drawing.Size(68, 25)
        Me.lblFromHere.TabIndex = 21
        Me.lblFromHere.Text = "From: "
        '
        'lblToHere
        '
        Me.lblToHere.AutoSize = True
        Me.lblToHere.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblToHere.Location = New System.Drawing.Point(594, 57)
        Me.lblToHere.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblToHere.Name = "lblToHere"
        Me.lblToHere.Size = New System.Drawing.Size(47, 25)
        Me.lblToHere.TabIndex = 22
        Me.lblToHere.Text = "To: "
        '
        'lblAccessRequirements
        '
        Me.lblAccessRequirements.AutoSize = True
        Me.lblAccessRequirements.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.lblAccessRequirements.Location = New System.Drawing.Point(1091, 57)
        Me.lblAccessRequirements.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblAccessRequirements.Name = "lblAccessRequirements"
        Me.lblAccessRequirements.Size = New System.Drawing.Size(208, 25)
        Me.lblAccessRequirements.TabIndex = 23
        Me.lblAccessRequirements.Text = "Access Requirements:"
        '
        'btnEasyReadMode
        '
        Me.btnEasyReadMode.BackColor = System.Drawing.Color.LightBlue
        Me.btnEasyReadMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnEasyReadMode.Location = New System.Drawing.Point(1623, 896)
        Me.btnEasyReadMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnEasyReadMode.Name = "btnEasyReadMode"
        Me.btnEasyReadMode.Size = New System.Drawing.Size(206, 42)
        Me.btnEasyReadMode.TabIndex = 25
        Me.btnEasyReadMode.Text = "Easy Read Mode"
        Me.btnEasyReadMode.UseVisualStyleBackColor = False
        '
        'btnDarkMode
        '
        Me.btnDarkMode.BackColor = System.Drawing.Color.Black
        Me.btnDarkMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnDarkMode.ForeColor = System.Drawing.Color.BurlyWood
        Me.btnDarkMode.Location = New System.Drawing.Point(1456, 896)
        Me.btnDarkMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnDarkMode.Name = "btnDarkMode"
        Me.btnDarkMode.Size = New System.Drawing.Size(159, 42)
        Me.btnDarkMode.TabIndex = 28
        Me.btnDarkMode.Text = "Dark Mode"
        Me.btnDarkMode.UseVisualStyleBackColor = False
        '
        'btnRegularMode
        '
        Me.btnRegularMode.BackColor = System.Drawing.Color.White
        Me.btnRegularMode.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.btnRegularMode.Location = New System.Drawing.Point(1277, 896)
        Me.btnRegularMode.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.btnRegularMode.Name = "btnRegularMode"
        Me.btnRegularMode.Size = New System.Drawing.Size(159, 42)
        Me.btnRegularMode.TabIndex = 29
        Me.btnRegularMode.Text = "Regular Mode"
        Me.btnRegularMode.UseVisualStyleBackColor = False
        '
        'pbxMap
        '
        Me.pbxMap.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pbxMap.Image = CType(resources.GetObject("pbxMap.Image"), System.Drawing.Image)
        Me.pbxMap.Location = New System.Drawing.Point(143, 113)
        Me.pbxMap.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pbxMap.Name = "pbxMap"
        Me.pbxMap.Size = New System.Drawing.Size(1095, 825)
        Me.pbxMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pbxMap.TabIndex = 19
        Me.pbxMap.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(144.0!, 144.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1858, 957)
        Me.Controls.Add(Me.lstbxAccReqs)
        Me.Controls.Add(Me.btnRegularMode)
        Me.Controls.Add(Me.btnDarkMode)
        Me.Controls.Add(Me.btnEasyReadMode)
        Me.Controls.Add(Me.lblAccessRequirements)
        Me.Controls.Add(Me.lblToHere)
        Me.Controls.Add(Me.lblFromHere)
        Me.Controls.Add(Me.lstbxWrittenDirections)
        Me.Controls.Add(Me.btnGo)
        Me.Controls.Add(Me.cbxFromHere)
        Me.Controls.Add(Me.cbxToHere)
        Me.Controls.Add(Me.pbxMap)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.MinimumSize = New System.Drawing.Size(1364, 836)
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.pbxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pbxMap As PictureBox
    Friend WithEvents lstbxAccReqs As ListBox
    Friend WithEvents cbxToHere As ComboBox
    Friend WithEvents cbxFromHere As ComboBox
    Friend WithEvents btnGo As Button
    Friend WithEvents lstbxWrittenDirections As ListBox
    Friend WithEvents lblFromHere As Label
    Friend WithEvents lblToHere As Label
    Friend WithEvents lblAccessRequirements As Label
    Friend WithEvents btnEasyReadMode As Button
    Friend WithEvents btnDarkMode As Button
    Friend WithEvents btnRegularMode As Button
End Class
