<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWebsiteTraffic
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.btnVisitorAnalytics = New System.Windows.Forms.Button()
        Me.lstVisitorData = New System.Windows.Forms.ListBox()
        Me.lblAverageTimeSpentLabel = New System.Windows.Forms.Label()
        Me.lblAverageTimeSpent = New System.Windows.Forms.Label()
        Me.picWebsiteTraffic = New System.Windows.Forms.PictureBox()
        CType(Me.picWebsiteTraffic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Arial Black", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(29, 24)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(340, 33)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Website Traffic Estimate"
        '
        'btnVisitorAnalytics
        '
        Me.btnVisitorAnalytics.BackColor = System.Drawing.Color.LightSeaGreen
        Me.btnVisitorAnalytics.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisitorAnalytics.Location = New System.Drawing.Point(53, 81)
        Me.btnVisitorAnalytics.Name = "btnVisitorAnalytics"
        Me.btnVisitorAnalytics.Size = New System.Drawing.Size(178, 41)
        Me.btnVisitorAnalytics.TabIndex = 1
        Me.btnVisitorAnalytics.Text = "Enter Visitor Analytics"
        Me.btnVisitorAnalytics.UseVisualStyleBackColor = False
        '
        'lstVisitorData
        '
        Me.lstVisitorData.Font = New System.Drawing.Font("Arial", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstVisitorData.FormattingEnabled = True
        Me.lstVisitorData.ItemHeight = 24
        Me.lstVisitorData.Location = New System.Drawing.Point(285, 81)
        Me.lstVisitorData.Name = "lstVisitorData"
        Me.lstVisitorData.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lstVisitorData.Size = New System.Drawing.Size(84, 196)
        Me.lstVisitorData.TabIndex = 2
        '
        'lblAverageTimeSpentLabel
        '
        Me.lblAverageTimeSpentLabel.AutoSize = True
        Me.lblAverageTimeSpentLabel.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageTimeSpentLabel.Location = New System.Drawing.Point(29, 320)
        Me.lblAverageTimeSpentLabel.Name = "lblAverageTimeSpentLabel"
        Me.lblAverageTimeSpentLabel.Size = New System.Drawing.Size(188, 22)
        Me.lblAverageTimeSpentLabel.TabIndex = 3
        Me.lblAverageTimeSpentLabel.Text = "Average Time Spent:"
        Me.lblAverageTimeSpentLabel.Visible = False
        '
        'lblAverageTimeSpent
        '
        Me.lblAverageTimeSpent.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAverageTimeSpent.Location = New System.Drawing.Point(223, 320)
        Me.lblAverageTimeSpent.Name = "lblAverageTimeSpent"
        Me.lblAverageTimeSpent.Size = New System.Drawing.Size(163, 22)
        Me.lblAverageTimeSpent.TabIndex = 4
        Me.lblAverageTimeSpent.Text = "26.67 Seconds"
        Me.lblAverageTimeSpent.Visible = False
        '
        'picWebsiteTraffic
        '
        Me.picWebsiteTraffic.Image = Global.Website_Traffic_Metric.My.Resources.Resources.Website
        Me.picWebsiteTraffic.Location = New System.Drawing.Point(0, 374)
        Me.picWebsiteTraffic.Name = "picWebsiteTraffic"
        Me.picWebsiteTraffic.Size = New System.Drawing.Size(399, 254)
        Me.picWebsiteTraffic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWebsiteTraffic.TabIndex = 5
        Me.picWebsiteTraffic.TabStop = False
        '
        'frmWebsiteTraffic
        '
        Me.AcceptButton = Me.btnVisitorAnalytics
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SandyBrown
        Me.ClientSize = New System.Drawing.Size(398, 627)
        Me.Controls.Add(Me.picWebsiteTraffic)
        Me.Controls.Add(Me.lblAverageTimeSpent)
        Me.Controls.Add(Me.lblAverageTimeSpentLabel)
        Me.Controls.Add(Me.lstVisitorData)
        Me.Controls.Add(Me.btnVisitorAnalytics)
        Me.Controls.Add(Me.lblTitle)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmWebsiteTraffic"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Website Traffic Estimate"
        CType(Me.picWebsiteTraffic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblTitle As Label
    Friend WithEvents btnVisitorAnalytics As Button
    Friend WithEvents lstVisitorData As ListBox
    Friend WithEvents lblAverageTimeSpentLabel As Label
    Friend WithEvents lblAverageTimeSpent As Label
    Friend WithEvents picWebsiteTraffic As PictureBox
End Class
