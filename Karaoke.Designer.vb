<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Karaoke
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Karaoke))
        Me.lblKaraokeMusic = New System.Windows.Forms.Label()
        Me.cboSelectAction = New System.Windows.Forms.ComboBox()
        Me.lblHourlyRental = New System.Windows.Forms.Label()
        Me.txtValue = New System.Windows.Forms.TextBox()
        Me.btnValue = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.lblDisplay = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblKaraokeMusic
        '
        Me.lblKaraokeMusic.AutoSize = True
        Me.lblKaraokeMusic.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKaraokeMusic.ForeColor = System.Drawing.Color.White
        Me.lblKaraokeMusic.Location = New System.Drawing.Point(540, 76)
        Me.lblKaraokeMusic.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblKaraokeMusic.Name = "lblKaraokeMusic"
        Me.lblKaraokeMusic.Size = New System.Drawing.Size(393, 42)
        Me.lblKaraokeMusic.TabIndex = 1
        Me.lblKaraokeMusic.Text = "Karaoke Music Night "
        '
        'cboSelectAction
        '
        Me.cboSelectAction.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboSelectAction.FormattingEnabled = True
        Me.cboSelectAction.Items.AddRange(New Object() {"Number of Songs ($2.99 per song)", "Hours in Private Karaoke Booth ($8.99 per hour)"})
        Me.cboSelectAction.Location = New System.Drawing.Point(547, 143)
        Me.cboSelectAction.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cboSelectAction.Name = "cboSelectAction"
        Me.cboSelectAction.Size = New System.Drawing.Size(431, 28)
        Me.cboSelectAction.TabIndex = 2
        Me.cboSelectAction.Text = "Customize your Night:"
        '
        'lblHourlyRental
        '
        Me.lblHourlyRental.AutoSize = True
        Me.lblHourlyRental.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHourlyRental.ForeColor = System.Drawing.Color.White
        Me.lblHourlyRental.Location = New System.Drawing.Point(581, 314)
        Me.lblHourlyRental.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblHourlyRental.Name = "lblHourlyRental"
        Me.lblHourlyRental.Size = New System.Drawing.Size(320, 25)
        Me.lblHourlyRental.TabIndex = 3
        Me.lblHourlyRental.Text = "Hourly Rental of Karaoke Room:"
        Me.lblHourlyRental.Visible = False
        '
        'txtValue
        '
        Me.txtValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtValue.Location = New System.Drawing.Point(729, 369)
        Me.txtValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtValue.Name = "txtValue"
        Me.txtValue.Size = New System.Drawing.Size(64, 29)
        Me.txtValue.TabIndex = 4
        Me.txtValue.Visible = False
        '
        'btnValue
        '
        Me.btnValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnValue.Location = New System.Drawing.Point(561, 427)
        Me.btnValue.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnValue.Name = "btnValue"
        Me.btnValue.Size = New System.Drawing.Size(169, 49)
        Me.btnValue.TabIndex = 5
        Me.btnValue.Text = "Total Cost"
        Me.btnValue.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(800, 427)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(169, 49)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear Form"
        Me.btnClear.UseVisualStyleBackColor = True
        Me.btnClear.Visible = False
        '
        'lblDisplay
        '
        Me.lblDisplay.AutoSize = True
        Me.lblDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDisplay.ForeColor = System.Drawing.Color.White
        Me.lblDisplay.Location = New System.Drawing.Point(570, 523)
        Me.lblDisplay.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblDisplay.Name = "lblDisplay"
        Me.lblDisplay.Size = New System.Drawing.Size(36, 25)
        Me.lblDisplay.TabIndex = 7
        Me.lblDisplay.Text = "$$"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(5, 5)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(463, 601)
        Me.PictureBox1.TabIndex = 8
        Me.PictureBox1.TabStop = False
        '
        'Karaoke
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1031, 608)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblDisplay)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnValue)
        Me.Controls.Add(Me.txtValue)
        Me.Controls.Add(Me.lblHourlyRental)
        Me.Controls.Add(Me.cboSelectAction)
        Me.Controls.Add(Me.lblKaraokeMusic)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "Karaoke"
        Me.Text = "Karaoke Music "
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblKaraokeMusic As Label
    Friend WithEvents cboSelectAction As ComboBox
    Friend WithEvents lblHourlyRental As Label
    Friend WithEvents txtValue As TextBox
    Friend WithEvents btnValue As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents lblDisplay As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
