Public Class frmLayers
    Public Event CheckedItemsChanged(ByVal aCheckedItems As Generic.List(Of String))
    Public Event Apply()

    Private pPopulating As Boolean = False
    Private pLayers As New Generic.List(Of clsLayer)
    Private pRandom As New Random

    Private Sub RaiseChanged(ByVal aIndex As Integer, ByVal aChecked As Boolean)
        If Not pPopulating AndAlso Me.Visible Then
            Dim lChecked As Boolean
            Dim lCheckedItems As New Generic.List(Of String)
            For lIndex As Integer = 0 To pLayers.Count - 1
                If lIndex = aIndex Then lChecked = aChecked Else lChecked = lstLayers.Items(lIndex).Checked
                If lChecked Then lCheckedItems.Add(pLayers(lIndex).Filename)
            Next
            RaiseEvent CheckedItemsChanged(lCheckedItems)
        End If
    End Sub

    Private Sub lstLayers_ItemCheck(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lstLayers.ItemCheck
        If Not pPopulating AndAlso (e.NewValue = CheckState.Checked) <> pLayers.Item(e.Index).Visible Then
            RaiseChanged(e.Index, e.NewValue)
        End If
    End Sub

    Private Sub lstLayers_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstLayers.SelectedIndexChanged
        For Each lIndex As Integer In lstLayers.SelectedIndices
            Dim lLayer As clsLayer = pLayers.Item(lIndex)
            Dim lColor As Color = lLayer.LegendColor
            btnColor.BackColor = Color.FromArgb(255, lColor.R, lColor.G, lColor.B)
            If lLayer.GetType.Name = "clsLayerGPX" Then
                Dim lGPX As clsLayerGPX = lLayer
                Dim lWasPopulating As Boolean = pPopulating
                pPopulating = True
                txtOpacity.Text = CInt(lColor.A / 2.55)
                txtWidth.Text = lGPX.PenTrack.Width
                txtArrowSize.Text = lGPX.ArrowSize
                pPopulating = lWasPopulating
            End If
        Next
    End Sub

    Public Sub PopulateList(ByVal aLayers As Generic.List(Of clsLayer))
        Dim lSelectedIndex As Integer = -1
        pPopulating = True
        lstLayers.Items.Clear()
        Dim lHaveLayers As Boolean = aLayers IsNot Nothing AndAlso aLayers.Count > 0
        If lHaveLayers Then
            pLayers = aLayers
            For Each lLayer As clsLayer In aLayers
                Dim lItem As ListViewItem = lstLayers.Items.Add(lLayer.Filename)
                lItem.BackColor = lLayer.LegendColor
                If lItem.BackColor.GetBrightness < 0.5 Then
                    lItem.ForeColor = Color.White
                End If
                lItem.Checked = lLayer.Visible
                'lstLayers.SetItemChecked(lstLayers.Items.Add(lLayer.Filename), lLayer.Visible)
            Next
        ElseIf pLayers.Count > 0 Then
            pLayers = New Generic.List(Of clsLayer)
        End If
        pPopulating = False
    End Sub

    ' Return a random RGB color.
    Public Function RandomRGBColor(Optional ByVal aAlpha As Integer = 255) As Color
        Return Color.FromArgb(aAlpha, _
                 pRandom.Next(0, 255), _
                 pRandom.Next(0, 255), _
                 pRandom.Next(0, 255))
    End Function

    Private Sub txtWidth_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtWidth.TextChanged
        If Not pPopulating AndAlso IsNumeric(txtWidth.Text) Then
            Dim lWidth As Integer = CInt(txtWidth.Text)
            Dim lGPX As clsLayerGPX
            For Each lLayer As clsLayer In pLayers
                If lLayer.GetType.Name = "clsLayerGPX" Then
                    lGPX = lLayer
                    lGPX.PenTrack.Width = lWidth
                End If
            Next
            RaiseEvent Apply()
        End If
    End Sub

    Private Sub txtArrowSize_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtArrowSize.TextChanged
        If Not pPopulating AndAlso IsNumeric(txtArrowSize.Text) Then
            Dim lArrowSize As Integer = CInt(txtArrowSize.Text)
            Dim lGPX As clsLayerGPX
            For Each lLayer As clsLayer In pLayers
                If lLayer.GetType.Name = "clsLayerGPX" Then
                    lGPX = lLayer
                    lGPX.ArrowSize = lArrowSize
                End If
            Next
            RaiseEvent Apply()
        End If
    End Sub

    Private Sub txtOpacity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpacity.TextChanged
        If Not pPopulating AndAlso IsNumeric(txtOpacity.Text) Then
            Try
                Dim lAlpha As Integer = CInt(txtOpacity.Text) * 2.55
                If lAlpha >= 0 AndAlso lAlpha <= 255 Then
                    For Each lLayer As clsLayer In pLayers
                        lLayer.LegendColor = Color.FromArgb(lAlpha, lLayer.LegendColor.R, lLayer.LegendColor.G, lLayer.LegendColor.B)
                    Next
                    RaiseEvent Apply()
                End If
            Catch
            End Try
        End If
    End Sub

    Private Function SelectedLayers() As Generic.List(Of clsLayer)
        Dim lItems As New Generic.List(Of clsLayer)
        For Each lIndex As Integer In lstLayers.SelectedIndices
            lItems.Add(pLayers(lIndex))
        Next
        Return lItems
    End Function

    Private Sub chkAllVisible_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAllVisible.CheckedChanged
        Select Case chkAllVisible.CheckState
            Case CheckState.Checked, CheckState.Unchecked
                Dim lWasPopulating As Boolean = pPopulating
                pPopulating = True
                Dim lCheck As Boolean = chkAllVisible.Checked
                For Each lItem As ListViewItem In lstLayers.Items
                    lItem.Checked = lCheck
                Next
                pPopulating = lWasPopulating
                RaiseChanged(-1, False)
        End Select
    End Sub

    Private Sub btnColorRandom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorRandom.Click
        ColorAll(True, False, False)
    End Sub

    Private Sub btnColorRamp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorRamp.Click
        ColorAll(False, True, False)
    End Sub

    Private Sub btnColorSame_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColorSame.Click
        ColorAll(False, False, True)
    End Sub

    Private Sub ColorAll(ByVal aRandom As Boolean, ByVal aRamp As Boolean, ByVal aSame As Boolean)
        Dim lAlpha As Integer = 255
        If IsNumeric(txtOpacity.Text) Then
            lAlpha = CInt(txtOpacity.Text) * 2.55
        End If

        Dim lRed As Integer = btnColor.BackColor.R
        Dim lGreen As Integer = btnColor.BackColor.G
        Dim lBlue As Integer = btnColor.BackColor.B
        Dim lChannel As Integer = pRandom.Next(0, 2)

        Dim lColor As Color = Color.FromArgb(lAlpha, lRed, lGreen, lBlue)
        Dim lForeColor As Color = Color.Black

        If lColor.GetBrightness < 0.5 Then lForeColor = Color.White

        Dim lWidth As Integer = 1
        If IsNumeric(txtWidth.Text) Then
            lWidth = CInt(txtWidth.Text)
        End If

        For lIndex As Integer = 0 To pLayers.Count - 1
            If aSame Then
                'don't need to change color in loop
            Else
                If aRandom Then
                    lColor = RandomRGBColor(lAlpha)
                ElseIf aRamp Then
                    Select Case lChannel
                        Case 0 : lRed -= 20 : If lRed < 0 Then lRed = pRandom.Next(100, 255) : lChannel = 1
                        Case 1 : lGreen -= 20 : If lGreen < 0 Then lGreen = pRandom.Next(100, 255) : lChannel = 2
                        Case 2 : lBlue -= 20 : If lBlue < 0 Then lBlue = pRandom.Next(100, 255) : lChannel = 0
                    End Select
                    lColor = Color.FromArgb(lAlpha, lRed, lGreen, lBlue)
                End If
                If lColor.GetBrightness < 0.5 Then
                    lForeColor = Color.White
                Else
                    lForeColor = Color.Black
                End If
            End If

            pLayers(lIndex).LegendColor = lColor
            With lstLayers.Items(lIndex)
                .BackColor = lColor
                .ForeColor = lForeColor
            End With
        Next
        RaiseEvent Apply()

    End Sub

    Private Sub btnColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnColor.Click
        Dim lLayers As Generic.List(Of clsLayer) = SelectedLayers()
        If lLayers.Count = 0 Then lLayers = pLayers
        If lLayers.Count > 0 Then
            Dim lColorDialog As New ColorDialog
            With lColorDialog
                .Color = btnColor.BackColor
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    btnColor.BackColor = .Color 'Use simple non-transparent color for button
                    Dim lAlpha As Integer
                    If Not Integer.TryParse(txtOpacity.Text, lAlpha) Then lAlpha = 50
                    If lAlpha < 0 OrElse lAlpha > 255 Then lAlpha = 50
                    Dim lColor As Color = Color.FromArgb(lAlpha * 2.55, .Color.R, .Color.G, .Color.B)
                    For Each lLayer As clsLayer In lLayers
                        lLayer.LegendColor = lColor
                    Next
                    RaiseEvent Apply()
                    PopulateList(pLayers)
                End If
            End With
        End If
    End Sub

End Class