<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.monthSavings = New System.Windows.Forms.Label()
        Me.averageSavings = New System.Windows.Forms.Label()
        Me.significantSavings = New System.Windows.Forms.Label()
        Me.selectedMonth = New System.Windows.Forms.ComboBox()
        Me.btnStatistics = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(-7, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(274, 240)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(310, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(340, 120)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Smart Home" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Electric Savings"
        '
        'monthSavings
        '
        Me.monthSavings.AutoSize = True
        Me.monthSavings.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthSavings.Location = New System.Drawing.Point(199, 279)
        Me.monthSavings.Name = "monthSavings"
        Me.monthSavings.Size = New System.Drawing.Size(242, 23)
        Me.monthSavings.TabIndex = 2
        Me.monthSavings.Text = "The electric savings for July is"
        '
        'averageSavings
        '
        Me.averageSavings.AutoSize = True
        Me.averageSavings.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.averageSavings.Location = New System.Drawing.Point(199, 410)
        Me.averageSavings.Name = "averageSavings"
        Me.averageSavings.Size = New System.Drawing.Size(241, 23)
        Me.averageSavings.TabIndex = 3
        Me.averageSavings.Text = "The average monthly savings:"
        Me.averageSavings.Visible = False
        '
        'significantSavings
        '
        Me.significantSavings.AutoSize = True
        Me.significantSavings.Font = New System.Drawing.Font("Impact", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.significantSavings.Location = New System.Drawing.Point(141, 456)
        Me.significantSavings.Name = "significantSavings"
        Me.significantSavings.Size = New System.Drawing.Size(416, 23)
        Me.significantSavings.TabIndex = 4
        Me.significantSavings.Text = "December had the most significant monthly savings"
        Me.significantSavings.Visible = False
        '
        'selectedMonth
        '
        Me.selectedMonth.FormattingEnabled = True
        Me.selectedMonth.Location = New System.Drawing.Point(396, 182)
        Me.selectedMonth.Name = "selectedMonth"
        Me.selectedMonth.Size = New System.Drawing.Size(121, 21)
        Me.selectedMonth.TabIndex = 5
        '
        'btnStatistics
        '
        Me.btnStatistics.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStatistics.Location = New System.Drawing.Point(248, 329)
        Me.btnStatistics.Name = "btnStatistics"
        Me.btnStatistics.Size = New System.Drawing.Size(193, 42)
        Me.btnStatistics.TabIndex = 6
        Me.btnStatistics.Text = "Display Statistics"
        Me.btnStatistics.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AntiqueWhite
        Me.ClientSize = New System.Drawing.Size(673, 518)
        Me.Controls.Add(Me.btnStatistics)
        Me.Controls.Add(Me.selectedMonth)
        Me.Controls.Add(Me.significantSavings)
        Me.Controls.Add(Me.averageSavings)
        Me.Controls.Add(Me.monthSavings)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents monthSavings As Label
    Friend WithEvents averageSavings As Label
    Friend WithEvents significantSavings As Label
    Friend WithEvents selectedMonth As ComboBox
    Friend WithEvents btnStatistics As Button
End Class
