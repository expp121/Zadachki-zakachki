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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.scores_lstBox = New System.Windows.Forms.ListBox()
        Me.name_comboBox = New System.Windows.Forms.ComboBox()
        Me.add_buttn = New System.Windows.Forms.Button()
        Me.clear_buttn = New System.Windows.Forms.Button()
        Me.name_sort_buttn = New System.Windows.Forms.Button()
        Me.score_sort_buttn = New System.Windows.Forms.Button()
        Me.results_names_lstBox = New System.Windows.Forms.ListBox()
        Me.results_scorese_lstBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ИМЕ:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(156, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ОЦЕНКА"
        '
        'scores_lstBox
        '
        Me.scores_lstBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.scores_lstBox.FormattingEnabled = True
        Me.scores_lstBox.ItemHeight = 15
        Me.scores_lstBox.Items.AddRange(New Object() {"2.00", "2.25", "2.50", "2.75", "3.00", "3.25", "3.50", "3.75", "4.00", "4.25", "4.50", "4.75", "5.00", "5.25", "5.50", "5.75", "6.00"})
        Me.scores_lstBox.Location = New System.Drawing.Point(159, 38)
        Me.scores_lstBox.Name = "scores_lstBox"
        Me.scores_lstBox.Size = New System.Drawing.Size(49, 259)
        Me.scores_lstBox.Sorted = True
        Me.scores_lstBox.TabIndex = 2
        '
        'name_comboBox
        '
        Me.name_comboBox.FormattingEnabled = True
        Me.name_comboBox.Items.AddRange(New Object() {"Ваня", "Галя", "Гошо", "Даниел", "Денис", "Денислав", "Емо", "Иван", "Мария", "Моника", "Христо"})
        Me.name_comboBox.Location = New System.Drawing.Point(12, 38)
        Me.name_comboBox.Name = "name_comboBox"
        Me.name_comboBox.Size = New System.Drawing.Size(121, 21)
        Me.name_comboBox.Sorted = True
        Me.name_comboBox.TabIndex = 3
        '
        'add_buttn
        '
        Me.add_buttn.Location = New System.Drawing.Point(220, 265)
        Me.add_buttn.Name = "add_buttn"
        Me.add_buttn.Size = New System.Drawing.Size(75, 23)
        Me.add_buttn.TabIndex = 4
        Me.add_buttn.Text = "ADD"
        Me.add_buttn.UseVisualStyleBackColor = True
        '
        'clear_buttn
        '
        Me.clear_buttn.Location = New System.Drawing.Point(220, 294)
        Me.clear_buttn.Name = "clear_buttn"
        Me.clear_buttn.Size = New System.Drawing.Size(75, 23)
        Me.clear_buttn.TabIndex = 5
        Me.clear_buttn.Text = "CLEAR"
        Me.clear_buttn.UseVisualStyleBackColor = True
        '
        'name_sort_buttn
        '
        Me.name_sort_buttn.Location = New System.Drawing.Point(324, 265)
        Me.name_sort_buttn.Name = "name_sort_buttn"
        Me.name_sort_buttn.Size = New System.Drawing.Size(102, 23)
        Me.name_sort_buttn.TabIndex = 6
        Me.name_sort_buttn.Text = "SORT(by Name)"
        Me.name_sort_buttn.UseVisualStyleBackColor = True
        '
        'score_sort_buttn
        '
        Me.score_sort_buttn.Location = New System.Drawing.Point(324, 294)
        Me.score_sort_buttn.Name = "score_sort_buttn"
        Me.score_sort_buttn.Size = New System.Drawing.Size(102, 23)
        Me.score_sort_buttn.TabIndex = 7
        Me.score_sort_buttn.Text = "SORT(by Score)"
        Me.score_sort_buttn.UseVisualStyleBackColor = True
        '
        'results_names_lstBox
        '
        Me.results_names_lstBox.FormattingEnabled = True
        Me.results_names_lstBox.Location = New System.Drawing.Point(220, 25)
        Me.results_names_lstBox.Name = "results_names_lstBox"
        Me.results_names_lstBox.Size = New System.Drawing.Size(144, 225)
        Me.results_names_lstBox.TabIndex = 8
        '
        'results_scorese_lstBox
        '
        Me.results_scorese_lstBox.FormattingEnabled = True
        Me.results_scorese_lstBox.Location = New System.Drawing.Point(371, 25)
        Me.results_scorese_lstBox.Name = "results_scorese_lstBox"
        Me.results_scorese_lstBox.Size = New System.Drawing.Size(188, 225)
        Me.results_scorese_lstBox.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 340)
        Me.Controls.Add(Me.results_scorese_lstBox)
        Me.Controls.Add(Me.results_names_lstBox)
        Me.Controls.Add(Me.score_sort_buttn)
        Me.Controls.Add(Me.name_sort_buttn)
        Me.Controls.Add(Me.clear_buttn)
        Me.Controls.Add(Me.add_buttn)
        Me.Controls.Add(Me.name_comboBox)
        Me.Controls.Add(Me.scores_lstBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents scores_lstBox As ListBox
    Friend WithEvents name_comboBox As ComboBox
    Friend WithEvents add_buttn As Button
    Friend WithEvents clear_buttn As Button
    Friend WithEvents name_sort_buttn As Button
    Friend WithEvents score_sort_buttn As Button
    Friend WithEvents results_names_lstBox As ListBox
    Friend WithEvents results_scorese_lstBox As ListBox
End Class
