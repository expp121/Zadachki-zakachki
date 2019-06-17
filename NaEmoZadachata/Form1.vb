Public Class Form1
    Dim dict As New Dictionary(Of String, Double)

    Private Sub Add_buttn_Click(sender As Object, e As EventArgs) Handles add_buttn.Click
        results_names_lstBox.Items.Add(name_comboBox.SelectedItem)
        results_scorese_lstBox.Items.Add(scores_lstBox.SelectedItem)
        dict.Add(name_comboBox.SelectedItem, Double.Parse(scores_lstBox.SelectedItem))
    End Sub

    Private Sub Clear_buttn_Click(sender As Object, e As EventArgs) Handles clear_buttn.Click
        results_names_lstBox.Items.Clear()
        results_scorese_lstBox.Items.Clear()
    End Sub

    Private Sub Name_sort_buttn_Click(sender As Object, e As EventArgs) Handles name_sort_buttn.Click
        Dim sorted_byName = From pair In dict
                            Order By pair.Key
        results_names_lstBox.Items.Clear()
        results_scorese_lstBox.Items.Clear()
        dict = sorted_byName.ToDictionary(Function(p) p.Key, Function(p) p.Value)
        results_names_lstBox.Items.AddRange(dict.Keys.ToArray())
        For Each value In dict.Values
            results_scorese_lstBox.Items.Add(value)
        Next
    End Sub

    Private Sub Score_sort_buttn_Click(sender As Object, e As EventArgs) Handles score_sort_buttn.Click
        Dim sorted_byValue = From pair In dict
                             Order By pair.Value
        results_names_lstBox.Items.Clear()
        results_scorese_lstBox.Items.Clear()
        dict = sorted_byValue.ToDictionary(Function(p) p.Key, Function(p) p.Value)
        results_names_lstBox.Items.AddRange(dict.Keys.ToArray())
        For Each value In dict.Values
            results_scorese_lstBox.Items.Add(value)
        Next
    End Sub
End Class
